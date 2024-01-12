﻿// Открывается файл "input.txt" для чтения
StreamReader input = new StreamReader("input.txt");

// Читаем  размерность массива из первой строки файла
int n = Convert.ToInt32(input.ReadLine());

// Создается двумерный массив размером n на n
int[,] a = new int[n, n];

// Заполняется массив данными из файла
for (int i = 0; i < n; i++)
{
    // Читаем строку из файла, разделяем на числа и преобразуем в целые числа
    string[] arg = input.ReadLine().Split(' ');

    // Элементы строки записываются в соответствующие ячейки массива a, для этого цикл фор
    for (int j = 0; j < n; j++)
        a[i, j] = Convert.ToInt32(arg[j]);
}

// Закрываем поток чтения из файла
input.Close();

// Проверяем симметричность массива относительно главной диагонали(b для проверки)
bool b = true;
//используем цикл фор в форе
for (int i = 0; i < a.GetLength(0); i++)
    for (int j = 0; j < a.GetLength(1); j++)
        // Если хотя бы одна пара элементов не совпадает, устанавливается b в false
        if (a[i, j] != a[j, i])
            b = false;

// Результат проверки выводится в файл: "Y" если симметричен, иначе "N"
output.WriteLine(b ? "Y" : "N");
output.Close();