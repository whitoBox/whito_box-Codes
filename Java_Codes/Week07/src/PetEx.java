
public class PetEx {
	public static void main(String[] args) {
		Pet pet = new Pet("뽀삐","리트리버");
		
		System.out.println("<애완동물 정보 1>");
		System.out.println("이름: "+pet.name);
		System.out.println("종류: "+ pet.type);
		System.out.printf("나이: %d살\n",pet.age);
		System.out.println("색상: "+ pet.color);
		
		System.out.println();
		
		Pet pet2 = new Pet("초코","허스키",2,"흰색");
		System.out.println("<애완동물 정보 2>");
		System.out.println("이름: "+pet2.name);
		System.out.println("종류: "+ pet2.type);
		System.out.printf("나이: %d살\n",pet2.age);
		System.out.println("색상: "+ pet2.color);
	}
}
