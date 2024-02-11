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
        if (length > 0 && width > 0 && length != null && width != null && length <= 100 && width <= 100)
        {
            this.length = length;
            this.width = width;
        }
        else
        {
            Console.WriteLine("One of the parameters have incorrect value."); 
            Environment.Exit(0);
        }
    }
    public TRectangle(TRectangle instance)
    {
        this.length = instance.length;
        this.width = instance.width;
    }

    public void set()
    {
        try
        {
            while (length <= 0 || length == null)
            {
                Console.WriteLine("Set rectangle length:");
                this.length = float.Parse(Console.ReadLine());
                if (length <= 0 || length > 100)
                {
                    Console.WriteLine("Your length is incorrect.");
                }
            }

            while (width <= 0 || width == null)
            {
                Console.WriteLine("Set rectangle width:");
                this.width = float.Parse(Console.ReadLine());
                if (width <= 0 || width > 100)
                {
                    Console.WriteLine("Your width is incorrect.");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"You made grammar mistake while setting the variable. The reason is...");
            Console.WriteLine($"{e}");
            Environment.Exit(0);
        }
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
            Console.WriteLine("One of the parameters is null. Can't find area.");
            Environment.Exit(0);
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
            Console.WriteLine("One of the parameters is null. Can't find perimeter.");
            Environment.Exit(0);
        }
    }

    public void compare(TRectangle instance)
    {
        if (instance.length != null && this.length != null && 
            instance.width != null && this.width != null)
        {
            if (instance.length == this.length)
            {
                Console.WriteLine("Rectangles have the same length!");
            }
            else
            {
                Console.WriteLine("Length of rectangles are different!");
            }
            
            if (instance.width == this.width)
            {
                Console.WriteLine("Rectangles have the same width!");
            }
            else
            {
                Console.WriteLine("Width of rectangles are different!");
            }
        }
        else
        {
            Console.WriteLine("One of the parameters is null. Can't compare values.");
            Environment.Exit(0);
        }
    }
    
    public static TRectangle operator +(TRectangle rectangle1, TRectangle rectangle2)
    
    {
        if (rectangle1.length != null && rectangle2.length != null && 
            rectangle1.width != null && rectangle2.width != null)
        {
            return new TRectangle(rectangle1.length + rectangle2.length, 
                rectangle1.width + rectangle2.width);
        }
        
        Console.WriteLine("One of the parameters is null. Can't add instances."); 
        Environment.Exit(0);
        return null;
    }
    public static TRectangle operator -(TRectangle rectangle1, TRectangle rectangle2)
    {
        if (rectangle1.length != null && rectangle2.length != null && 
            rectangle1.width != null && rectangle2.width != null)
        {
            float? resultLength, resultWidth;
            if (rectangle1.length >= rectangle2.length)
            {
                resultLength = rectangle1.length - rectangle2.length;
            }
            else
            {
                resultLength = rectangle2.length - rectangle1.length;
            }

            if (rectangle1.width >= rectangle2.width)
            {
                resultWidth = rectangle1.width - rectangle2.width;
            }
            else
            {
                resultWidth = rectangle2.width - rectangle1.width;
            }

            return new TRectangle(resultLength, resultWidth);
        }

        Console.WriteLine("One of the parameters is null. Can't subtract instances."); 
        Environment.Exit(0);
        return null;
    }
    public static TRectangle operator *(TRectangle rectangle1, float variable)
    {
        if (variable > 0 && variable != null && 
            rectangle1.length != null && 
            rectangle1.width != null)
        {
            return new TRectangle(rectangle1.length * variable, 
                rectangle1.width * variable);
        }
        
        Console.WriteLine("Variable have incorrect value.");
        Console.WriteLine("OR");
        Console.WriteLine("One of the parameters is null. Can't multiply instances."); 
        Environment.Exit(0);
        return null;
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
        if (length > 0 && width > 0 && height > 0 && 
            length != null && width != null && height != null
            && length <= 100 && width <= 100 && height <= 100)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        else
        {
            Console.WriteLine("One of the parameters have incorrect value."); 
            Environment.Exit(0);
        }
    }
    public TParallelepiped(TParallelepiped instance) : base(instance)
    {
        this.height = instance.height;
    }
    
    public new void set()
    {
        try
        {
            while (length <= 0 || length == null)
            {
                Console.WriteLine("Set parallelepiped length:");
                this.length = float.Parse(Console.ReadLine());
                if (length <= 0 || length > 100)
                {
                    Console.WriteLine("Your length is incorrect.");
                }
            }

            while (width <= 0 || width == null)
            {
                Console.WriteLine("Set parallelepiped width:");
                this.width = float.Parse(Console.ReadLine());
                if (width <= 0 || width > 100)
                {
                    Console.WriteLine("Your width is incorrect.");
                }
            }
            
            while (height <= 0 || height == null)
            {
                Console.WriteLine("Set parallelepiped height:");
                this.height = float.Parse(Console.ReadLine());
                if (height <= 0 || height > 100)
                {
                    Console.WriteLine("Your height is incorrect.");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"You made grammar mistake while setting the variable. The reason is...");
            Console.WriteLine($"{e}");
            Environment.Exit(0);
        }
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
            Console.WriteLine("One of the parameters is null. Can't find area.");
            Environment.Exit(0);
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
            Console.WriteLine("One of the parameters is null. Can't find perimeter.");
            Environment.Exit(0);
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
            Console.WriteLine("One of the parameters is null. Can't find volume.");
            Environment.Exit(0);
        }
    }

    public new void compare(TParallelepiped instance)
    {
        if (instance.length != null && this.length != null && 
            instance.width != null && this.width != null && 
            instance.height != null && this.height != null)
        {
            if (instance.length == this.length)
            {
                Console.WriteLine("Parallelepipeds have the same length!");
            }
            else
            {
                Console.WriteLine("Length of parallelepipeds are different!");
            }

            if (instance.width == this.width)
            {
                Console.WriteLine("Parallelepipeds have the same width!");
            }
            else
            {
                Console.WriteLine("Width of parallelepipeds are different!");
            }
            
            if (instance.height == this.height)
            {
                Console.WriteLine("Parallelepipeds have the same height!");
            }
            else
            {
                Console.WriteLine("Height of parallelepipeds are different!");
            }
        }
        else
        {
            Console.WriteLine("One of the parameters is null. Can't compare values.");
            Environment.Exit(0);
        }
    }
    
    public static TParallelepiped operator +(TParallelepiped parallelepiped1, TParallelepiped parallelepiped2)
    {
        if (parallelepiped1.length != null && parallelepiped2.length != null && 
            parallelepiped1.width != null && parallelepiped2.width != null && 
            parallelepiped1.height != null && parallelepiped2.height != null)
        {
            return new TParallelepiped(parallelepiped1.length + parallelepiped2.length, 
                parallelepiped1.width + parallelepiped2.width, 
                parallelepiped1.height + parallelepiped2.height);
        }
        
        Console.WriteLine("One of the parameters is null. Can't add instances."); 
        Environment.Exit(0);
        return null;
    }
    public static TParallelepiped operator -(TParallelepiped parallelepiped1, TParallelepiped parallelepiped2)
    {
        if (parallelepiped1.length != null && parallelepiped2.length != null && 
            parallelepiped1.width != null && parallelepiped2.width != null &&
            parallelepiped1.height != null && parallelepiped2.height != null)
        {
            float? resultLength, resultWidth, resultHeight;
            if (parallelepiped1.length >= parallelepiped2.length)
            {
                resultLength = parallelepiped1.length - parallelepiped2.length;
            }
            else
            {
                resultLength = parallelepiped2.length - parallelepiped1.length;
            }

            if (parallelepiped1.width >= parallelepiped2.width)
            {
                resultWidth = parallelepiped1.width - parallelepiped2.width;
            }
            else
            {
                resultWidth = parallelepiped2.width - parallelepiped1.width;
            }
            
            if (parallelepiped1.height >= parallelepiped2.height)
            {
                resultHeight = parallelepiped1.height - parallelepiped2.height;
            }
            else
            {
                resultHeight = parallelepiped2.height - parallelepiped1.height;
            }

            return new TParallelepiped(resultLength, resultWidth, resultHeight);
        }

        Console.WriteLine("One of the parameters is null. Can't subtract instances."); 
        Environment.Exit(0);
        return null;
    }
    public static TParallelepiped operator *(TParallelepiped parallelepiped1, float variable)
    {
        if (variable > 0 && variable != null && 
            parallelepiped1.length != null && 
            parallelepiped1.width != null && 
            parallelepiped1.height != null)
        {
            return new TParallelepiped(parallelepiped1.length * variable, 
                parallelepiped1.width * variable, 
                parallelepiped1.height * variable);
        }
        
        Console.WriteLine("Variable have incorrect value.");
        Console.WriteLine("OR");
        Console.WriteLine("One of the parameters is null. Can't multiply instances."); 
        Environment.Exit(0);
        return null;
    }
}

public class LabTask_1
{
    static private TRectangle rectangle;
    static private TParallelepiped parallelepiped;
    public static void Main() {
        rectangle = new TRectangle();
        rectangle.set();
        rectangle.show();
        rectangle *= 5;
        rectangle.show();
        rectangle += new TRectangle(rectangle);
        rectangle.show();
        rectangle -= new TRectangle(10, 10);
        rectangle.show();
        rectangle.findPerimeter();
        rectangle.findArea();
        rectangle.compare(new TRectangle(10, 10));

        parallelepiped = new TParallelepiped();
        parallelepiped.set();
        parallelepiped.show();
        parallelepiped *= 5;
        parallelepiped.show();
        parallelepiped += new TParallelepiped(parallelepiped);
        parallelepiped.show();
        parallelepiped -= new TParallelepiped(10, 10, 10);
        parallelepiped.show();
        parallelepiped.findPerimeter();
        parallelepiped.findArea();
        parallelepiped.findVolume();
        parallelepiped.compare(new TParallelepiped(10, 10, 10));
    }
}