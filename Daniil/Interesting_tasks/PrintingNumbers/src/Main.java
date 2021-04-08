public class Main {

    public static void main(String[] args) {
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
