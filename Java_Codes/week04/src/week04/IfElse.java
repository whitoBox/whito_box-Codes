package week04;

public class IfElse {

	public static void main(String[] args) {
		
		int score = 85;
		//이상, 이하 : >=, <=
		//초과, 미만 : >, <
		if(score >= 90) {
			System.out.println("점수가 90 이상");
			System.out.println("A 등급");
		}else {
			System.out.println("점수가 90 미만");
			System.out.println("B 등급");
		}

	}

}
