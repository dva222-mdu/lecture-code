
static class TryDelegate {

    delegate void MyDelegate(string message);

    public static void Run() {
        var o1 = new MyClass("MyClass 1");
        var o2 = new MyClass("MyClass 2");

        o1.MyMethod("Hej!");

        MyDelegate m = o1.MyMethod;
        m("Hello!");

    }

}

class MyClass
{
    string Label;
    public MyClass(string label)
    {
        Label = label;
    }

    public void MyMethod(string message)
    {
        Console.WriteLine($"{message} from Myclass with label {Label}");
    }
}