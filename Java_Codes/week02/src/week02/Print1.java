package week02;

public class Print1 {
	public static void main(String[] args) {
		//main 메소드 단축키 : main + ctrl+space
		//main 메소드는 반드시 필요 => JVM이 main을 찾아서 실행 => 프로그램 실행의 시작점
		//출력 단축키 : sysout 작성후 + ctrl+space
		//실행 단축키 : ctrl + F11
		System.out.println("객체지향 프로그래밍");
		
		/*System.out.println("객체");
		System.out.println("지향");*/ //주석 넣는 방법
		
		//주석 단축키 : ctrl + /(토글)
		System.out.println("프로그래밍");
		
		//숫자 출력시 주의사항
		System.out.println(17+35);
		System.out.println("17+35 = " + (17+35)); //주의 문자열 + 숫자 = 문자열

		//다양한 출력 포맷
		//문자열 포맷(printf) 프린트 포맷 기호 '%'
		System.out.printf("이름 : %s", "홍실동\n");
		System.out.printf("나이 : %d세\n", 21);
		
		System.out.printf("과목 : %s %s %s\n", "객체", "지향", "프로그래밍");
		
	}
}
