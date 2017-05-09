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
        
        //這裡撰寫變色方法, 傳入(字串內容,物件本身)
        public static void color_change(string i, TextBox self)
        {
            char color_W = 'W', color_R = 'R', color_G = 'G', color_B = 'B', color_Y = 'Y', color_O = 'O';
            self.Text = self.Text.ToUpper();
            i = self.Text;
            if (i == "")
            {
                self.ResetText();
            }
            else if (i[0] == color_W)
            {
                self.BackColor = Color.White;

            }
            else if (i[0] == color_R)
            {
                self.BackColor = Color.Red;
            }
            else if (i[0] == color_G)
            {
                self.BackColor = Color.Green;
            }
            else if (i[0] == color_B)
            {
                self.BackColor = Color.Blue;
            }
            else if (i[0] == color_Y)
            {
                self.BackColor = Color.Yellow;
            }
            else if (i[0] == color_O)
            {
                self.BackColor = Color.Orange;
            }
            self.Text = "";  //消除文字

            //這邊之後應該還要再加"寫入矩陣"的功能

        }








        //以下函式為測試groupbox統一控制faces用 (失敗)
        private void Test_block_Enter(object sender, EventArgs e)
        {
            //下面定義一變數取得text_block裡面的控制項,最後進行類型篩選(TextBox)
            /*var test_faces = Test_block.Controls.OfType<TextBox>();
            foreach(TextBox chosen in test_faces)    //變數a可自行定義
            {
                
                chosen.Text = chosen.Text.ToUpper();
                string i = chosen.Text;

                if (i == "")
                {
                    chosen.ResetText();
                }
                else if (i[0] == color_W)
                {
                    chosen.BackColor = Color.White;

                }
                else if (i[0] == color_R)
                {
                    chosen.BackColor = Color.Red;
                }
                else if (i[0] == color_G)
                {
                    chosen.BackColor = Color.Green;
                }
                else if (i[0] == color_B)
                {
                    chosen.BackColor = Color.Blue;
                }
                else if (i[0] == color_Y)
                {
                    chosen.BackColor = Color.Yellow;
                }
                else if (i[0] == color_O)
                {
                    chosen.BackColor = Color.Orange;
                }
            }*/
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            color_change(f_0.Text,f_0);            
        }





        private void groupBox6_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
