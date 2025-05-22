package week12;

public class VolumeEx {
	public static void main(String[] args) {
		//익명 구현 객체 만들기
		//명시적인 구현 클래스느 생략하고 구현 객체르 바로 생성
		//인터페이스 변수 = new 인터페이스(){  };
		
		Volume vol = new Volume() {
			@Override
			public void volumeUp(int level) {
				System.out.println("익명객체의 볼륨을 올립니다: " + level);
			}
			@Override
			public void volumeDown(int level) {
				System.out.println("익명객체의 볼륨을 내립니다: " + level);
			}
		};
		
		vol.volumeDown(7);
		vol.volumeUp(5);
	}
}
