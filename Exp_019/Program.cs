// Фибоначчи через рекурсию
// f(n) = f(n-1) + f(n-2)
// f(1) = 1
// f(2) = 1
// f(3) = 2
// f(4) = 3
// f(5) = 5
// f(6) = 8

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
Console.WriteLine(Fibonacci(8));

for (int i = 1; i < 30; i++)
{
    Console.WriteLine(Fibonacci(i));
}

