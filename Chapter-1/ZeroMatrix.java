/**
 * 1.8: Zero Matrix
 * Write an algorithm such that if an element in an MxN matrix is 0, its entire
 * row and column are set to 0.
 */

public class ZeroMatrix {
    public static void main(String[] args) {
        int[][] matrix = {{ 0,  2,  3,  4},
                          { 5,  6,  7,  8},
                          { 9, 10,  0, 12},
                          {13, 14, 15, 16}};
        addZeros(matrix);
        for (int i = 0; i < matrix.length; i++)
            System.out.println(java.util.Arrays.toString(matrix[i]));

    }

    private static void addZeros(int[][] matrix) {
        int rows = matrix.length;
        int cols = matrix[0].length;
        boolean[][] visited = new boolean[rows][cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                if (!visited[i][j]) {
                    if (matrix[i][j] == 0)
                        setRowAndColToZero(i, j, matrix, visited);
                    else
                        visited[i][j] = true;
                }
    }

    private static void setRowAndColToZero(int i, int j, int[][] matrix, boolean[][] visited) {
        // Set column to 0
        for (int k = 0; k < matrix[0].length; k++) {
            matrix[i][k] = 0;
            visited[i][k] = true;
        }
        // Set row to 0
        for (int m = 0; m < matrix.length; m++) {
            matrix[m][j] = 0;
            visited[m][j] = true;
        }
    }
}
