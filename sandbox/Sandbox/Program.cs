using System;
using System.Linq.Expressions;
using Microsoft.Win32;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        // Using Select to 'map' each number to its square
        var squaredNumbers = numbers.Select(x => x * x);
        Console.WriteLine(squaredNumbers);
    }

    static int GetUserInputInteger(string Prompt)
    {
        int  returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.WriteLine(Prompt);
                string wacUserInputStr = Console.ReadLine();
                returnValue = int.Parse(wacUserInputStr);
            } catch (Exception e) {
                Console.WriteLine("Value is not acceptable, please enter an whole number for, ");
            }
            wac_flag = false; 
        }
        return returnValue; 
    }

    static float GetUserInputFloat(string Prompt)
    {
        float returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.WriteLine(Prompt);
                string wacUserInputStr = Console.ReadLine();
                returnValue = float.Parse(wacUserInputStr);
            } catch (Exception e) {
                Console.WriteLine("Value is not acceptable, please enter an decimal value for, ");
            }
            wac_flag = false; 

        }
        return returnValue; 
    }

static float GetUserInputRealNumber(string Prompt)
    {
        float returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.WriteLine(Prompt);
                string wacUserInputStr = Console.ReadLine();
                returnValue = float.Parse(wacUserInputStr);
                if (float.IsRealNumber(returnValue))
                {
                    throw new Exception(); 
                }
            } catch (Exception) {
                Console.WriteLine("Value is not acceptable, please enter an decimal value for, ");
            }
            wac_flag = false; 
        }
        
        return returnValue; 
    }

static string GetUserInputString(string Prompt)
{
    string returnValue = "";
    bool wac_flag = true;
    while (wac_flag)
    {
        try
        {
            Console.WriteLine(Prompt);
            returnValue = Console.ReadLine();
            if (string.IsNullOrEmpty(returnValue)==true)
            {
                throw new Exception();
            }

        } catch (Exception) {
            Console.WriteLine("Value is not acceptable, please enter a string for, ");
        }
        wac_flag = false;
    } 
    return returnValue; 
}

    static void DisplayString(String outputString)
    {
        Console.WriteLine(outputString);
    }
}

