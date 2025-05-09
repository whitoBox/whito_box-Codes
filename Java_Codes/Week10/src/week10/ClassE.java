package week10;

public class ClassE {
	public ClassE() {
		ClassD dd = new ClassD();
		dd.field1 = 20;
		dd.field2 = 20;
		//private 필드는 접근 불가
		//dd.field3 = 20;
		
		dd.method1();
		dd.method2();
		//private 필드는 접근 불가
		//dd.method3();
		
	}
}
