import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

/**
 * The Class GameCommands.
 */
public class GameCommands implements KeyListener{
	
	/**
	 * Instantiates a new game commands.
	 *
	 * @param game the game
	 */
	public GameCommands(Game game){
		game.addKeyListener(this);
	}
	
	/* (non-Javadoc)
	 * @see java.awt.event.KeyListener#keyPressed(java.awt.event.KeyEvent)
	 */
	public void keyPressed(KeyEvent e) {
		int numberOfKey = e.getKeyCode();
		
		if (numberOfKey == KeyEvent.VK_W || numberOfKey == KeyEvent.VK_UP) {
			if(Game.snake.getVelY() != 20){
				Game.snake.setVelX(0);
				Game.snake.setVelY(-20);
			}
		}
		if (numberOfKey == KeyEvent.VK_S || numberOfKey == KeyEvent.VK_DOWN) {
			if(Game.snake.getVelY() != -20){
				Game.snake.setVelX(0);
				Game.snake.setVelY(20);
			}
		}
		if (numberOfKey == KeyEvent.VK_D || numberOfKey == KeyEvent.VK_RIGHT) {
			if(Game.snake.getVelX() != -20){
			Game.snake.setVelX(20);
			Game.snake.setVelY(0);
			}
		}
		if (numberOfKey == KeyEvent.VK_A || numberOfKey == KeyEvent.VK_LEFT) {
			if(Game.snake.getVelX() != 20){
				Game.snake.setVelX(-20);
				Game.snake.setVelY(0);
			}
		}
		//Other controls
		if (numberOfKey == KeyEvent.VK_ESCAPE) {
			System.exit(0);
		}
	}
	
	/* (non-Javadoc)
	 * @see java.awt.event.KeyListener#keyReleased(java.awt.event.KeyEvent)
	 */
	public void keyReleased(KeyEvent e) {
	}
	
	/* (non-Javadoc)
	 * @see java.awt.event.KeyListener#keyTyped(java.awt.event.KeyEvent)
	 */
	public void keyTyped(KeyEvent e) {
		
	}

}
