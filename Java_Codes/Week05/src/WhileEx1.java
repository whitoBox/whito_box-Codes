
public class WhileEx1 {
	public static void main(String[] args) {
		//1~100까지 의 합
		int i=100,sum=0;
		while(i>0) {//조건은 boolean 값만 가능합니다.
			sum+=i;
			i--;
		}
		System.out.println(sum);
	}
}
