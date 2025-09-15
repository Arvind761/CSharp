using System;
class GlobalLocal{
int x=10;
static void Main(){
int y=20;
GlobalLocal obj1=new GlobalLocal();
Console.Write($"Global Variabels is {obj1.x} and local variables is {y}");
}
}