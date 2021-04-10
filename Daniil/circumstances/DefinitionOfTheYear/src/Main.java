import java.util.Scanner;
import java.util.GregorianCalendar;
public class Main { 
    // Перенос фигурной скобки на следующую строку везде!
    public static void main(String[] args) {
        GregorianCalendar calendar = new GregorianCalendar();
        Scanner in = new Scanner(System.in);

        int year;
        
        // Забыл пробел между скобками
        while (true){
            System.out.println("Введите год");
            year = in.nextInt();

            // Забыл пробел между скобками
            if (calendar.isLeapYear(year)){
                System.out.println("В году 366 дней");
            }
            else
            {
                // В году также еще 12 кроликов, 25 морковок и 365 дней
                System.out.println("В году 365 лет");
            }
        }
    }
}
