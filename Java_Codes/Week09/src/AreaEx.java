
public class AreaEx {
	public static void main(String[] args) {
		Area areaObj = new Area();
		
		double result1 = areaObj.areaCal(10.5);
		System.out.println("원의 넓이 = "+ result1);
		
		int result2 = areaObj.areaCal(12);
		System.out.println("정사각형 넓이 = "+ result2);
		
		int result3 = areaObj.areaCal(6,7);
		System.out.println("직사각형의 넓이 = "+ result3);
	}
}
