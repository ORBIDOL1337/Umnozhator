using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
        //
        // TODO: Add constructor logic here
        //
        int Otvet;
        Console.WriteLine("Введите первое число");
        int Chislo1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int Chislo2 = Convert.ToInt32(Console.ReadLine());
        Otvet = Chislo1 * Chislo2;
        Console.WriteLine($"Результат умножения чисел:{Otvet}");
        Console.WriteLine($"Результат деления чисел:{Chislo1 / Chislo2}");
        Console.ReadKey();
    }
}
