package week03;

public class ThreeOperand {
	public static void main(String[] args) {
		//3항 연산자 > (조건식) ? true : false
		int num1 = 35;
		int num2 = 45;
		String result;
		
		result = (num1 > num2) ? "num1 is bigger" : "num2 is bigger";
		System.out.println(result);
		
		boolean bresult;
		bresult = (num1 > num2) ? true : false;
		System.out.println(bresult);
		
		System.out.println();
		int score = 105;
		String result2;
		
		result2 = (score>=90) ? "EXCELLENT" : ((score>=80)? "MEH" : "LOSER");
		System.out.println(result2);
		
		
	}
}
