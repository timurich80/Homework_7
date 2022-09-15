﻿/* 
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
 */
void printArr(int[,] arr) 
{
    for (int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j< arr.GetLength(1); j++)
        {
            Console.Write($"-{arr[i,j]}-");
        }
        Console.WriteLine();
    }
}



void fillArr(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = i+j;
        }
    }
}


int[,] array2D = new int[3, 4];
fillArr(array2D); 
System.Console.WriteLine();
printArr(array2D);