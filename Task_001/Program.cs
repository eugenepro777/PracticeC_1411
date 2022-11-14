// Создайте функцию и выведите на экран консоли
// сегодняшнюю дату

//class Program  // если мы будем обращаться из другого файла к нашей функции
//{
//    static void Main(string[] args)
//    {
//        Program x = new Program();
//        x.Data();
 //   }
//
void Data() //функция(метод), которая не возвращает никакие данные
{
//    if (x == "Сегодня")
//    {
    DateTime todayDate = DateTime.Now; //отвечает за вывод текущей даты
    Console.WriteLine(todayDate.ToString("dd/MM/yyyy"));
//    Console.WriteLine(y);
//    }
//    else
//    {
//    Console.WriteLine("Завтра еще не наступило");
//    Console.WriteLine(y);
//    }
}
//}
//Console.WriteLine("Введите число");
// int y = Convert.ToInt32(Console.ReadLine());
Data();