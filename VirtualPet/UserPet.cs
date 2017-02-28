using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class UserPet
    {
        // Created variables for each property of the UserPet class
        private int hunger = 50;
        private int waste = 0;
        private int play = 50;
        private string petName = string.Empty; 
        
         
             
        // Default Constructor for UserPet
        public UserPet ()
        {
           
        }

        // Constructor of UserPet that only name modifier
        public UserPet (string name)
        {
            this.petName = name;
           
            
        }

        // Constructor for UserPet that modifies each property 
        public UserPet (string name, int hungerCon, int wasteCon, int playCon)
        {
            this.hunger = hungerCon;
            this.waste = wasteCon;
            this.play = playCon;
            this.petName = name; 
        }

        // Returns the value of the string PetName
        public string PetName
        {
            get { return petName; }
            
        }

        // Returns the value of the integer Hunger and allows it to be changed in other classes
        public int Hunger
        {
            get { return hunger;  }
            set { hunger = value; }
        }

        // Returns the value of the integer waste and allows it to be changed in other classes
        public int Waste
        {
            get { return waste; }
            set { waste = value; }
        }

        // Returns the value of the integer Play and allows it to be changed in other classes
        public int Play
        {
            get { return play; }
            set { play = value; }
        }

        // Upon being called, adds two to the ints hunger and waste, but reduces 2 from play
        public void Feed()
        {
            hunger+= 2;

            waste+= 2;

            play-= 2;

        }

        // Upon being called, reduces waste by 2, but add 2 to hunger
        public void Relieve()
        {
            waste -= 2;

            hunger += 2; 
        }

        // Upon being called, adds 2 to play, but reduces hunger for 2
        public void Entertain()
        {
            play += 2;

            hunger -=2; 
        }

        // Upon being called, reduces all properties by one 
        public void Nothing()
        {
            hunger--;

            play--;

            waste--;
        }



        // Randomly runs one of 3 conditions, each decreasing a property respectfully by a random number
        // Between 1 and 10
        public void Event()
        {
            Random randomOne = new Random();
            int randomFirst = randomOne.Next(1, 4);
            Random randomTwo = new Random();
            int randomSecond = randomTwo.Next(1, 10);

            switch (randomFirst)
            {
                case 1:
                    Console.WriteLine("Oh no! Your lovely " + petName + " ate some bad food! It seems to have vomitted and needs some more dinner...");
                    hunger -= randomSecond;
                    break;

                case 2:
                    Console.WriteLine("Oh no! Something didn't agree with " + petName + "at all! I think it might have to use the restroom very bad!");
                    waste -= randomSecond;
                    break;

                case 3:
                    Console.WriteLine("Oh no! " + petName + " is dying of sheer boredom! Go and have some fun already!");
                    play -= randomSecond;
                    break;
            }



            
        }
    }
}
