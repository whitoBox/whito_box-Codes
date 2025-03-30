package week04;

public class Switch2 {
	public static void main(String[] args) {
		char grade = 'B';
		
		switch (grade) {
		case 'A' -> {
			System.out.println("A 등급");
			System.out.println("우수 회원");
		}
		case 'B' -> {
			System.out.println("B 등급");
			System.out.println("일반 회원");
		}
		default -> {
			System.out.println("기타 등급");
			System.out.println("손님");
		}
		}
		
		switch(grade) {
		case 'A','a' -> System.out.println("우수회원");
		case 'B','b' -> System.out.println("일반 회원");
		default -> System.out.println("손님");
		}
	}
}
