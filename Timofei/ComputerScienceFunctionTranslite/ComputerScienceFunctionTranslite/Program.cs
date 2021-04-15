using System;
using System.Collections.Generic;


namespace ComputerScienceFunctionTranslite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputUser = Console.ReadLine();

            // Исправить название переменной, по сути ты обманываешь пользователей,
            // Вот поэтому нельзя обращать слишком большое внимание на название в переменных
            // Потому что джуны часто путаются и только вводят в замешательство.
            // Я хочу видеть название отражающее суть, то есть translator.
            Translator user = new Translator(inputUser);
            
            // 
            user.Print();
        }
    }

    public class Translator
    {
        private readonly string _input;
        private readonly List<string> _inputString = new List<string>();

        public Translator(string input)
        {
            _input = input;
        }

        // Нет смысла хранить строки, если бы у нас транслировались буквенные сочетания,
        // тогда возможно да, но это был бы и другой способ парсинга входящей строки.  
        private void GetStringCharactersToArray()
        {
            for (int i = 0; i < _input.Length; i++)
            {
                _inputString.Add(_input.ToCharArray()[i].ToString());
            }
        }

        // rename to Translate()
        public void Print()
        {
            // remove this method
            GetStringCharactersToArray();
            
            // use char symbol in _input
            foreach (var symbolString in _inputString)
            {
                // use https://docs.microsoft.com/ru-ru/dotnet/api/system.collections.generic.dictionary-2.containskey?view=net-5.0#System_Collections_Generic_Dictionary_2_ContainsKey__0_
                // remove loop from here, if(contains) KeyDictionary.TranslateString[symbol]
                foreach (var result in KeyDictionary.TranslateString)
                {
                    if (symbolString == result.Key)
                    {
                        Console.Write(result.Value);
                    }
                }
            }
        }
    }

    // Make this class more flexible, dont use static.
    // Make ITranslatorDict Interface with property Dictionary<char, string> Values { get; };
    // Make EnglishDict implements ITranslatorDict, initialize values property with your variant of translate
    // Create property for Translator and add dependensy with constructor param -> Translator(ITranslatorDict dict)
    public static class KeyDictionary
    {
        // change string type of key to char
        public static Dictionary<string, string> TranslateString { get; } = new Dictionary<string, string>
        {
            {"а","a"}, {"б","b"},  {"в","v"},  {"г","g"}, {"д","d"}, {"е","e"},
            {"ё","e"}, {"ж","eh"}, {"з","z"}, {"и","i"}, {"й","y"}, {"к","k"},
            {"л","l"}, {"м","m"}, {"н","n"}, {"о","o"}, {"п","p"}, {"р","r"}, 
            {"с","c"}, {"т","t"}, {"у","u"}, {"ф","f"}, {"х","h"}, {"ц","c"},
            {"ч","ch"}, {"ш","sh"}, {"щ","h"}, {"ь",""}, {"ъ",""}, {"ы","i"},
            {"э","e"}, {"ю","yu"}, {"я","ya"}, {" "," "}, {"А","A"},
            {"Б","B"}, {"В","V"}, {"Г","G"}, {"Д","D"}, {"Е","E"}, {"Ё","E"},
            {"Ж","EH"}, {"З","Z"}, {"И","I"}, {"Й","Y"}, {"К","K"}, {"Л","L"}, 
            {"М","M"}, {"Н","N"}, {"О","O"}, {"П","P"}, {"Р","R"}, {"С","C"}, 
            {"Т","T"}, {"У","U"}, {"Ф","F"}, {"Х","H"}, {"Ц","C"}, {"Ч","CH"},
            {"Ш","SH"}, {"Щ","H"}, {"Ь",""}, {"Ъ",""}, {"Ы","I"}, {"Э","E"},
            {"Ю","YU"}, {"Я","YA"},
        };
    }
}
