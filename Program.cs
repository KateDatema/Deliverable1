using System;

namespace Deliverable1
{
    //Program that takes Imperial measurements and changes it to MilHop
    class Program
    {
        static void Main(string[] args)
        {  
            //declaring continueAnswer var so I can use it globally 
            string continueAnswer="yes";

            // This program is in a 'do while' loops so that it runs onces, and only continues to run if the user chooses so
            do {
                // asks the user for measuring type and store it in a variable (to lower to make it not case sensitive)
                Console.WriteLine("Please enter your measurement type (example: inches, foot, fidget spinners, memes)");
                String measurementType = Console.ReadLine();
                measurementType = measurementType.ToLower();
                
                // ask the user for ammount
                Console.WriteLine("Please enter your measurement ammount (enter only numbers)");
                decimal measurementAmmount = decimal.Parse(Console.ReadLine());

                //creating a if-else extended control statement so that the computer and take the measurement type + find the correct conversion rate
                   
                    //inches to fidget spinners, Accounting for singular or plural
                    if ((measurementType == "inches") || (measurementType == "inch")) {
                        decimal ConversionRate= 3.5m;
                        measurementAmmount = Decimal.Multiply(measurementAmmount, ConversionRate);
                        Console.WriteLine(measurementAmmount + " fidget spinners");
                    }
                    //foot to memes
                    else if ((measurementType == "foot") || (measurementType == "feet")) {
                        decimal ConversionRate= 5m;
                        measurementAmmount = Decimal.Multiply(measurementAmmount, ConversionRate);
                        Console.WriteLine(measurementAmmount + " memes");
                    }
                    //fidge spinners to inches
                    else if (measurementType == "fidget spinners") {
                        decimal ConversionRate= 3.5m;
                        measurementAmmount = Decimal.Divide(measurementAmmount, ConversionRate);
                        Console.WriteLine(measurementAmmount + " inches");
                    }
                    //memes to foot 
                    else if (measurementType == "memes") {
                        decimal ConversionRate= 5m;
                        measurementAmmount = Decimal.Divide(measurementAmmount, ConversionRate);
                        Console.WriteLine(measurementAmmount + " inches");
                    }
                    //if user inputed meaurement type incorrect, ask them to redo their imput
                    else {
                        Console.WriteLine("I am sorry, it appears you inputed your measurement type incorrectly, please rerun the program");
                    }

                //ask user if they wish to do another calculation (ToLower so it's not case sensitive)
                Console.WriteLine("Would you like to do another calculation?");
                continueAnswer = Console.ReadLine();
                continueAnswer = continueAnswer.ToLower();

            }
            
            while (continueAnswer == "yes");
         }
    }
}
