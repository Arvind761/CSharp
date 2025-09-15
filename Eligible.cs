using System;
class Eligible{
static void Main(){
Console.Write("Enter Age: ");
Double x=Convert.ToDouble(Console.ReadLine());
if(x>18)
Console.Write($" Person  is Eligible ");
else
Console.Write($" Person  is not Eligible");
}
}