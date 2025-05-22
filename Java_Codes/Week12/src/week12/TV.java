package week12;

public class TV implements RemoteControl{
	//구현 클래스 : 인터페이스를 사용하는(구현하는) 클래스
	
	private int volume;
	
	@Override
	public void turnOn() {
		System.out.println("TV 전원을 킵니다");
	}
	@Override
	public void turnOff() {
		System.out.println("TV 전원을 끕니다");
	}

	@Override
	public void setVolume(int volume) {
		if(volume > MAX_VALUE) {
			volume = MAX_VALUE;
		}
		else if(volume < MIN_VALUE) {
			volume = MIN_VALUE;
		}
		this.volume = volume;
		System.out.println("current volume : "+this.volume);
	}
	
}
