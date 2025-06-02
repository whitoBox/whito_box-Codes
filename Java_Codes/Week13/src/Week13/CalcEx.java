package Week13;

public class CalcEx {
	public static void main(String[] args) {
		Calculator calc = new Calculator();
		
		User1 user1 = new User1();
		user1.setCalc(calc);
		user1.start();
		
		User2 User2 = new User2();
		User2.setCalc(calc);
		User2.start();
	}
}
