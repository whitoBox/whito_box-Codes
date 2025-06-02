package Week13;

public class ConsumerThread extends Thread{
	private DataBox dataBox;
	
	public ConsumerThread(DataBox databox) {
		this.dataBox = databox;
	}
	
	@Override
	public void run() {
		//소비자 스레드 작업 내용
		//data를 읽기만 한다
		for (int i = 1; i <= 3; i++) {
			try {
				String data = dataBox.getData();
			} catch (InterruptedException e) { }
		}
	}
}
