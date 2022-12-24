// Программа, построчно выводящая элементы трёхмерного массива 
//из неповторяющихся двузначных чисел, добавляя индексы каждого элемента

//  программа
Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = ReadData("Введите X: ");
int y = ReadData("Введите Y: ");
int z = ReadData("Введите Z: ");
Console.WriteLine($"");
int[,,] arr = new int[x, y, z];
Create3DArray(arr);
Write3DArray(arr);

//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод вывода 3D массива с индексами каждого элемента
void Write3DArray (int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write("{0}({1},{2},{3}); ", arr[i,j,k], i, j, k);
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

//метод формирования 3D массива
void Create3DArray(int[,,] arr)
{
  int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arr.GetLength(0); x++)
  {
    for (int y = 0; y < arr.GetLength(1); y++)
    {
      for (int z = 0; z < arr.GetLength(2); z++)
      {
        arr[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

