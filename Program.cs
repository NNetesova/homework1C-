// Задача №1 (Семинар) найдите квадрат числа

//Console.Write("Enter your number:");
//int number = int.Parse(Console.ReadLine()); //перевод значения в число
//int result = number*number;
//Console.Write("Square of your number: ");
//Console.WriteLine(result);

// Задача №2 (Семинар) По двум заданным числам проверить является ли первое квадратом второго 

//Console.Write("ВВедите число numberA: ");
//int numberA = int.Parse(Console.ReadLine());
//Console.Write("ВВедите число numberB: ");
//int numberB = int.Parse(Console.ReadLine());
//
//if (numberA == numberB*numberB)
//{
//    Console.Write("Да, первое число является квадратом второго");
//}
//else
//{
//    Console.Write("Нет, первое число не является квадратом второго");
//}

// Задача №3 (Семинар) Найдите наибольшее и наименьшее число из двух

//Console.Write("ВВедите число A: ");
//int numberA = int.Parse(Console.ReadLine());
//Console.Write("ВВедите число B: ");
//int numberB = int.Parse(Console.ReadLine());
//
//if (numberA>numberB)
//{
//  Console.Write("Число А наибольшее, число В наименьшее");  
//}
//else if (numberA<numberB)
//{
//    Console.Write("Число А наименьшее, число В наибольшее");
//}
//else
//{
//    Console.Write("Число А равно числу В");
//}

// Задача №4 (Семинар) Проверить является ли число четным или нечетным

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());

if (A%2==0)
{
    Console.Write("Число является четным");
}
else
{
    Console.Write("Число является нечетным");
}