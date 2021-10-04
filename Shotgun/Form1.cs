using System;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class Form1 : Form
    {
        //Instaniserar klassen Shotgun med variabeln shotgun.
        Shotgun shotgun = new Shotgun();
        
        //Formuläret Form1 metod som inistialiserar den.
        //Kör refreshView metoden vid start.
        public Form1()
        {
            InitializeComponent();
            refreshView();
        }


        //Metoden refreshView kollar följande:
        //Hämtar antal skott spelaren har från klassen shotgun (shotgun.GetAmmunition).
        //Om 3 eller fler skott finns blir knappen Shotgun klickbar.
        //Om fler än 0 skott finns blivk knappen Skjut klickbar.
        //Rubrikentexten uppdateras med hur många skott spelaren har.
        //Textrutan uppdateras med status efter varje händelse.
        public void refreshView()
        {
            //Get AmountShot
            //Enable or disable buttons shoot and shotgun
            int amountOfShots = shotgun.GetAmmunition();
            
            
            if(amountOfShots >= 3)
            {
                buttonShotgun.Enabled = true;
            }
            else if(amountOfShots > 0)
            {
                buttonShoot.Enabled = true;
            }
            else
            {
                buttonShotgun.Enabled = false;
                buttonShoot.Enabled = false;
            }
            labelPlayerBullet.Text = amountOfShots.ToString();
            labelComputerbullet.Text = shotgun.GetComputerAmmunition().ToString();
            textBoxMessage.Text = shotgun.GetResult();
            

            //Under metoden refreshView kollas status för om seplet är över med metoden GameIsOver
            //Om spelet är över, GmeIsOver är true sker följande:
            //En bild visas, knapparna för skjuta, shotgun, blocka och ladda blir icke-klickbara.
            //Knappen restart för att starta om spelet dyker upp.
            if (shotgun.GameIsOver())
            {
                pictureBoxGameOver.Visible = true;
                buttonShotgun.Enabled = false;
                buttonShoot.Enabled = false;
                buttonBlock.Enabled = false;
                buttonLoad.Enabled = false;
                buttonRestart.Visible = true;
            }
            return;
        }
        
        //Vad som sker när man klickar knappen Load.
        //Metoden Load i klassen shotgun körs.
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            shotgun.Load();
            refreshView();
        }

        //Vad som sker när man klickar knappen Shoot.
        //Metoden Shoot i klassen shotgun körs.
        private void buttonShoot_Click(object sender, EventArgs e)
        {
            shotgun.Shoot();
            refreshView();
        }

        //Vad som sker när man klickar knappen Block.
        //Metoden Block i klassen shotgun körs.
        private void buttonBlock_Click(object sender, EventArgs e)
        {
            shotgun.Block();
            refreshView();
        }

        //Vad som sker när man klickar knappen Shotgun.
        //Metoden Shotgun i klassen shotgun körs.
        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            shotgun.shootShotgun();
            refreshView();
        }

        //Vad som sker när man klickar knappen restart.
        //Ny instans av klassen Shotgun.
        //Knapparna Block och Load blir klickbara.
        //Bilden som visas när spelet är över och knappen restart blir dolda.
        //MEtoden refreshView körs.
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            shotgun = new Shotgun();
            buttonBlock.Enabled = true;
            buttonLoad.Enabled = true;
            pictureBoxGameOver.Visible = false;
            buttonRestart.Visible = false;
            refreshView();
        }
    }
}
