using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VirtualPet
{
    class Program
    {
        #region Class Variables 
        // Declare string for the name of the users pet to be used later
        static string userPetName = String.Empty;
        // Declare a boolean to break the loop for the introduction
        static bool introDone = false;

        static bool exitConsole = false;
        #endregion


        static void Main(string[] args)
        {
            #region Intro
            // Creates a loop to first run the intro, then breaks the loop once it is over
            do
            {


                Console.WriteLine("Virtual Spouse: Welcome ho-- what in the holy blazes is THAT thing?");
                Console.WriteLine("Virtual Spouse: You brought home a... pet? A Camogatchi? Is that something Japanese?");
                Console.WriteLine("Virtual Spouse: Whatever, I'm not taking care of it. What will you name it, anyways?");

                // Assigns the user input to the userPetName string
                userPetName = Console.ReadLine();

                Console.WriteLine("Virtual Spouse: Well... just take care of your " + userPetName + ".");

                introDone = true;


            } while (introDone == false);
            #endregion

            
            // creates a new instance of the class UserPet using only the name modifier
            UserPet yourPet = new UserPet(userPetName);
            // Declares an array of strings for the menu options
            string[] options = new string[] { "1. Feed", "2. Send Outside", "3. Play Together", "4. Do Nothing", "5. Exit"};
            
            
            // creates an infinite loop that introduces menu options and runs them
            for (int i = 1; i < (i + 2); i++ )
            {
                // Caps the hunger of the pet to 100
                if (yourPet.Hunger > 100)
                {
                    yourPet.Hunger = 100;
                }

                // Caps the waste of the pet to 0
                if (yourPet.Waste < 0)
                {
                    yourPet.Waste = 0;
                }

                // Caps the play of the pet to 100
                if (yourPet.Play > 100)
                {
                    yourPet.Play = 100;
                }

                

                // Menu options are stated 
                Console.WriteLine("What will you do? Choose a number:");
                Console.WriteLine("Hunger = " + yourPet.Hunger);
                Console.WriteLine("waste = " + yourPet.Waste);
                Console.WriteLine("Boredom = " + yourPet.Play);

                // Writes to the console each element of the array options
                foreach (string option in options)
                {
                    Console.WriteLine(option);
                }

                // Collects the users input
                int userChoice = int.Parse(Console.ReadLine());

                // Creates a switch of conditions that run depending on the users response
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("You fed " + userPetName + "a delicious meal! They seem rather happy.");
                        yourPet.Feed();
                        break;

                    case 2:
                        Console.WriteLine("You took " + userPetName + "outside to relieve themself. They seem much more comfortable!");
                        yourPet.Relieve();
                        break;

                    case 3:
                        Console.WriteLine("You played with " + userPetName + "for a few hours. They seem highly amused!");
                        yourPet.Entertain();
                        break;

                    case 4:
                        Console.WriteLine("You decide to leave " + userPetName + "alone for now. They look quite confused.");
                        yourPet.Nothing();
                        break;

                    case 5:
                        Console.WriteLine("Exiting Virtual Pet Camogatchi. Good-Bye!");
                        Console.ReadKey();
                        exitConsole = true;
                        break;

                    default:
                        Console.WriteLine("That is not an option. Choose one next time.");
                        yourPet.Nothing();
                        break;

                        
                }


                if (exitConsole == true)
                {
                    break;
                }
                // Runs the UserPet Even method 
                else if (i % 2 == 0)
                {
                    yourPet.Event();
                }
            }
            
        }


        

       
    }
}
