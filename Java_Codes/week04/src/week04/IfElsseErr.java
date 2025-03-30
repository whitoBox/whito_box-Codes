package week04;

public class IfElsseErr {

	public static void main(String[] args) {
		int score = 85;
		char grade;
		
		if (score >= 90) {
			System.out.println("90 이상");
			grade = 'A';
		}
		else if (score >= 80 && score < 90) {
			// 80 <= score < 90 응응 여기는 이런 조건이얌 
			System.out.println("80 이상");
			grade = 'B';
		}
		else if (score >= 70) {
			System.out.println("70 이상");
			grade = 'C';
		}
		else if (score >= 60) {
			System.out.println("60 이상");
			grade = 'D';
		}
		else {
			grade = 'F';			
		}
		System.out.println(grade);
	}

}
