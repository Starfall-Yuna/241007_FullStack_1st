import java.util.Scanner;

public class double_loop {
	public static void main(String args[]) {
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		
		for(int i=1; i<=n; i++) {		// i :: 1부터 n까지
			for(int k=1; k<=i; k++) {	// k :: 1부터 n까지
				System.out.print("*");
				System.out.print("("+i+","+k+")" );
			}
			System.out.println();
		}
	}
}
