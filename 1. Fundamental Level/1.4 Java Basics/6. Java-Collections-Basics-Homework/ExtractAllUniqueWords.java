/*
 * Problem 10. Extract All Unique Words
 * At the first line at the console you are given a piece of text. 
 * Extract all words from it and print them in alphabetical order. 
 * Consider each non-letter character as word separator. 
 * Take the repeating words only once. 
 * Ignore the character casing. 
 * Print the result words in a single line, separated by spaces.
 * */
import java.util.*;

public class ExtractAllUniqueWords {
	public static ArrayList<String> uniqueWords;
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter sentence: ");
		String readSentence = scanner.nextLine();
		String[] words = readSentence.split("[^a-zA-Z]");
		
		scanner.close();
		
		uniqueWords = extractAllUniqueWords(words);
		
		printUniqueWords(uniqueWords);
	}
	
	/**
	 * Extract all unique words.
	 *
	 * @param words the words
	 * @return the array list
	 */
	public static ArrayList<String> extractAllUniqueWords(String[] words) {
		uniqueWords = new ArrayList<String>();
		
		int length = words.length;
		
		if(length == 1) {
			uniqueWords.add(words[0]);
			return uniqueWords;
		}
		
		String word = null;
		
		for (int i = 0; i < length; i++) {
			word = words[i].toLowerCase();
			
			if(!uniqueWords.contains(word)) {
				uniqueWords.add(word);
			}
		}
		
		Collections.sort(uniqueWords);
		
		return uniqueWords;
	}
	
	/**
	 * Prints the unique words.
	 *
	 * @param uniqueWords the unique words
	 */
	public static void printUniqueWords(ArrayList<String> uniqueWords) {
		for (String string : uniqueWords) {
			System.out.printf("%s ", string);
		}
		System.out.println();
	}
}