using System;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class Form1 : Form
    {
        //Instaniserar klassen Shotgun
        Shotgun shotgun = new Shotgun();
        public Form1()
        {
            InitializeComponent();
            refreshView();
        }
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
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            shotgun.Load();
            refreshView();
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            shotgun.Shoot();
            refreshView();
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            shotgun.Block();
            refreshView();
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            shotgun.shootShotgun();
            refreshView();
        }

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
