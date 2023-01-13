//Домашнее задание

//Задача 1: написать цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень B.

// Console.WriteLine("Введите число для возведения в степень ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите степень числа ");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число {A} в степени {B} равно {RaiseToPower(A, B)}");


// int RaiseToPower(int A, int B)
// {
//     int pow = 1;

//     for(int i = 1; i <= B; i++)
//     {
//         pow = pow * A;
//     }
//     return pow;
// }

//Задача 2: написать программу, которая принимает на вход число и выдает сумму цифр в числе. 
// Console.WriteLine("Введите число ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр в числе {n} равна {SumDigits(n)}");


// int SumDigits(int num)
// {
//     int sum = 0;
//     int digit = 0; //локальная переменная
//     if (num == 0) return 0;
//     while(num > 0)
//     {
//         digit = num % 10;
//         num = num / 10; 
//         sum += digit; 
//     }
//     return sum;
// }


//Задача 3. Программа, которая задаёт массив из 8 элементов и выводит их на экран. (любые числа)
// int[] Array = GetArray(8);
// Console.WriteLine($"[{String.Join(',', Array)}]"); 


// int[] GetArray(int size)
// {
//     int[] Array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         Array[i] = new Random().Next(0, 100);
//     }
//     return Array;
// }

