/*
 * Problem 7. Count Substring Occurrences
 * Write a program to find how many times given string appears in given text as substring. 
 * The text is given at the first input line. 
 * The search string is given at the second input line. 
 * The output is an integer number. 
 * Please ignore the character casing.
 * */
import java.util.Scanner;

public class CountSubstringOccurrences {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter sentence: ");
		String readSentence = scanner.nextLine();
		
		System.out.print("Enter substring: ");
		String substring = scanner.nextLine();
		
		int count = countOfSubstring(readSentence, substring);
		
		System.out.println(count);
		
		scanner.close();
	}
	
	public static int countOfSubstring(String readSentence, String substring) {
		if(!readSentence.contains(substring)) {
			return 0;
		}
		String[] splitSentence = readSentence.split(" ");
		int length = splitSentence.length;
		int count = 1, index = 0;
		String word = null;
		
		for (int i = 0; i < length; i++) {
			word = splitSentence[i];
			
			index = word.indexOf(substring);
			
			while (index != -1) {
				count++;
				index = word.indexOf(substring, index + 1);
			}
		}
		
		return count;
	}
}
