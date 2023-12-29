// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// ****
// Задача 1: Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.
//****
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(number);
if (number%7==0 && number%23==0) {
    Console.WriteLine($"Введенное число {number} кратно одновременно 23 и 7");

}
else
{
     Console.WriteLine($"Введенное число {number} не кратно одновременно 23 и 7");
}
