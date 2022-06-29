// Задача №1 (Семинар) найдите квадрат числа

//Console.Write("Enter your number:");
//int number = int.Parse(Console.ReadLine()); //перевод значения в число
//int result = number*number;
//Console.Write("Square of your number: ");
//Console.WriteLine(result);

// Задача №2 (Семинар) По двум заданным числам проверить является ли первое квадратом второго 

Console.Write("ВВедите число numberA: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("ВВедите число numberB: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB*numberB)
{
    Console.Write("Да, первое число является квадратом второго");
}
else
{
    Console.Write("Нет, первое число не является квадратом второго");
}