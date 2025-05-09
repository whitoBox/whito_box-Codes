
public class CalculatorEx {
	public static void main(String[] args) {
		int radius = 8;
		double circleArea = Calculator.pi * radius * radius;
		System.out.printf("반지름이 %d인 원의 면적  = %.2f\n",radius, circleArea);
		
		int x = 8;
		int y = 7;
		System.out.printf("%d + %d = %d\n",x,y,Calculator.plus(x, y));
		System.out.printf("%d - %d = %d",x,y,Calculator.minus(x, y));
	}
}
