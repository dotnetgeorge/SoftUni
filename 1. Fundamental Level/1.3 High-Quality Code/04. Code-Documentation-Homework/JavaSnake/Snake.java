import java.awt.Color;
import java.awt.Graphics;
import java.util.LinkedList;

/**
 * The Class Snake.
 */
public class Snake{
	LinkedList<Point> snakeBody = new LinkedList<Point>();
	private Color snakeColor;
	private int velocityX, velocityY;
	
	/**
	 * Instantiates a new snake.
	 */
	public Snake() {
		snakeColor = Color.GREEN;
		snakeBody.add(new Point(300, 100)); 
		snakeBody.add(new Point(280, 100)); 
		snakeBody.add(new Point(260, 100)); 
		snakeBody.add(new Point(240, 100)); 
		snakeBody.add(new Point(220, 100)); 
		snakeBody.add(new Point(200, 100)); 
		snakeBody.add(new Point(180, 100));
		snakeBody.add(new Point(160, 100));
		snakeBody.add(new Point(140, 100));
		snakeBody.add(new Point(120, 100));

		velocityX = 20;
		velocityY = 0;
	}
	
	public void drawSnake(Graphics graphics) {		
		for (Point point : this.snakeBody) {
			point.drawPoint(graphics, snakeColor);
		}
	}
	
	/**
	 * Tick.
	 */
	public void tick() {
		Point newPoint = new Point((snakeBody.get(0).getPointX() + velocityX), (snakeBody.get(0).getPointY() + velocityY));
		
		if (newPoint.getPointX() > Game.WIDTH - 20) {
		 	Game.gameRunning = false;
		} else if (newPoint.getPointX() < 0) {
			Game.gameRunning = false;
		} else if (newPoint.getPointY() < 0) {
			Game.gameRunning = false;
		} else if (newPoint.getPointY() > Game.HEIGHT - 20) {
			Game.gameRunning = false;
		} else if (Game.apple.getPoint().equals(newPoint)) {
			snakeBody.add(Game.apple.getPoint());
			Game.apple = new Apple(this);
			Game.points += 50;
		} else if (snakeBody.contains(newPoint)) {
			Game.gameRunning = false;
			System.out.println("You ate yourself");
		}	
		
		for (int i = snakeBody.size()-1; i > 0; i--) {
			snakeBody.set(i, new Point(snakeBody.get(i-1)));
		}	
		snakeBody.set(0, newPoint);
	}

	/**
	 * Gets the vel x.
	 *
	 * @return the vel x
	 */
	public int getVelX() {
		return velocityX;
	}

	/**
	 * Sets the vel x.
	 *
	 * @param velX the new vel x
	 */
	public void setVelX(int velX) {
		this.velocityX = velX;
	}

	/**
	 * Gets the vel y.
	 *
	 * @return the vel y
	 */
	public int getVelY() {
		return velocityY;
	}

	/**
	 * Sets the vel y.
	 *
	 * @param velY the new vel y
	 */
	public void setVelY(int velY) {
		this.velocityY = velY;
	}
}
