using System;

public class Homework
{
    public static int stepen(int num, int secnum)
    {
        int itog = 0;
        for (int i = 1; i < secnum; i++)
        {
            if (itog == 0)
            {
                itog = num * num;
            }
            else
            {
                itog = itog * num;
            }
        }
        return itog;
    }

    public static void Main(string[] args)
    {
        int num;
        int secnum;

        Console.Write("Введите число которое хотите возвести :");
        num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите степень в которую хотите возвести данное число :");
        secnum = Convert.ToInt32(Console.ReadLine());

        int result = stepen(num, secnum);
        Console.WriteLine($"  {num} В степени {secnum} = {result}");
    }
}
