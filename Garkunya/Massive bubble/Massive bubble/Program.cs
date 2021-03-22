using System;

namespace Massive_bubble
{
    // В целом круто, но не нужно комментировать каждую строчку - это плохая практика.
    // Нужно писать код так, чтобы при его чтении и так было понятно, что он выполняет.
    // В крайнем случае, когда ты хардкодишь или лепишь костыли, тогда пишешь пояснение, что и зачем.
    // FUCK MOY MOZG!!! - означает, что без комментария было бы слишком сложно понять, что происходит, сарказм.
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = new int[] {4, 7, 2, 3, 9, 8, 0, 1, 5, 6}; // заранее известный массив FUCK MOY MOZG!!!
            // Тут скорее не для сравнения, а для обмена значениями,
            // так что коммент мало того, что не нужен, так еще и неправильный
            int temp; //переменная для сравнения FUCK MOY MOZG!!!

            for (int i = 0; i < someArray.Length; i++)
            {
                for (int j = i + 1; j < someArray.Length; j++)
                {
                    if (someArray[i] > someArray[j]) //сравниваем соседние переменные и меняем их местами FUCK MOY MOZG!!!
                    {                               // в случае успеха. FUCK MOY MOZG!!!
                        temp = someArray[i];
                        someArray[i] = someArray[j];
                        someArray[j] = temp;
                    }                   
                }            
            }
            
            for (int i = 0; i < someArray.Length; i++) //выводим массив FUCK MOY MOZG!!!
            {
                Console.Write(someArray[i] + " ");
            } 
            // лишний интер в конце программы, у сука за такое у меня люди теряли + 1 балл за семантику на сореве.

        }
    }
}
