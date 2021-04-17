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
            Translator translator = new Translator(eng);
            
            translator.Translate(inputUser);
        }
    }

    public class Translator
    {
        private readonly List<char> _inputString = new List<char>();
        private readonly ITranslatorDict _values;
        
        public Translator(ITranslatorDict values)
        {
            _values = values;
        }
        
        public void Translate(string input)
        {
            for (int i = 0; i < input.Length; i++) 
            {
                if (_values.Values.ContainsKey(input[i]))
                { 
                    Console.Write(_values.Values[input[i]]); 
                }
                else
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
   
    public interface ITranslatorDict
    { 
        Dictionary<char, string> Values { get; }
    }
    
    public class KeyDictionary : ITranslatorDict
    {
        public Dictionary<char, string> Values { get; } = new Dictionary<char, string>() {
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
}
