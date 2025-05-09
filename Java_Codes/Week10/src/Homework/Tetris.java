package Homework;

public class Tetris extends Game{
	
	public Tetris(String version) {
		super("Tetris", version);
	}
	public void tetrisDesc(){
		System.out.println("테트리스(Tetris)는 퍼즐 게임으로,"
				+ "소련의 프로그래머 알렉세이 파지트노프가 처음"
				+ "디자인하고 프로그래밍 한 게임이다");
	}
}
