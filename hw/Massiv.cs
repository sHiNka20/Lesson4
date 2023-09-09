int vvod(string mess)
{
    Console.Write(mess);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] generate(int lenght, int min, int max)
{
    int[] arr = new int[lenght];

    Random rnd = new Random();

    for(int i = 0; i < lenght; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void print(int[] arr)
{
    Console.Write(" [");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.WriteLine("]");
}

int lenght = vvod("Введите размер массива : ");
int min = vvod("Введите начальное значение, для диопозона случайного числа : ");
int max = vvod("Введите конечное значение, для диопозона случайного числа : ");
int[] arr = generate(lenght, min, max);

print(arr);