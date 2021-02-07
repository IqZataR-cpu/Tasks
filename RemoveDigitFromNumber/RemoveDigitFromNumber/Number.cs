using System;

namespace RemoveDigitFromNumber
{
    class Number
    {
        private Digits _digits;

        public Number(int number)
        {
            _digits = new Digits(number);
        }

        public void SetNumber(int number)
        {
            _digits.SetDigits(number);
        }

        public void RemoveDigital(int digit)
        {
            _digits.Remove(digit);
        }
        
        public void Print()
        {
            Console.WriteLine($"Число: {_digits}");
        }
    }
}