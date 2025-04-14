
public class ArrayEx2 {
	public static void main(String[] args) {
		int[] score = new int[10];
		int total = 0;
		for (int i = 0; i < score.length; i++) {
			score[i] = (int)(Math.random() * 100) ;
			total += score[i];
			System.out.printf("score[%d] = %d\n",i,score[i]);
		}
		System.out.printf("=== 총점 및 평균 ===\n");
		System.out.printf("총점 : %d\n",total);
		System.out.printf("평균 : %.1f",(double)total/score.length);
	}
}
