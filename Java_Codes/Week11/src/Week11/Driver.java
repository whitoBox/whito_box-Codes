package Week11;

public class Driver {
	//매개변수가 클래스 변수 => 매개변수의 다형성
	//Vehicle을 상속한 자식객체도 대입 가능(자동타입 변환)
	
	public void drive(Vehicle v) {
		v.run();
	}
}
