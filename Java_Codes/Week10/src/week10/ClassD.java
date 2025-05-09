package week10;

public class ClassD {
	
	public int field1;
	int field2; 			//기본 접근 제한자 default
	private int field3;
	
	public ClassD() {
		//클래스 내부에서는 접근제한자의 영향을 받지 않는다.
		field1 = 10;
		field2 = 10;
		field3 = 10;
		method1();
		method2();
		method3();
		
	}
	//메소드의 접근제한자
	public void method1() {}
	void method2() {} 		//생략되면 default
	private void method3() {}
}
