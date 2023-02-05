// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

Console.WriteLine("Введите количество элементов в массиве");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[sizeArray];

for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"Введите элемент массива {i}");
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Вывод массива -> ");
for(int i = 0; i < myArray.Length; i++)

{
Console.WriteLine("[{0}]", string.Join(", ", myArray));
break;
}
