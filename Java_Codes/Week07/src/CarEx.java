
public class CarEx {
	public static void main(String[] args) {
		//객체 생성
		//Car(); <= 생성자
		Car mycar = new Car();
		
		//필드
		//필드값은 반드시 객체명을 통해서 접근
		System.out.println("제조회사:" + mycar.company);
		System.out.println("모델:" + mycar.model);
		System.out.println("색상:" + mycar.color);
		System.out.println("최고속도:" + mycar.maxSpeed);
		System.out.println("현제 속도:" + mycar.speed);
		//필드 값 변경
		mycar.speed = 100;
		System.out.println("현제 속도:" + mycar.speed);
		
		System.out.println();
		
		Car yourCar = new Car();
		System.out.println("yourCar");
		System.out.println("제조회사:" + yourCar.company);
		System.out.println("모델:" + yourCar.model);
		System.out.println("색상:" + yourCar.color);
		System.out.println("최고속도:" + yourCar.maxSpeed);
		System.out.println("현제 속도:" + yourCar.speed);
		
		System.out.println();
		//매개변수를 이용한 객체 생성
		Car myCar2 = new Car("AMG GT BlackSeries", "Silver Gray", 430);
		System.out.println("제조회사:" + myCar2.company);
		System.out.println("모델:" + myCar2.model);
		System.out.println("색상:" + myCar2.color);
		System.out.println("최고속도:" + myCar2.maxSpeed);
		System.out.println("현제 속도:" + myCar2.speed);
		
		System.out.println();
		Car yourCar2 = new Car("S-550", "Black", 400);
		System.out.println("제조회사:" + yourCar2.company);
		System.out.println("모델:" + yourCar2.model);
		System.out.println("색상:" + yourCar2.color);
		System.out.println("최고속도:" + yourCar2.maxSpeed);
		System.out.println("현제 속도:" + yourCar2.speed);
		
		
	}
}
