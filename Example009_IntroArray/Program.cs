﻿// Найти максимум из 9 чисел.

// int a1 = 19825;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 2311;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 3193;

//Замена 2 на =>

int [] array = {11,211,31,41,15,61,17,18,19};

// array[0] = 605;
// Console.WriteLine(array[0]);
// Задаем значение итого эл.массива и его Вывод(для наглядного примера)

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;
// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;
// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// Замена 1 на =>

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

// Замена 1 на =>

// int max = Max(
// Max(a1, b1, c1),
// Max(a2, b2, c2),
// Max(a3, b3, c3));

//Замена 2 на =>

int result = Max(
 Max(array[0], array[1], array[2]),
Max(array[3], array[4], array[5]),
Max(array[6], array[7], array[8])
);

Console.Write($"max = {result}");