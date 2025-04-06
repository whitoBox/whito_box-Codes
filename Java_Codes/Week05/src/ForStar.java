
public class ForStar {
	public static void main(String[] args) {
		//1~10사이의 랜점 숫자
		int num = (int)(Math.random() * 10 + 1);
		
		System.out.println("random num = "+num);
		//별표 출력
		for (int i = 0; i < num; i++) {
			System.out.print("*");
		}
	}
}
