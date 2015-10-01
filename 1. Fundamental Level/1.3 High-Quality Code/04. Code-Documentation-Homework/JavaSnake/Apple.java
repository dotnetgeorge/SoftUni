import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;

/**
 * The Class Apple.
 */
public class Apple {
	public static Random random;
	private Point apple;
	private Color snakeColor;

	/**
	 * Instantiates a new apple.
	 *
	 * @param snake the snake
	 */
	public Apple(Snake snake) {
		apple = createApple(snake);
		snakeColor = Color.RED;		
	}
	
	/**
	 * Creates the apple.
	 *
	 * @param s the s
	 * @return the point
	 */
	private Point createApple(Snake s) {
		random = new Random();
		int x = random.nextInt(30) * 20; 
		int y = random.nextInt(30) * 20;
		
		for (Point snakePoint : s.snakeBody) {
			if (x == snakePoint.getPointX() || y == snakePoint.getPointY()) {
				return createApple(s);				
			}
		}
		return new Point(x, y);
	}
	
	/**
	 * Draw apple.
	 *
	 * @param graphics the graphics
	 */
	public void drawApple(Graphics graphics){
		apple.drawPoint(graphics, snakeColor);
	}	
	
	/**
	 * Gets the point.
	 *
	 * @return the point
	 */
	public Point getPoint(){
		return apple;
	}
}
