package Week13;

public class BeepThreadEx {
	public static void main(String[] args) throws InterruptedException {
		//main() 스레드
		//작업 스레드
		Thread thread = new BeepThread();
		thread.start();
		
		//'***' 출력하는 작업
		for (int i = 0; i < 25; i++) {
			System.out.println("***");
			Thread.sleep(100);			
		}
	}
}
