using System;

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

    class StringHelper
    {
        private string _input;

        public StringHelper(string input)
        {
            _input = input;
        }

        public void Reverse()
        {
            string reverse = "";

            for (int i = _input.Length - 1; i >= 0; i--)
            {
                reverse += _input[i];
            }

            _input = reverse;
        }

        public void ucFirst()
        {
            char[] firstSymbol = _input.ToCharArray();
            firstSymbol[0] = System.Char.ToUpper(firstSymbol[0]);
            _input = new string(firstSymbol);
        }

        public void ucWord()
        {
            char[] stringUp = _input.ToCharArray();

            for (int i = 0; i <= stringUp.Length - 1; i++)
            {
                if (i == 0 || stringUp[i] != ' ' && stringUp[i - 1] == ' ')
                {
                    stringUp[i] = System.Char.ToUpper(stringUp[i]);
                }
            }

            _input = new string(stringUp);
        }

        public void Print()
        {
            Console.WriteLine(_input);
        }
    }
}
