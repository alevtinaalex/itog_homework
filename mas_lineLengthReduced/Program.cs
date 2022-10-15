// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//“Russia”, “Denmark”, “Kazan”] → []

System.Console.WriteLine("Введите любую строку");
string text = Console.ReadLine();
string[] array = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
System.Console.WriteLine("[{0}]", string.Join(" , ", array));
string[] result = Decrease(array);
System.Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам");
System.Console.WriteLine("[{0}]", string.Join(" , ", result));

string[] Decrease(string[] array)
{
    string[] array1 = new string[array.Length];
    int col = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            array1[col] = array[i];
            col++;
        }
    }
    array1 = array1.Where(col => col != null).ToArray();
    return array1;
}