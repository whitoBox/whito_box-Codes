
public class CarEx2 {
	public static void main(String[] args) {
		 Car c1 = new Car();
		 System.out.printf("c2:%s %s %d\n",c1.model,c1.color,c1.maxSpeed);
		 
		 Car c2 = new Car("GT");
		 System.out.printf("c2:%s %s %d\n",c2.model,c2.color,c2.maxSpeed);
		
		 Car c3 = new Car("C-Class", "white");
		 System.out.printf("c2:%s %s %d\n",c3.model,c3.color,c3.maxSpeed);

		 Car c4 = new Car("GLC", "white", 320);
		 System.out.printf("c2:%s %s %d\n",c4.model,c4.color,c4.maxSpeed);
	}
}
