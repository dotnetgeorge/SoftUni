/*
 * Problem 4.	Print a Deck of 52 Cards
 * Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
 * The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). 
 * The card faces should start from 2 to A.
 * Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
 * Use 2 nested for-loops and a switch-case statement.
 * output:
 * 2♣ 2♦ 2♥ 2♠
 * 3♣ 3♦ 3♥ 3♠
 * …
 * K♣ K♦ K♥ K♠
 * A♣ A♦ A♥ A♠
 */
using System;

class PrintDeckOf52Cards
{
    static void Main(string[] args)
    {
        string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        char[] symbols = new char[] { '♣', '♦', '♥', '♠' };

        int cardsLength = cards.Length;
        int symbolsLength = symbols.Length;

        Console.WriteLine("Output:");

        for (int card = 0; card < cardsLength; card++)
        {
            for (int symbol = 0; symbol < symbolsLength; symbol++)
            {
                Console.Write("{0}{1} ", cards[card], symbols[symbol]);
            }
            Console.WriteLine();
        }
    }
}