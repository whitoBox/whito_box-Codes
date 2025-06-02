package Week13;

public class BeepTaskEx {
	public static void main(String[] args) throws InterruptedException {
		//Thread 객체를 직접 생성
		//매개변수로 인터페이스 구현객체를 사용
		//구현 객체 생성
		Runnable beepTask = new BeepTask();
		Thread thread = new Thread(beepTask);
		//Thread thread = new Thread(new BeepTask());
		thread.start();
		
		//'***' 출력하는 작업
		for (int i = 0; i < 25; i++) {
			System.out.println("***");
			Thread.sleep(100);			
		}
	}
}
