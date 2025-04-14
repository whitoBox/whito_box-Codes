import java.util.Scanner;

public class StudentSerch {
	public static void main(String[] args) {
		String[] students = {"홍길동", "이순신", "이수정" , "김정민", "김강민"};
		Scanner sc = new Scanner(System.in);
		
		System.out.print("찾고 싶은 학생>>");
		String name = sc.next();
		
		boolean found=false;
		for (int i = 0; i < students.length; i++) {
			if(students[i].equals(name)) {
				found = true;
				break;
			}
		}
		if(found) {
			System.out.println(name = "명단에 있음");
		}else {
			System.out.println(name = "명단에 없음");
		}
	}
}
