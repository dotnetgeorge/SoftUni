/*
 * Problem 5. Count All Words
 * Write a program to count the number of words in given sentence. 
 * Use any non-letter character as word separator.
 * */
import java.util.Scanner;

public class CountAllWords {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter sentence: ");
		String readSentence = scanner.nextLine();
		String[] words = readSentence.replaceAll("-", " ").split("\\s+");
		scanner.close();
		
		for (String string : words) {
			System.out.println(string);
		}
		
		System.out.println(words.length);
	}

}
