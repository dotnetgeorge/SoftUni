import java.util.Scanner;

public class CardsFrequencies {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter cards: ");
		String readCards = scanner.nextLine();
		String[] cards = readCards.split("[^a-zA-Z0-9]");
		
		cardFrequencies(cards, readCards);
		
		scanner.close();
	}
	
	public static void cardFrequencies(String[] cards, String readCards) {
		String card = "";
		int length = cards.length;
		int index = -1;
		int count = 1;
		
		for (int i = 0; i < length; i++) {
			card = cards[i];
			
			index = readCards.indexOf(card);
			
			while (index != -1) {
				count++;
				index = readCards.indexOf(card, index + 1);
			}
			
			Double percent = (double) (count / length);
			
			System.out.println(card + " -> " + percent + "%");
			count = 1;
		}
	}
}
