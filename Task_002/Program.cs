﻿// вывести все числа диапазона от 0 до 10 в виде строк используя for
//for ([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])
//{
    // действия
//} 
int x;
string numbers = "";

for (x = 0; x <= 10; x++)
{
    numbers += x.ToString(); // хранит текст с 0 (нулём)
    Console.WriteLine(numbers);
}
