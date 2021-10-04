using System;

namespace Shotgun
{
    public class Computer
    {
        //medlemsvariabler
        private int amountShots = 0;
        private state computerMove = state.load;

        //Enum klassvariabler
        public enum state
        {
            load,
            shoot,
            block,
            shotgun
        }
        //Konstruktorn
        public Computer()
        {
        }

        //Metoden utvärderar vad som sker efter spelaren spelat.
        //Om datorn antal skott är 3 eller mer kan datorn skjuta Shotgun.
        //Om datorns antal skott är 0 kan datorn bara ladda, Load.
        //I annat fall initieras ny klass, Random. Där frå variabeln value slumpmässigt tal mellan 0-3 för att utföra en handling från state (enum)
        //Slumpmässiga talet konverteras och tilldelas till variabeln computerMove.
        //Om datorn skjuter, state.shoot, eller laddar, state.load, tilldelas dessa till variabeln computerMove. Sedan körs metoderna Shoot eller Load respektive.

        public state GetMove()
        {
            if (amountShots >= 3)
            {
                Shotgun();
            }

            else if (amountShots == 0)
            {
                Load();
            }
            else
            {
                Random rnd = new Random();
                int value = rnd.Next(0, 2);  // creates a number between 0 and 3
                computerMove = (state)value;

                if (computerMove == state.shoot)
                {
                    Shoot();
                }
                else if (computerMove == state.load)
                {
                    Load();
                }
            }
            return computerMove;
        }

        //MEtoden returnerar siffervärde med variabeln amountshots och hämtar antal skot..
        public int GetAmmunition()
        {
            return amountShots;
        }

        //Metoden tilldelar state.load till variabeln computerMove.
        //Anatl skott ökar med ett (+1) för datorn.
        public void Load()
        {
            computerMove = state.load;
            amountShots = amountShots + 1;
        }

        //Metoden tilldelar state.shotgun till variabeln computerMove
        //Antal skott minskas med tre (-3).
        public void Shotgun()
        {
            computerMove = state.shotgun;
            amountShots = amountShots -3;
        }

        //Metoden tilldelar state.shoot till variabeln computerMove.
        //Antalet skott minskas med ett (-1).
        public void Shoot()
        {
            computerMove = state.shoot;
            amountShots = amountShots - 1;
        }
    }
}
