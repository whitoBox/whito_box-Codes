package week03;

public class ProductPrice2 {
	public static void main(String[] args) {
		int milk = 1*4500;
		int carrot = 3*1000;
		int chips = 2*1500;
		double rate = 25;
		
		int total = milk + carrot + chips;
		System.out.println("할인 전 상품 가격: "+total+"원");
		
		double dcprice = total * (rate/100);
		
		System.out.println("할인 금액: "+dcprice+"원");
		
		System.out.println("최종 결제 금액: "+ (total-dcprice) +"원");
	}
}
