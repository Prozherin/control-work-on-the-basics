Console.WriteLine("Введите элементы массива через запятую:");
string input = Console.ReadLine();

string[] inputArray = input.Split(',');

string[] filteredArray = FilterStrings(inputArray);

Console.WriteLine("Результат:");
Console.WriteLine(string.Join(", ", filteredArray));

string[] FilterStrings(string[] array)
{
    int count = CountFilteredStrings(array);
    string[] filteredArray = new string[count];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (IsStringValid(array[i]))
        {
            filteredArray[index] = array[i];
            index++;
        }
    }

    Array.Resize(ref filteredArray, index); // Уменьшаем размер массива до реального количества элементов

    return filteredArray;
}

int CountFilteredStrings(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (IsStringValid(array[i]))
        {
            count++;
        }
    }

    return count;
}

bool IsStringValid(string str)
{
    // Проверка условий для фильтрации строки
    return str.Length <= 3;
}
