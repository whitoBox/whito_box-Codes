import java.util.Scanner;

public class DoWhile {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.println("메시지를 입력하세요");
		System.out.println("프로그램을 종료하려면 q를 입력하세요");
		
		String inStr;
		do {
			System.out.print(">>");
			inStr = sc.nextLine();
			System.out.println(inStr);
		}while(!inStr.equals("q")); //String 조건 확인하는 방법
		
		System.out.println("\n프로그램 종료");
		sc.close();
	}
}
