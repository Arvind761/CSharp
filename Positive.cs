using System;
class Positive
{
static void Main(){
Console.Write("Enter Two Number: ");
Double x=Convert.ToDouble(Console.ReadLine());

if(x>0)
Console.Write($" x is Positve {x}");
else
Console.Write($" x is Negative {x}");
}
}