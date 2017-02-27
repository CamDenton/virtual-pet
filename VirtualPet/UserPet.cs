using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class UserPet
    {
        private int hunger = 100;
        private int waste = 100;
        private int play = 100;
        private string petName = string.Empty; 
        
         
             

        public UserPet ()
        {

        }

        public UserPet (string name)
        {
            this.petName = name;
            
        }

        public UserPet (string name, int hungerCon, int wasteCon, int playCon)
        {
            this.hunger = hungerCon;
            this.waste = wasteCon;
            this.play = playCon;
            this.petName = name; 
        }

        public string PetName
        {
            get { return petName; }
        }

        public int Hunger
        {
            get { return hunger;  }
        }

        public int Waste
        {
            get { return waste; }
        }

        public int Play
        {
            get { return play; }
        }

        public void Feed()
        {
            hunger+= 2;

            waste+= 2;

            play-= 2;

        }

        public void Relieve()
        {
            waste -= 2;

            hunger += 2; 
        }

        public void Entertain()
        {
            play += 2;

            hunger -=2; 
        }

        public void Nothing()
        {
            hunger--;

            play--;

            waste--;
        }

        

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
