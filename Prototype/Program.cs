using System;

public class ComplexObject : ICloneable
{
    public int IntValue { get; set; }
    public string StringValue { get; set; }

    public ComplexObject(int intValue, string stringValue)
    {
        IntValue = intValue;
        StringValue = stringValue;
    }

    public object Clone()
    {
        return new ComplexObject(this.IntValue, this.StringValue);
    }

    public void Display()
    {
        Console.WriteLine($"IntValue: {IntValue}, StringValue: {StringValue}");
    }
}

class Program
{
    static void Main()
    {
        ComplexObject originalObject = new ComplexObject(42, "Hello");

        ComplexObject clonedObject = (ComplexObject)originalObject.Clone();

        Console.WriteLine("Original Object:");
        originalObject.Display();

        Console.WriteLine("Cloned Object:");
        clonedObject.Display();

        clonedObject.IntValue = 99;
        clonedObject.StringValue = "World";

        Console.WriteLine("After modifying Cloned Object:");
        Console.WriteLine("Original Object:");
        originalObject.Display();
        Console.WriteLine("Cloned Object:");
        clonedObject.Display();
    }
}