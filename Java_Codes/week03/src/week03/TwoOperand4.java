package week03;

public class TwoOperand4 {
	public static void main(String[] args) {
		//비트 이동 연산자
		System.out.println("1 << 3 : " + (1<<3));
		System.out.printf("1        = %6s\n",Integer.toBinaryString(1));
		System.out.printf("(1 << 3) = %6s\n",Integer.toBinaryString(1<<3));
		
		System.out.println();
		System.out.println("-8 >> 3 : " + (-8>>3));
		System.out.printf("-8        = %32s\n",Integer.toBinaryString(-8));
		System.out.printf("(-8 >> 3) = %32s\n",Integer.toBinaryString(-8>>3));
	}
}
