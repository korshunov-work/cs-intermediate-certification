// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// Реализация функции Аккермана.
int Akkerman(int number, int argument)
{
    if (number == 0) return argument + 1;
    else
    {
        if (number != 0 && argument == 0) return Akkerman(number - 1, 1);
        else return Akkerman(number - 1, Akkerman(number, argument - 1));
    }
}

// Функция запрашивает ввод данных с терминала и проверяет,
// является ли введенное значение неотрицательным целым числом.
int CheckInputNaturalNumbersZero(string message)
{
    bool check;
    Console.Write($"{message} ");
    check = int.TryParse(Console.ReadLine(), out int number);
    if (number < 0) check = false;
    while (!check)
    {
        Console.Write($"ОШИБКА! Ввести можно только неотрицательные целые числа.\n{message} ");
        check = int.TryParse(Console.ReadLine(), out number);
        if (number < 0) check = false;
    }
    return number;
}

Console.Clear();
int userNumber = CheckInputNaturalNumbersZero("Введите число функции Аккермана:"); 
int userArgument = CheckInputNaturalNumbersZero("Введите аргумент функции Аккермана:");
Console.WriteLine($"\nЗначение функции Аккермана для ({userNumber}, {userArgument}) равно: {Akkerman(userNumber, userArgument)}\n");