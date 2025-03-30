package week04;

public class IfNested {
	public static void main(String[] args) {
		// 점수 0~99
		int score = (int)(Math.random() * 100);
		String grade;
		
		if(score >= 90) {
			if(score >= 95) {
				grade = "A+";
			}
			else if(score > 93) {
				grade = "A0";
			}
			else {
				grade = "A-";
			}
		}else 
			grade= "B";
		System.out.println("your score : "+score);
		System.out.println("your grade : "+grade);
	}
}
