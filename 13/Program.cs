string str = "";
int a;
List<int> all = new List<int>();

Console.WriteLine("");
Console.Write("Введите 3-х значное  число: ");
while (int.TryParse(str = Console.ReadLine()!, out a) == false)
{

    Console.WriteLine("Ошибка: несоответствие типу!");
    Console.Write("Введите число: ");
}

a = int.Parse(str);
all = IntToList(a);

Console.WriteLine("");
if (all.Count > 2) Console.WriteLine("Цифра 3-го разряда: [" + all[2] + "]");
else Console.WriteLine("Цифра 3-го разряда не найдена.");

// Функция записи int в List по разрядам
List<int> IntToList(int number)
{
    number = (int)Math.Abs(number);
    List<int> temp = new List<int>();
    List<int> result = new List<int>();
    while (number > 9)
    {
        temp.Add(number % 10);
        number /= 10;
    }
    result.Add(number);
    for (int i = temp.Count - 1; i > -1; i--)
    {
        result.Add(temp[i]);
    }
    return result;
}