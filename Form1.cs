using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKAssignment2_re_
{
    public partial class Form1 : Form
    {
        bool Player1 = true;
        bool Player2 = false;
        private Image X = Properties.Resources.X;
        private Image O = Properties.Resources.O;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Player1 == true)
            {
                //Player1 = true;
                btn1.BackgroundImage = X;
                Player1 = false;
                btn1.Enabled = false;
            }
            else
            {
                Player2 = true;
                btn1.BackgroundImage = O;
                Player2 = false;
                Player1 = true;
                btn1.Enabled = false;
            }
            Wincombination();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Player1 == true)
            {
                //Player1 = true;
                btn2.BackgroundImage = X;
                Player1 = false;
                btn2.Enabled = false;
            }
            else
            {
                Player2 = true;
                btn2.BackgroundImage = O;
                Player2 = false;
                Player1 = true;
                btn2.Enabled = false;
            }
            Wincombination();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Player1 == true)
            {
                //Player1 = true;
                btn3.BackgroundImage = X;
                Player1 = false;
                btn3.Enabled = false;
            }
            else
            {
                Player2 = true;
                btn3.BackgroundImage = O;
                Player2 = false;
                Player1 = true;
                btn3.Enabled = false;
            }
            Wincombination();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Player1 == true)
            {
                //Player1 = true;
                btn4.BackgroundImage = X;
                Player1 = false;
                btn4.Enabled = false;
            }
            else
            {
                Player2 = true;
                btn4.BackgroundImage = O;
                Player2 = false;
                Player1 = true;
                btn4.Enabled = false;
            }
            Wincombination();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Player1 == true)
            {
                //Player1 = true;
                btn5.BackgroundImage = X;
                Player1 = false;
                btn5.Enabled = false;
            }
            else
            {
                Player2 = true;
                btn5.BackgroundImage = O;
                Player2 = false;
                Player1 = true;
                btn5.Enabled = false;
            }
            Wincombination();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Player1 == true)
            {
                //Player1 = true;
                btn6.BackgroundImage = X;
                Player1 = false;
                btn6.Enabled = false;
            }
            else
            {
                Player2 = true;
                btn6.BackgroundImage = O;
                Player2 = false;
                Player1 = true;
                btn6.Enabled = false;
            }
            Wincombination();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Player1 == true)
            {
                //Player1 = true;
                btn7.BackgroundImage = X;
                Player1 = false;
                btn7.Enabled = false;
            }
            else
            {
                Player2 = true;
                btn7.BackgroundImage = O;
                Player2 = false;
                Player1 = true;
                btn7.Enabled = false;
            }
            Wincombination();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Player1 == true)
            {
                //Player1 = true;
                btn8.BackgroundImage = X;
                Player1 = false;
                btn8.Enabled = false;
            }
            else
            {
                Player2 = true;
                btn8.BackgroundImage = O;
                Player2 = false;
                Player1 = true;
                btn8.Enabled = false;
            }
            Wincombination();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Player1 == true)
            {
                //Player1 = true;
                btn9.BackgroundImage = X;
                Player1 = false;
                btn9.Enabled = false;
            }
            else
            {
                Player2 = true;
                btn9.BackgroundImage = O;
                Player2 = false;
                Player1 = true;
                btn9.Enabled = false;
            }
            Wincombination();
        }

        private void Wincombination()
        {
            //X
            if (btn1.BackgroundImage == X && btn2.BackgroundImage == X && btn3.BackgroundImage == X)
            {
                xWin();
                reset();
            }
            if (btn4.BackgroundImage == X && btn5.BackgroundImage == X && btn6.BackgroundImage == X)
            {
                xWin();
                reset();
            }
            if (btn7.BackgroundImage == X && btn8.BackgroundImage == X && btn9.BackgroundImage == X)
            {
                xWin();
                reset();
            }
            if (btn1.BackgroundImage == X && btn5.BackgroundImage == X && btn9.BackgroundImage == X)
            {
                xWin();
                reset();
            }
            if (btn3.BackgroundImage == X && btn5.BackgroundImage == X && btn7.BackgroundImage == X)
            {
                xWin();
                reset();
            }
            if (btn1.BackgroundImage == X && btn4.BackgroundImage == X && btn7.BackgroundImage == X)
            {
                xWin();
                reset();
            }
            if (btn2.BackgroundImage == X && btn5.BackgroundImage == X && btn8.BackgroundImage == X)
            {
                xWin();
                reset();
            }
            if (btn3.BackgroundImage == X && btn6.BackgroundImage == X && btn9.BackgroundImage == X)
            {
                xWin();
                reset();
            }

            //O
            if (btn1.BackgroundImage == O && btn2.BackgroundImage == O && btn3.BackgroundImage == O)
            {
                oWin();
                reset();
            }
            if (btn4.BackgroundImage == O && btn5.BackgroundImage == O && btn6.BackgroundImage == O)
            {
                oWin();
                reset();
            }
            if (btn7.BackgroundImage == O && btn8.BackgroundImage == O && btn9.BackgroundImage == O)
            {
                oWin();
                reset();
            }

            if (btn1.BackgroundImage == O && btn5.BackgroundImage == O && btn9.BackgroundImage == O)
            {
                oWin();
                reset();
            }
            if (btn3.BackgroundImage == O && btn5.BackgroundImage == O && btn7.BackgroundImage == O)
            {
                oWin();
                reset();
            }

            if (btn1.BackgroundImage == O && btn4.BackgroundImage == O && btn7.BackgroundImage == O)
            {
                oWin();
                reset();
            }
            if (btn2.BackgroundImage == O && btn5.BackgroundImage == O && btn8.BackgroundImage == O)
            {
                oWin();
                reset();
            }
            if (btn3.BackgroundImage == O && btn6.BackgroundImage == O && btn9.BackgroundImage == O)
            {
                oWin();
                reset();
            }
            // tie
           
            if (btn1.Enabled != true && btn2.Enabled!=true && btn3.Enabled != true
                && btn4.Enabled != true && btn5.Enabled != true && btn6.Enabled != true
                && btn7.Enabled != true && btn8.Enabled != true && btn9.Enabled != true)
            {
                tie();
                reset();
            }
        }

        private void xWin()
        {
            MessageBox.Show("X Win!", "Game over", MessageBoxButtons.OK);
        }
        private void oWin()
        {
            MessageBox.Show("O Win!", "Game over", MessageBoxButtons.OK);
        }
        private void tie()
        {     
                MessageBox.Show("Tie!", "Game over", MessageBoxButtons.OK);
        }

        private void reset()
        {
            btn1.BackgroundImage = null;
            btn2.BackgroundImage = null;
            btn3.BackgroundImage = null;
            btn4.BackgroundImage = null;
            btn5.BackgroundImage = null;
            btn6.BackgroundImage = null;
            btn7.BackgroundImage = null;
            btn8.BackgroundImage = null;
            btn9.BackgroundImage = null;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

        }
    }
}
