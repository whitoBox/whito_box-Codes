package week03;

public class TwoOperand3 {

	public static void main(String[] args) {
		//비트 논리 연산자 : &(and), |(or), ^
		byte num1 = 45;
		byte num2 = 25;
		int result = num1 & num2;
		
		System.out.println("num1 = "+ num1);
		System.out.println("num2 = "+ num2);
		System.out.println("result = "+ result);

		//비트 (AND) 연산
		System.out.printf("num1      = %6s\n", Integer.toBinaryString(num1));
		System.out.printf("num2      = %6s\n", Integer.toBinaryString(num2));
		System.out.printf("result(&) = %6s\n", Integer.toBinaryString(result));
		
		//비트 (OR) 연산
		result = num1 | num2;
		System.out.printf("\nnum1      = %6s\n", Integer.toBinaryString(num1));
		System.out.printf("num2      = %6s\n", Integer.toBinaryString(num2));
		System.out.printf("result(|) = %6s\n", Integer.toBinaryString(result));
		
		//비트 (XOR) 연산
		result = num1 ^ num2;
		System.out.printf("\nnum1      = %6s\n", Integer.toBinaryString(num1));
		System.out.printf("num2      = %6s\n", Integer.toBinaryString(num2));
		System.out.printf("result(^) = %6s\n", Integer.toBinaryString(result));
	}

}
