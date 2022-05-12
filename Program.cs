using TestConsoleApplication;

class Program
{
    static void Main(string[] args)
    {
        // Test t=new Test();
        // t.StringTest();
        // ConstructTest t=new ConstructTest();
        // t.SetA(100);
        // Console.WriteLine(t.GetHashCode());
        // Line line1=new Line();
        // line1.setLength(10);
        // Console.WriteLine(line1.getLength());
        // Taplap taplap1=new Taplap(12,23);
        // taplap1.SetCost(10);
        // Console.WriteLine(taplap1.GetCost(10));
        // ShapeRectangle rect1=new ShapeRectangle(10,20);
        // rect1.Height=30;
        // rect1.Height=40;
        // Box box1=new Box(10,20);
        // Box box2=new Box(30,40);
        // Box box3=new Box();
        // box3=box1+box2;
        // Console.WriteLine(box3.GetHeight());
        // Console.WriteLine(box3.ToString());

        //宏定义
        // DefineTest test1=new DefineTest();
        // test1.IfDefineTest();

        // //正则表达式
        // RegulationTest test1=new RegulationTest();
        // test1.RegulationTestMethod();

        //exception 
        // ExceptionTest test1=new ExceptionTest();
        // test1.ExceptionTestMethod(10,1);


        //FileStream Test
        FileStreamTest test1=new FileStreamTest();
        test1.FileStreamTestMethod();
        
    }
    // static void Main(string[] args)
    // {
    //     bool endApp = false;
    //     // Display title as the C# console calculator app.
    //     Console.WriteLine("Console Calculator in C#\r");
    //     Console.WriteLine("------------------------\n");

    //     while (!endApp)
    //     {
    //         // Declare variables and set to empty.
    //         var numInput1 = "";
    //         var numInput2 = "";
    //         double result = 0;

    //         // Ask the user to type the first number.
    //         Console.Write("Type a number, and then press Enter: ");
    //         numInput1 = Console.ReadLine();

    //         double cleanNum1 = 0;
    //         while (!double.TryParse(numInput1, out cleanNum1))
    //         {
    //             Console.Write("This is not valid input. Please enter an integer value: ");
    //             numInput1 = Console.ReadLine();
    //         }

    //         // Ask the user to type the second number.
    //         Console.Write("Type another number, and then press Enter: ");
    //         numInput2 = Console.ReadLine();

    //         double cleanNum2 = 0;
    //         while (!double.TryParse(numInput2, out cleanNum2))
    //         {
    //             Console.Write("This is not valid input. Please enter an integer value: ");
    //             numInput2 = Console.ReadLine();
    //         }

    //         // Ask the user to choose an operator.
    //         Console.WriteLine("Choose an operator from the following list:");
    //         Console.WriteLine("\ta - Add");
    //         Console.WriteLine("\ts - Subtract");
    //         Console.WriteLine("\tm - Multiply");
    //         Console.WriteLine("\td - Divide");
    //         Console.Write("Your option? ");

    //         var op = Console.ReadLine();

    //         try
    //         {
    //             result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
    //             if (double.IsNaN(result))
    //             {
    //                 Console.WriteLine("This operation will result in a mathematical error.\n");
    //             }
    //             else Console.WriteLine("Your result: {0:0.##}\n", result);
    //         }
    //         catch (Exception e)
    //         {
    //             Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
    //         }

    //         Console.WriteLine("------------------------\n");

    //         // Wait for the user to respond before closing.
    //         Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
    //         if (Console.ReadLine() == "n") endApp = true;

    //         Console.WriteLine("\n"); // Friendly linespacing.
    //     }
    //     return;
    // }
}
