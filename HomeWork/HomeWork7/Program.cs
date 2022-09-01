//Задача 47
/*
Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
*/
//Задача 50
/*
int[,] FillArray2D(int m, int n, int minValue, int maxValue)
 {
     int[,] array = new int[m, n];

     Random random = new Random();

    for (int i = 0; i < m; i++)
    {
         for (int j = 0; j < n; j++)
         {
             array[i, j] = random.Next(minValue, maxValue);
         }
     }
     return array;
 }

 void PrintArray(int[] arr)
 {
    
     for (int i = 0; i < arr.Length; i++)
     {
         System.Console.Write($"{arr[i]} ");
     }
    
 }

 void Print2dArray(int[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             System.Console.Write($"{array[i, j]} ");
         }
         System.Console.WriteLine();
     }
 }

 int[] CheckTheNumberInArray(int[,] arr, int number)
 {

    
     for (int i = 0; i < arr.GetLength(0); i++)
     {
         for (int j = 0; j < arr.GetLength(1); j++)
         {
             if (number == arr[i, j])
             {
                int[] array = {i , j};
                return array;
             }
            
         }
     }
     return null;
 }

 System.Console.WriteLine("Введите номер длины");
 int lengthMassive = int.Parse(Console.ReadLine());
 System.Console.WriteLine("Введите большее число");
 int higherMassive = int.Parse(Console.ReadLine());
 System.Console.WriteLine("Введите минимальное число");
 int minValue = int.Parse(Console.ReadLine());
 System.Console.WriteLine("Введите максимальное количество");
 int maxValue = int.Parse(Console.ReadLine());

 System.Console.WriteLine("Введите число, которое вы хотите найти в массиве");
 int number = int.Parse(Console.ReadLine());

 int[,] array = FillArray2D(lengthMassive, higherMassive, minValue, maxValue);
 Print2dArray(array);
 System.Console.WriteLine();
 int[] index = CheckTheNumberInArray(array , number);

 if (index == null)
 {
     System.Console.WriteLine($"Этого числа {number} не существует в этом массиве");
 }
 else
 {
     System.Console.Write($"Это число {number} находится в массиве под индексами" );
     PrintArray(index);
 }
*/
 //Задача 52

 Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

