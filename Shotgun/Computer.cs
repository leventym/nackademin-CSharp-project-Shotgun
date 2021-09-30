using System;

namespace Shotgun
{
    public class Computer
    {
        //medlemsvariabler
        private int amountShots = 0;
        private state computerMove = state.load;

        public enum state
        {
            load,
            shoot,
            block,
            shotgun
        }
        public Computer()
        {
        }

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

        public int GetAmmunition()
        {
            return amountShots;
        }

        public void Load()
        {
            computerMove = state.load;
            amountShots = amountShots + 1;
        }

        public void Shotgun()
        {
            computerMove = state.shotgun;
            amountShots = amountShots -3;
        }

        public void Shoot()
        {
            computerMove = state.shoot;
            amountShots = amountShots - 1;
        }

    }
}
