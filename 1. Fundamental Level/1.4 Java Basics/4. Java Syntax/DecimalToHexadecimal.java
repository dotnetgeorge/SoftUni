/*
 * Problem 5. Decimal to Hexadecimal
 * Write a program that enters a positive integer number num and converts and prints it in hexadecimal form.
 *  You may use some built-in method from the standard Java libraries.
 * */
import java.util.Scanner;

public class DecimalToHexadecimal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter number: ");
		int number = scanner.nextInt();
		
		String hexValue = Integer.toHexString(number).toUpperCase();
		
		System.out.println("Hex = " + hexValue);
	}

}
