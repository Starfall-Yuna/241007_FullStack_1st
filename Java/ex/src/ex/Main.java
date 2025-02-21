package ex;

import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        System.out.print("숫자를 입력하세요 : ");
        int n = scan.nextInt();

        print(n);
    }

    public static boolean selection(int n) {
        if (n <= 1) {//n=1 => 출력 수행X
            return false;
        }
        for (int i = 2; i <= Math.sqrt(n); i++) {//제곱근까지만 검사하면 소수찾기가능함
            if (n % i == 0) {
                return false;
            }
        }
        return true;
    }

    public static void print(int n) {
        for (int i = 2; i <= n; i++) {
            if (selection(i)) {
                System.out.print(i + " ");
            }
        }
    }
}