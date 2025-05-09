package package1;

import week10.ClassD;

public class ClassF {
	public ClassF() {
		ClassD dd = new ClassD();
		dd.field1 = 20;
		//패키지가 달라지면 default 접근 불가
		//dd.field2 = 20;
		//dd.field3 = 20;
		
		dd.method1();
		//dd.method2();
		//dd.method3();
	} 
}
