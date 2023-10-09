Console.WriteLine("Введите элементы массива через запятую:"); // Вывод просьбы ввести элементы массива
string input = Console.ReadLine(); // Чтение введенной строки с клавиатуры

string[] inputArray = input.Split(','); // Разделение введенной строки на элементы массива по запятой

string[] filteredArray = FilterStrings(inputArray); // Фильтрация массива строк

Console.WriteLine("Результат:"); // Вывод заголовка результата
Console.WriteLine(string.Join(", ", filteredArray)); // Вывод отфильтрованных строк, объединенных запятой

string[] FilterStrings(string[] array)
{
    int count = CountFilteredStrings(array); // Подсчет количества отфильтрованных строк
    string[] filteredArray = new string[count]; // Создание нового массива для отфильтрованных строк
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (IsStringValid(array[i])) // Проверка, является ли строка допустимой
        {
            filteredArray[index] = array[i]; // Добавление строки в отфильтрованный массив
            index++;
        }
    }

    Array.Resize(ref filteredArray, index); // Уменьшение размера массива до реального количества элементов

    return filteredArray; // Возвращение отфильтрованного массива
}

int CountFilteredStrings(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (IsStringValid(array[i])) // Проверка, является ли строка допустимой
        {
            count++; // Увеличение счетчика отфильтрованных строк
        }
    }

    return count; // Возвращение количества отфильтрованных строк
}

bool IsStringValid(string str)
{
    // Проверка условий для фильтрации строки
    return str.Length <= 3; // Возвращение значения, указывающего, является ли строка допустимой
}