using System;

namespace ConsoleApp3
{
    // В целом хорошо, но есть фичи, которые тебе неизвестны,
    // соответственно прочитал, обдумал, запомнил, стал успешным
    class Program
    {
        static void Main(string[] args)
        {
            // Прикольное объявление, мне нравится,
            // все выведено на один уровень табуляции.
            // Не корректное название переменной "n" - стоило назвать FibbonachiLength или АНАЛогами.
            // Здесь душильня так что грамматические ошибки тоже учитываются FistNumber != FiRstNumber
            int  n             = 15;
            int  FistNumber    = 0;
            int  SecondNumber  = 1;
            // Более подходящее название Temp, субъективно.
            int  NeutralNumber = 1;
            
            Console.Write(FistNumber);
            
            // не нужно ставить Enter после каждого присваивания,
            // разделяй на логические блоки, в данном случае их 2 
            // Первый - Вывод на консоль
            // Второй - Блок инициализации переменных(блок присваивания значений)
            // Пример ниже
            for (int i = 0; i < n; i++)
            {
                Console.Write($" " + NeutralNumber);
                
                NeutralNumber = FistNumber + SecondNumber;
                FistNumber    = SecondNumber;
                SecondNumber  = NeutralNumber;
            }
        }
    }
}