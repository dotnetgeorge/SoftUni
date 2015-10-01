import java.util.List;
import java.util.Scanner;

/*
 * Problem 3. Largest Sequence of Equal Strings
 * Write a program that enters an array of strings and finds in it the largest sequence of equal elements.
 *  If several sequences have the same longest length, print the leftmost of them. 
 *  The input strings are given as a single line, separated by a space.
 * */


public class LargestSequenceOfEqualStrings {
	public static int length;
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter strings: ");
		String readStrings = scanner.nextLine();
		
		scanner.close();
		
		
		String[] strings = readStrings.split(" ");
		
		String[] results = findSequence(strings);
		
		printResult(results);
	}
	
	public static String[] findSequence(String[] strings) {
		length = strings.length;
		
		if(length == 1) {
			return strings;
		}
		String word = "";
		String nextWord = "";
		String bestWord = "";
		int count = 1;
		int bestCount = -1;
		
		for (int i = 0; i < length - 1; i++) {
			word = strings[i];
			nextWord = strings[i + 1];
			
			if(word.equals(nextWord)) {
				count++;
				
				if(count > bestCount) {
					bestCount = count;
					bestWord = word;
				}
			} else {
				count = 1;
			}
		}
		
		if(bestCount == -1) {
			bestCount = 1;
			bestWord = strings[0];
		}
		
		String[] sequence = new String[bestCount];
		
		for (int i = 0; i < bestCount; i++) {
			sequence[i] = bestWord;
		}
		
		return sequence;
	}
	
	public static void printResult(String[] results) {
		length = results.length;
		
		for (int i = 0; i < length; i++) {
			System.out.print(results[i] + " ");
		}
		System.out.println();
	}
}
