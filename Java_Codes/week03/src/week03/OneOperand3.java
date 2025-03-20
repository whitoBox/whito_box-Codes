package week03;

public class OneOperand3 {
	public static void main(String[] args) {
		//단항 연산자: ~ (비트 반전 연산자, 2진수)
		int var1 = 10;
		int var2 = ~var1;
		int var3 = ~var1 + 1;
		
		System.out.println("var1 = " + var1);
		System.out.println("var2 = " + var2);
		System.out.println("var3 = " + var3);
		
		System.out.printf("십진수 (%d) : %32s\n",var1 ,Integer.toBinaryString(var1));
		System.out.printf("십진수 (%d) : %32s\n",var2 ,Integer.toBinaryString(var2));
		System.out.printf("십진수 (%d) : %32s\n",var3 ,Integer.toBinaryString(var3));
	}
}
