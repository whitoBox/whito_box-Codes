
public class KoreanEx {
	public static void main(String[] args) {
		Korean k1 = new Korean("홍","234234-38472093","01035121351");
		System.out.println("k1.nation: "+k1.nation);
		System.out.println("k1.name: "+k1.name);
		System.out.println("k1.ssn: "+k1.ssn);
		System.out.println("k1.phone: "+k1.phone);
		
		Korean k2 = new Korean("렘","736273-3215151","01012354568");
		System.out.println("k1.nation: "+k2.nation);
		System.out.println("k1.name: "+k2.name);
		System.out.println("k1.ssn: "+k2.ssn);
		System.out.println("k1.phone: "+k2.phone);
	}
}
