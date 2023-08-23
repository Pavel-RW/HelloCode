// Рекурсия - Recursion
// Вычисление Факториала - ! с помощью Рекурсии

// // // int Factorial(int n)
// // // {
// // //  // 1! = 1
// // //  // 0! = 1
// // //  if(n == 1) return 1;
// // //  else return n * Factorial(n-1);
// // // }
// // // Console.WriteLine(Factorial(3)); 
// // // // 1 * 2 * 3 = 6

// // int Factorial(int n)
// // {
// //  // 1! = 1
// //  // 0! = 1
// //  if(n == 1) return 1;
// //  else return n * Factorial(n-1);
// // }
// // for (int i = 1; i < 40; i++)
// // {
// //  Console.WriteLine(Factorial(i));
// // }
// // // Проблема - в какойто момент получаем отрицательные числа
// // // Связано с переполнением типа.

// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }
// //  Проверим, до какого значения можем посчитать факториал.
// // До 17!

double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
// Double - тип данных который способен переваривать большие числа.
// Видим нормальные значения. E + 46 означает что число нужно умножить на 10 в степени 46.

