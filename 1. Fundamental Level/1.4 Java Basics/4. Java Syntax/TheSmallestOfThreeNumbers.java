/*
 * Problem 4. The Smallest of 3 Numbers
 * Write a program that finds the smallest of three numbers.
 * */
import java.util.Scanner;

public class TheSmallestOfThreeNumbers {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter three numbers: ");
		double firstNumber = scanner.nextDouble();
		double secondNumber = scanner.nextDouble();
		double thirdNumber = scanner.nextDouble();
		
		if(firstNumber < secondNumber) {
			if(firstNumber < thirdNumber) {
				System.out.println(firstNumber);
			} else {
				System.out.println(thirdNumber);
			}
		} else {
			if(secondNumber < thirdNumber) {
				System.out.println(secondNumber);
			} else {
				System.out.println(thirdNumber);
			}
		}
	}

}
