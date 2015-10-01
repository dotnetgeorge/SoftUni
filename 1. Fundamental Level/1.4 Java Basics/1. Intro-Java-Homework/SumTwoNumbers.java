/*
 * Problem 6. Sum Two Numbers
 * Write a program SumTwoNumbers.java that enters two integers from the console, calculates and prints their sum.
 *  Search in Internet to learn how to read numbers from the console. 
 *  Examples: 
 *  a  b  result
 *  5  3  8
 *  12 -7 5
 */
import java.util.Scanner;

public class SumTwoNumbers {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner reader = new Scanner(System.in);
		
		System.out.print("Enter two numbers: ");
		int firstNumber = reader.nextInt();
		int secondNumber = reader.nextInt();
		
		int result = firstNumber + secondNumber;
		
		System.out.println("a\tb\tresult");
		System.out.println(firstNumber + "\t" + secondNumber + "\t" + result);
		
		reader.close();
	}

}
