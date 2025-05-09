package week10;

class AirLine {
	public void land() {
		System.out.println("landed.");
	}
	public void fly() {
		System.out.println("normal flying");
	}
	public void takeoff() {
		System.out.println("taking off");
	}
}

public class AirCraft extends AirLine{
	@Override
	public void fly() {
		// TODO Auto-generated method stub
		super.fly();
	}
	
	public static void main(String[] args) {
		AirCraft ac = new AirCraft();
		ac.takeoff();
		ac.fly();
		ac.takeoff();
	}
	
}
