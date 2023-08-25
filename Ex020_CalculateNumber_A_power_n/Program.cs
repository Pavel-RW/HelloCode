// // Вычислить число А в степени n - CalculateNumber_A_power_n

// // int PowerFor(int a, int n)
// // {
// //     int result = 1;
// //     for (int i = 1; i <= n; i++) result *= a;
// //     return result;
// // }

// // int PowerRec(int a, int n)
// // {
// //     return n == 0 ? 1 : PowerRec(a, n - 1) * a; if (n == 0) return 1;
// //     else return PowerRec(a, n - 1) * a;
// // }

// // Console.WriteLine(PowerFor(2, 10)); // 1024
// // Console.WriteLine(PowerRec(2, 10)); // 1024


// Флешбеки
// Базовая математика, которая пригодится всем
// Степени	

// 2^3 * 2^5= 2^8	am * an = a(m+n)  {1}	
// 2^12 = (2^2)^6	(am)n = a(m*n)	{2}

// 228 = 2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2×2
// 27 операций умножения

// 228={2}=(2^14)^2={2}=([2^7]^2)^2={1}=([2^6×2^1]^2)^2={2}=([(2^3)^2×2^1]^2)^2={1}=268 435 456
// 6 операций

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024

