package Ex;

public class Tetris extends Game{

	public Tetris(String title, String version) {
		super(title, version);
	}

	@Override
	public void GameDesc() {
		System.out.println("Tetris는 러시아의 알렉세이 파지노프가 만든 역사가 깊은 게임입니다.");
	}
	
}
