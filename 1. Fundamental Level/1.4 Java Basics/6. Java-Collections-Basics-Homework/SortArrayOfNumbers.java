/*
 * Problem 1. Sort Array of Numbers
 * Write a program to enter a number n and n integer numbers and sort and print them. 
 * Keep the numbers in array of integers: int[].
 * */
import java.util.Scanner;

public class SortArrayOfNumbers {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter length of array: ");
		int length = scanner.nextInt();
		
		int[] numbers = new int[length];
		
		for (int i = 0; i < length; i++) {
			numbers[i] = scanner.nextInt(); 
		}
		
		numbers = selectionSort(numbers, length);
		
		printArray(numbers, length);
		
		scanner.close();
	}
	
	public static int[] selectionSort(int[] numbers, int length)
	{
		int min = 0, swap = 0;
		
		for (int i = 0; i < length; i++) {
			
			min = i;
			
			for (int j = i + 1; j < length; j++) {
				if(numbers[j] < numbers[min]) {
					min = j;
				}
				
				swap = numbers[i];
				numbers[i] = numbers[min];
				numbers[min] = swap;
			}
		}
		
		return numbers;
	}
	
	public static void printArray(int[] numbers, int length) {
		for (int i = 0; i < length; i++) {
			System.out.print(numbers[i] + " ");
		}
		System.out.println();
	}
}
