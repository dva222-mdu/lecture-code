// See https://aka.ms/new-console-template for more information
using Lecture_8;

var list = new LinkedList() { 5 , 4, 5, 6, 7, 4 };
int[] x = { 1, 4, 5, 6, 7, 4 };


foreach (var item in list)
{
    Console.WriteLine(item);
}

var tree = new BinarySearchTree();

tree.Add(1);
tree.Add(5);
tree.Add(3);
tree.Add(4);

int y = (int) tree.Find(4);
Console.WriteLine(y);
