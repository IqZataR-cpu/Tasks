public class Main {

    public static void main(String[] args) {
        // Максимальное несоблюдение стилистических требований.
        // Нет пробелов. Нет интеров. Я уже молчу про очевидную табуляцию.
        // Фигурная скобка методов и классов переносится на следующую строчку.
        // Между методами ставится Enter
    int number = 1;

    printNumber(number);
    }
    public static void printNumber(int number){
        if (number <= 100){
            System.out.println(number);
            printNumber(number + 1);
        }
    }
}
