package week04;

import java.util.Scanner;

public class DiscountCalculator {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.print("상품 구매 가격 입력>>");
		int price = sc.nextInt();
		double dc = 0;
		
		if(price/100000 >= 1) dc = 0.1;
		else if(price/50000 >= 1) dc = 0.05;
		
		double newprice = price - price * dc;
		
		System.out.println("처음 구매 가격:"+price+"원");
		//System.out.println("할인 가격:"+dc*100+"%");
		//System.out.println("할인 후 가격:"+newprice+"원");
		System.out.printf("할인 가격:%.0f%%\n",dc);
		System.out.printf("할인 후 가격:%.0f원",newprice);
	}

}
