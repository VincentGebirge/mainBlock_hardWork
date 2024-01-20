// // Написать программу, которая из имеющегося массива строк формирует новый 
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

//Метод перебирает элементы массива и сравнивает их длину с заданным 
// параметром <=3. Далее, отсортированные элементы, удовлетворяющие условию
// записывает в новый массив 
string[] symbol(string[] stringArray)
{
  int n = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
      n++;
  }
  string[] newArray = new string[n];
  int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
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