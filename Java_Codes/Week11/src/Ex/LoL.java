package Ex;

public class LoL extends Game{

	public LoL(String title, String version) {
		super(title, version);
	}

	@Override
	public void GameDesc() {
		System.out.println("LoL은 리그오브레전드 라는 인기 게임입니다. 질병을 유발하므로 권장하지 않습니다.");
		
	}
	
}
