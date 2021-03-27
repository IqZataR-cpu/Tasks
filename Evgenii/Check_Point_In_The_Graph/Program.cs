using System;

namespace Check_Point_In_The_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату X");
            int coordX = CheckPointInGraph.InputCoord();
            Console.WriteLine("Введите координату Y");
            int coordY = CheckPointInGraph.InputCoord();
            
            bool isPointOnGraph = CheckPointInGraph.CheckPointGraph(coordX, coordY);

            CheckPointInGraph.OutputAnswer(isPointOnGraph);
        }
    }

    class CheckPointInGraph
    {
        static public int InputCoord()
        {
            int coord = int.Parse(Console.ReadLine());

            return coord;
        }

        static public bool CheckPointGraph(int coordX, int coordY)
        {
            bool isPointOnGraph;

            if (coordY == Math.Pow(5 * coordX, 2) - 7 * coordX + 2)
            {
                isPointOnGraph = true;
            }
            else
            {
                isPointOnGraph = false;
            }

            return isPointOnGraph;
        }

        static public void OutputAnswer(bool isPointOnGraph)
        {
            if (isPointOnGraph)
            {
                Console.WriteLine("Точка находится на графике");
            }
            else
            {
                Console.WriteLine("Точка не находится на графике");
            }
        }
    }
}
