/*
 * Problem 3. Points inside a Figure
 * Write a program to check whether a point is inside or outside of the figure below. 
 * The point is given as a pair of floating-point numbers, separated by a space. 
 * Your program should print "Inside" or "Outside".
 * */
import java.util.Scanner;

public class PointsInsideFigure {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter X and Y: ");
		double sideX = scanner.nextDouble();
		double sideY = scanner.nextDouble();
		
		if((sideX >= 12.5 && sideX <= 22.5) && (sideY >= 6 && sideY <= 13.5)) {
			System.out.println("Inside");
		} else {
			System.out.println("Outside");
		}
	}
}
