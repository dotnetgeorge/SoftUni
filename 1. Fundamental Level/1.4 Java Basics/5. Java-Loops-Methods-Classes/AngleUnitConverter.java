import java.util.Scanner;

public class AngleUnitConverter {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);

		System.out.print("Length: ");
		int length = scanner.nextInt();

		while (length-- > 0) {
			System.out.print("Enter Number and Type: ");
			int number = scanner.nextInt();
			String type = scanner.next();
			int numberType = type.equals("rad") ? 0 : 1;

			double result = ConvertAngle(number, numberType);

			if (numberType == 0) {
				System.out.printf("%.6f deg\n", result);
			} else {
				System.out.printf("%.6f rad\n", result);
			}
		}
		scanner.close();
	}

	public static Double ConvertAngle(int number, int typeNumber) {
		double convertAngle = 0;

		if (typeNumber == 0) {
			convertAngle = (number * (180 / Math.PI));
		} else {
			convertAngle = ((180 * Math.PI) / number);
		}

		return convertAngle;
	}
}
