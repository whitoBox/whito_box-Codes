
public class Calculator {
	String Color;
	String Size;
	static double pi = 3.141592;
	public Calculator(String color, String size) {
		this.Color = color;
		this.Size  = size;
	}
	void powerOn() {
		System.out.println("전원을 킵니다.");
	}
	void PowerOff() {
		System.out.println("전원을 끕니다.");
	}
	static int plus(int x, int y) {
		return x+y;
	}
	double plus(double x, double y) {
		return x+y;
	}
	static int minus(int x, int y) {
		return x-y;
	}
	double divide(int x ,int y) {
		return (double)x/y;
	}
	double avg(int x, int y) {
		double sum = plus(x,y);
		return sum / 2; 
	}
	int sum1(int[] values) {
		int sum=0;
		for(int i : values) {
			sum += i;
		}
		return sum;
	}
	int sum2(int...values) {
		int sum = 0;
		for (int i = 0; i < values.length; i++) {
			sum += values[i];
		}
		return sum;
	}
}
