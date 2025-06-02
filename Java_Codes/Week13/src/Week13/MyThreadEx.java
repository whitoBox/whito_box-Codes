package Week13;

public class MyThreadEx {
	public static void main(String[] args) throws InterruptedException {
		//멀티 스레드 객체 생성
		for (int i = 0; i < 100; i++) {
			MyThread thread = new MyThread(i);
			thread.start();
			thread.join();
		}

		
		
	}
}
