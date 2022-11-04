import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner Keyboard = new Scanner(System.in);

    System.out.print("What's your name :");
    String name = Keyboard.nextLine();
    System.out.print("what's your surname :");
    String sname = Keyboard.nextLine();

    System.out.print("How old are your :");
    int olds = Keyboard.nextInt();

    System.out.println(name + "  " + sname);
   
    System.out.println(olds);

  }
}
