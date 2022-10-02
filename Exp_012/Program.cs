﻿// Перезапись кода задачи Exp_10, используя методы заполнения и печати массива

void FillArray(int[] nabor)  // Создаем метод, который будет заполнять массив. 
// void - без вывода результатов
// в качестве агрумента метода будет выступать массив int[] и его элементы nabor
{
    int n = nabor.Length; // Определяем длину массива
    int index = 0;
    while (index < n)
    {
        nabor[index] = new Random().Next(1, 10); // Присваиваем каждому 
        // элементу массива рандомное число от 1 до 10
        index++;
    }
}

void PrintArray(int[] nabor2) // Метод, который будет печатать массив
// Аргумент будет тот же, только именоваться элементы массива будут через nabor2
{
    int n1 = nabor2.Length; // Длина массива
    int position = 0; // Задаем позицию первого элемента 0
    while (position < n1)
    {
        Console.WriteLine(nabor2[position]);
        position++;
    }
}

int IndexOf(int[] nabor, int find)  // Метод, который будет возвращать 
// позицию (индекс). В отличие от void здесь будет return
{
    int count = nabor.Length;
    int index = 0;
    int position = -1; // -1 Если искомого элемента не будет в массиве
    while (index < count)
    {
        if (nabor[index] == find)
        {
            position = index; 
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[5]; // Задается новый массив из 10 элементов
// По умолчанию такой массив будет наполнен нулями

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4); 
Console.WriteLine(pos);

