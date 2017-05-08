using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicBube_Solution
{
    public partial class Form1 : Form
    {
        char color_W = 'W', color_R = 'R', color_G = 'G', color_B = 'B', color_Y = 'Y', color_O = 'O';

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            f_0.Text = f_0.Text.ToUpper();
            char i= f_0.Text[0];
            int c = 
            //這邊一直卡住，但把下邊運算式註解掉卻能跑＠＠　ＷＴＦ？？？

            /*if (i == color_W)
            {
                f_0.BackColor = Color.White;

            }else if (i == color_R)
            {
                f_0.BackColor = Color.Red;
            }else if (i == color_G)
            {
                f_0.BackColor = Color.Green;
            }else if (i == color_B)
            {
                f_0.BackColor = Color.Blue;
            }else if (i == color_Y)
            {
                f_0.BackColor = Color.Yellow;
            }else if (i == color_O)
            {
                f_0.BackColor = Color.Orange;
            }
            f_0.ResetText();*/
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
