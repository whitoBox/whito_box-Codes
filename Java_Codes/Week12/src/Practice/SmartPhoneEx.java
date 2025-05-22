package Practice;

import java.util.Scanner;

public class SmartPhoneEx {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int menu;
		
		SmartPhone sp = new SmartPhone();
		Earphone   ep = null;
		sp.musicOn(new Airpods());
		
		System.out.println("** 스마트 폰으로 음악 재생하기 **");
		
		while(true) {
			System.out.println("\n연결한 이어폰 성택(1.Buds 2.AirPods 3.TonFree 4.종료");
			menu = sc.nextInt();
			
			if(menu > 4 || menu < 1) continue;
			if(menu == 4) break;
			
			ep = switch(menu) {
			case 1 -> new Buds();
			case 2 -> new Airpods();
			case 3 -> new TonFree();
			default -> null;
			};
			
			sp.musicOn(ep);
			sp.musicOff(ep);
		}
	}
}
