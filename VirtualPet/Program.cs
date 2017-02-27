using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {

        static string userPetName = String.Empty;
        static bool introDone = false;


        static void Main(string[] args)
        {
            do
            {


                Console.WriteLine("Virtual Spouse: Welcome ho-- what in the holy blazes is THAT thing?");
                Console.WriteLine("Virtual Spouse: You brought home a... pet? A Camogatchi? Is that something Japanese?");
                Console.WriteLine("Virtual Spouse: Whatever, I'm not taking care of it. What will you name it, anyways?");

                userPetName = Console.ReadLine();

                Console.WriteLine("Virtual Spouse: Well... just take care of your " + userPetName + ".");

                introDone = true;


            } while (introDone == false);

            UserPet yourPet = new UserPet(userPetName);
            string[] options = new string[] { "1. Feed", "2. Send Outside", "3. Play Together", "4. Do Nothing"};
            
            for (int i = 1; i < (i + 2); i++ )
            {
                Console.WriteLine("What will you do? Choose a number:");
                Console.WriteLine("Hunger = " + yourPet.Hunger);
                Console.WriteLine("waste = " + yourPet.Waste);
                Console.WriteLine("Boredom = " + yourPet.Play);

                foreach(string option in options)
                {
                    Console.WriteLine(option);
                }

                int userChoice = int.Parse(Console.ReadLine());
                
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

                    default:
                        Console.WriteLine("That is not an option. Choose one next time.");
                        yourPet.Nothing();
                        break;

                        
                }

                yourPet.Event();
            }
            
        }

        

       
    }
}
