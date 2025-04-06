import java.util.Scanner;

public class WhileEx2 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int num1,num2;
		while(true) {
			System.out.print("input num1:");
			num1 = sc.nextInt();
			System.out.print("input num2:");
			num2 = sc.nextInt();
			
			System.out.printf("%d + %d = %d\n",num1,num2,num1+num2);
		}
	}
}
