/*
 * Problem 6. Formatting Numbers
 * Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), 
 * a floating-point b and a floating-point c and prints them in 4 virtual columns on the console.
 * Each column should have a width of 10 characters.
 * The number a should be printed in hexadecimal, left aligned;
 *  then the number a should be printed in binary form, padded with zeroes,
 *  then the number b should be printed with 2 digits after the decimal point, right aligned;
 *  the number c should be printed with 3 digits after the decimal point, left aligned.
 * */
import java.util.Scanner;

public class FormattingNumbers {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter Integer and Two Float Numbers: ");
		int firstNumber = scanner.nextInt();
		float secondNumber = scanner.nextFloat();
		float thirdNumber = scanner.nextFloat();
		
		String hexValue = Integer.toHexString(firstNumber).toUpperCase();
		String binaryValue = String.format("%10s", Integer.toBinaryString(firstNumber)).replace(' ', '0');
		
		System.out.printf("|%-10s|%10s|%10.2f|%.3f", hexValue, binaryValue, secondNumber, thirdNumber);
	}

}
