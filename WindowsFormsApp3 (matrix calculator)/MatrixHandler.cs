using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3__matrix_calculator_
{
    public class MatrixHandler
    {
        public static int[,] addMatrixes (int[,] matrixA ,int[,] matrixB)
        {
            int[,] resultMatrix = new int[matrixA.GetLength(0), matrixA.GetLength(1)];

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            return resultMatrix;
        }

        public static int[,] subMatrixes(int[,] matrixA, int[,] matrixB)
        {
            int[,] resultMatrix = new int[matrixA.GetLength(0), matrixA.GetLength(1)];

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = matrixA[i, j] - matrixB[i, j];
                }
            }
            return resultMatrix;
        }

        public static int[,] multiMatrixes(int[,] matrixA, int[,] matrixB)
        {
            int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixA.GetLength(1); k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return resultMatrix;
        }

    }
}
