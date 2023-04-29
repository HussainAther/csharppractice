using System;

/*
Data structure for matrix-filling algorithm.
/*


public class MatrixSpiral
{ 
    static void MAin()
    { 
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        
        FillMatrix(matrix, n);
        PrintMatrix(matrix, n);
    }

    private static void FillMatrix(int[,] matrix, int n) 
    {
        int positionX = n / 2;
        int positionY = n % 2 == 0 ? (n / 2) -1 : (n / 2);
        int direction = 0 ;
        int stepsCount = 1;
        int stepPosition = 0;
        int stepChange = 0; 
        
        for (int i = 0; i < n * n; i++)
        {
            matrix[positionY, positionX] = i;
            if (stepPosition < stepsCount)
            {
                stepPosition++;
            }
            else
            {
                stepPosition =1;
                if (stepChange == 1)
                {
                    stepsCount++;
                }
