import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class GameCommands implements KeyListener{
	
	public GameCommands(Game game){
		game.addKeyListener(this);
	}
	
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
	
	public void keyReleased(KeyEvent e) {
	}
	
	public void keyTyped(KeyEvent e) {
		
	}

}
