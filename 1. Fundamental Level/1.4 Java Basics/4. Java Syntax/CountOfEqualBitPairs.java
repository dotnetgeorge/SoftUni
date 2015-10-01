/*
 * Problem 8. * Count of Equal Bit Pairs
 * Write a program to count how many sequences of two equal bits ("00" or "11")
 * can be found in the binary representation of given integer number n (with overlapping).
 * */
import java.util.Scanner;

public class CountOfEqualBitPairs {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		int count = 0;
		
		System.out.print("Enter Number: ");
		int number = scanner.nextInt();
		
		String binary = String.format("%16s", Integer.toBinaryString(number));
		binary = binary.trim();
		int length = binary.length();
		
		
		
		for (int i = 0; i < length - 1; i++) {
			if(binary.charAt(i) == binary.charAt(i + 1)) {
				count++;
			}
		}
		
		System.out.printf("Number: %d\n", number);
		System.out.printf("Binary Number: %s\n", binary);
		System.out.printf("Count: %d\n", count);
		
		scanner.close();
	}

}
