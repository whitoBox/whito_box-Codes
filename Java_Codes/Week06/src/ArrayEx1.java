
public class ArrayEx1 {
	public static void main(String[] args) {
		//배열 선언과 생성
		//값 목록으로 생성하는 방법
		int[] score = {10,20,30,40,50};
		String[] pNames = {"java","c","C#","Python"};
		double[] dArr1;
		dArr1 = new double[]{0.1,0.2,0.3};
		
		//new 연산자로 배열 생성
		int[] intArray = new int[5];
		System.out.println("intArray[0]= "+ intArray[0]);
		
		double[] dArray2 = new double[5];
		System.out.println("dArray[0] = "+ dArray2[0]);
		
		String[] sArray = new String[5];
		System.out.println("sArray[0] = "+ sArray[0]);
		
		//sArray = pNames;
		//배열의 처리는 for문
		for (int i = 0; i < pNames.length; i++) {
			sArray[i] = pNames[i];
			System.out.printf("sArray[%d] = %s\n",i,sArray[i]);
		}
	}
}
