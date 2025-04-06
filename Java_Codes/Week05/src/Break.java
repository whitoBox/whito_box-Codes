
public class Break {
	public static void main(String[] args) {
		while(true) {
			int num = (int)(Math.random() * 10);
			System.out.printf("랜덤 숫자: %d\n",num);
			if(num == 7)break;
		}
		System.out.println("7이 나오므로 프로그램 종료");
	}
}
