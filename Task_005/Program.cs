// задайте массив и отсортируйте его от меньшего к большему

int[] array = new int[] { 23, 80, -1, 11, -66, 17, 3 };
        Array.Sort(array);
        Console.WriteLine("Вывод значений элементов: ");
        Array.ForEach(array, Console.WriteLine);