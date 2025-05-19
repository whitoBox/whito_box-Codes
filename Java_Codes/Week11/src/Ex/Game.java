package Ex;

public abstract class Game {
	private String title;
	private String version;
	
	public Game(String title, String version) {
		//필드 초기화
		this.title = title;
		this.version = version;
	}
	
	public void start() {
		System.out.println("제목 : " + title );
		System.out.println("버전 : " + version );
		System.out.println(title+"게임을 시작합니다");
	}
	//게임에 대한 설명이 필요
	//메소드의 모양만 선언한다.
	public abstract void GameDesc();
	
}
