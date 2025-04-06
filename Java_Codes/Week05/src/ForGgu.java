import java.util.Scanner;

public class ForGgu {
	public static void main(String[] args) {
		//구구단 출력 프로그램
		Scanner sc = new Scanner(System.in);
		System.out.print("input num: ");
		int num = sc.nextInt();
		
		System.out.printf("구구단 %d단을 계산한다.\n",num);
		for (int i = 1; i <= 9; i++) {
			System.out.printf("%d x %d = %d\n",num,i,num*i);
		}
		sc.close();
	}
}
