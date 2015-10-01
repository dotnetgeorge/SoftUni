/*
 * Problem 4. Longest Increasing Sequence
 * Write a program to find all increasing sequences inside an array of integers. 
 * The integers are given in a single line, separated by a space. 
 * Print the sequences in the order of their appearance in the input array, each at a single line. 
 * Separate the sequence elements by a space. 
 * Find also the longest increasing sequence and print it at the last line. 
 * If several sequences have the same longest length, print the leftmost of them.
 * */
import java.util.ArrayList;
import java.util.Scanner;

public class LongestIncreasingSequence {
	public static ArrayList<Integer> numbers;
	public static int length;
	public static int number;
	
	public static void main(String[] args) {		
		ArrayList<Integer> numbers = readNumbers();
		findIncreasingSequence(numbers);
	}
	
	/**
	 * Read numbers.
	 *
	 * @return the array list
	 */
	public static ArrayList<Integer> readNumbers() {
		numbers = new ArrayList<Integer>();
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter numbers: ");
		String readNumbers = scanner.nextLine();
		String[] splitNumbers = readNumbers.split(" ");
		length = splitNumbers.length;
		
		for (int i = 0; i < length; i++) {
			number = Integer.parseInt(splitNumbers[i]);
			numbers.add(number);
		}
		
		scanner.close();
		
		return numbers;
	}
	
	/**
	 * Find increasing sequence.
	 *
	 * @param numbers the numbers
	 */
	public static void findIncreasingSequence(ArrayList<Integer> numbers) {
		length = numbers.size();
		int nextNumber = 0, count = 1, bestCount = -1;
		String result = "", bestResult = null;
		
		for (int i = 0; i < length; i++) {
			number = numbers.get(i);
			
			if(i != length - 1) {
				nextNumber = numbers.get(i + 1);
			}
			
			if(number < nextNumber) {
				System.out.printf("%d ", number);
				count++;
				result += number + " ";
			} else {
				System.out.println(number);
				result += number + " ";
				count++;
				
				if(count > bestCount) {
					bestCount = count;
					bestResult = result;
				}
				
				count = 1;
				result = "";
			}
		}
		
		
		System.out.printf("Longest: %s\n", bestResult);
	}
}
