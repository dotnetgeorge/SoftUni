/*
 * Problem 8. * Sort Array of Strings
 * Write a program that enters from the console number n and n strings,
 * then sorts them alphabetically and prints them. 
 * Implement your own sorting algorithm. 
 * Note: you might need to learn how to use loops and arrays in Java (search in Internet).
 * */

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
public class SortArrayOfStrings {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner read = new Scanner(System.in);
		
		System.out.println("Enter Count of Strings: ");
		int count = read.nextInt();
		String name = null;
		ArrayList<String> names = new ArrayList<String>();
		
		for (int i = 0; i < count; i++) {
			System.out.println("[" + (i + 1) + "] Enter String: ");
			name = read.next();
			
			names.add(name);
		}
		
		Collections.sort(names);
		
		System.out.println("Sorted List: ");
		for (String item : names) {
			System.out.println(item);
		}
		
		read.close();
	}

}
