string str = "";
int a;

Console.WriteLine("");
do
{
    Console.Write("Введите число: ");
    while (int.TryParse(str = Console.ReadLine()!, out a) == false) 
    {

        Console.WriteLine("err: несоответствие типу integer!");
        Console.Write("Введите число: ");
    }

    a = (int)Math.Abs(int.Parse(str));
    if (a < 100 || a > 999)
    {

        Console.WriteLine("err: не трехзначное число!");

    }
} while (a < 100 || a > 999);

a /= 10;
a %= 10;

Console.WriteLine("");
Console.WriteLine("Цифра 2-го разряда: [" + a + "]");