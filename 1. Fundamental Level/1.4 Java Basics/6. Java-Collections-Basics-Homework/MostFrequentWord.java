/*
 * Problem 11. Most Frequent Word
 * Write a program to find the most frequent word in a text and print it, 
 * 		as well as how many times it appears in format "word -> count". 
 * Consider any non-letter character as a word separator. 
 * Ignore the character casing. 
 * If several words have the same maximal frequency, print all of them in alphabetical order.
 * */
import java.util.*;

public class MostFrequentWord {
	public static Map<Integer, String> frequentWords;
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter words: ");
		String readWords = scanner.nextLine();
		String[] words = readWords.split("[^a-zA-Z]");
		
		scanner.close();
		
		frequentWords = findMostFrequentWord(words);
		
		printFrequentWords(frequentWords);
	}
	
	public static Map<Integer, String> findMostFrequentWord(String[] words) {
		frequentWords = new TreeMap<Integer, String>();
		
		int length = words.length;
		int count = 0;
		String word = "", nextWord = "";
		
		Arrays.sort(words);
		
		for (int i = 0; i < length; i++) {
			word = words[i].toLowerCase();
			
			for (int j = 0; j < length; j++) {
				nextWord = words[j].toLowerCase();
				
				if(word.equals(nextWord)) {
					count++;
				}
			}
			if(!frequentWords.containsValue(word)) {
				frequentWords.put(count, word);
			}
			count = 0;
			
		}
		
		Map<Integer, String> sortedFrequentWords = new TreeMap<Integer, String>(
			new Comparator<Integer>() {

			@Override
			public int compare(Integer o1, Integer o2) {
				return o2.compareTo(o1);
			}
		});
		sortedFrequentWords.putAll(frequentWords);
		
		return sortedFrequentWords;
	}
	
	public static void printFrequentWords(Map<Integer, String> frequentWords) {
		int count = (int) frequentWords.keySet().toArray()[0];
		
		
		for (Map.Entry<Integer, String> element : frequentWords.entrySet()) {
			/*if(element.getKey() != count) {
				break;
			}*/
			
			System.out.printf("%s -> %d times.\n", element.getValue(), element.getKey());
		}
	}
}
