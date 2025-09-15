using System;
class Swap{
static void Main(){
Console.Write("Enter Two Number: ");
Double x=Convert.ToDouble(Console.ReadLine());
Double y=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" Before Swapping x is {x} and y is {y}");
Double t=x;
x=y;
y=t;
Console.WriteLine($" After Swapping x is {x} and y is {y}");
}
}
