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
            string i= f_0.Text;

            //下面這段為測試用
            textBox10.Text = i.ToString();

            //首先的判斷式必須先確定i是否為空字串,則後面判斷i[0]時會因為讀不到而出錯
            if (i == "")
            {
                f_0.ResetText();
            }

            //test code
            /*else if (i[0] == color_B)
            {
                textBox9.Text = "hk";
                textBox11.BackColor = Color.Blue;
            }*/
            //這邊主要會卡住原因是因為如果裡面是空字串,則會產生錯誤,而改其他字元就不會
            
            else if (i[0] == color_W)
            {
                f_0.BackColor = Color.White;

            }else if (i[0] == color_R)
            {
                f_0.BackColor = Color.Red;
            }else if (i[0] == color_G)
            {
                f_0.BackColor = Color.Green;
            }else if (i[0] == color_B)
            {
                f_0.BackColor = Color.Blue;
            }else if (i[0] == color_Y)
            {
                f_0.BackColor = Color.Yellow;
            }else if (i[0] == color_O)
            {
                f_0.BackColor = Color.Orange;
            }
            
            
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
