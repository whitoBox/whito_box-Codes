package week02;

public class Data_Type1 {
	public static void main(String[] args) {
		//실수 데이터 타입
		//실수 리터럴 저장
		float fValue = 3.14f;
		double dValue = 3.14; //실수 리터럴은 기본 값이 double 이다
		 
		System.out.println("fValue = " + fValue);
		System.out.println("dValue = " + dValue);
		
		//실수 정밀도 테스트
		fValue = 0.1234567890123456789f;
		dValue = 0.1234567890123456789;
		
		System.out.println("fValue = " + fValue);
		System.out.println("dValue = " + dValue);
		
		//e 사용하기
		int iData = 4500000;
		float fData = 3e7f;
		double dData1 = 3e7; // 10^7
		double dData2 = 3e-7;// 10^-7
		
		System.out.println("idata = " + iData);
		System.out.println("fData = " + fData);
		System.out.println("dData1 = " + dData1);
		System.out.println("dData2 = " + dData2);
		
		System.out.println();
		System.out.printf("iData = %d\n",iData);
		System.out.printf("fData = %f\n",fData);
		System.out.printf("dData1 = %f\n", dData1);
		System.out.printf("dData2 = %7f\n", dData2);
		
		System.out.println();
		System.out.printf("fData = %.4f\n",fData);
		System.out.printf("dData1 = %.2f\n", dData1);
		System.out.printf("dData2 = %10.8f\n", dData2);
		
		
		
		
	}
}
