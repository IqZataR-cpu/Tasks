import  java.lang.Math;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);

        int radius;
        int x;
        int y;
        double hypotenuse;

        while (true)
        {
            System.out.println("Введите радиус круга, координаты x и y");
            radius = in.nextInt();
            x = in.nextInt();
            y = in.nextInt();

            hypotenuse = Math.sqrt(x * x + y * y);

            if(hypotenuse > radius)
            {
                System.out.println("Точка не принадлежит кругу");
            }
            else
            {
                System.out.println("Точка принадлежит кругу");
            }
        }
    }
}
