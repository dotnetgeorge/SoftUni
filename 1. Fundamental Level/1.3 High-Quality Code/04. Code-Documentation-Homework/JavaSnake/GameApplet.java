import java.applet.Applet;
import java.awt.Dimension;
import java.awt.Graphics;

/**
 * The Class GameApplet.
 */
@SuppressWarnings("serial")
public class GameApplet extends Applet {
	private Game game;
	GameCommands IH;
	
	/* (non-Javadoc)
	 * @see java.applet.Applet#init()
	 */
	public void init(){
		game = new Game();
		game.setPreferredSize(new Dimension(800, 650));
		game.setVisible(true);
		game.setFocusable(true);
		this.add(game);
		this.setVisible(true);
		this.setSize(new Dimension(800, 650));
		IH = new GameCommands(game);
	}
	
	/* (non-Javadoc)
	 * @see java.awt.Container#paint(java.awt.Graphics)
	 */
	public void paint(Graphics g){
		this.setSize(new Dimension(800, 650));
	}

}
