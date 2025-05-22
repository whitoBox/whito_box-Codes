package Practice;

public class Airpods implements Earphone{
	
	public Airpods() {
		System.out.println("\n새로 구입한 Apple의 Airpods 연결");
	}
	@Override
	public void play() {
		System.out.println("Airpods 음악 재생중~");
	}

	@Override
	public void stop() {
		System.out.println("Airpods 음악중지.");
		
	}

}
