//Задача 19

Console.WriteLine("Введите пятизначное число: ");
string numbers = Console.ReadLine();

string Shifter(string number)
{
    char[] numberArray = number.ToCharArray();
    Array.Reverse(numberArray);
    return new string(numberArray);
}

bool LetterInNumbers(string let)
{
    int n = let.Length;
    bool yes = true;
    if (n == 5)
    {
        for (int i = 0; i < n; i++)
        {
            if (Char.IsDigit(let[i]) == false)
            {
                yes = false;
                return yes;
            }
        }
        return yes;
    }
    else
    {
        yes = false;
        return yes;
    }
}

bool letter = LetterInNumbers(numbers);
string shifter = Shifter(numbers);

if (letter == true)
{
    if (shifter == numbers) 
        Console.WriteLine($"{numbers} является палиндромом? Да");
    else Console.WriteLine($"{numbers} является палиндромом? Нет");
}
 
 //Задача 21



int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");



//Задача 23



Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Таблица кубов чисел от 1 до {number}.");
Console.WriteLine();

Console.WriteLine("Число\tКуб числа");
    
for (int i = 1; i <= number; i++)
{
    Console.WriteLine("{0}\t{1}", i, Math.Pow(i, 3));
}

