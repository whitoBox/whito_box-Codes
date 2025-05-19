package Week11;

public class CarEx {
	public static void main(String[] args) {
		Car car = new Car();
		
		car.tire = new Tire();
		car.run();
		
		car.tire = new HankookTire();
		car.run();
		
		car.tire = new KumhoTire();
		car.run();
	}
}
