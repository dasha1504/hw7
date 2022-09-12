/* double[,] GetArray(int m, int n)
{
    double[,] array = new double[n, m];
    for(int i = 0; i<array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble()*10;
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    
}
double[,] array = GetArray(3, 4);
PrintArray(array); */



/* int[,] FillArray(int n, int m)
{
    int[,] array = new int[n, m];
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] arr = FillArray(5, 10);
PrintArray(arr);
Console.WriteLine("Input first position: ");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Input second position: ");
int j = int.Parse(Console.ReadLine());
Console.WriteLine($"Element = {arr[j, i]}"); */



double[,] FillArray(int n, int m)
{
    double[,] array = new double[n, m+1];
    for(int i = 0; i<array.GetLength(0); i++)
    {   double sum = 0;
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(j<array.GetLength(1) - 1)
            {
                array[i, j] = new Random().Next(1, 10);
                sum = sum+array[i, j];
                
            }
            else
            {
                array[i, j] = sum/m;

            }
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
double[,] arr = FillArray(3, 4);
PrintArray(arr);








