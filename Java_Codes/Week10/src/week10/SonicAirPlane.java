package week10;

public class SonicAirPlane extends AirPlane {
	//비행 모드 초기값 설정
	public static final int NORMAL = 1;
	public static final int SUPERSONIC = 2;
	
	int flyMode = NORMAL;
	
	private int soundspeed;
	private int maxSpeed;
	
	//부모 메소드를 재정의
	@Override
	public void fly() {
		if(flyMode == NORMAL)
			super.fly();
		else if(flyMode == SUPERSONIC)
			System.out.println("SONIC BOOM FLINGGGGGGGG");
	}
	
	public int getSoundspeed() {
		return soundspeed;
	}
	public void setSoundspeed(int soundspeed) {
		this.soundspeed = soundspeed;
	}
	public int getMaxSpeed() {
		return maxSpeed;
	}
	public void setMaxSpeed(int maxSpeed) {
		this.maxSpeed = maxSpeed;
	}
	
	
}
