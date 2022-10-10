/* 
ТИП ДАННЫХ[] ИМЯ = {Значение1,Значение2, ...}
int[] array = { 9, 28, 1, 32, 1990 }
int[] array = { 0, 0, 0, 0, 0 }
int[] array = new int[5];
int[] array = new int[]{ 0, 0, 0, 0, 0 }
int[] array = new int[5]{ 1, 0, 2, 0, 3 } 
*/

// Вспомогательный механизм, который ищет максимальное из трёх чисел
int FunctionFindMax(int arg1, int arg2, int arg3) 
// FunctionFindMax - имя новой функции (метода)
// В неё входят три аргумента arg1, arg2 и arg3
{  // Описание тела метода
    int result = arg1;                      
    if (arg2 > result) result = arg2;          
    if (arg3 > result) result = arg3;          
    return result;         // Метод возвращает результат (result)
}
/*
int a1 = 3;
int a2 = 5;
int a3 = 5;
int b1 = 4;
int b2 = 93333;
int b3 = 11;
int c1 = 1;
int c2 = 11;
int c3 = 322;
*/
//              0   1  2   3     4   5   6   7  8 -> нумерация элементов в массиве
int[] array = { 9, 28, 1, 32, 1990, 34, 23, 33, 9999 }; // определяем массив
//Т.е. одной строкой (32-ой) записали с 18 по 26 строки
array[0] = 333; // присвоил первому элементу массива значение 333
//Console.WriteLine(array[0]);
/*
int max1 = FunctionFindMax(a1, a2, a3);  // Поиск max1 из первых трех чисел
int max2 = FunctionFindMax(b1, b2, b3);  // Поиск max2 
int max3 = FunctionFindMax(c1, c2, c3);  // Поиск max3
// int max = FunctionFindMax(max1,max2,max3); 
int max = FunctionFindMax(FunctionFindMax(a1, a2, a3), FunctionFindMax(b1, b2, b3), FunctionFindMax(c1, c2, c3));
Console.WriteLine(max);
*/
int max = FunctionFindMax(FunctionFindMax(array[0], array[1], array[2]),
         FunctionFindMax(array[3], array[4], array[5]),
         FunctionFindMax(array[6], array[7], array[8]));

Console.WriteLine(max);

