package week04;

import java.util.Scanner;

public class IfStudent {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("input born year:");
		int year = sc.nextInt();
		int age = 2025-year;
		
		if(age > 27 || age < 8) {
			System.out.println("학생이 아닙니다");
			sc.close();
			return;
		}
		if (age>=20) {
			System.out.println("대학생");
		}else if(age>=17) {
			System.out.println("고등학생");
		}else if(age>=14){
			System.out.println("중학생");
		}else if(age>=8) {
			System.out.println("초등학생");			
		}
		
		sc.close();
	}
}
