// Задача 64:
// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Рекурсивная функция возвращает строку с натуральными числами, разделенными табуляцией,
// в диапазаоне от начального до конечного числа включительно.
string PrintNumbers(int start, int end)
{
    if (start > end) return "";
    return $"{start}\t{PrintNumbers(start + 1, end)}";
}

// Функция запрашивает ввод данных с терминала и проверяет,
// является ли введенное значение натуральным числом.
int CheckInputNaturalNumbers(string message)
{
    bool check;
    Console.Write($"{message} ");
    check = int.TryParse(Console.ReadLine(), out int number);
    if (number < 1) check = false;
    while (!check)
    {
        Console.Write($"ОШИБКА! Ввести можно только натуральные числа.\n{message} ");
        check = int.TryParse(Console.ReadLine(), out number);
        if (number < 1) check = false;
    }
    return number;
}

Console.Clear();
int startNumber = CheckInputNaturalNumbers("Введите начальное число:");
int endNumber = CheckInputNaturalNumbers("Введите конечное число:");
// Проверка: не является ли начальное число больше чем конечное.
// Если проверка возварщает false - обмениваем содержимое переменных,
// для универсальнсти ввода. 
if (startNumber > endNumber)
{
    (endNumber, startNumber) = (startNumber, endNumber);
}
Console.WriteLine($"\n{PrintNumbers(startNumber, endNumber)}\n");

