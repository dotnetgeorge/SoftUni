/*
 * Problem 9. Combine Lists of Letters
 * Write a program that reads two lists of letters l1 and l2 and combines them: 
 * 		appends all letters c from l2 to the end of l1, but only when c does not appear in l1. 
 * Print the obtained combined list. 
 * All lists are given as sequence of letters separated by a single space, each at a separate line. 
 * Use ArrayList<Character> of chars to keep the input and output lists.
 * */
import java.util.ArrayList;
import java.util.Scanner;

public class CombineListsOfLetters {
	public static ArrayList<Character> characters;
	public static int length;
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		characters = readCharacters();
		
		printCharacters(characters);
	}
	
	public static ArrayList<Character> readCharacters() {
		Scanner scanner = new Scanner(System.in);
		characters = new ArrayList<Character>();
		
		System.out.print("Enter first characters: ");
		String readFirstCharacters = scanner.nextLine();
		
		System.out.print("Enter second characters: ");
		String readSecondCharacters = scanner.nextLine();
		
		length = readFirstCharacters.length();
		
		for(int i = 0; i < length; i++) {
			characters.add(readFirstCharacters.charAt(i));
		}
		
		length = readSecondCharacters.length();
		
		for (int i = 0; i < length; i++) {
			if(!characters.contains(readSecondCharacters.charAt(i))) {
				characters.add(' ');
				characters.add(readSecondCharacters.charAt(i));
			}
		}
		
		scanner.close();
		
		return characters;
	}
	
	public static void printCharacters(ArrayList<Character> characters) {
		for (Character character : characters) {
			System.out.printf("%s", character);
		}
		System.out.println();
	}
}