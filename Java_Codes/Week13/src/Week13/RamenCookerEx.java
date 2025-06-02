package Week13;

public class RamenCookerEx {
	public static void main(String[] args) {
		//멀티 스레드 생성
		RamenCooker guest1 = new RamenCooker("김민수");
		guest1.start();
		RamenCooker guest2 = new RamenCooker("변현지");
		guest2.start();
		RamenCooker guest3 = new RamenCooker("이채린");
		guest3.start();
		
		//그냥 해본거 ㅋㅋ
		RamenCooker[] guests = new RamenCooker[10000];
		for (int i = 0; i < guests.length; i++) {
			String g = "g"+i;
			guests[i] = new RamenCooker(g);
			guests[i].start();
		}
	}
}
