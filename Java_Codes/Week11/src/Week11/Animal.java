package Week11;

public abstract class Animal {
	public String kind;
	
	public void breath() {
		System.out.println("숨을 쉰다");
	}
	
	//모든 동물은 소리를 낸다.
	//동물마다 소리가 다르다 => 자식객체에서 재정의해야 함
	//메소드의 모양만 제공
	
	public abstract void sound();
}
