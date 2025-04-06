
public class ForNested {
	public static void main(String[] args) {
		for(int i=2; i<=9; i++) {
			System.out.println("=============");
			System.out.printf("구구단 : %d단\n",i);
			System.out.println("=============");
			for (int j=1; j<=9; j++) {
				System.out.printf("%d * %d = %d\n",i,j,i*j);
			}
		}
	}
}
