namespace LabTask_1;

class TRectangle
{
    public float? length, width;
    
    public TRectangle()
    {
        length = null;
        width = null;
    }
    public TRectangle(float? length, float? width)
    {
        this.length = length;
        this.width = width;
    }
    public TRectangle(TRectangle instance)
    {
        this.length = instance.length;
        this.width = instance.width;
    }

    public void set()
    {
        Console.WriteLine("Set rectangle length:");
        this.length = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Set rectangle width:");
        this.width = float.Parse(Console.ReadLine());
    }
    public void show()
    {
        Console.WriteLine($"Rectangle length is {this.length} and it's width is {this.width}!");
    }

    public void findArea()
    {
        if (length != null && width != null)
        {
            Console.WriteLine($"Rectangle area is {this.length * this.width}!");
        }
        else
        {
            Console.WriteLine("Error occured while searching an area of rectangle!");
            Console.WriteLine("Check if there is no mistakes in variables:!");
            Console.WriteLine($"Length: {this.length}");
            Console.WriteLine($"Width: {this.width}");
        }
    }
    public void findPerimeter()
    {
        if (length != null && width != null)
        {
            Console.WriteLine($"Rectangle perimeter is {2 * (this.length + this.width)}!");
        }
        else
        {
            Console.WriteLine("Error occured while searching a perimeter of rectangle!");
            Console.WriteLine("Check if there is no mistakes in variables:!");
            Console.WriteLine($"Length: {this.length}");
            Console.WriteLine($"Width: {this.width}");
        }
    }

    public void compare(TRectangle instance)
    {
        if (instance.length == this.length)
        {
            Console.WriteLine("Rectangles have the same length!");
        }
        else
        {
            Console.WriteLine("Length of rectangles are different!"); ;
        }
        
        if (instance.width == this.width)
        {
            Console.WriteLine("Rectangles have the same width!");
        }
        else
        {
            Console.WriteLine("Width of rectangles are different!"); ;
        }
    }
    
    public static TRectangle operator +(TRectangle rectangle1, TRectangle rectangle2)
    {
        return new TRectangle(rectangle1.length + rectangle2.length, rectangle1.width + rectangle2.width);
    }
    public static TRectangle operator -(TRectangle rectangle1, TRectangle rectangle2)
    {
        return new TRectangle(rectangle1.length - rectangle2.length, rectangle1.width - rectangle2.width);
    }
    public static TRectangle operator *(TRectangle rectangle1, float variable)
    {
        return new TRectangle(rectangle1.length * variable, rectangle1.width * variable);
    }
}

class TParallelepiped : TRectangle
{
    private float? height;
    
    public TParallelepiped() : base()
    {
        height = null;
    }
    public TParallelepiped(float? length, float? width, float? height) : base(length, width)
    {
        this.height = height;
    }
    public TParallelepiped(TParallelepiped instance) : base(instance)
    {
        this.height = instance.height;
    }
    
    public new void set()
    {
        Console.WriteLine("Set parallelepiped length:");
        this.length = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Set parallelepiped width:");
        this.width = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Set parallelepiped height:");
        this.height = float.Parse(Console.ReadLine());
    }
    public new void show()
    {
        Console.WriteLine($"Parallelepiped length is {this.length} and it's width is {this.width}, also height is {this.height}!");
    }

    
    public new void findArea()
    {
        if (length != null && width != null && height != null)
        {
            Console.WriteLine($"Parallelepiped area is {2 * (this.length * this.width) + 2 * (this.length * this.height) + 2 * (this.width * this.height)}!");
        }
        else
        {
            Console.WriteLine("Error occured while searching an area of parallelepiped!");
            Console.WriteLine("Check if there is no mistakes in variables:!");
            Console.WriteLine($"Length: {this.length}");
            Console.WriteLine($"Width: {this.width}");
            Console.WriteLine($"Height: {this.height}");
        }
    }
    public new void findPerimeter()
    {
        if (length != null && width != null && height != null)
        {
            Console.WriteLine($"Parallelepiped perimeter is {4 * (this.length + this.width + this.height)}!");
        }
        else
        {
            Console.WriteLine("Error occured while searching a perimeter of parallelepiped!");
            Console.WriteLine("Check if there is no mistakes in variables:!");
            Console.WriteLine($"Length: {this.length}");
            Console.WriteLine($"Width: {this.width}");
            Console.WriteLine($"Height: {this.height}");
        }
    }
    public void findVolume()
    {
        if (length != null && width != null && height != null)
        {
            Console.WriteLine($"Parallelepiped volume is {(this.length * this.width * this.height)}!");
        }
        else
        {
            Console.WriteLine("Error occured while searching an area of parallelepiped!");
            Console.WriteLine("Check if there is no mistakes in variables:!");
            Console.WriteLine($"Length: {this.length}");
            Console.WriteLine($"Width: {this.width}");
            Console.WriteLine($"Height: {this.height}");
        }
    }

    public new void compare(TParallelepiped instance)
    {
        if (instance.length == this.length)
        {
            Console.WriteLine("Parallelepiped have the same length!");
        }
        else
        {
            Console.WriteLine("Length of parallelepiped are different!"); ;
        }
        
        if (instance.width == this.width)
        {
            Console.WriteLine("Parallelepiped have the same width!");
        }
        else
        {
            Console.WriteLine("Width of parallelepiped are different!"); ;
        }
        
        if (instance.height == this.height)
        {
            Console.WriteLine("Parallelepiped have the same height!");
        }
        else
        {
            Console.WriteLine("Height of parallelepiped are different!"); ;
        }
    }
    
    public static TParallelepiped operator +(TParallelepiped parallelepiped1, TParallelepiped parallelepiped2)
    {
        return new TParallelepiped(parallelepiped1.length + parallelepiped2.length, parallelepiped1.width + parallelepiped2.width, parallelepiped1.height + parallelepiped2.height);
    }
    public static TParallelepiped operator -(TParallelepiped parallelepiped1, TParallelepiped parallelepiped2)
    {
        return new TParallelepiped(parallelepiped1.length - parallelepiped2.length, parallelepiped1.width - parallelepiped2.width, parallelepiped1.height - parallelepiped2.height);
    }
    public static TParallelepiped operator *(TParallelepiped parallelepiped1, float variable)
    {
        return new TParallelepiped(parallelepiped1.length * variable, parallelepiped1.width * variable, parallelepiped1.height * variable);
    }
}

public class Main_5
{
    public static void Main() {
        TRectangle rectangle = new TRectangle();
        rectangle.set();
        rectangle.show();
        rectangle *= 5;
        rectangle.show();
        rectangle.findPerimeter();
        rectangle.findArea();
        rectangle.compare(new TRectangle(10, 50));

        TParallelepiped parallelepiped = new TParallelepiped();
        parallelepiped.set();
        parallelepiped.show();
        parallelepiped *= 5;
        parallelepiped.show();
        parallelepiped.findPerimeter();
        parallelepiped.findArea();
        parallelepiped.findVolume();
        parallelepiped.compare(new TParallelepiped(50, 50, 100));
    }
}