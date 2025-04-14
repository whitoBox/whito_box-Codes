
public class ReferenceString {
	public static void main(String[] args) {
		//String클래스 타입 변수
		String ssm = "0508263213212";
		
		//String은 0번부터 인덱스를 갖게 된다.
		char gender = ssm.charAt(6);
		switch(gender) {
		case '1','3' -> System.out.println("남자");
		case '2','4' -> System.out.println("여자");
		}
		
		//문자열의 길이
		int length = ssm.length();
		if (length == 13) {
			System.out.println("올바른 주민번호");
		}else {
			System.out.println("잘못된 주민번호");
		}
		
		//문자열 대체 기능
		String oldStr = "자바프로그래밍";
		String newStr = oldStr.replace("자바", "java");
		System.out.println(oldStr+System.identityHashCode(oldStr));
		System.out.println(newStr+System.identityHashCode(newStr));
		
		//문자열 잘라내기(가져오기, 추출하기)
		String firstNum = ssm.substring(0,6);
		System.out.println(firstNum);
		String secondNum = ssm.substring(6);
		System.out.println(secondNum);
		
		//문자열 찾기
		//String oldStr = "자바프로그래밍";
		//찾는 값이 없으면 리턴값 = '-1
		int index = oldStr.indexOf("프로그래밍");
		if (index == -1) {
			System.out.println("프로그래밍 단어가 없습니다");
		}else {
			System.out.println(index + "번 인덱스에 프로그래밍 단어가 있음");
		}
		
		//문자열 포함 여부 확인
		boolean result = oldStr.contains("자바"); //return = true/false
		if(result) {
			System.out.println("자바와 관련되어 있는 문자열");
		} else {
			System.out.println("자바와 관련 없는 문자열");
		}
		
		//문자열 분리
		String board = "1,자바학습,참조타입 String 클래스,홍길동";
		String[] tokens = board.split(",");
		for (int i = 0; i < tokens.length; i++) {
			System.out.printf("%d:%s\n",i,tokens[i]);
		}
		for(String a : tokens) {
			System.out.println(a);
		}
	}
}
