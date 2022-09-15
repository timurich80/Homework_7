/* Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты. */


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
            arr[i,j] = new Random().Next(1,10);
        }
    }
}
void result(int[,] arr)
{
   for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i % 2 != 0 && j % 2 != 0)
            arr[i,j] = arr[i,j]*arr[i,j];
        }
    } 
}


int[,] array2D = new int[5, 5];
fillArr(array2D); 
printArr(array2D);
System.Console.WriteLine();
result(array2D);
printArr(array2D);