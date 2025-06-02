package Week13;

public class BeepTask implements Runnable{
	//RUnnable 인터페이스를 구현하는 구현클래스
	@Override
	public void run() {
		//작업 스레드 코드 작성
		for (int i = 0; i < 5; i++) {
			System.out.println("삐");
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) { }
		}
	}

}
