package week12;

public class RemoteContorlEx {
	public static void main(String[] args) {
		//구현 클래스를 이요해서 구현 객체 생성
		
		Audio audio = new Audio();
		TV    tv    = new TV();
		
		//생성된 구현객체로 메소드 호출
		audio.turnOn();
		audio.setVolume(5);
		audio.setMute(true);
		audio.setMute(false);
		audio.turnOff();

		System.out.println();
		tv.turnOn();
		tv.setVolume(100);
		tv.setMute(true);
		tv.setMute(false);
		tv.turnOff();
		
		System.out.println();
		RemoteControl.changeBattery();
		
		System.out.println();
		SmartTV smart = new SmartTV();
		smart.turnOn();
		smart.setVolume(10);
		smart.setMute(true);
		smart.serch("google");
		smart.setMute(false);
		smart.turnOff();
		
		//상수 필드 접근
		System.out.println();
		System.out.println("리모컨 최대 볼륨: "+ RemoteControl.MAX_VALUE);
		System.out.println("리모컨 최소 볼륨: "+ RemoteControl.MIN_VALUE);
		//이거 어캐갖고옴?(인터페이스의 필드는 [static 상수]입니다)
		
		System.out.println("--- 인터페이스의 다형성 ---");
		RemoteControl[] rc = new RemoteControl[3];
		rc[0] = new Audio();
		rc[1] = new TV();
		rc[2] = new SmartTV();
		
		for(RemoteControl r : rc) {
			r.turnOn();
			r.turnOff();
			r.setMute(true);
			r.setMute(false);
			r.turnOff();
			System.out.println("---");
		}
	}	
}
