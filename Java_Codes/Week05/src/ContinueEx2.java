
public class ContinueEx2 {
	public static void main(String[] args) {
		int sum = 0;
		for (int i = 1; i < 101; i++) {
			if(i%3==0)continue;
			
			sum+=i;
			//System.out.println(i); 
		}
		System.out.printf("1~100 without 3 = %d\n",sum);
		int sum2=0;
		for (int i = 1; i < 101; i++) {
			if(i%3==0)
				sum2+=i;
		}
		System.out.println(sum2);
		System.out.printf("%d + %d = %d",sum,sum2,sum+sum2);
	}
}
