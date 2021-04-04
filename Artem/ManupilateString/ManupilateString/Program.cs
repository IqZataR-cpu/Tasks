using System;
using System.Globalization;

namespace ManupilateString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");


            StringHelper inputUser = new StringHelper(Console.ReadLine());


            inputUser.Reverse();
            inputUser.Print();

            inputUser.Reverse();
            inputUser.ucFirst();
            inputUser.Print();

            inputUser.ucWord();
            inputUser.Print();
        }
    }

    public class StringHelper
    {
        private string _input;

        public StringHelper(string input)
        {
            _input = input;
        }

        public string Reverse()
        {
            char[] reverse = _input.ToCharArray();

            Array.Reverse(reverse);

            return _input = new string(reverse);
        }

        public void ucFirst()
        {
            char[] firstSymbol = _input.ToCharArray();
            firstSymbol[0] = Char.ToUpper(firstSymbol[0]);
            _input = new string(firstSymbol);
        }

        public void ucWord()
        {
            TextInfo infoText = new CultureInfo("en-US", false).TextInfo;
            _input = infoText.ToTitleCase(_input);          
        }

        public void Print()
        {
            Console.WriteLine(_input);
        }
    }
}
