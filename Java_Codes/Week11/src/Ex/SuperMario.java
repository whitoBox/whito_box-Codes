package Ex;

public class SuperMario extends Game{

	public SuperMario(String title, String version) {
		super(title, version);
	}

	@Override
	public void GameDesc() {
		System.out.println("닌텐도의 대표 비디오 게임 시리즈중 하나입니다.");
	}

}
