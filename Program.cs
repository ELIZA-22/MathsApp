
// prompt user to give 5 inputs 
// declare an array of numbers and transfer the inputs into arrays
// check if input are numbers if not print invalid input
// else do sum, mean,median,mode,max


using System;
using System.ComponentModel;
using System.Collections.Generic;



public class Program
{
    static void Main(string[] args) {
      Console.WriteLine("Please enter the number of your inputs. e.g if you want to enter 1,2,5 (enter 3)\n");
      var noOfInputsString = Console.ReadLine();
      var noOfInputStringValid = Int32.TryParse(noOfInputsString, out int noOfInputNum);

      if(!noOfInputStringValid) {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Invalid input, please try again\n");
        Console.ResetColor();
        Main(args); // Recursion
      }

      Console.WriteLine("Enter the input in this format (2,4,5)\n");

      var input = Console.ReadLine();

      var inputArray = input.Split(",");

      var numbers = new int[noOfInputNum];


      // Convert string input to integers
      for(int i = 0; i < noOfInputNum; i++) {
        var numberValid = Int32.TryParse(inputArray[i], out int num);

        if(!numberValid) {
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine($"Your input is invalid, please try again\n");
          Console.ResetColor();
          Main(args);
        }

        numbers[i] = num;
      }

      PrintSum(numbers);
      PrintMean(numbers);
      PrintMin(numbers);
      PrintMax(numbers);
      PrintMedian(numbers);
      PrintMode(numbers);
    
      //Main(args);

    }

   

    static void PrintSum(int[] numbers) // 1,2,4
    {
      var sum = 0;

      for(int i = 0; i < numbers.Length; i++) {
        sum += numbers[i]; // sum = sum + numbers[i];
      }

      Console.WriteLine($"The sum is {sum}");
    }
    static void PrintMean(int[] numbers) // 1,2,4
    {
      double Totalsum = 0;
     
      for(int i = 0; i < numbers.Length; i++) {
        Totalsum += numbers[i]; 
        }
      
      double Mean = Totalsum/numbers.Length ;
      Console.WriteLine($"The mean is {Mean}");
      
    }
    static void PrintMedian(int[] numbers) // 1,2,3,4,5,6,7,8,9,10
    {   // sort numbers first
      // Implementing a manual sorting algorithm (Bubble Sort)
      for (int i = 0; i < numbers.Length - 1; i++)
      {
          for (int j = 0; j < numbers.Length - i - 1; j++)
          {
          if (numbers[j] > numbers[j + 1])
          {
          // Swap numbers[j] and numbers[j + 1]
          int temp = numbers[j];
          numbers[j] = numbers[j + 1];
          numbers[j + 1] = temp;
          }
          }
      }  // odd case
        if (numbers.Length  % 2 == 1) {
          int Position = (numbers.Length/ 2 );
          Console.WriteLine($"The median is {numbers[Position]}");
        }
        else {
          int Position1 =  numbers.Length /2 ;// 10/2  =5
          int Position2 = Position1 - 1 ; // 5-1 =4
          double Result = (numbers[Position1] + numbers[Position2])/ 2D; 
          Console.WriteLine($"The median is {Result}");
        }
    }
    static void PrintMin(int[] numbers) // 1,2,3,4,5,6,7,8,9,10
    { 
       var  smallest = numbers[0];
    
        for (int i =1; i < numbers.Length; i++)
          {
           var current = numbers[i];
          if (smallest > current)
          {
            smallest = current ;
              }
        
          }
            Console.WriteLine($"The minimum number is {smallest}");
          
    }
    static void PrintMax(int[] numbers) //17,8,199,10
    { 
       var Biggest = numbers[0];
    
        for (int i =1; i < numbers.Length; i++)
          {
           var current = numbers[i];
          if (Biggest < current)// 17 < 8
          {
            Biggest = current ;
          }
          }
            Console.WriteLine($"The maximum number is {Biggest}");
          
    }
    static void PrintMode(int[] numbers) //17,8,199,10
    {
      var numberCountDict = new Dictionary<int, int>();

      // Count occurrences of each number
      foreach (var num in numbers)
      {
        if (!numberCountDict.ContainsKey(num)) 
        {
          numberCountDict[num] = 1;
        }
        else
        {
          numberCountDict[num]++;
        }
      }

      // Find the number with the highest count
      int mode = numbers[0];
      int maxCount = 0;

      foreach (var pair in numberCountDict)
      {
        if (pair.Value > maxCount)
        {
          maxCount = pair.Value;
          mode = pair.Key;

        }
      }

      Console.WriteLine($"The mode is {mode} and it occurred {maxCount} times.");
    }
         
    }
     
  
  
   // private static void Main(string[] args)
    // {
    //     // print a message to ask user to give 5 inputs
    //     Console.WriteLine("Enter five numbers seperated by commas:");

    //     //declare an array of 5 numbers
    //     var numbers = new int[5];

    //     // read input and check if it is up to 5 and seperated by commas
    //     var inputs = Console.ReadLine();

    //     // make them come in commas
    //     var seperate = inputs.Split(',');

    //     if (seperate.Length > 5)
    //     {
    //        Console.WriteLine("Invalid input");
    //     }
    //     else 
    //     // convert strings to integers and add to numbers array
    //     {
    //       for (int i =0 ; i < seperate.Length ; i++)
    //       {

    //        numbers[i] = int.Parse(seperate[i]);
    //       }
    //    //create method .sum, .max, mean,median,mode,
    //      var Maximum = numbers.Max();
    //      Console.WriteLine($" The maximum number is {Maximum}");
    //      int Sum = numbers.Sum();
    //      Console.WriteLine($" The Sum of numbers is {Sum}");
    //      int mean = Sum /numbers.Length;
    //      Console.WriteLine($" The mean of numbers is {mean}");
    //      // to calculate median , sort numbers first then return  the value of arrays = numbers[numbers.Length/2]
    //      Array.Sort(numbers);
    //      double Position = numbers.Length/ 2 ;
    //      int Rounded = (int)Math.Round(Position);
    //      Console.WriteLine($" The median of numbers is {numbers[Rounded]}");
    //      //mode



    //     


