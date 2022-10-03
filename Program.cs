
PrintTriangle();
PrintNumberTable();
ExitProgram();







static void PrintTriangle()
{   
    int triangle = 1;
    int num = 0;
    int userInput = 1;
    System.Console.WriteLine($"Enter {triangle} to display the triangle");
    userInput = int.Parse(Console.ReadLine());
    if(userInput != 1)
    {
        System.Console.WriteLine("Invalid choice.");
    }
    else{
         System.Console.WriteLine("\t\t");
        for(int i=10; i>0; i--)
    {
        for(int j=i; j>0; j--)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
    

    }
   

}



static void PrintNumberTable()
{
    int table = 2;
    int i = 1;
    int userInput2 = 2;
    System.Console.WriteLine($"Enter {table} to display the table");
    userInput2 = int.Parse(Console.ReadLine());
    if(userInput2 != 2)
    {
        System.Console.WriteLine("Invalid choice.");
    }
    else{
        while(i <= 4)
    {
            int column = i;
            System.Console.Write(column);
            for(int j=0; j<10; j++)
        {
                int row = column*j;
                System.Console.Write("\t" + row);
            
        }
        System.Console.WriteLine("");
        i++;
    }
        
    }

} 



static int ExitProgram()
{
    int exit = 3;
    int userInput3 = 0;
    System.Console.WriteLine($"Enter {exit} to terminate the program.");
    userInput3 = int.Parse(Console.ReadLine());
    if(userInput3 != 3)
    {
        System.Console.WriteLine("Invalid choice.");
    }
    return exit;

}