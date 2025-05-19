package Week11;

public class DriverEx {
	public static void main(String[] args) {
		Driver driver = new Driver();
		Vehicle v = new Vehicle();
		driver.drive(v);
		
		driver.drive(new Bus());
		driver.drive(new Taxi());
	}
}
