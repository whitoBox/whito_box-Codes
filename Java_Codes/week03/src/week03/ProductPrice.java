package week03;

public class ProductPrice {
	public static void main(String[] args) {
		int milk = 1*4500;
		int carrot = 3*1000;
		int chips = 2*1500;
		
		int total = milk + carrot + chips;
		System.out.println("총 "+total+"원");
		
		double dcprice = total * 0.1;
		System.out.println("할인 "+dcprice+"원");
		
		dcprice = total * 0.9;
		System.out.println("할인 "+dcprice+"원");
	}
}
