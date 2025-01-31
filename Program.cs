using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Please choose your coffee choice");
            Console.WriteLine("1. Black Coffee");
            Console.WriteLine("2. Cappuccino");
            Console.WriteLine("3. Caramel Latte");

            Console.Write("Enter your choice (1, 2 or 3): ");
            string choice = Console.ReadLine();
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            

            switch (choice)
            {
                case "1":

                 var result = coffeeMachine.MakeBlackCoffee(0, 4, 6);
                 Console.WriteLine(result);
                 break;

                 case "2":
                 var result1 = coffeeMachine.MakeCappuccino(2, 3, 4); 
                 Console.WriteLine(result1);
                 break;
                 
                case "3":
                 var result2 = coffeeMachine.MakeCaramelLatte();
                 Console.WriteLine(result2);
                 break;
                 

                 default:
                 Console.WriteLine("Invalid choice! Please select 1 or 2 or 3.");
                 break;

            
            }

            
        }
    }

    class CoffeeMachine
    {
        private string CaramelAmuont;
        private int caramelCupsLimit ;
        private int maxCaramelCupsCount;
        private bool outOfOrder;
        public string MachineName { get; } = "mokka";
        public CoffeeMachine()
        { 
           CaramelAmuont = "";
           maxCaramelCupsCount = 0;
           caramelCupsLimit = 5;
           outOfOrder = false;
           
            
        }
       
        public string MakeBlackCoffee(decimal AmountOfWater, int CountOfCoffeeSpoons,
         int CountOfSugarSpoons)
        {
            if(AmountOfWater > 0M && CountOfCoffeeSpoons > 0 && CountOfSugarSpoons > 0)
            {
                return "Hi, I am making a coffee right now... wait a moment";
            }
            
            else{

                return "something is missing please add it!";
            }
        }
        public string MakeCappuccino(decimal AmountOfMilk, int CountOfCoffeeSpoons,
         int CountOfSugarSpoons)
         {
             if(AmountOfMilk > 0M && CountOfCoffeeSpoons > 0 && CountOfSugarSpoons > 0)
            {
                return "Hi, I am making a coffee right now... wait a moment";
            }
            
            else{

                return "something is missing please add it!";
            }

         }
         public string MakeCaramelLatte()
         {
          
            
                if(maxCaramelCupsCount < caramelCupsLimit)
                {  
                    while(maxCaramelCupsCount < caramelCupsLimit)
                    {
                      CaramelAmuont = Console.ReadLine();
                      maxCaramelCupsCount++;
                    Console.WriteLine("Hi, I am making a caramellatte right now... wait a moment");
                    }
                   return "All caramel latte of done";
                }
                else 
                {
                    
                    return "Hi, Caramel latte is out of order";
                }
            
         }
       


    }


}
