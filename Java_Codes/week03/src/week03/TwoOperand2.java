package week03;

public class TwoOperand2 {
	public static void main(String[] args) {
		//이항 연산자 : 비교 연산자 (<, > , <=, >=, ==, !=)
		//논리 연산자 : (&& / &) , (|| / |)
		int charCode1 = 'A';
		
		if(charCode1 >= 65 && charCode1 <= 90) {
			//65와 90사이인 경우
			System.out.println((char)charCode1 + "는 알파벳 대문자이다.");
		}
		
		int charCode2 = 'b';
		if(charCode2 >= 97 && charCode2 <= 122) {
			//97 < charCode2 < 122 이다
			System.out.println((char)charCode2 + "는 알파벳 소문자이다");
		}
		
		char charCode3 = '9';
		if  (!(charCode3 < 48) && !(charCode3 > 58)) {
			System.out.println(charCode3 + "는 숫자이다");
		}
		
		int ivalue = 4;
		if(ivalue % 2 == 0) {
			System.out.println(ivalue + "는 짝수다");
		}
		if(ivalue % 2 == 0 || ivalue % 3 == 0) {
			System.out.println(ivalue + "는 3의 배수이거나 3의 배수이다");
		}
	}
}
