package Practice;

public class TonFree implements Earphone {
	public TonFree() {
		System.out.println("\nLG의 TonFree가 연결");
	}
	
	@Override
	public void play() {
		System.out.println("TonFree음악 재생");
	}

	@Override
	public void stop() {
		System.out.println("TonFree음악 중지");
	}

}
