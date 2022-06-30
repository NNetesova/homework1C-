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

//Console.Write("Введите число A: ");
//int A = int.Parse(Console.ReadLine());

//if (A%2==0)
//{
//    Console.Write("Число является четным");
//}
//else
//{
//    Console.Write("Число является нечетным");
//}



//Задача №1 (HomeWork) "По заданному номеру дня недели вывести его название"

//Console.WriteLine("Введите номер дня недели от 1 до 7: ");
//int A = int.Parse(Console.ReadLine());
//
//if (A==1)
//{
//   Console.Write("Понедельник");
//}
//else if (A==2)
//{
//   Console.Write("Вторник");
//}
//else if (A==3)
//{
//   Console.Write("Среда");
//}
//else if (A==4)
//{
//   Console.Write("Четверг");
//}
//else if (A==5)
//{
//   Console.Write("Пятница");
//}
//else if (A==6)
//{
//   Console.Write("Суббота");
//}
//else if (A==7)
//{
//   Console.Write("Воскресенье");
//}

// Задача №2 (HomeWork) "Выяснить, кратно ли число заданному, если нет, вывести остаток"

//Console.Write("ВВедите число A: ");
//int numberA = int.Parse(Console.ReadLine());;
//Console.Write("ВВедите число B: ");
//int numberB = int.Parse(Console.ReadLine());

//int result = numberA%numberB;

//if (numberA%numberB==0)
//{
//    Console.Write("Число В является кратным числу А");
//}
//else if (numberA%numberB!=0)
//{
//    Console.Write($"Число B не является кратным данному числу A, остаток равен {result}");
//}

//Задача №3 (HomeWork) "Найти максимальное из трех чисел"

//Console.Write("ВВедите число A: ");
//int numberA = int.Parse(Console.ReadLine());
//Console.Write("ВВедите число B: ");
//int numberB = int.Parse(Console.ReadLine());
//Console.Write("ВВедите число C: ");
//int numberC = int.Parse(Console.ReadLine());

//max = numberA;

//if (numberB>A)
//{
//    Console.Write("B = max");
//}
//
//if (numberC>max)
//{
//    Console.Write("C = max");
//}
//max = Math.Max(numberA, Math.Max(numberB, numberC));