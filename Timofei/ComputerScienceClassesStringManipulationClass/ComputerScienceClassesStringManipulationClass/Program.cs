using System;
using System.Globalization;
using System.Linq;

namespace ComputerScienceClassesStringManipulationClass
{
    class Program
    {
        // Реализуйте класс StringHelper, который будет иметь следующие методы: метод reverse(),
        // который параметром принимает строку, а возвращает ее в перевернутом виде, метод ucFirst(),
        // который параметром принимает строку, а возвращает эту же строку, сделав ее первую букву заглавной
        // и метод ucWords, который принимает строку и делает заглавной первую букву каждого слова этой строки.
        
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            
            Console.Write("Делаем первую букву заглавной: ");
            StringHelper.UcWord(inputData);
           
            Console.Write("Делаем первую букву каждого слова заглавной: ");
            StringHelper.UcWords(inputData);
            
            inputData = StringHelper.Reverse(inputData);
           
            Console.Write("Переворот слова: ");
            Console.WriteLine(inputData);
        }
    }

    public abstract class StringHelper
    {
        public static void UcWord(string inputData)
        {
            char[] arrayCharData = new char[inputData.Length];
            
            for (int i = 0; i < arrayCharData.Length; i++)
            {
                if (i == 0)
                {
                    arrayCharData[i] = char.ToUpper(inputData[0]);
                }
                else
                {
                    arrayCharData[i] = Convert.ToChar(inputData[i]);
                }
                
                Console.Write(arrayCharData[i]);
            }
            
            Console.WriteLine();
        }

        public static void UcWords(string inputData)
        {
            TextInfo ucWord = new CultureInfo("ru",false).TextInfo;
            
            Console.WriteLine(ucWord.ToTitleCase(inputData));
        }
        
        public static string Reverse(string inputData)
        {
            char[] arrayChar = inputData.ToCharArray();
            
            Array.Reverse(arrayChar);
            
            return new string(arrayChar);
        }
    }
}