using System;

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
