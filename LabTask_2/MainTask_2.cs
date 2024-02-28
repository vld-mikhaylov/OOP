/*
ОДНОВИМІРНА МАТРИЦЯ
1. Дано n дійсних чисел: x1, x2,..., xn. Знайти середнє геометричне значення цих чисел.
2. Дано вектор x є R^n і число a є R. Знайти добуток вектора на число.
3. Впорядкувати елементи масиву за спаданням.

ДВОВИМІРНА МАТРИЦЯ
1. Дана цілочислова квадратна матриця. Розмістити елементи непарних рядків у порядку зростання.
2. Дана цілочислова прямокутна матриця. Визначити кількість стовпців, які не містять жодного нульового елемента.
3. Дана цілочислова прямокутна матриця. Переставляючи рядки даної матриці, розташувати їх у відповідності з ростом характеристик. 
   Характеристикою рядка цілочислової матриці назвемо суму її додатних парних елементів.
*/

namespace LabTask_2;

public class Matrix {
    public static double doubleUserInput()
    {
        double? input = null;
        try
        {
            while (input < 0 || input == null || input > 10)
            {
                Console.WriteLine("Set value:");
                input = double.Parse(Console.ReadLine());
                if (input < 0 || input > 10)
                {
                    Console.WriteLine("Your value is too big or too low!");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"You made mistake while setting the variable. The reason is...");
            Console.WriteLine($"{e}");
            Environment.Exit(0);
        }

        return (double) input;
    }
    public static int intUserInput()
    {
        int? input = null;
        try
        {
            while (input < -10 || input == null || input > 10)
            {
                Console.WriteLine("Set value:");
                input = int.Parse(Console.ReadLine());
                if (input < -10 || input > 10)
                {
                    Console.WriteLine("Your value is too big or too low!");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"You made mistake while setting the variable. The reason is...");
            Console.WriteLine($"{e}");
            Environment.Exit(0);
        }

        return (int) input;
    }

    public void task1_1()
    {
        Console.WriteLine("===| TASK 1_1 |===");
        
        Console.WriteLine("Enter size of an array...");
        int arraySize;
        do
        {
            arraySize = intUserInput();
        } while (arraySize <= 0);
        double[] array = new double[arraySize];

        for (int elementID = 0; elementID < array.Length; elementID++)
        {
            Console.WriteLine($"Enter value for {elementID + 1}'s element of an array...");
            array[elementID] = doubleUserInput();
        }

        double result = 1;
        foreach (double elementValue in array)
        {
            result *= elementValue;
        }
        
        Console.WriteLine($"Result is... {Math.Round(Math.Pow(result, 1.0 / array.Length), 2)}");
    }
    public void task1_2()
    {
        Console.WriteLine("===| TASK 1_2 |===");
        
        Console.WriteLine("Enter size of an array...");
        int arraySize;
        do
        {
            arraySize = intUserInput();
        } while (arraySize <= 0);
        double[] array = new double[arraySize];

        for (int elementID = 0; elementID < array.Length; elementID++)
        {
            Console.WriteLine($"Enter value for {elementID + 1}'s element of an array...");
            array[elementID] = doubleUserInput();
        }
        
        Console.WriteLine($"Enter some value for a scalar...");
        int scalarValue = intUserInput();

        for (int elementID = 0; elementID < array.Length; elementID++)
        {
            array[elementID] *= scalarValue;
        }

        Console.WriteLine("Values of an array after multiplying it with scalar...");
        foreach (double element in array)
        {
            Console.Write($"=|{Math.Round(element, 2)}|=");
        }
    }
    public void task1_3()
    {
        Console.WriteLine("===| TASK 1_3 |===");
        
        Console.WriteLine("Enter size of an array...");
        int arraySize;
        do
        {
            arraySize = intUserInput();
        } while (arraySize <= 0);
        double[] array = new double[arraySize];

        for (int elementID = 0; elementID < array.Length; elementID++)
        {
            Console.WriteLine($"Enter value for {elementID + 1}'s element of an array...");
            array[elementID] = doubleUserInput();
        }
        
        Array.Sort(array, (x, y) => y.CompareTo(x));

        Console.WriteLine("Values of an array after sorting it in desc order...");
        foreach (double element in array)
        {
            Console.Write($"=|{Math.Round(element, 2)}|=");
        }
    }

    public void task2_1()
    {
        Console.WriteLine("===| TASK 2_1 |===");
        
        Console.WriteLine("Enter size of an array...");
        int arraySize;
        do
        {
            arraySize = intUserInput();
        } while (arraySize <= 0);
        int[][] array = new int[arraySize][];
        
        for (int rowElementID = 0; rowElementID < array.GetLength(0); rowElementID++)
        {
            array[rowElementID] = new int[arraySize];
        }

        for (int rowElementID = 0; rowElementID < array.GetLength(0); rowElementID++)
        {
            Console.WriteLine($"Enter values for the {rowElementID + 1}'s row of an array...");
            for (int colElementID = 0; colElementID < array.GetLength(1); colElementID++)
            {
                Console.WriteLine($"Enter value for {colElementID + 1}'s element of an array...");
                array[rowElementID][colElementID] = intUserInput();
            }
        }
        
        for (int rowElementID = 0; rowElementID < array.GetLength(0); rowElementID+=2)
        {
            Array.Sort(array[rowElementID], (x, y) => x.CompareTo(y));
        }

        Console.WriteLine("Values of an array after sorting it in asc order...");
        for (int rowElementID = 0; rowElementID < array.GetLength(0); rowElementID++)
        {
            Console.WriteLine("");
            for (int colElementID = 0; colElementID < array.GetLength(1); colElementID++)
            {
                Console.Write($"=|{array[rowElementID][colElementID]}|=");
            }
        }
    }
    public void task2_2()
    {
        Console.WriteLine("===| TASK 2_2 |===");
        
        Console.WriteLine("Enter firstly amount of rows and then amount of columns of an array...");
        int arrayRowSize, arrayColSize;
        do
        {
            arrayRowSize = intUserInput();
            arrayColSize = intUserInput();
        } while (arrayRowSize <= 0 || arrayColSize <= 0);
        int[][] array = new int[arrayRowSize][];
        
        for (int rowElementID = 0; rowElementID < array.GetLength(0); rowElementID++)
        {
            array[rowElementID] = new int[arrayColSize];
        }

        for (int rowElementID = 0; rowElementID < array.GetLength(0); rowElementID++)
        {
            Console.WriteLine($"Enter values for the {rowElementID + 1}'s row of an array...");
            for (int colElementID = 0; colElementID < array.GetLength(1); colElementID++)
            {
                Console.WriteLine($"Enter value for {colElementID + 1}'s element of an array...");
                array[rowElementID][colElementID] = intUserInput();
            }
        }

        int counter = 0;
        for (int colElementID = 0; colElementID < array.GetLength(0); colElementID++)
        {
            for (int rowElementID = 0; rowElementID < array.GetLength(1); rowElementID++)
            {
                if (array[rowElementID][colElementID] == 0)
                {
                    counter++;
                    rowElementID = array.GetLength(0);
                }
            }
        }

        Console.WriteLine($"Amount of columns with at least one 0 is...{counter}");
    }
    public void task2_3()
    {
        Console.WriteLine("===| TASK 2_3 |===");
        
        Console.WriteLine("Enter firstly amount of rows and then amount of columns of an array...");
        int arrayRowSize, arrayColSize;
        do
        {
            arrayRowSize = intUserInput();
            arrayColSize = intUserInput();
        } while (arrayRowSize <= 0 || arrayColSize <= 0);
        int[][] array = new int[arrayRowSize][];
        
        for (int rowElementID = 0; rowElementID < array.Length; rowElementID++)
        {
            array[rowElementID] = new int[arrayColSize];
        }

        for (int rowElementID = 0; rowElementID < array.Length; rowElementID++)
        {
            Console.WriteLine($"Enter values for the {rowElementID + 1}'s row of an array...");
            for (int colElementID = 0; colElementID < array[0].Length; colElementID++)
            {
                Console.WriteLine($"Enter value for {colElementID + 1}'s element of an array...");
                array[rowElementID][colElementID] = intUserInput();
            }
        }
        
        int[] rowChar = new int[array.Length];
        for (int rowElementID = 0; rowElementID < array.Length; rowElementID++)
        {
            int sum = 0;
            for (int colElementID = 1; colElementID < array[0].Length; colElementID+=2)
            {
                if (array[rowElementID][colElementID] > 0)
                {
                    sum += array[rowElementID][colElementID];
                }
            }
            rowChar[rowElementID] = sum;
        }

        int[] rowCharSorted = new int[array.Length];
        rowChar.CopyTo(rowCharSorted, 0);
        Array.Sort(rowCharSorted, (x, y) => x.CompareTo(y));
        int[][] arraySorted = new int[arrayRowSize][];
        for (int rowElementID = 0; rowElementID < array.Length; rowElementID++)
        {
            arraySorted[rowElementID] = new int[arrayColSize];
        }
        for (int rowElementID = 0; rowElementID < array.Length; rowElementID++)
        {
            array[rowElementID].CopyTo(arraySorted[Array.LastIndexOf(rowCharSorted, rowChar[rowElementID])], 0);
            rowCharSorted[rowChar[rowElementID]] = -1;
        }
        
        Console.WriteLine("Rows of an array after sorting it in asc order...");
        for (int rowElementID = 0; rowElementID < arraySorted.Length; rowElementID++)
        {
            Console.WriteLine("");
            for (int colElementID = 0; colElementID < arraySorted[0].Length; colElementID++)
            {
                Console.Write($"=|{arraySorted[rowElementID][colElementID]}|=");
            }
        }
    }
}

public class MainTask_2
{
    public static void Main()
    {
        Matrix matrix = new Matrix();

        matrix.task1_1();
        matrix.task1_2();
        matrix.task1_3();
        matrix.task2_1();
        matrix.task2_2();
        matrix.task2_3();
    }
}