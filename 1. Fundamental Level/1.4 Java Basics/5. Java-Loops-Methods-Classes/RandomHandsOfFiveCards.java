/*
 * Problem 6.	Random Hands of 5 Cards
 * Write a program to generate n random hands of 5 different cards form a standard suit of 52 cards. 
 * */
import java.util.Random;
import java.util.Scanner;

public class RandomHandsOfFiveCards {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter length: ");
		int length = scanner.nextInt();
		
		for (int i = 0; i < length; i++) {
			GetCard();
		}
		
		scanner.close();
	}
	
	public static void GetCard() {
		String[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
		char[] symbols = {'\u2666','\u2663', '\u2665','\u2660'};
		
		for (int i = 0; i < 5; i++) {
			System.out.printf("%s%s ", cards[RandomNumber(11)], symbols[RandomNumber(2)]);
		}
		System.out.println();
	}
	
	public static int RandomNumber(int end) {
		Random random = new Random();
		
		int randomNumber = random.nextInt((end - 0) + 1) + 0;
		
		return randomNumber;
	}
}
