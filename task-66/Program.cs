// Задача 66:
// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Рекурсивная функция возвращает сумму натуральных чисел,
// в диапазаоне от начального до конечного числа включительно.
int GetNumbersSum(int start, int end)
{
    if (start > end) return 0;
    return start + GetNumbersSum(start + 1, end);
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
// Если проверка возвращает false - обмениваем содержимое переменных,
// для универсальнсти ввода.
if (startNumber > endNumber)
{
    (endNumber, startNumber) = (startNumber, endNumber);
}

Console.WriteLine($"\nСумма натуральных чисел в диапазоне от {startNumber} до {endNumber} равна: {GetNumbersSum(startNumber, endNumber)}\n");