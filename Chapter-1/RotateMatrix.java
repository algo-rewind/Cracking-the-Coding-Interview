/**
 * 1.7: Rotate Matrix
 * Given an image represented by an NxN matrix, where each pixel in the image
 * is 4 bytes, write a method to rotate the image by 90 degrees. Can you do
 * this in place?
 */

public class RotateMatrix {
    public static void main(String[] args) {
        int[][] matrix = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        reverseRows(matrix);
        transpose(matrix);
        print(matrix);
    }

    private static void reverseRows(int[][] matrix) {
        int N = matrix.length;
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N / 2; j++) {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][N - j - 1];
                matrix[i][N - j - 1] = temp;
            }
    }

    private static void transpose(int[][] matrix) {
        int N = matrix.length;
        for (int i = 0; i < N; i++)
            for (int j = i + 1; j < N; j++) {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
    }

    private static void print(int[][] matrix) {
        for (int i = 0; i < matrix.length; i++)
            System.out.println(java.util.Arrays.toString(matrix[i]));
    }
}
