
// prompt user to give 5 inputs 
// declare an array of numbers and transfer the inputs into arrays
// check if input are numbers if not print invalid input
// else do sum, mean,median,mode,average,max


using System.Net.Mime;
using System.Runtime.Intrinsics.X86;

public class Program
{
    private static void Main(string[] args)
    {
        // print a message to ask user to give 5 inputs
        Console.WriteLine("Enter five numbers seperated by commas:");

        //declare an array of 5 numbers
        var numbers = new int[5];

        // read input and check if it is up to 5 and seperated by commas
        var inputs = Console.ReadLine();

        // make them come in commas
        var seperate = inputs.Split(',');

        if (seperate.Length > 5)
        {
           Console.WriteLine("Invalid input");
        }
        else 
        // convert strings to integers and add to numbers array
        {
          for (int i =0 ; i < seperate.Length ; i++)
          {

           numbers[i] = int.Parse(seperate[i]);
          }
       //create method .sum, .max, mean,median,mode,
         var Maximum = numbers.Max();
         Console.WriteLine($" The maximum number is {Maximum}");
         int Sum = numbers.Sum();
         Console.WriteLine($" The Sum of numbers is {Sum}");
         int mean = Sum /numbers.Length;
         Console.WriteLine($" The mean of numbers is {mean}");
         // to calculate median , sort numbers first then return  the value of arrays = numbers[numbers.Length/2]
         Array.Sort(numbers);
         double Position = numbers.Length/ 2 ;
         int Rounded = (int)Math.Round(Position);
         Console.WriteLine($" The median of numbers is {numbers[Rounded]}");
         //mode



        }

            
            
    }
}