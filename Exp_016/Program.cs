// Двумерный массив
string[,] table = new string[2, 5]; // table - название двумернго массива. 2 - строки, 5 - столбцов

// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]


// По умолчанию инициализация строк идёт через константу String.Empty.
// Для обращения  к нужному элементу
table[1, 2] = "слово"; // "слово" - присвоили 1 строке и 2 столбцу

// Для печати массива нужен цикл в цикле
for (int rows = 0; rows < 2; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}


int[,] matrix = new int[2, 5];
// for (int i = 0; i < 2; i++) // вместо 2 -> matrix.GetLength(0)
// {
//     for (int j = 0; j < 5; j++) // вместо 5 -> matrix.GetLength(1)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();
// }

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
