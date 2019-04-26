using System; 

namespace Treehouse.FitnessFrog 
{
  class Program
  {
      static void Main()
      {
        int runningTotal = 0;
        bool keepGoing = true;
        
        while (keepGoing) 
        {
            // Prompt the user for minutes exercised
           Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
          
          
          string entry = System.Console.ReadLine();
          
          if(entry == "quit") {
             keepGoing = false;
          } else {
    
          // add minutes excercised to total
          // display total minutes exercised to the screen
         int minutes = int.Parse(entry);
          runningTotal += minutes; 
          
          
              Console.WriteLine($"You've entered {runningTotal} minutes!");
  
          }
  
          // repeat until the user quits 
        }
        Console.WriteLine("GoodBye");
          
      }
  }
}
