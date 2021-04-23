using System;
using System.Collections.Generic;
namespace OperationWithStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            char stackElement;

            stack.Push('U');
            stack.Push('K');
            stack.Push('I');
            stack.Push('M');

            stack.TrimExcess();
            Console.WriteLine("Стек после добавления элементов и со сниженной нагрузкой на память: ");
            PrintStack(stack);

            if (stack.TryPeek(out stackElement))
            {
                Console.WriteLine($"\nСтек после TryPeek крайнего элемента {stackElement}: ");
                PrintStack(stack);
            }

            stackElement = stack.Pop();
            Console.WriteLine($"\nСтек после Pop крайнего элемента {stackElement}: ");
            PrintStack(stack);

            stackElement = stack.Peek();
            Console.WriteLine($"\nСтек после Peek крайнего элемента {stackElement}: ");
            PrintStack(stack);

            if (stack.Contains(stackElement))
            {
                Console.WriteLine($"\nСтек содержит элемент {stackElement}");
            }

            stack.Clear();
            PrintStack(stack);

            if (stack.TryPop(out stackElement))
            {
                Console.WriteLine($"\nСтек после trypop крайнего элемента {stackElement}: ");
                PrintStack(stack);
            }
            else
            {
                Console.WriteLine("В стеке отсутсвуют элементы, операция TryPop невозможна");
            }
        }

        private static void PrintStack(Stack<char> stack)
        {
            foreach (char itemStack in stack)
            {
                Console.Write($"{itemStack} ");
            }
        }
    }
}
