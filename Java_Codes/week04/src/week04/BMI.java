package week04;

import java.util.Scanner;

public class BMI {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("name:");
		String name = sc.next();
		System.out.print("height(cm):");
		int height = sc.nextInt();
		System.out.print("weight(kg):");
		int weight = sc.nextInt();
		System.out.printf("%s's height is %dcm weight is %dkg\n",name,height,weight);
		
		double mheight = (double)height/100; 
		//System.out.println(mheight);
		double bmi = weight / (mheight * mheight);
		
		String fat="";
		if(bmi >= 30) {
			fat = "고도비만";
		}else if(bmi >= 25) {
			fat = "비만";
		}else if(bmi >=23) {
			fat = "과제중";
		}else if(bmi >= 18.5) {
			fat = "정상";
		}
		
		System.out.printf("bmi 지수는 %.2f이고 %s입니다",bmi,fat);
		
	}
}
