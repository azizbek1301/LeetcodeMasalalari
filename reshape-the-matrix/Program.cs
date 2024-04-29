
public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {

        int m = mat.Length;
        int n = mat[0].Length;


        if (m * n != r * c)
        {
            return mat;
        }


        int[][] reshapedMat = new int[r][];


        int rowIndex = 0, colIndex = 0;


        for (int i = 0; i < r; i++)
        {
            reshapedMat[i] = new int[c];
            for (int j = 0; j < c; j++)
            {

                reshapedMat[i][j] = mat[rowIndex][colIndex];

                colIndex++;
                if (colIndex == n)
                {
                    colIndex = 0;
                    rowIndex++;
                }
            }
        }


        return reshapedMat;
    }
}