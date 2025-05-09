
public class CalcEx {
	public static void main(String[] args) {
		Calculator c1 = new Calculator("White", "Small");
		System.out.println(c1.Color + ", " + c1.Size);
		
		int result1 = c1.plus(10,20);
		System.out.println("plus(10,20) = "+result1);
		
		double result2 = c1.divide(10, 20);
		System.out.println("divide(10,20) = "+ result2);
		
		byte b1 = 10;
		byte b2 = 20;
		result2 = c1.divide(b1, b2);
		System.out.println("divide(10,20) = "+result2);
		
		double result3 = c1.avg(10, 7);
		System.out.println("avg(10,7) = " + result3);
		
		int[] arr1 = {1,2,3,4,5};
		int sum1 = c1.sum1(arr1);
		System.out.println("{1,2,3,4,5} = "+sum1);
		
		int sum2 = c1.sum2(arr1);
		System.out.println("{1,2,3,4,5} = "+sum2);
	}
}
