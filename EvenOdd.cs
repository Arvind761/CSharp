using System;
class EvenOdd{
static void Main(){
Console.Write("Enter  Number: ");
Double x=Convert.ToDouble(Console.ReadLine());

if(x%2==0)
Console.Write($" x is Even Number {x}");
else
Console.Write($" x is Odd Number {x}");
}
}