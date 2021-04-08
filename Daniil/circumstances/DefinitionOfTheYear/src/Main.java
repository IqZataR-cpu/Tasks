import java.util.Scanner;
import java.util.GregorianCalendar;
public class Main {

    public static void main(String[] args) {
        GregorianCalendar calendar = new GregorianCalendar();
        Scanner in = new Scanner(System.in);

        int year;

        while (true){
            System.out.println("Введите год");
            year = in.nextInt();

            if (calendar.isLeapYear(year)){
                System.out.println("В году 366 дней");
            }
            else
            {
                System.out.println("В году 365 лет");
            }
        }
    }
}
