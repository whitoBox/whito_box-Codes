package week10;

public class carEx {
	public static void main(String[] args) {
		Car mycar = new Car();
		
		//setter() 이용
		mycar.setCompany("Porsche");
		mycar.setModel("911 Sports Classic");
		mycar.setColor("Green");
		
		//getter() 이용
		System.out.println(mycar.getCompany());
		System.out.println(mycar.getModel());
		System.out.println(mycar.getColor());
	}
}
