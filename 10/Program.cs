string str = "";
int n;

Console.WriteLine("");
do
{
    Console.Write("Введите число: ");
    while (int.TryParse(str = Console.ReadLine()!, out n) == false) 
    {

        Console.WriteLine("err: несоответствие типу integer!");
        Console.Write("Введите число: ");
    }

    n = (int)Math.Abs(int.Parse(str));
    if (n < 100 || n > 999)
    {

        Console.WriteLine("err: не трехзначное число!");

    }
} while (n < 100 || n > 999);

n /= 10;
n %= 10;

Console.WriteLine("");
Console.WriteLine("Цифра 2-го разряда: [" + n + "]");