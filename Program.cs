// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//        result += $"{i} ";
//     }
//     return result;
// }
// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10 
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// ********************************************************************
// int SumFor(int n)
// {    
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }

// Console.WriteLine(SumFor(10)); // 55 
// Console.WriteLine(SumRec(10)); // 55

// ********************************************************************

// int FactorialFor(int n)
// {    
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }

// int FactorialRec(int n)
// {    
//     if (n == 1) return 1;
//     else return n * FactorialRec(n - 1); 
// }

// Console.WriteLine(FactorialFor(10)); // 3628800 
// Console.WriteLine(FactorialRec(10)); // 3628800

// ********************************************************************



// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result; 
// }

// int PowerRec(int a, int n) 
// {   //return n == 0 ? 1 : PowerRec(a, n - 1) * a; // Тернарный оператор
//     if (n == 0) return 1;    
//     else return PowerRec(a, n - 1) * a;
// }
// Console.WriteLine(PowerFor(2, 10)); // 1024 
// Console.WriteLine(PowerRec(2, 10)); // 1024

// ********************************************************************
// int n = 1;

// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//         {
//             Console.WriteLine($"{n++} {new String(word)}");  return;
//         }
//         for (int i = 0; i < alphabet.Length; i++)
//             {
//                 word[length] = alphabet[i];
                
//                 FindWords(alphabet, word, length + 1);
//             }
// }

// FindWords("аисв", new char[3]);

// ********************************************************************

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }

// // string PrintNumbers(int start, int end)
// // {
// // if (start == end) return start.ToString();
// // return (start + " " + PrintNumbers(start + 1, end));
// // }


// void PrintNumbers(int start, int end)
// {
//     if (start > end) return;
//     Console.Write(start + " ");
//     PrintNumbers(++start, end);
// }

// int num = InputNum("Введите целое число: ");
// PrintNumbers(1, num);

// int end = 5;
// int start = 1;
// end = end + start++;
// System.Console.WriteLine(end);
// System.Console.WriteLine(start);

// ********************************************************************
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }

// // string PrintNumbers(int start, int end)
// // {
// // if (start == end) return start.ToString();
// // return (start + " " + PrintNumbers(start + 1, end));
// // }


// void PrintNumbers(int start, int end)
// {
//     if (start > end) return;
//     Console.Write(start + " ");
//     PrintNumbers(++start, end);
// }

// int start = InputNum("Введите M: ");
// int end = InputNum("Введите N: ");

// PrintNumbers(start, end);



// ********************************************************************
// Дмитрий Тихонов: Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int InputNum (string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.ReadLine()!);
// }

// int SumDigits(int num)
// {
// if (num == 0) return 0;
// return num % 10 + SumDigits(num / 10);
// }

// int number = InputNum("Введите целое число: ");
// int sum = SumDigits(number);
// System.Console.WriteLine(sum);

// ********************************************************************
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
// С учётом отрицательных степеней - сложный вариант.

int InputNum(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine()!);
}

double StepenNumber(int a, int b)
{
if (b == 0) return 1;
if (b > 0)
{
return a * StepenNumber(a, b - 1);
}
return Math.Round(1 / (a * StepenNumber(a, -b - 1)), 3);
}
int a = InputNum("Введите целое число A: ");
int b = InputNum("Введите целое число B: ");
Console.WriteLine(StepenNumber(a, b));