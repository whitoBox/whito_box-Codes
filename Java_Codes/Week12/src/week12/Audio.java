package week12;

public class Audio implements RemoteControl{

	private int volume;
	private int memoryVol;
	@Override
	public void turnOn() {
		System.out.println("오디오를 킵니다");
	}
	@Override
	public void turnOff() {
		System.out.println("오디오를 끕니다");
	}
	@Override
	public void setVolume(int volume) {
		this.volume = volume;	
	}
	
	//default 메소드도 필요한 경우 재정의 가능
	@Override
	public void setMute(boolean mute) {
		if(mute) {
			memoryVol = volume;
			setVolume(MIN_VALUE);
			System.out.println("Audio 무음 처리");
			System.out.println("previous volume: "+volume);
		}
		else {
			setVolume(memoryVol);
			System.out.println("Audio 무음 처리 해제");
			System.out.println("current vol: "+volume);
			
		}
	}
	
}
