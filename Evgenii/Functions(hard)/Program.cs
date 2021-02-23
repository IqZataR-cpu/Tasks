using System;

namespace Functions_hard_
{
    // В целом красавчик, уже чувствуется,
    // что уровень растет, но не хватает внимательности.
    // Реализация правильная, но постарайся более внимательно относится к написанию каждой задачи
    // Это позволит воспитать в себе привычку писать всегда правильно и не задумываться об этом.
    class Program
    {
        private static int[] array = new int[] { 1, 3, 6, 8, 11, 25, 57, 65, 100 };

        static void Main(string[] args)
        {
            int enteredValue;
            int? index;

            Console.WriteLine("Введите значение массива");
            enteredValue = int.Parse(Console.ReadLine());

            index = searchIndex(enteredValue);
            
            // Зачем здесь else? Либо прерви выполнение функции Main(),
            // либо сделай отдельную функцию для генерации сообщения
            // И тогда это уже будет более профессиОНАЛЬНЫЙ код.
            // index == null можно заменить на !index,
            // но в некоторых сеньорских кругах ходят слухи что это может запутать новиков,
            // спорно, но я лично делаю так !index
            if (index == null)
            {
                Console.WriteLine("Значения не существует");
            }
            else
            {
                Console.WriteLine(index + 1);
            }
        }
        
        // пример функции генерации сообщения
        private static string messageBy(int? index)
        {
            if (!index)
            {
                return "Значения не существует";
            }

            return index + 1;
        }

        private static int? searchIndex(int? value)
        {
            int middleOfArray = array.Length / 2;
            int counter = 1;
            // IDE говорит разделяй инит и присваивание значения, но это калл - запомни!
            // На практике будут вопросы, почему сразу не int? index = null, не ошибка, но на будущее.
            int? index;
            index = null;

            // ОШИБКА! Дубляж проверки "counter < array.Length", for what(для чего)??
            while ((middleOfArray >= 0 && counter < array.Length) &&
                   (middleOfArray <= array.Length && counter < array.Length))
            {
                counter = counter * 2;

                if (array[middleOfArray] == value)
                {
                    // логичнее было бы сделать return middleOfArray; 
                    index = middleOfArray;
                    break;
                } 
                // Разрыв(ENTER) между if и else if

                else if (array[middleOfArray] > value)
                {
                    middleOfArray = middleOfArray - array.Length / counter;
                    continue;
                }
                // Лишний TAB
                    middleOfArray = middleOfArray + array.Length / counter;
            }

            return index;
        }
    }
}
