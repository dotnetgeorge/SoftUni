/*
 * Problem 1. Rectangle Area
 * Write a program that enters the sides of a rectangle (two integers a and b) and calculates and prints the rectangle's area.
 * */

import java.util.Scanner;

public class RectangleArea {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter sides of rectangle: ");
		int firstSide = scanner.nextInt();
		int secondSide = scanner.nextInt();
		
		int area = firstSide * secondSide;
		
		System.out.println("Area = " + area);
	}

}
