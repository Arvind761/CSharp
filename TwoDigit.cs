using System;
class TwoDigit{
static void Main(){
Console.Write("Enter  Number: ");
Double x=Convert.ToDouble(Console.ReadLine());

if(x>=10&&x<=99)
Console.Write($"{x} is a Two Digit Number ");
else
Console.Write($"{x} is a not Two Digit Number");
}
}