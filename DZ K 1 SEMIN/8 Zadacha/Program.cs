/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: ");
int numeven = int.Parse(Console.ReadLine () ?? "");
int cur = 2;
Console.Write($"Четные числа от <1> до <{numeven}> :");  
while (cur < numeven)
{
    Console.Write($" {cur}");
    cur =cur +2;  
}    
Console.WriteLine(" Выполнено! Ура!!! ");