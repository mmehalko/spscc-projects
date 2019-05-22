import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.io.UnsupportedEncodingException;
import java.util.Collections;
import java.util.LinkedList;
import java.util.Scanner;

/* The purpose of this program is to pull three random names from a list of 
 * names inputed by the user. */

public class MainProject {
	public static void main(String[] args) throws FileNotFoundException, UnsupportedEncodingException {
		// Create and initialize the list and scanner object.
		LinkedList<String> userList = new LinkedList<>();
		// Printer for file input.
		PrintWriter writer = new PrintWriter("RandomHatEntry.txt", "UTF-8");
		
		int nameCount = 0;
		String nameEntry;
		
		// Ask user how many names they want to put into the hat.
		do {
			System.out.println("How many names would you like to enter into the hat?");
			Scanner numberScanner = new Scanner(System.in);
		
			// while the numberScanner does not return an int
			while (!numberScanner.hasNextInt()) {
				// Request user for proper input.
				System.out.println("That is an invalid integer, please enter a valid integer:");
				numberScanner.next();
			}
				// Set nameCount equivalent to user input.
			nameCount = numberScanner.nextInt();
			
			// If nameCount is zero, request user to put in valid entry.
			if (nameCount == 0) {
				System.out.println("Your entry must be greater than zero. Please try again!");
			}
		}
		while (nameCount == 0);
		
		for (int i = 1; i < nameCount + 1; i++) {
			System.out.println("Enter name " + i + ".");
			Scanner nameScanner = new Scanner(System.in);
			nameEntry = nameScanner.nextLine();
			userList.add(nameEntry);
		}
				
		Collections.shuffle(userList);
		
		System.out.println("Randomly selected three names: ");
		 for(int i = 1; i < 4; i++) {
			 	// Adds random selection to text file.
			 	writer.println(i + ": " + userList.get(i)); 
	            System.out.println(i + ": " + userList.get(i));
	        }
		// Saves file
		 writer.close(); 
	}
}
