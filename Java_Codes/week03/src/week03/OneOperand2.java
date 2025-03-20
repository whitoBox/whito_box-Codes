package week03;

public class OneOperand2 {
	public static void main(String[] args) {
		//단항 연산자 ++,--
		//++ : A = A + 1
		int x = 10;
		int y = 10;
		int z;
		
		// ++전위 후위 c랑 똑같이 있음
		System.out.println("++x = " + ++x);
		System.out.println("x++ = " + x++);
		
		//x = 12
		// --기호 : "-1:
		z = x++;
		System.out.println("z = " + z);
		System.out.println("x = " + x);
		
		z = ++x + y--;
		System.out.println("x = " + x);
		System.out.println("y = " + y);
		System.out.println("z = " + z);
	}	
	
}
