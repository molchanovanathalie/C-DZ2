﻿Console.WriteLine("Введите номер дня недели");
int a = int.Parse(Console.ReadLine());
if (a > 5 && a < 8)
{
    Console.WriteLine("Выходной день");
}
else if (a < 6)
{
    Console.WriteLine("Будний день");
}
if (a > 7) 
{
    Console.WriteLine("Ошибка");
}
