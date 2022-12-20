//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using MethodPractise;



Calculate();



static void Calculate()
{

Calculator calculator=new Calculator();

Console.WriteLine("Add First Number");
    Number1: string number1 = Console.ReadLine();
    int checkedNum1;
    bool isParseNum1=int.TryParse(number1, out checkedNum1);

    if (isParseNum1)
    {
       
    }
    else
    {
        Console.WriteLine("Add Correct format number 1");
        goto Number1;
    }


    Console.WriteLine("Operatoru daxil edin");
   
   string operate = Console.ReadLine();

    Console.WriteLine("Add Second Number");
   
    int num2 = int.Parse(Console.ReadLine());
   
    
    Number2: string number2 = Console.ReadLine();
    int checkedNum2;
    bool isParseNum2 = int.TryParse(number2, out checkedNum2);

    if (!isParseNum2)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Add Correct format number 2");
        goto Number2;
    }
   
    var result= calculator.Calculation(checkedNum1, checkedNum2,operate);
   
   
    Console.ForegroundColor=ConsoleColor.Blue;
    
    Console.WriteLine("Netice"+result);
}

