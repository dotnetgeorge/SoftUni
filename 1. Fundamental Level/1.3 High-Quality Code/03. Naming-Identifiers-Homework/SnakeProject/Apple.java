import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;


public class Apple {
	public static Random random;
	private Point apple;
	private Color snakeColor;
	
	public Apple(Snake snake) {
		apple = createQbalkata(snake);
		snakeColor = Color.RED;		
	}
	
	private Point createQbalkata(Snake s) {
		random = new Random();
		int x = random.nextInt(30) * 20; 
		int y = random.nextInt(30) * 20;
		
		for (Point snakePoint : s.snakeBody) {
			if (x == snakePoint.getPointX() || y == snakePoint.getPointY()) {
				return createQbalkata(s);				
			}
		}
		return new Point(x, y);
	}
	
	public void drawApple(Graphics graphics){
		apple.drawPoint(graphics, snakeColor);
	}	
	
	public Point GetPoint(){
		return apple;
	}
}
