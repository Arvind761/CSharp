using System;
class Divide5{
static void Main(){
Console.Write("Enter  Number: ");
Double x=Convert.ToDouble(Console.ReadLine());

if(x%5==0)
Console.Write($" x is divisble by 5 {x}");
else
Console.Write($" x is not divisble by 5 {x}");
}
}