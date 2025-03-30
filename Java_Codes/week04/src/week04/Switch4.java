package week04;

import java.util.Scanner;

public class Switch4 {
	public static void main(String[] args) {
		String mobile = "iPhone";
		
		switch(mobile) {
		case "iPhone" -> System.out.println("APPLE");
		case "Galaxy" -> System.out.println("SAMSUNG");
		default -> System.out.println("Other");
		}
		
		System.out.println();
		
		//점수에 따라 등급 출력
		Scanner sc = new Scanner(System.in);
		System.out.print("점수입력 >>");
		int score = sc.nextInt();
		
		char grade = switch (score/10) {
		case 10,9 -> 'A'; 
		case 8 -> 'B'; 
		case 7 -> 'c'; 
		default -> 'c';
		};
		
		System.out.println(grade);
		sc.close();
	}
}
