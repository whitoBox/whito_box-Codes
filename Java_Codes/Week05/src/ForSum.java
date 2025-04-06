
public class ForSum {
	public static void main(String[] args) {
		//1~100까지의 합 구하기
		//누적 변수 => 초기화
		int sum = 0;
		for (int i = 1; i <= 100; i++) {
			sum += i;
		}
		System.out.println("the sum of 1 ~ 100 = "+sum);
	}
}
