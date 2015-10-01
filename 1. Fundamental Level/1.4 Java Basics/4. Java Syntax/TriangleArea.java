/*
 * Problem 2. Triangle Area
 * Write a program that enters 3 points in the plane (as integer x and y coordinates),
 *  calculates and prints the area of the triangle composed by these 3 points. 
 *  Round the result to a whole number.
 *  In case the three points do not form a triangle, print "0" as result.
 * */
import java.util.Scanner;

public class TriangleArea {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter first side X and Y: ");
		int firstSideX = scanner.nextInt();
		int firstSideY = scanner.nextInt();
		
		System.out.print("Enter second side X and Y: ");
		int secondSideX = scanner.nextInt();
		int secondSideY = scanner.nextInt();
		
		System.out.print("Enter third side X and Y: ");
		int thirdSideX = scanner.nextInt();
		int thirdSideY = scanner.nextInt();
		
		int area = Math.floorDiv(((firstSideX*(secondSideY - thirdSideY)) + (secondSideX*(thirdSideY - firstSideY)) + (thirdSideX*(firstSideY - secondSideY))) , 2) * (-1);
		
		System.out.println("Area = " + area);
	}

}
