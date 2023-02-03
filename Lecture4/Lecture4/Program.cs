// See https://aka.ms/new-console-template for more information
using Lecture4;

var v1 = new MutableVector(1, 2);
var v2 = new MutableVector(1, 2);

Console.WriteLine(v1.Equals(v2));
Console.WriteLine(v1 == v2);

try
{
    var s = Console.ReadLine();
    var i = Convert.ToInt32(s);
    Console.WriteLine(i);
} catch (FormatException e)
{
    Console.WriteLine($"{e.StackTrace}");
}

/*
Vector v3 = new MutableVector(3, 4);

var v2 = new Vector(2, 3);
v1.Add(v2);


B b = new B();
A a = new B();

a.F();
b.F();

Console.WriteLine(a.Equals(b));
*/