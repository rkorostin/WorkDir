Console.Clear(); // Очистка консоли
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 8, ya = 1,
    xb = 1, yb = 10,
    xc = 16, yc = 10;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("x");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("x");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("x");

int x = xa, y = xb; // Задаём какую то случаюную точку "х"

int count = 0; // Задаём счетчик, по которому будет жить цикл

while(count < 100) // Пока счетчик менеше count - работает цикл
{
    int what = new Random().Next(0,3); // Случайное число what через генератор 
    // случайных чисел. Будем брать одну из трех точек (0 1 2)
    if(what == 0) // Если выпала первая точка, то 
    {
        x = (x+xa)/2;
        y = (y+ya)/2;  
    }
      if(what == 1) // Если выпала вторая точка, то 
    {
        x = (x+xb)/2;
        y = (y+yb)/2;  
    }
          if(what == 2) // Если выпала третья точка, то 
    {
        x = (x+xc)/2;
        y = (y+yc)/2;  
    }
    Console.SetCursorPosition(x, y); // Вычислили точку и выставляем её на позиции
    Console.WriteLine("x");
    count++;
}
