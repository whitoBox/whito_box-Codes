package week02;

public class PruduckPrice {
	public static void main(String[] args) {
		int apple = 7;
		int total = 5700;
		double price = (double)total/apple; //하나만 캐스팅 해도 나머지도 연산할떄 바뀜
		
		System.out.printf("구매 수량: %d개\n",apple);
		System.out.printf("총 구매 금액: %d원\n",total);
		System.out.printf("상품단가: %.1f원",price);
	}
}
