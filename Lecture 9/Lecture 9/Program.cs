/*
var l1 = new Lecture_9.LinkedList<string>();

l1.Add("a");
string x1 = l1[0];

foreach (var x in l1)
{

}

var l2 = new Lecture_9.LinkedList<int>();

l2.Add(1);
int x2 = l2[0];

foreach (var x in l2)
{

}

var l3 = new Lecture_9.LinkedList<object>();

l3.Add("a");
l3.Add(1);

var x3 = (string)l3[0];
var x4 = l3[1];
*/

using Lecture_9;

var b = new Board(3);
b.Print();

var temp = b.Tiles[0, 0];
b.Tiles[0, 0] = b.Tiles[1, 2];
b.Tiles[1, 2] = temp;

b.Print();
