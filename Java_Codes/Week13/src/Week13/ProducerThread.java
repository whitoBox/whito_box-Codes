package Week13;

public class ProducerThread extends Thread{
	//생산자 작업 스레드
	private DataBox dataBox;
	
	public ProducerThread(DataBox databox) {
		this.dataBox = databox;
	}
	
	@Override
	public void run() {
		//생산자 작업 내용
		//data를 쓰기만 하는 작업
		for (int i = 1; i <= 3; i++) {
			String data = "data-"+ i;
			try {
				dataBox.setData(data);
			} catch (InterruptedException e) { }
		}
	}
}
