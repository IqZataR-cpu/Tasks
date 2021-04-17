using System;
using System.Collections.Generic;

namespace ComputerScienceFunctionTranslite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputUser = Console.ReadLine();
            
            ITranslatorDict eng = new KeyDictionary();
            Translator translator = new Translator(inputUser, eng);
            
            translator.Translate();
        }
    }

    public class Translator
    {
        private readonly string _input;
        private readonly List<char> _inputString = new List<char>();
        private readonly ITranslatorDict _values;
        
        public Translator(string input, ITranslatorDict values)
        {
            _input = input;
            _values = values;
        }
        
        private void GetStringCharactersToArray()
        {
            for (int i = 0; i < _input.Length; i++)
            {
                _inputString.Add(_input.ToCharArray()[i]);
            }
        }
        
        public void Translate()
        {
            GetStringCharactersToArray();
            
            foreach (char symbolString in _inputString)
            {
                if (_values.Values.ContainsKey(symbolString))
                { 
                    Console.Write(_values.Values[symbolString]); 
                }
                else
                {
                    Console.Write(symbolString);
                }
              
                // if (KeyDictionary.TranslateString.TryGetValue(symbolString, out string value))
                 // { 
                 //     Console.Write(value); 
                 // }
                 // else
                 // { 
                 //     Console.Write(symbolString);
                 // }
            }
        }
    }
    
    public interface ITranslatorDict
    { 
        Dictionary<char, string> Values { get; }
    }
    
    public class KeyDictionary : ITranslatorDict
    {
        public KeyDictionary()
        {
            this.Values = new Dictionary<char, string>
            {
                {'а', "a"}, {'б', "b"}, {'в', "v"}, {'г', "g"}, {'д', "d"}, {'е', "e"},
                {'ё', "e"}, {'ж', "h"}, {'з', "z"}, {'и', "i"}, {'й', "y"}, {'к', "k"},
                {'л', "l"}, {'м', "m"}, {'н', "n"}, {'о', "o"}, {'п', "p"}, {'р', "r"},
                {'с', "c"}, {'т', "t"}, {'у', "u"}, {'ф', "f"}, {'х', "h"}, {'ц', "c"},
                {'ч', "ch"}, {'ш', "sh"}, {'щ', "h"}, {'ь', ""}, {'ъ', ""}, {'ы', "i"},
                {'э', "e"}, {'ю', "yu"}, {'я', "ya"}, {' ', " "}, {'А', "A"},
                {'Б', "B"}, {'В', "V"}, {'Г', "G"}, {'Д', "D"}, {'Е', "E"}, {'Ё', "E"},
                {'Ж', "H"}, {'З', "Z"}, {'И', "I"}, {'Й', "Y"}, {'К', "K"}, {'Л', "L"},
                {'М', "M"}, {'Н', "N"}, {'О', "O"}, {'П', "P"}, {'Р', "R"}, {'С', "C"},
                {'Т', "T"}, {'У', "U"}, {'Ф', "F"}, {'Х', "H"}, {'Ц', "C"}, {'Ч', "CH"},
                {'Ш', "SH"}, {'Щ', "H"}, {'Ь', ""}, {'Ъ', ""}, {'Ы', "I"}, {'Э', "E"},
                {'Ю', "YU"}, {'Я', "YA"},
            };
        }
        // change string type of key to char
        // public Dictionary<char, string> TranslateString { get; } = new Dictionary<char, string>
        // {
        //     {'а',"a"}, {'б',"b"},  {'в',"v"},  {'г',"g"}, {'д',"d"}, {'е',"e"},
        //     {'ё',"e"}, {'ж',"h"}, {'з',"z"}, {'и',"i"}, {'й',"y"}, {'к',"k"},
        //     {'л',"l"}, {'м',"m"}, {'н',"n"}, {'о',"o"}, {'п',"p"}, {'р',"r"}, 
        //     {'с',"c"}, {'т',"t"}, {'у',"u"}, {'ф',"f"}, {'х',"h"}, {'ц',"c"},
        //     {'ч',"ch"}, {'ш',"sh"}, {'щ',"h"}, {'ь',""}, {'ъ',""}, {'ы',"i"},
        //     {'э',"e"}, {'ю',"yu"}, {'я',"ya"}, {' '," "}, {'А',"A"},
        //     {'Б',"B"}, {'В',"V"}, {'Г',"G"}, {'Д',"D"}, {'Е',"E"}, {'Ё',"E"},
        //     {'Ж',"H"}, {'З',"Z"}, {'И',"I"}, {'Й',"Y"}, {'К',"K"}, {'Л',"L"}, 
        //     {'М',"M"}, {'Н',"N"}, {'О',"O"}, {'П',"P"}, {'Р',"R"}, {'С',"C"}, 
        //     {'Т',"T"}, {'У',"U"}, {'Ф',"F"}, {'Х',"H"}, {'Ц',"C"}, {'Ч',"CH"},
        //     {'Ш',"SH"}, {'Щ',"H"}, {'Ь',""}, {'Ъ',""}, {'Ы',"I"}, {'Э',"E"},
        //     {'Ю',"YU"}, {'Я',"YA"},
        // };

        public Dictionary<char, string> Values { get; }
    }
}
