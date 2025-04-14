
public class Reference1 {
	public static void main(String[] args) {
		//참조 타입 변수 : 클래스 타입
		//기본 데이터 타입의 비교
		int iVal1 = 100;
		int iVal2 = 100;
		System.out.println("iVal1 == iVal2 : "+(iVal1==iVal2?"TRUE" : "False"));
		
		//string:  대표적이 클래스 타입입니다.
		String sVal1 = "Java";
		String sVal2 = "Java";
		
		//자바는 문자열리터럴이 동일하다면 String 객체를 공유한다. ******
		//즉 같은 주소의 객체를 참조한다.
		System.out.println("sVal1 == sVal2 : " + (sVal1==sVal2? "참조가같다":"참조가다르다"));
		System.out.println(System.identityHashCode(sVal1));
		System.out.println(System.identityHashCode(sVal2));
		
		String sVal3 = new String("Java");
		String sVal4 = new String("Java");
		System.out.println("sVal3 == sVal4 : " + (sVal3==sVal4? "참조가같다":"참조가다르다"));
		System.out.println(System.identityHashCode(sVal3));
		System.out.println(System.identityHashCode(sVal4));
		
		//참조타입 변수는 초기값으로 null을 사용할수 있다.
		//스택영역에서만 생성됨 아직 객체가 생성되지 않음?
		String sVal5 = null;
		
		//null 값을 가지고 있을 때는 변수를 상요할 수 없다.
		//NullPointerExceptoin발생
		//System.out.println("sval5.length= "+ sVal5.length());
		sVal5 = "Java";
		System.out.println("sVal5주소 = "+System.identityHashCode(sVal5));
		System.out.println("sVal5 == sVal1 : "+(sVal1==sVal5));
		
		if(sVal3.equals(sVal4)) {
			System.out.println("sVal3과 sVal4의 문자열은 동일하다");
		}else {
			System.out.println("sVal3과 sVal4의 문자열을 다르다");
		}
	}	
}
