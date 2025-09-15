using System;
class TypeDemo{
static void Main(){
int x=10;
double y=10.89;
String str="RadhaRani";
Console.Write($"Type of variable is {x.GetType()}");
Console.Write($"Type of variable is {y.GetType()}");
Console.Write($"Type of variable is {str.GetType()}");
}
}