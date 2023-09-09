
int vvod(string mess)
{
    Console.Write(mess);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
    
int summa(int number)
{
    int rav = 0;
    
    while(number > 0)
    {
        rav += number % 10;
        number /= 10;
    }
    return rav;
}

int number = vvod("Введите число : ");

Console.WriteLine($" Сумма всех цифр в числе {number} = {summa(number)}");