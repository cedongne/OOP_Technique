using System;

interface InterfaceTest
{
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

    abstract public void AbstractFunc();
};

class Test : AbstractTest, InterfaceTest
{

    public override void AbstractFunc()
    {
        Console.WriteLine("Abstract Func");
    }

    public override void VirtualFunc(){
        Console.WriteLine("Overrided Virtual Func");
    }
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
        InterfaceTest interfaceTest = t;

        t.Func();
        t.VirtualFunc();
        t.AbstractFunc();

        interfaceTest.InterfaceFunc();
    }
};