// Вспомогательный механизм, который ищет максимальное из трёх чисел
int FunctionFindMax(int arg1, int arg2, int arg3) // FunctionFindMax - имя новой функции (метода)
// В неё входят три аргумента arg1, arg2 и arg3
{
    int result = arg1;                      // Описание тела метода
    if (arg2 > result) result = arg2;          // Описание тела метода
    if (arg3 > result) result = arg3;          // Описание тела метода
    return result;         // Метод возвращает результат (result)
}

int a1 = 3;
int a2 = 5;
int a3 = 5;
int b1 = 4;
int b2 = 93333;
int b3 = 11;
int c1 = 1;
int c2 = 11;
int c3 = 322;

int max1 = FunctionFindMax(a1, a2, a3);  // Поиск max1 из первых трех чисел
int max2 = FunctionFindMax(b1, b2, b3);  // Поиск max2 
int max3 = FunctionFindMax(c1, c2, c3);  // Поиск max3

// int max = FunctionFindMax(max1,max2,max3); 

int max = FunctionFindMax(FunctionFindMax(a1, a2, a3),FunctionFindMax(b1, b2, b3),FunctionFindMax(c1, c2, c3));

Console.WriteLine(max);
