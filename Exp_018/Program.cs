// Факториал при помощи рекурсии
// 5!=5*4*3*2*1
//    5*4!
//      4*3!
//        3*2!
//          2*1!

int Factorial(int n)
{   //1! = 1, 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(5));


