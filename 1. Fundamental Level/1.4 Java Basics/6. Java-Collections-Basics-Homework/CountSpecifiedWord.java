/*
 * Problem 6. Count Specified Word
 * Write a program to find how many times a word appears in given text. 
 * The text is given at the first input line. 
 * The target word is given at the second input line. 
 * The output is an integer number. 
 * Please ignore the character casing. 
 * Consider that any non-letter character is a word separator.
 * */
import java.util.Scanner;

public class CountSpecifiedWord {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter sentence: ");
		String readSentence = scanner.nextLine();
		
		System.out.print("Enter specified word: ");
		String specifiedWord = scanner.next(); 
		
		int countOfWord = countWordInSentence(readSentence, specifiedWord);
		
		System.out.println(countOfWord);
		
		scanner.close();
	}
	
	public static int countWordInSentence(String readSentence, String specifiedWord) {
		String sentence = readSentence.toLowerCase();
		
		if(!sentence.contains(specifiedWord)) {
			return 0;
		}
		
		int index = sentence.indexOf(specifiedWord);
		int count = 1;
		
		while (index != -1) {
			count++;
			index = sentence.indexOf(sentence, index + 1);
		}
		
		return count;
	}
}
