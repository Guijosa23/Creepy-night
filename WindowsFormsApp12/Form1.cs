using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        int scene = 1;

        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            double diceValue = randGen.Next(1, 101);

            if (e.KeyCode == Keys.R)
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 3)
                {
                    if (diceValue <= 70)
                    {
                        scene = 3;
                    }
                    else { scene = 2; }
                }
                else if (scene == 2) { scene = 5; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 10) { scene = 11; }
                else if (scene == 12) { scene = 15; }
                else if (scene == 15) { scene = 17; }
                else if (scene == 16) { scene = 19; }

            }
                       
            if (e.KeyCode == Keys.Y)
            {
                if (scene == 1) { scene = 3; }
                else if (scene == 2)
                {
                    if (diceValue <= 70)
                    {
                        scene = 2;
                    }    
                    else { scene = 3; }
                }     
                else if (scene == 2) { scene = 4; }
                else if (scene == 6) { scene = 8; }
                else if (scene == 8) { scene = 10; }
                else if (scene == 10) { scene = 12; }
                else if (scene == 12) { scene = 14; }
                else if (scene == 15) { scene = 16; }
                else if (scene == 16) { scene = 18; }





            }
        }
    }
}
