package Week13;

public class User1 extends Thread{
	private Calculator calc;
	
	public void setCalc(Calculator calc) {
		setName("User1");
		this.calc = calc;
	}
	
	//작업 스레드 코딩
	@Override
	public void run() {
		try {
			calc.setMemory(100);
		} catch (InterruptedException e) { }
	}
}
