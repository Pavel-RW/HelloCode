// Числа Фибоначи - Numbers Fibonacci

// // // f(1) = 1
// // // f(2) = 1
// // // f(n) = f(n-1) + f(n-2)
// // int Fibonacci(int n)
// // {
// //     if (n == 1 || n == 2) return 1;
// //     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// // }
// // for (int i = 1; i < 10; i++)
// // {
// //     Console.WriteLine(Fibonacci(i));
// // }
// // //  Покажем первые 10


// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }
// // По аналогии с факториалом попробуем посчитать первые 50


// Первые числа вылетят в консоль быстро, дальше начнёт работать медленнее.
// Попробуем понять, с какого числа начинается проблема. 
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
// Начиная с 40 значения выводятся очень медленно. Cразу отмечу, что рекурсию можно сделать более шустрой. Можно ли
// заменить рекурсию другими конструкциями (в частности, циклом) — да, можно. Именно этим мы
// займёмся на семинаре. 

