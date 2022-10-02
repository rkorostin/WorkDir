﻿// Запись методов, которые будут заполнять массив случайными числами
// и выводить в консоль элементы массива

void FillArray(int[] nabor)  // Создаем метод, который будет заполнять массив. 
// void - без вывода результатов
// в качестве агрументов метода будет выступать массив int[] и его элементы nabor
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
// Аргументы будут те же, только именоваться элементы массива будут через nabor2
{
    int n1 = nabor2.Length; // Длина массива
    int position = 0; // Задаем позицию первого элемента 0
    while(position<n1)
    {
        Console.WriteLine(nabor2[position]);
        position++;
    }
}


int[] array = new int[5]; // Задается новый массив из 10 элементов
// По умолчанию такой массив будет наполнен нулями

FillArray(array);
PrintArray(array);

