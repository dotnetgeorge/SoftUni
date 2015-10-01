/*
 * Problem 7.	Days between Two Dates
 * Write a program to calculate the difference between two dates in number of days. 
 * The dates are entered at two consecutive lines in format day-month-year. 
 * Days are in range [1…31].
 * Months are in range [1…12]. 
 * Years are in range [1900…2100]. 
 * */
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.Scanner;

public class DaysBetweenTwoDates {

	public static void main(String[] args) throws ParseException {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		String format = "dd-MM-yyyy";
		
		System.out.print("Enter First Date: ");
		Date firstDate = new SimpleDateFormat(format).parse(scanner.nextLine());
		System.out.print("Enter Second Date: ");
		Date secondDate = new SimpleDateFormat(format).parse(scanner.nextLine());
		
		int daysBetween = DaysBetween(firstDate, secondDate);
		
		System.out.println("Days Between: " + daysBetween);
		
		scanner.close();
	}
	
	public static int DaysBetween(Date firstDate, Date secondDate) {
		int days = 0;
		
		Calendar calendar = new GregorianCalendar();
		calendar.setTime(firstDate);
		
		while (calendar.getTime().before(secondDate)) {
			days++;
			calendar.add(Calendar.DATE, 1);
		}
		
		return days;
	}
}
