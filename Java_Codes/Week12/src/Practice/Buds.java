package Practice;

public class Buds implements Earphone{
	public Buds() {
		System.out.println("\n새로 구입한 삼성의 버즈 연결");
	}
	@Override
	public void play() {
		System.out.println("버즈로 음악 재생");
	}

	@Override
	public void stop() {
		System.out.println("버즈로 음악 중지");
	}

}
