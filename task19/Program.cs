// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int a = num;
int b = 0;
int c;
while( num > 0 )
{
    c = num % 10; 
    b = b * 10 + c;
    num = num / 10;
}

if(a == b)
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не палиндром");
}


