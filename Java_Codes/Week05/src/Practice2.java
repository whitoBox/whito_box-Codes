import java.util.Scanner;

public class Practice2 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int score;
		char  grade;
		while(true) {
			System.out.print("점수 입력>>");
			score = sc.nextInt();
			if(score < 0) break;
			
			grade = switch (score/10) {
			case 10,9 -> 'A';
			case 8 -> 'B';
			case 7 -> 'C';
			case 6 -> 'D';
			default -> 'F';
			};
			System.out.println("score \t   grade");
			System.out.println("====================");
			System.out.println(" "+score+"\t     "+ grade);
		}
		sc.close();
		System.out.println("프로그램 종료");
	}
}
