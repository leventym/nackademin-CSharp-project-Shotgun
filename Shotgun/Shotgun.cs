using System;
using System.Collections.Generic;
using System.Text;

namespace Shotgun
{
    class Shotgun
    {
        //Medlemsvariabler
        private Computer computer = new Computer();
        private int amountShots = 0;
        private bool gameIsOver = false;
        private state playerMove = state.none;
        private string result = "";
        
        //Enum typ
        private enum state
        {
            none,
            load,
            shoot,
            block,
            shotgun
        }

        public void evaluateRound()
        {
            Computer.state computerMove = computer.GetMove();

            switch (playerMove)
            {
                case state.load:
                    if(computerMove == Computer.state.shoot)
                    {
                        result = "Computer shot you. Game Over!";
                        gameIsOver = true;
                    }
                    else if (computerMove == Computer.state.load)
                    {
                        result = "Both players loading!";

                    }
                    else if (computerMove == Computer.state.block)
                    {
                        result = "Player was loading while computer was blocking";
                    }
                    break;
                case state.block:
                    if(computerMove == Computer.state.shoot)
                    {
                        result = "Computer shoot player. Player blocked.";
                    }
                    else if(computerMove == Computer.state.load)
                    {
                        result = "Player was blocking. Computer was loading.";
                    }
                    else if (computerMove == Computer.state.block)
                    {
                        result = "Both players were blocking.";
                    }
                    break;
                case state.shoot:
                    if (computerMove == Computer.state.shoot)
                    {
                        result = "Both players shoot";
                    }
                    else if (computerMove == Computer.state.load)
                    {
                        result = "Player shot while computer was loding. You won!";
                        gameIsOver = true;
                    }
                    else if (computerMove == Computer.state.block)
                    {
                        result = "Player shot computer. Computer blocked";
                    }
                    break;
                case state.shotgun:
                    if (computerMove == Computer.state.shotgun)
                    {
                        result = "Both players shot Shotgun. Game continues...";
                    }
                    else
                    {
                        result = "Players shot Shotgun. Computer is in Heaven.";
                        gameIsOver = true;
                    }
                    break;
            }
        }

        public bool GameIsOver()
        {
            return gameIsOver;
        }
        public string GetResult()
        {
            return result;
        }

        public Shotgun()
        {
            playerMove = state.shotgun;
            evaluateRound();
        }


        public void Block()
        {
            playerMove = state.block;
            evaluateRound();
        }

        public void Shoot()
        {
            if (HasAmmunition())
            {
                playerMove = state.shoot;
                evaluateRound();
            } 
        }

        public void Load()
        {
            playerMove = state.load;
            amountShots = amountShots + 1;
            evaluateRound();
        }

        public bool HasAmmunition()
        {
            if (amountShots > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ShotgunActive()
        {
            if (amountShots >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
