

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

        public Shotgun()
        {
        }


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
                        result = "Both player and computer are loading!";

                    }
                    else if (computerMove == Computer.state.block)
                    {
                        result = "Player was loading while computer was blocking";
                    }
                    else if (computerMove == Computer.state.shotgun)
                    {
                        result = "Computer shot Shotgun. Player is killed.";
                        gameIsOver = true;
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
                    else if (computerMove == Computer.state.shotgun)
                    {
                        result = "Computer shot Shotgun. Player is killed.";
                        gameIsOver = true;
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
                    else if (computerMove == Computer.state.shotgun)
                    {
                        result = "Computer shot Shotgun. Player is killed.";
                        gameIsOver = true;
                    }
                    break;
                case state.shotgun:
                    if (computerMove == Computer.state.shotgun)
                    {
                        result = "Both players shot Shotgun. Game continues...";
                    }
                    else
                    {
                        result = "Player shot Shotgun. Computer is in Heaven.";
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

        public void Block()
        {
            playerMove = state.block;
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

        public void Shoot()
        {
            if (HasAmmunition())
            {
                playerMove = state.shoot;
                amountShots = amountShots - 1;
                evaluateRound();
            } 
        }

        public void Load()
        {
            playerMove = state.load;
            amountShots = amountShots + 1;
            evaluateRound();
        }

        public int GetAmmunition()
        {
            return amountShots;
        }

        public int GetComputerAmmunition()
        {
            return computer.GetAmmunition();
        }

        public void shootShotgun()
        {
            playerMove = state.shotgun;
            amountShots = amountShots -3;
            evaluateRound();
        }

        /*
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
        */
    }
}
