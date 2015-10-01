/*
 * Problem 8.	Sum Numbers from a Text File
 * Write a program to read a text file "Input.txt" holding a sequence of integer numbers, each at a separate line. 
 * Print the sum of the numbers at the console.
 * Ensure you close correctly the file in case of exception or in case of normal execution. 
 * In case of exception (e.g. the file is missing), print "Error" as a result. 
 * */
import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;


public class SumNumbersFromTextFile {

	public static void main(String[] args) throws FileNotFoundException, IOException {
		// TODO Auto-generated method stub
		try {
			ArrayList<Integer> readFile = ReadFileLines("E:\\tessssst.txt");
			int result = Sum(readFile);
			
			System.out.println("Sum = " + result);
		} catch (FileNotFoundException fnfe) {
			// TODO: handle exception
			System.err.println("Error");
		}
	}
	
	public static ArrayList<Integer> ReadFileLines(String fileName) throws FileNotFoundException, IOException {
		ArrayList<Integer> readFileLine = new ArrayList<Integer>();
		
		try(BufferedReader reader = new BufferedReader(new FileReader(fileName))) {
			String line;
			
			while ((line = reader.readLine()) != null) {
				readFileLine.add(Integer.parseInt(line));
			}
		}
		
		return readFileLine;
	}
	
	public static Integer Sum(ArrayList<Integer> numbers) {
		int length = numbers.size();
		int result = 0;
		
		for (int i = 0; i < length; i++) {
			result += numbers.get(i);
		}
		
		return result;
	}
}
