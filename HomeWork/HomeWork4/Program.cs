// Задача 25
/*
Console.WriteLine("Введите 1-е число ");
 double numberOne = double.Parse(Console.ReadLine());
 Console.WriteLine("Введите 2-е число");
 double numberTwo = double.Parse(Console.ReadLine());

 double result = GetExponentiationTwo(numberOne, numberTwo);
 System.Console.WriteLine($"{numberOne} в степени {numberTwo} равняется {result}");

double GetExponentiationTwo(double arg1 , double arg2)
{
double exp = 1;
for(double i = 0; i < arg2; i++)
{
    exp = exp * arg1;
}
return exp;
}
*/
// Задача 27
/*
 Console.WriteLine("Введите число ");
 int number = int.Parse(Console.ReadLine());
 int result = GetSumOfFigures(number);
 System.Console.WriteLine($" Сумма всех чисел {number} равняется {result}");

int GetSumOfFigures(int num)
{
    int summ = 0;
    while(num > 0)
    {
        summ = summ + num % 10;
        num /= 10;
    }
    return summ;
}
*/
// Задача 29

 Console.WriteLine("Введите 1-е число");
 int n1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите 2-е число");
 int n2 = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите 3-е число");
 int n3 = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите 4-е число");
 int n4 = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите 5-е число");
 int n5 = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите 6-е число");
 int n6 = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите 7-е число");
 int n7 = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите 8-е число");
 int n8 = int.Parse(Console.ReadLine());


 int[] array = { n1, n2, n3, n4, n5, n6, n7, n8 };


 void PrintArray(int[] arr)
 {
    
     for (int i = 0; i < arr.Length; i++)
     {
         System.Console.Write($"{arr[i]} ");
     }
    
 }

 PrintArray(array);
