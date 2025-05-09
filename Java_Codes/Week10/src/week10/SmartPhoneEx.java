package week10;

public class SmartPhoneEx {
	public static void main(String[] args) {
		SmartPhone mine = new SmartPhone("갤럭시","white");
	
		System.out.println("모델 : "+ mine.getModel());
		System.out.println("색상 : "+ mine.getColor());
		System.out.println("wifi : "+ mine.isWifi());
		
		mine.bell();
		mine.sendVoice("Hello");
		mine.receiveVoice("홍길동입니다");
		mine.hangUp();
	}
}
