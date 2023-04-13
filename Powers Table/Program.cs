// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

public class Program3
{
    public static void Main()
    {
        Console.WriteLine("Learn your squares and cubes!");
        
        bool goOn = true;

        do
        {
            int maxEnter = MaxEnter();
            Console.WriteLine($"The maximum of enter is : {maxEnter}. Enter an integer: ");
            int enter = int.Parse(Console.ReadLine());
            
            if (enter> maxEnter)
            {
                Console.WriteLine("Cubes of enter exceed int range,let's try again");
                continue;
            }
           
           else if (enter > 0)
            { 
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", "Number", "Squared", "Cubed");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", "========",  "========", "========");
           

                for (int i=1; i <= enter; i++)
                {
                int squares = GetSquares(i);
                int cubes = GetCubes(i);
                Console.WriteLine("{0,-20}{1,-20}{2,-20}", i, squares, cubes);
            }
            goOn = Continue();

            }
         
            else { 

                Console.WriteLine("Enter wrong,let's try again"); 
                continue;
            }

        } while (goOn == true);


    }

    public static int MaxEnter()
    {
        
        for(int i= 100;; i++)
        {
            int cubes = GetCubes(i+1);
            if (cubes < 0)
          {
            return i;
          }
        }
    }
    
    public static int GetSquares(int x)
    {
        return x * x;
    }
    public static int GetCubes(int x)
    {
        return x * x *x;
    }


    public static bool Continue()
    {
        Console.WriteLine("would you like to enter again? yes/no ");
        string a = Console.ReadLine().ToLower();
        if(a == "yes")
        {
            return true;
        }
        else if (a == "no")
        {
            Console.WriteLine("Goodbye!");
            return false;
        }
        
        else
        {
            Console.WriteLine("Enter wrong,let's try again");
            return Continue();
        }

    }
}
