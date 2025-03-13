package week02;

public class Casting {
	public static void main(String[] args) {
		int iData = 65;           // int = 4byte
		char cData = (char)iData; // char = 1byte
		
		System.out.println(cData);
		
		long lData = 500;    //long = 8byte
		iData = (int)lData;
		System.out.println(iData);
		
		double dData = 3.14;  //double = 8byte
		iData = (int)dData;
		System.out.println(iData);
		
		//casting 하기 전에 데이터 손실 확인
		int iValue = 128;
		byte bValue = (byte)iValue;
		System.out.println(bValue);
		
		if (iValue >= Byte.MIN_VALUE && iValue <= Byte.MAX_VALUE) {
			bValue = (byte)iValue;
		}else {
			System.out.println("Error: casting value");
		}
	}
}
