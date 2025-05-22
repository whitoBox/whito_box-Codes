package week12;

public interface RemoteControl {
	//인터페이스 선언
	//인터페이스의 필드 => 상수필드
	int MAX_VALUE = 10;
	int MIN_VALUE = 0;
	
	//모든 자식 객체에서 사용하는 기능을 모아 놓은 것
	//데이터를 저장하는 필드 선언은 불가능
	//선언된 필드 => 상수필드(public static final)
	//선언될 메소드 => abstract가 생량되어도 자동으로 컴파일때 추상메소드가 된다.
	//추상 메소드 = 실행문이 없는 메소드(머리만 있는 메소드)
	//추상 메소드 => 구현 클래스에서 반드시 재정의해서 사용
	
	public void turnOn(); // <= abstract 가 자동으로 들어감
	
	//기능 추가
	void turnOff();
	void setVolume(int volume);
	
	//새로운 기능 추가
	//default 메소드로 선언 => 기존 구현 클래스에는 영향을 주지 않는다
	default void setMute(boolean mute) {
		//default 메소드는 반드시 실행명령문이 포함되어야 함
		if(mute) {
			System.out.println("무음 처리합니다");
			setVolume(MIN_VALUE);
		}else {
			System.out.println("무음을 해제합니다");
			setVolume(5);
		}
	}
	
	//정적 메소드 추가
	//구현 객체가 없어도 인터페이스 이름으로 호출이 가능한 메소드
	static void changeBattery() {
		System.out.println("BOXBOX (change battery)");
	}
}
