package week12;

public class SmartTV implements RemoteControl, Serchable{
	
	private int Volume;
	@Override
	public void serch(String url) {
		System.out.println(url+"을 검색합니다.");
	}
	@Override
	public void turnOn() {
		System.out.println("Smart TV를 켭니다.");
	}
	@Override
	public void turnOff() {
		System.out.println("SmartTV를 끕니다.");
	}
	@Override
	public void setVolume(int volume) {
		Volume = volume;
	}
	
}
