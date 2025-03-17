package week02;

public class Data_type2 {
	public static void main(String[] args) {
		//char 데이터 타입 => 정수(음수는 없음)
		char cData1 = 'A';
		char cData2 = 65;
		char cData3 = '\u0041'; //16진수 유니코드
		System.out.println("cData1 = " + cData1);
		System.out.println("cData2 = " + cData2);
		System.out.println("cData3 = " + cData3);
		
		char cData4 = '가';
		char cData5 = 44032;
		char cData6 = '\uac00';
		System.out.println("cData4 = " + cData4);
		System.out.println("cData5 = " + cData5);
		System.out.println("cData6 = " + cData6);
		
		int cData7 = 'B';
		int cData8 = '하';
		int cData9 = '&';
		System.out.println("cData7 = " + cData7);
		System.out.println("cData8 = " + cData8);
		System.out.println("cData9 = " + cData9);
		
		//char 타입 변수의 유니코드 값을 알고 싶으면 int 타입에 대입한다.
		int  cData10 = cData7 + cData9;
		char cData11 = (char)(cData7 + cData9);
		System.out.println("cData10 = " + cData10);
		System.out.println("cData11 = " + cData11);
	}
}
