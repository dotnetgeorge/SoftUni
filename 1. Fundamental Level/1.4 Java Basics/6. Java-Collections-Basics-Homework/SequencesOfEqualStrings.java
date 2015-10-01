/*
 * Problem 2. Sequences of Equal Strings
 * Write a program that enters an array of strings and finds in it all sequences of equal elements. 
 * The input strings are given as a single line, separated by a space.
 * */
import java.util.*;

public class SequencesOfEqualStrings {
	public static int length = 0;
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		String readLine = scanner.nextLine();
		
		String[] strings = readLine.split(" ");
		
		printSequenceOfEqualStrings(strings);
		
		scanner.close();
	}
	
	public static void printSequenceOfEqualStrings(String[] strings) {
		Stack<String> checked = new Stack<String>();  
		length = strings.length;
		String word = null;
		
		for (int i = 0; i < length; i++) {
			word = strings[i];
			
			if(!checked.contains(word)) {
				checked.push(word);
				
				equalStrings(strings, word);
			}
		}
	}
	
	public static void equalStrings(String[] strings, String word) {
		length = strings.length;
		
		for (int i = 0; i < length; i++) {
			if(strings[i].equals(word)) {
				System.out.print(word + " ");
			}
		}
		System.out.println();
	}
}
