import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        int x;
        int y;

        while (true)
        {
            System.out.println("Введите координаты x,y");
            x = in.nextInt();
            y = in.nextInt();

            if (y != ((5 * x * x) - 7 * x + 2))
            {
                System.out.println("Точка не принадлежит графику функции");
            }
            else
            {
                System.out.println("Точка принадлежит графику функции");
            }
        }
    }
}
