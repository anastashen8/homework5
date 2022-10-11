// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Ведите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int rev = 0;
while (num > 0)
{
    rev = rev * 10 + num % 10;
    num = num / 10;
}
if(temp == rev)
{
Console.WriteLine("Это палиндром");
}
else
   {
    Console.WriteLine("Это не палиндром");
   } 