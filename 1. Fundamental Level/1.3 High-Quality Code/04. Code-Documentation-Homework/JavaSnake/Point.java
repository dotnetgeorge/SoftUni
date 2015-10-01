import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;

/**
 * The Class Point.
 */
public class Point {
	private int pointX, pointY;
	private final int Width = 20;
	private final int Height = 20;
	
	/**
	 * Instantiates a new point.
	 *
	 * @param p the p
	 */
	public Point(Point p){
		this(p.pointX, p.pointY);
	}
	
	/**
	 * Instantiates a new point.
	 *
	 * @param x the x
	 * @param y the y
	 */
	public Point(int x, int y){
		this.pointX = x;
		this.pointY = y;
	}	
		
	/**
	 * Gets the point x.
	 *
	 * @return the point x
	 */
	public int getPointX() {
		return pointX;
	}
	
	/**
	 * Sets the point x.
	 *
	 * @param x the new point x
	 */
	public void setPointX(int x) {
		this.pointX = x;
	}
	
	/**
	 * Gets the point y.
	 *
	 * @return the point y
	 */
	public int getPointY() {
		return pointY;
	}
	
	/**
	 * Sets the point y.
	 *
	 * @param y the new point y
	 */
	public void setPointY(int y) {
		this.pointY = y;
	}
	
	/**
	 * Draw point.
	 *
	 * @param grapgics the grapgics
	 * @param color the color
	 */
	public void drawPoint(Graphics grapgics, Color color) {
		grapgics.setColor(Color.BLACK);
		grapgics.fillRect(pointX, pointY, Width, Height);
		grapgics.setColor(color);
		grapgics.fillRect(pointX+1, pointY+1, Width-2, Height-2);		
	}
	
	/* (non-Javadoc)
	 * @see java.lang.Object#toString()
	 */
	public String toString() {
		return "[x=" + pointX + ",y=" + pointY + "]";
	}
	
	/* (non-Javadoc)
	 * @see java.lang.Object#equals(java.lang.Object)
	 */
	public boolean equals(Object obj) {
        if (obj instanceof Point) {
        	Point point = (Point)obj;
            return (pointX == point.pointX) && (pointY == point.pointY);
        }
        return false;
    }
}
