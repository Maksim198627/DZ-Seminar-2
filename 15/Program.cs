string str = ""; 
int n; 
Console.WriteLine("");
Console.WriteLine("Понедельник: 1");
Console.WriteLine("Вторник: 2");
Console.WriteLine("Среда: 3");
Console.WriteLine("Четверг: 4");
Console.WriteLine("Пятница: 5");
Console.WriteLine("Суббота: 6");
Console.WriteLine("Воскресенье: 7");

Console.WriteLine("");
do
{
    Console.Write("Введите число дня недели: ");
    while (int.TryParse(str = Console.ReadLine()!, out n) == false) 
    {
               Console.WriteLine("Неверный ввод!");
                Console.Write("Введите число дня недели: ");
    }

    n = int.Parse(str); 

    if (n < 1 || n > 7) 
    {
                Console.WriteLine("Неверный ввод!");
       
    }
} 
while (n < 1 || n > 7);

Console.Write("Результат: ");
if (n >= 1 & n <= 5) Console.Write("Рабочий день :( ");
else Console.Write("Ура!Выходной!");