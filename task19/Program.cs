// Напишите программу, которая принимает на вход пятизначное число и проверияет, является ли оно палиндромом.
System.Console.WriteLine("Введите пятизначное число : ");
int n = Convert.ToInt32(Console.ReadLine());
string chr = Convert.ToString(n);
if (chr[0] == chr[^1] && chr[1] == chr[^2])
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}
