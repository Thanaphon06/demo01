import java.util.Scanner;
class Main {
  public static void main(String[] args) {
    Scanner Keyboard = new Scanner(System.in);
    int d,e,f,c,year;
    int a = 5;
    int b = 10;
    
   
    System.out.print("number d :");
    d = Keyboard.nextInt();
    System.out.print("number e :");
    e = Keyboard.nextInt();

    
    System.out.print("What's your name :");
    String name = Keyboard.nextLine();
    
    System.out.print("what's your surname :");
    String sname = Keyboard.nextLine();

    System.out.print("What is your birth year 25__?:");
    int olds = Keyboard.nextInt();

    year = 2565 - olds;

    
    
    c = a + b;
    f = d + e;
    System.out.println("a");
    System.out.println(c);
   System.out.println(f);
    System.out.println(name + "  " + sname);
   
    System.out.println(year);
    
    
  }
}
