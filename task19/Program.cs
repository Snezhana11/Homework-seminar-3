// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num;
int num2 = 0;
int num3;
while( num > 0 )
{
    num3 = num % 10; 
    num2 = num2 * 10 + num3;
    num = num / 10;
}

if(num1 == num2)
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не палиндром");
}


