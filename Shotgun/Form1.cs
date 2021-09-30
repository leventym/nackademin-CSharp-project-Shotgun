using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shotgun shotgun = new Shotgun();

            Shotgun startgame = new Shotgun();
            startgame.Load();
            textBoxMessage.Text = startgame.GetResult();
            startgame.Shoot();
            textBoxComputer.Text = startgame.GetResult();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
