Console.WriteLine("Введите любое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (number > 0)
{
while (i <= number)
{
int ost = i % 2;
if (ost == 0 )
{
    Console.Write(i + " ");
}
i++;
}
}
else
{
Console.WriteLine("Введено не верное значение");
}
