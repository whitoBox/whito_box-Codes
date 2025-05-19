package Ex;

public class GameEx {
	public static void main(String[] args) {
		Game[] game = new Game[3];
		game[0] = new LoL("LOL","12.34");
		game[1] = new Tetris("Tetris", "234.2");
		game[2] = new SuperMario("SuperMario", "33.44");
		
		for(Game gm : game) {
			gm.start();
			gm.GameDesc();
			System.out.println();
		}
		System.out.println("--------------------");
		for (int i = 0; i < game.length; i++) {
			game[i].start();
			game[i].GameDesc();
			System.out.println();
		}
	}
}
