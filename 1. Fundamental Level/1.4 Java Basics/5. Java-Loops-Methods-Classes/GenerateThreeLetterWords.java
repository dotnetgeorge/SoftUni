/*
 * Problem 2.	Generate 3-Letter Words
 * Write a program to generate and print all 3-letter words consisting of given set of characters. 
 * For example if we have the characters 'a' and 'b', 
 * all possible words will be "aaa", "aab", "aba", "abb", "baa", "bab", "bba" and "bbb".
 * The input characters are given as string at the first line of the input. 
 * Input characters are unique (there are no repeating characters). 
 * */
import java.util.Scanner;

public class GenerateThreeLetterWords {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter characters: ");
		String readChars = scanner.nextLine();
		char[] characters = readChars.toCharArray();
		int length = characters.length;
		
		for (int firstChar = 0; firstChar < length; firstChar++) {
			for (int secondChar = 0; secondChar < length; secondChar++) {
				for (int thirdChar = 0; thirdChar < length; thirdChar++) {
					System.out.printf("%s%s%s ", characters[firstChar], characters[secondChar], characters[thirdChar]);
				}
			}
		}
		
		
		scanner.close();
	}
}
