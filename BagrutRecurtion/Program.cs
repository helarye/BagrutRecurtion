// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("Hello, World!");

int n = 5;
Console.WriteLine(Sum(n));

Node<int> lst = new Node<int>(1, new Node<int>(2, new Node<int>(3, new Node<int>(4, new Node<int>(5)))));
Console.WriteLine(lst);
lst = What(lst);
static int Sum(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return n + Sum(n - 1);
}
static Node<int>What(Node<int>lst)
{
        
    if (lst == null)
    {
        Console.WriteLine("the current value of lstNode is null");
        return null;
    }
        Console.WriteLine("the current value of lstNode is " + lst.GetValue());
    Node<int> temp = What(lst.GetNext());
        Console.WriteLine("the current value of lstNode is " + lst.GetValue());
        Console.WriteLine("the current value of tempList is " + temp);
    lst.SetNext(temp);
        Console.WriteLine("the current value of lstList is " + lst);
        Console.WriteLine();
    return lst;
}