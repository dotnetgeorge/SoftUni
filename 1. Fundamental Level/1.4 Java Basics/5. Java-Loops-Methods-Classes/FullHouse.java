/*
 * Problem 3.	Full House
 * In most Poker games, the "full house" hand is defined as three cards of the same face + two cards of the same face, 
 * other than the first, regardless of the card's suits. 
 * The cards faces are "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" and "A". 
 * The card suits are "♣", "♦", "♥" and "♠".
 * Write a program to generate and print all full houses and print their number. 
 * */
import java.util.Scanner;

public class FullHouse {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		String[] card = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
		char[] symbols = {'♣', '♦', '♥', '♠'};
		int count = 0;
		
		
		for (int i = 0; i < 52; i++) {
			for (int j = 0; j < 12; j++) {
				for (int j2 = 0; j2 < 4; j2++) {
					
				}
			}
		}
		
		scanner.close();
	}
}
