# Object Oriented Programming

C# is a rich implementation of the object orientation paradigm, which includes encapsulation, iheritance and polymorphism

# Encapsulation 
Encapsulation is when a class or struct specify how accessible each of its **Members** is to code outside the class or struct.

## Members
- Fields
- Constants
- Properties
- Methods
- Events
- Finalizers
- Indexers
- Operators
- Nested Types

## Accessiblity
it specify where the **Members** can be accessed

- public
- protected
- internal
- protected internal
- private
- private protected

# Inhertance
When a class inherit from another class it automatically contains all the public, protected and internal members of the base class except its **Constructors** and **Finalizers**

Classes can be declared **Abstract** which means one or more of thier methods have no implementation. Classes can also be declared as sealed to prevent other classes from inheriting from them

```
// Implicitly inherit from Object class.
public class WorkItem 
{
    //static field to store job ID
    private static int currentID;

    //Properties
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string Description { get; set; }
    protected TimeSpan jobLength { get; set; }

    // Default Constructor
    public WorkItem()
    {
        ID = 0;
        Title = "Default title";
        Description = "Default Description";
        jobLength = new TimeSpan();
    }

    // Parameterized Constructor
    public WorkItem(string title, string desc, TimeSpan joblen)
    {
        ID = GetNextID();
        Title = title;
        Description = desc;
        jobLength = joblen;
    }

    // Static constructor called one time
    static WorkItem() => currentID = 0;

    protected int GetNextID() => ++currentID;

    public void Update(string title, TimeSpan joblen)
    {
        this.Title = title;
        this.jobLength = joblen;
    }

    // Virtual method override of the ToString method that is inherited
    // from Sysem.Object
    public override string ToString() =>
        $"{this.ID} - {this.Title}";
}

// Inheritance helped us reuse the code in WorkItem
public class ChangeRequest : WorkItem
{
    protected int originalItemID { get; set; }

    public ChangeRequest() { }

    public ChangeRequest(string title, string desc, TimeSpan jobLen, int originalID)
    {
        this.ID = GetNextID();
        this.Title = title;
        this.Description = desc;
        this.jobLength = jobLen;
        this.originalItemID = originalID;
    }
}
```

# Polymorphism
polymorphism allow us to define diffrent implementation to our base class methods in the derived class

```
public class Shape
{
    public int X { get; init; }
    public int Y { get; init; }
    public int Height { get; init; }
    public int Width { get; init; }

    // Virtual method
    public virtual void Draw()
    {
        Console.WriteLine("Performing base class drawing tasks");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        // Code to draw a circle...
        Console.WriteLine("Drawing a circle");
        base.Draw();
    }
}
public class Rectangle : Shape
{
    public override void Draw()
    {
        // Code to draw a rectangle...
        Console.WriteLine("Drawing a rectangle");
        base.Draw();
    }
}
```

