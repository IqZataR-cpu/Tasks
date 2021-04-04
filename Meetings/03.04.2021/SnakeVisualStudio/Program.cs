using System;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            int userInput = 0;
            int colorWall = 0;
            int colorFood = 0;
            int colorSnake = 0;
            int speedGame = 100;
            int modificatorScore = 2;
            int sizeX = 60;
            int sizeY = 25;
            bool isForWin = false;

            while (userInput != 5)
            {
                Console.Clear();
                Console.WriteLine("Начать игру : 1\n" +
                    "Выбрать цвет стены, змейки, еды: 2\n" +
                    "Выбрать скорость игры: 3\n" +
                    "Выбрать размер поля: 4\n" +
                    "Выход : 5"
                    );
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.Clear();

                        Game game = new Game();
                        Console.WriteLine("Обычный режим: 1\n" +
                                "Победный режим: 2"
                                );
                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1: 
                                game.Run(colorWall, colorFood, colorSnake, speedGame, modificatorScore, sizeX, sizeY, isForWin);
                                break;
                            case 2:
                                isForWin = true;
                                game.Run(colorWall, colorFood, colorSnake, speedGame, modificatorScore, sizeX, sizeY, isForWin);
                                break;
                        }

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Выберите цвет стены:");
                        colorWall = ChoosingColor();
                        Console.Clear();
                        Console.WriteLine("Выберите цвет еды:");
                        colorFood = ChoosingColor();
                        Console.Clear();
                        Console.WriteLine("Выберите цвет змеи:");
                        colorSnake = ChoosingColor();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Выберите скорость игры:");

                        switch (ChoosingSpeedGame())
                        {
                            case 1:
                                speedGame = 200;
                                modificatorScore = 1;
                                break;
                            case 2:
                                speedGame = 100;
                                modificatorScore = 2;
                                break;
                            case 3:
                                speedGame = 50;
                                modificatorScore = 3;
                                break;
                            case 4:
                                speedGame = 5;
                                modificatorScore = 4;
                                break;
                        }

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Выберите  размер поля:");

                        switch (ChoosingSizeField())
                        {
                            case 1:
                                sizeX = 20;
                                sizeY = 10;
                                break;
                            case 2:
                                sizeX = 60;
                                sizeY = 25;
                                break;
                            case 3:
                                sizeX = 100;
                                sizeY = 50;
                                break;
                        }

                        break;
                }                              
            }
        }

        private static int ChoosingColor()
        {
            Console.WriteLine("Красный: 1\n" +
                    "Зеленый: 2\n" +
                    "Синий: 3\n" +
                    "Желтый: 4\n"
                    );

            return int.Parse(Console.ReadLine());
        }

        private static int ChoosingSpeedGame()
        {
            Console.WriteLine("Легкий: 1\n" +
                    "Средний: 2\n" +
                    "Сложный: 3\n" +
                    "Азиат: 4\n"
                    );

            return int.Parse(Console.ReadLine());
        }

        private static int ChoosingSizeField()
        {
            Console.WriteLine("Маленький: 1\n" +
                    "Средний: 2\n" +
                    "Большой: 3\n"
                    );

            return int.Parse(Console.ReadLine());
        }
    }
}


// Я всё, не считая бага с мерцающим выводом проигрыша, хотя выигрыш рабочий)