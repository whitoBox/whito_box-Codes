package Week13;

public class MyThread extends Thread{
	private int x;
	
	public MyThread(int x) {
		this.x = x;
	}
	@Override
	public void run() {
		System.out.printf("%d번째 스레드 입니다\n",x);
	}
}
