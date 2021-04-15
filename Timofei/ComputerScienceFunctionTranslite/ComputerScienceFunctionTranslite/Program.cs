using System;
using System.Collections.Generic;


namespace ComputerScienceFunctionTranslite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputUser = Console.ReadLine();

            Translator user = new Translator(inputUser);
            
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

        private void GetStringCharactersToArray()
        {
            for (int i = 0; i < _input.Length; i++)
            {
                _inputString.Add(_input.ToCharArray()[i].ToString());
            }
        }

        public void Print()
        {
            GetStringCharactersToArray();
            
            foreach (var symbolString in _inputString)
            {
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

    public static class KeyDictionary
    {
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