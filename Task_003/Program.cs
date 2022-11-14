// найти наибольшее число в массиве используя заранее заданный
// массив и цикл for

int[] array = new int [] {75, 7798, 2573, 76, 685, -570, 122};
int max = array[0]; // присваиваем максимальное значение 0-му элементу

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
         max = array[i];
    }
}
Console.WriteLine(max);