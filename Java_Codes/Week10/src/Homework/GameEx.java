package Homework;

public class GameEx {
	public static void main(String[] args) {
		LOL leage = new LOL("14.0");
		Tetris tetris = new Tetris("13.6");
		SuperMario mario = new SuperMario("16.2");
		
		leage.start();
		leage.lolDesc();
		
		tetris.start();
		tetris.tetrisDesc();
		
		mario.start();
		mario.marioDesc();
		
	}
}
