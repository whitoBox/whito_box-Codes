
public class TwoDiemnsion {
	public static void main(String[] args) {
		//int[열][행]
		int [][] math = new int[2][3];
		//2차월 배열 ->중첩 for문
		for (int i = 0; i < math.length; i++) { //행의 반복
			for (int j = 0; j < math[i].length; j++) { // 열의 방복
				System.out.printf("math[%d][%d] = %d\n",i,j,math[i][j]);
			}
		}
		int[][] eng = new int[2][];
		eng[0] = new int[2];
		eng[1] = new int[3]; //자바는 행 길이가 다른 2차원 배열 선언이 가능하다. 미친
		for (int i = 0; i < eng.length; i++) { //행의 반복
			for (int j = 0; j < eng[i].length; j++) { // 열의 방복
				System.out.printf("eng[%d][%d] = %d\n",i,j,eng[i][j]);
			}
		}
	}
}
