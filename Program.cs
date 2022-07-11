Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
int summa = 0;

void  Zadacha27 (int number1, int summa )

{
Console.Write($"В Числe {number1}");
    while ( number1 > 0 )
    {
    summa += number1 % 10;
    number1 /=10;
    }


Console.WriteLine($" сумма цифр = {summa}  ");
}
Zadacha27 (number1, summa );
