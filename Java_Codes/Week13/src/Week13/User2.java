package Week13;

public class User2 extends Thread{
	private Calculator calc;
	
	public void setCalc(Calculator calc) {
		setName("User2");
		this.calc = calc;
	}
	
	@Override
	public void run() {
		try {
			calc.setMemory(50);
		} catch (InterruptedException e) {}
	}
}
