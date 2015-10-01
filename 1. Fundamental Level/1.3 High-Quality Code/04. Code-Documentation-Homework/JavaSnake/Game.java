import java.awt.Canvas;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.image.BufferedImage;

/**
 * The Class Game.
 */
@SuppressWarnings("serial")
public class Game extends Canvas implements Runnable {
	public static Snake snake;
	public static Apple apple;
	static int points;
	
	private Graphics globalGraphics;
	private Thread runThread;
	public static final int WIDTH = 600;
	public static final int HEIGHT = 600;
	private final Dimension gameSize = new Dimension(WIDTH, HEIGHT);
	
	static boolean gameRunning = false;
	
	/* (non-Javadoc)
	 * @see java.awt.Canvas#paint(java.awt.Graphics)
	 */
	public void paint(Graphics g){
		this.setPreferredSize(gameSize);
		globalGraphics = g.create();
		points = 0;
		
		if(runThread == null){
			runThread = new Thread(this);
			runThread.start();
			gameRunning = true;
		}
	}
	
	/* (non-Javadoc)
	 * @see java.lang.Runnable#run()
	 */
	public void run(){
		while(gameRunning){
			snake.tick();
			render(globalGraphics);
			try {
				Thread.sleep(100);
			} catch (Exception e) {
				// TODO: fani ma za eksep6ana
			}
		}
	}
	
	/**
	 * Instantiates a new game.
	 */
	public Game(){	
		snake = new Snake();
		apple = new Apple(snake);
	}
		
	/**
	 * Render.
	 *
	 * @param g the g
	 */
	public void render(Graphics g){
		g.clearRect(0, 0, WIDTH, HEIGHT+25);
		
		g.drawRect(0, 0, WIDTH, HEIGHT);			
		snake.drawSnake(g);
		apple.drawApple(g);
		g.drawString("score= " + points, 10, HEIGHT + 25);		
	}
}

