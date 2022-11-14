//  заполнить массив рандомно целыми числами, вывести на экран
// номер индекса и значение каждого элемента

int[] array = new int[9]; //создаём новый целочисленный массив из 9 элементов
Random num = new Random();

for (int index = 0; index < array.Length; index++)
{
    array[index] = num.Next(99); // массив заполняется псевдослучайными числами от 0 до 99
    Console.WriteLine($"Индекс элемента {index}; Число в массиве = {array[index]}");
}