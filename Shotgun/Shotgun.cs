

namespace Shotgun
{
    class Shotgun
    {
        //Private instans av klassen Computer skapas och tilldelas till variablen computer
        private Computer computer = new Computer();

        //Medlemsvariabler
        private int amountShots = 0;
        private bool gameIsOver = false;
        private state playerMove = state.none;
        private string result = "";

        //Konstruktorn
        public Shotgun()
        {
        }


        //Enum klassvariabler
        private enum state
        {
            none,
            load,
            shoot,
            block,
            shotgun
        }

        //Metod som definierar vad som händer varje gång en handling sker.
        //Metoden börjar med att hämta datorns handling.
        //Metoden innehåller switch-sats som definierar vad som händer under varje situation i spelet.
        //T.ex. om spelaren laddar kan datorn göra förljande: skjuta, ladda, blocka eller skjuta Shotgun.
        //Flaggan gameIsOver blir true om någon spelar "dör"
        //Sedan roterar switch-satsen baserat på vad spelaren utför för handling, .tex. block.
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
                        result = "Computer shot player. Player blocked.";
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
                        result = "Both players shot";
                    }
                    else if (computerMove == Computer.state.load)
                    {
                        result = "Player shot while computer was loading. You won!";
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

        //Metod som returnerna bool/flagga gameIsOver.
        public bool GameIsOver()
        {
            return gameIsOver;
        }
        //Metod som returnerar strängvärde result.
        public string GetResult()
        {
            return result;
        }

        //Metod som tilldelar spelarens handling (state) till variabeln playerMove.
        //Metod evaluateRound körs.
        public void Block()
        {
            playerMove = state.block;
            evaluateRound();
        }

        //Metoden returnerar bool/flagga för om spelaren har skott.
        //Metoden utvärderar om antal skott är mer än 0 (true) eller inte (false).
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

        //Metoden utvärderar vad som sker efter spelaren har skjutit ett skott.
        //Kollar om spelare skott att skjuta med.
        //Om spelar har skott att skjuta med tilldelas den handlingen (state.shoot) till variabeln playerMove.
        //Antalet skott minskas med ett (-1).
        //Metoden evaluateRound körs.
        public void Shoot()
        {
            if (HasAmmunition())
            {
                playerMove = state.shoot;
                amountShots = amountShots - 1;
                evaluateRound();
            } 
        }

        //Metoden utvärderar vad som sker när man laddar (Load).
        //Handlingen ladda, state.load, tilldelas till  variabeln playerMove.
        //Antal skott ökar med ett (+1).
        //Metoden evaluateRound körs.
        public void Load()
        {
            playerMove = state.load;
            amountShots = amountShots + 1;
            evaluateRound();
        }

        //Metoden returnerar siffervärde med variablen amountShots (anatal skott).
        public int GetAmmunition()
        {
            return amountShots;
        }

        //Metoden returnerar siffervärde med datorns antal skott. 
        public int GetComputerAmmunition()
        {
            return computer.GetAmmunition();
        }

        //Metoden utvärderar vad som sker när man skjutit Shotgun
        //Handlingen shotgun tilldelas till variabeln playerMove
        //Spelarens antal skott minskas med tre (-3).
        //Metoden evaluateRound körs.

        public void shootShotgun()
        {
            playerMove = state.shotgun;
            amountShots = amountShots -3;
            evaluateRound();
        }
    }
}
