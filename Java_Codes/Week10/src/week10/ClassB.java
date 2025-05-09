package week10;

public class ClassB {
	//public : 어디에서든 사용 가능
	ClassA c1 = new ClassA(true); 
	//default : 같은 패키지 안에서 사용 가능
	ClassA c2 = new ClassA(10); 
	//private : 자신만 사용가능
	//ClassA c3 = new ClassA("문자"); 
}
