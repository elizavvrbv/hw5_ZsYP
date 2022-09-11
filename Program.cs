// Задача 34
System.Console.WriteLine("Задача 34");
string GetArray(){
    int [] arr = new int[new Random().Next(4, 13)];  // создаем массив размера от 4 до 12 
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)    // заполняем массив
    {
        arr[i] = new Random().Next(100, 1000);
    }
    for (int i = 0; i < arr.Length; i++)  // перебираем массив
    {
        if (arr[i] % 2 == 0)  // если число четное, то счетчик + 1
        { 
            counter += 1;
            continue;
        }
        else     // если число нечетное, то продолжаем перебирать массив
        {
            continue;
        }
    }

    return ($"Исходный массив --> {string.Join(' ', arr)} \n Количетво четных элементов --> {counter}");

}
System.Console.WriteLine(GetArray());

// Задача 36.
System.Console.WriteLine("Задача 36");
string GetArray1(){
    int [] arr1 = new int[new Random().Next(4, 13)];  // создаем массив размера от 4 до 12 
    int counter = 0;
    for (int i = 0; i < arr1.Length; i++)    // заполняем массив
    {
        arr1[i] = new Random().Next(-99, 100);
    }
    for (int i = 0; i < arr1.Length; i++)  // перебираем массив
    {
        if (i % 2 != 0)            // позиция должна быть нечетное 
        { 
            counter = counter + arr1[i];
            continue;
        }
        else     // если число четное, то продолжаем перебирать массив
        {
            continue;
        }
    }

    return ($"Исходный массив --> {string.Join(' ', arr1)} \n Сумма нечетных --> {counter}");
}
System.Console.WriteLine(GetArray1());

//  Задача 38.
System.Console.WriteLine("Задача 38");
string GetArray2(){
    int [] arr2 = new int[new Random().Next(4, 13)];  // создаем массив размера от 4 до 12 
    int numMax = 1;
    int numMin = 99;
    for (int i = 0; i < arr2.Length; i++)   
    {
        arr2[i] = new Random().Next(1, 100);
    }
    for (int i = 0; i < arr2.Length; i++)  
    {
        if (arr2[i] > numMax)         
        { 
            numMax = arr2[i];
            continue;
        }
        if ( arr2[i] < numMin) 
        {
            numMin = arr2[i];
            continue;
        }
        else 
        {
            continue;
        }
    }
    return ($"Исходный массив --> {string.Join(' ', arr2)} \n Сумма max и min --> {numMax - numMin}");
}
System.Console.WriteLine(GetArray2());