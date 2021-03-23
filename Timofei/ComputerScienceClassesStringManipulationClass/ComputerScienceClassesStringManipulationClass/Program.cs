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
            inputData = StringHelper.UcFirst(inputData);
            Console.WriteLine(inputData);
           
            Console.Write("Делаем первую букву каждого слова заглавной: ");
            StringHelper.UcWords(inputData);
            
            inputData = StringHelper.Reverse(inputData);
           
            Console.Write("Переворот слова: ");
            Console.WriteLine(inputData);
        }
    }

    public abstract class StringHelper
    {
        public static string UcFirst(string inputData)
        {
            return char.ToUpper(inputData[0]) + inputData.Substring(1);
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