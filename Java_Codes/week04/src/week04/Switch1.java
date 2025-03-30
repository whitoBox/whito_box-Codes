package week04;

public class Switch1 {
	public static void main(String[] args) {
		char grade = 'A';
		
		switch (grade) {
		case 'A': case 'a':
			System.out.println("A"); 
			break;
		case 'B': case 'b': 
			System.out.println("B"); 
			break;
		default:
			System.out.println("기타 등급");
		}
	}
}
