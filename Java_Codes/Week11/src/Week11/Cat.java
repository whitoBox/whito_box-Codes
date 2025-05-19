package Week11;

public class Cat extends Animal{
	
	public Cat() {
		this.kind = "포유류";
	}
	@Override
	public void sound() {
		System.out.println("Meow");
	}
	
	public void catLife() {
		System.out.println("Cat 평균 수명은 12-15년 입니다.");
	}
}
