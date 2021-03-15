using System;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        public const int MAXSIZESRING = 3;
        public const int MAXCOLUMNS = 4;

        static void Main(string[] args)
        {
            double[,] doubleArray = {{1, 2, 16, 4}, {15, 12, 3, 13}, {1, 2, 3, 4}};
            double[] secondArray = new double[3];
            
            ViewArray(doubleArray);
            
            int indexArray = Convert.ToInt32(IndexArray(doubleArray));

            ReplacementArray(doubleArray, secondArray, indexArray);
        }
        
        /// <summary>
        /// Вывод массива.
        /// </summary>
        /// <param name="array"></param>
        static void ViewArray(double[,] array)
        {
            int maxNumber = 0;

            for (int i = 0; i < MAXSIZESRING; i++)
            {
                for (int j = 0; j < MAXCOLUMNS; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Возвращает номер столбца в котором находится максимальный элемент.
        /// Если условие не нашло возвращает -1.
        /// </summary>
        /// <param name="array"></param>
        /// <returns> </returns>
        static double IndexArray(double[,] array)
        {
            double maxValue = 0;
            int indexArray = 0;
            for (int i = 0; i < MAXSIZESRING; i++)
            {
                for (int j = 0; j < MAXCOLUMNS; j++)
                {
                    if (array[i,j] > maxValue)
                    {
                        maxValue = array[i, j];
                        indexArray = j;
                    }
                }
            }

            return indexArray;
        }
        
        /// <summary>
        /// Провизводим замену первого столбца и столбца в котором находится максимальный элемент.
        /// </summary>
        /// <param name="arrayOne"></param>
        /// <param name="arraySecond"></param>
        /// <param name="indexArray"></param>
        static void ReplacementArray(double[,] arrayOne, double[] arraySecond, int indexArray)
        {
            for (int i = 0; i < MAXSIZESRING; i++)
            {
                arraySecond[i] = arrayOne[i, indexArray];
            }

            for (int i = 0; i < MAXSIZESRING; i++)
            {
                arrayOne[i, indexArray] = arrayOne[i,0];
            }

            for (int i = 0; i < MAXSIZESRING; i++)
            {
                arrayOne[i, 0] = arraySecond[i];
            }

            for (int i = 0; i < MAXSIZESRING; i++)
            {
                for (int j = 0; j < MAXCOLUMNS; j++)
                {
                    Console.Write($"{arrayOne[i,j]}    ");
                }
                Console.WriteLine();
            }
        }
    }
}