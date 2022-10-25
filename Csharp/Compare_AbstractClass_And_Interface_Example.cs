using System;

interface InterfaceTest
{
    // Override essential.
    void InterfaceFunc();
}

abstract class AbstractTest
{
    int num;

    public void Func()
    {
        Console.WriteLine("Func");
    }

    virtual public void VirtualFunc()
    {
        Console.WriteLine("Virtual Func");
    }

    // Override essential.
    abstract public void AbstractFunc();
};

// The interface can be multi-inherited.
class Test : AbstractTest, InterfaceTest
{

    public override void AbstractFunc()
    {
        Console.WriteLine("Abstract Func");
    }

    public override void VirtualFunc(){
        Console.WriteLine("Overrided Virtual Func");
    }

    // The 'Override' keyword is not required. The method to override the interface must be 'public'.
    public void InterfaceFunc()
    {
        Console.WriteLine("Interface Func");
    }
};

class Program
{
    static void Main()
    {
        Test t = new Test();
        // Can makes interface instance.
        InterfaceTest interfaceTest = t;

        t.Func();
        t.VirtualFunc();
        t.AbstractFunc();

        interfaceTest.InterfaceFunc();
    }
};