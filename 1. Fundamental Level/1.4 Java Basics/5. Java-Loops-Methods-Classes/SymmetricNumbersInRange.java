/*
 * Problem 1.	Symmetric Numbers in Range
 * Write a program to generate and print all symmetric numbers in given range [start…end] (0 ≤ start ≤ end ≤ 999). 
 * A number is symmetric if its digits are symmetric toward its middle.
 * For example, the numbers 101, 33, 989 and 5 are symmetric, but 102, 34 and 997 are not symmetric. 
 * */
import java.util.Scanner;

public class SymmetricNumbersInRange {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter Range: ");
		int start = scanner.nextInt();
		int end = scanner.nextInt();
		
		
		for (int i = start; i <= end; i++) {
			System.out.print(i == ReverseNumber(i) ? (i + " ") : "");
		}
		
		scanner.close();
	}
	
	public static int ReverseNumber(int number) {
		int resultNumber = 0;
		
	    for(int i = number; i != 0; i /= 10) {
	        resultNumber = (resultNumber * 10) + (i % 10);
	    }
	    
	    return resultNumber; 
	}
}
