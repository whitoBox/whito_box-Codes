package week04;

import java.util.Scanner;

public class UpAndDown {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int rannum = (int)(Math.random() * 100 + 1);
		int guess;
		while(true) {//1~100 사이 값 검사도 함
			System.out.print("숫자를 맞춰 보세요(1~100) >> ");
			guess = sc.nextInt();
			if(guess > 100 | guess < 0) {
				System.out.println("1~100 사이의 값을 입력하세요");
				continue;
			}
			if(guess > rannum)
				System.out.println("숫자가 너무 큽니다");
			if(guess < rannum)
				System.out.println("숫자가 너무 작습니다!");
			if(guess == rannum) {
				System.out.printf("정답입니다! 랜덤숫자는 %d 입니다",guess);
				break;
			}
		}
		sc.close();
	}
}

