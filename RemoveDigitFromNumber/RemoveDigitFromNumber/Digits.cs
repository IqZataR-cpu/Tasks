using System.Collections.Generic;
using System.Linq;

namespace RemoveDigitFromNumber
{
    class Digits : List<int>
    {
        public Digits(int number)
        {
            SetDigits(number);
        }

        public void SetDigits(int number)
        {
            while (number != 0)
            {
                Add(number % 10);
                number /= 10;
            }
            
            // сохраняем порядок цифр от начала до конца
            Reverse();
        }

        public override string ToString()
        {
            return this.Aggregate("", (current, digit) => current + digit);
        }
    }
}