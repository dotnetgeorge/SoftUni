import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;

public class Point {
	private int pointX, pointY;
	private final int Width = 20;
	private final int Height = 20;
	
	public Point(Point p){
		this(p.pointX, p.pointY);
	}
	
	public Point(int x, int y){
		this.pointX = x;
		this.pointY = y;
	}	
		
	public int getPointX() {
		return pointX;
	}
	public void setPointX(int x) {
		this.pointX = x;
	}
	public int getPointY() {
		return pointY;
	}
	public void setPointY(int y) {
		this.pointY = y;
	}
	
	public void drawPoint(Graphics grapgics, Color color) {
		grapgics.setColor(Color.BLACK);
		grapgics.fillRect(pointX, pointY, Width, Height);
		grapgics.setColor(color);
		grapgics.fillRect(pointX+1, pointY+1, Width-2, Height-2);		
	}
	
	public String toString() {
		return "[x=" + pointX + ",y=" + pointY + "]";
	}
	
	public boolean equals(Object obj) {
        if (obj instanceof Point) {
        	Point to4ka = (Point)obj;
            return (pointX == to4ka.pointX) && (pointY == to4ka.pointY);
        }
        return false;
    }
}
