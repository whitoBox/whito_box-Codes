package week03;

public class OneOperand1 {
	public static void main(String[] args) {
		//단항 연산자 :+, -, ++, --, !, ~
		int		ivalue1 = 100;
		int		ivalue2 = -100;
		double	value1 = 3.14;
		double	dvalue2 = -10.5;
		
		int result1 = +ivalue1;
		int result2 = -ivalue2;
		System.out.println("result1 =" + result1);
		System.out.println("result2 =" + result2);
		
		short svalue1 = 100;
		// int 보다 작은 데이터 타입의 연산은 결과가 int 타입이다.
		//short sresult = -svalue1;
		int sresult = -svalue1;
		System.out.println("sValue = " + svalue1);
		
		byte bValue = -100;
		int bValue1 = -bValue;
		
		long lValue1 = 100;
		long lValue2 = -lValue1;
	}
}
