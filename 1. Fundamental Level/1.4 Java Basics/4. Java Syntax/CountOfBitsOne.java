/*
 * Problem 7. Count of Bits One
 * Write a program to calculate the count of bits 1 in the binary representation of given integer number n.
 * */
import java.util.Scanner;

public class CountOfBitsOne {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter Number: ");
		int number = scanner.nextInt();
		
		String binaryValue = String.format("%16s", Integer.toBinaryString(number)).replace(' ', '0');
		
		int index = binaryValue.indexOf('1');
		int count = 0;
		
		while(index != -1) {
			index = binaryValue.indexOf('1', index + 1);
			count++;
		}
		
		System.out.println("Count of '1' in binary number is = " + count);
		System.out.println(binaryValue);
		
		scanner.close();
	}
}
