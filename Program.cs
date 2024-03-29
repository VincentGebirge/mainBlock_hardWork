﻿// // Написать программу, которая из имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный 
// массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.


Console.Write("Введите количество элементов массива: ");
int elementsQuantity = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[elementsQuantity];

//данный метод заполняет исходный массив элементами, которые вводит пользователь
void array(string[] stringArray)
{
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.WriteLine($"Введите {i + 1} элемент массива");
    stringArray[i] = Console.ReadLine();
  }
}

//Функция перебирает элементы массива и сравнивает их длину с заданным 
// параметром <=3. Далее, отсортированные элементы, удовлетворяющие условию
// записывает в новый массив 
string[] symbol(string[] stringArray)
{
  int n = 0;
  for (int i = 0; i < stringArray.Length; i++) //здемь проверяем, сколько 
  {                                             //элементов в массиве 
    if (stringArray[i].Length <= 3)             //соответствуют условию
      n++;
  }
  string[] newArray = new string[n];            //заполняем новый массив
  int j = 0;                                 //отсортированными элементами
  for (int i = 0; i < stringArray.Length; i++)  //и возвращаем новый массив из
  {                                             //функции
    if (stringArray[i].Length <= 3)
    {
      newArray[j] = stringArray[i];
      j++;
    }
  }
  return newArray;
}

// метод выводит получившейся массив в формате ['element1' 'element2 ...]
void printArray(string[] stringArray)
{
  Console.Write("[");
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.Write($"‘{stringArray[i]}’ ");
  }
  Console.Write("]");
}
array(stringArray);
printArray(symbol(stringArray));