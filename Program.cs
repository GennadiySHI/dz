//Console.Write("ВВедите число: ");
//int number = int.Parse(Console.ReadLine()); 
//int str = number * number;

// Вывод построчно 
//Console.Write("квадрат числа ");
//Console.Write(number);
//Console.Write (" равен = ");
//Console.Write(str);
//Console.WriteLine();

// Вывод с использованием $
//Console.WriteLine($"квадрат числа {number} равен = {str}");

// Вывод с обращением к переменным
//Console.WriteLine("квадрат числа {0} равен = {1}", number, str);

//Использование библиотек из Math
//int sqr = Convert.ToInt32(Console.ReadLine());
//double sqr_2 = Math.Pow(sqr,2);
//Console.WriteLine("квадрат числа {0} равен = {1}", number, sqr, sqr_2);

//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет
/*
Console.Write("ВВедите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
bool c = a == b*b;
Console.Write($"Является ли {a} квадратом {b} - {c}");
if (a == b*b){
    Console.WriteLine(" Является ");
}
else 
    Console.WriteLine(" Не является ");

//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
Console.WriteLine("Введите число от 1 до 7 ");
int number = Convert.ToInt32(Console.ReadLine());
 if (number == 1){
     Console.WriteLine(" Понедельник ");
 }
 else if (number == 2){
     Console.WriteLine(" Вторник ");
 }
 else if (number == 3){
     Console.WriteLine(" Среда ");
 }
 else if (number == 4){
     Console.WriteLine(" Четверг ");
 }
 else if (number == 5){
     Console.WriteLine(" Пятница ");
 }
 else if (number == 6){
     Console.WriteLine(" Суббота ");
 }
 else if (number == 7){
     Console.WriteLine(" Воскресенье ");
 }
 else{
    Console.WriteLine("Ваши данные некорректны. ВВедите число от 1 до 7");
 }
 //
//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"


System.Console.WriteLine(" ВВедите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int num=N*(-1);

if ( N > 0 ){ 
    while(num<=N){
    System.Console.WriteLine($"{num}");
   num++;
   // num = num+1
    }
}

else{
    while(num<=N){
    System.Console.WriteLine($"{num}");
    num--;   
    }
}



//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

using System.Net.WebSockets;

System.Console.WriteLine(" ВВедите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int ost=N%10;
System.Console.WriteLine(ost);
*/
Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
int amount = number.Length;

if (amount != 3)
{
Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
Console.WriteLine(number.Substring(amount-1));
}