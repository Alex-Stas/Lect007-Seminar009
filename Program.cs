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


