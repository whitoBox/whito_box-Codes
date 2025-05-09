package package1;

import week10.ClassA;

public class ClassC {
	//패키지가 다르면 반드시 import 해야됨
	ClassA c1 = new ClassA(true);
	
	//defalut, private는 접근 안됨
	//ClassA c2 = new ClassA(10);
	//ClassA c3 = new ClassA("word");
}
