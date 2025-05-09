package week10;

public class Car {
	//객체지향 프로그램에서는
	//클래스의 각 필드를 private으로 선언
	//외부에서의 접근을 제한
	private String company;
	private String model;
	private String color;
	private int    maxSpeed;
	
	//외부에서 값이 필요한 경우, 값을제공하기 위해 getter() 메소드 선언
	public String getCompany() {
		return company;
	}
	//외부에서 값을 지정해 주는 경우 setter() 메소드 이용. 이때, 이효성 검사도 가능
	public void setCompany(String company) {
		this.company = company;
	}
	public String getModel() {
		return model;
	}
	public void setModel(String model) {
		this.model = model;
	}
	public String getColor() {
		return color;
	}
	public void setColor(String color) {
		this.color = color;
	}
	public int getMaxSpeed() {
		return maxSpeed;
	}
	public void setMaxSpeed(int maxSpeed) {
		if(maxSpeed>350)
			maxSpeed = 350;
		else
			this.maxSpeed = maxSpeed;
	}
	
	
}
