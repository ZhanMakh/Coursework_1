// Курсовая работа. Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

// Объявляем массив
string [ ] names = new string [5];
int size = 5;
string [ ] massiv = new string [size];

// Вводим данные массива с клавиатуры
Console.WriteLine("Введите данные массива: ");
for (int i = 0; i < names.Length; i++)
{
    Console.Write("names[{0}] = ", i);
    names[i]=Console.ReadLine();
}
for (int i = 0; i < names.Length; i++)
{
    if(names[i].Length <=3)
        {
            massiv[i] = names[i];
            Console.Write(massiv[i] + ",");
        }   
        else continue;
}   
