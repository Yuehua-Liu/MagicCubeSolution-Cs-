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
        /*
        *******************************
        *** 魔術方塊矩陣宣告 + 預設 ***
        *******************************
        */
        string[] F_side = new string[9] {"W", "W", "W", "W", "W", "W", "W", "W", "W"};
        string[] B_side = new string[9] {"O", "O", "O", "O", "O", "O", "O", "O", "O"};
        string[] R_side = new string[9] {"R", "R", "R", "R", "R", "R", "R", "R", "R"};
        string[] L_side = new string[9] {"B", "B", "B", "B", "B", "B", "B", "B", "B"};
        string[] U_side = new string[9] {"Y", "Y", "Y", "Y", "Y", "Y", "Y", "Y", "Y"};
        string[] D_side = new string[9] {"G", "G", "G", "G", "G", "G", "G", "G", "G"};


        /*
        ********************************************************
        *** 這裡撰寫變色方法, 傳入(字串內容,物件本身) (成功) ***
        ********************************************************
        */
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

            /*
            *************************************************
            ***    這邊之後應該還要再加"寫入矩陣"的功能   ***
            *************************************************
            */


        }

        /*
        ***************************************
        *** 這裡要撰寫 F,B,R,L,U,D 旋轉方法 ***
        ***************************************
        */
        public void f_turn(int times)
        {
            string[] x = new string[1];
            for(int j=0; j<times; j++)
            {
                //F面四角
                x[0] = F_side[8];
                F_side[8] = F_side[2];
                F_side[2] = F_side[0];
                F_side[0] = F_side[6];
                F_side[6] = x[0];
                //F面四邊
                x[0] = F_side[5];
                F_side[5] = F_side[1];
                F_side[1] = F_side[3];
                F_side[3] = F_side[7];
                F_side[7] = x[0];

            }
        }


        public Form1()
        {
            InitializeComponent();
        }



        /*
        ************************************
        *** 這邊進行每個色塊方法引用設定 ***
        ************************************        
        */
        //F面
        private void f_0_TextChanged(object sender, EventArgs e)
        {
            color_change(f_0.Text, f_0);
        }

        private void f_1_TextChanged(object sender, EventArgs e)
        {
            color_change(f_1.Text, f_1);
        }

        private void f_2_TextChanged(object sender, EventArgs e)
        {
            color_change(f_2.Text, f_2);
        }

        private void f_3_TextChanged(object sender, EventArgs e)
        {
            color_change(f_3.Text, f_3);
        }

        private void f_4_TextChanged(object sender, EventArgs e)
        {
            color_change(f_4.Text, f_4);
        }

        private void f_5_TextChanged(object sender, EventArgs e)
        {
            color_change(f_5.Text, f_5);
        }

        private void f_6_TextChanged(object sender, EventArgs e)
        {
            color_change(f_6.Text, f_6);
        }

        private void f_7_TextChanged(object sender, EventArgs e)
        {
            color_change(f_7.Text, f_7);
        }

        private void f_8_TextChanged(object sender, EventArgs e)
        {
            color_change(f_8.Text, f_8);
        }
        //R面
        private void r_0_TextChanged(object sender, EventArgs e)
        {
            color_change(r_0.Text, r_0);
        }

        private void r_1_TextChanged(object sender, EventArgs e)
        {
            color_change(r_1.Text, r_1);
        }

        private void r_2_TextChanged(object sender, EventArgs e)
        {
            color_change(r_2.Text, r_2);
        }

        private void r_3_TextChanged(object sender, EventArgs e)
        {
            color_change(r_3.Text, r_3);
        }

        private void r_4_TextChanged(object sender, EventArgs e)
        {
            color_change(r_4.Text, r_4);
        }

        private void r_5_TextChanged(object sender, EventArgs e)
        {
            color_change(r_5.Text, r_5);
        }

        private void r_6_TextChanged(object sender, EventArgs e)
        {
            color_change(r_6.Text, r_6);
        }

        private void r_7_TextChanged(object sender, EventArgs e)
        {
            color_change(r_7.Text, r_7);
        }

        private void r_8_TextChanged(object sender, EventArgs e)
        {
            color_change(r_8.Text, r_8);
        }
        //L面
        private void l_0_TextChanged(object sender, EventArgs e)
        {
            color_change(l_0.Text, l_0);
        }

        private void l_1_TextChanged(object sender, EventArgs e)
        {
            color_change(l_1.Text, l_1);
        }

        private void l_2_TextChanged(object sender, EventArgs e)
        {
            color_change(l_2.Text, l_2);
        }

        private void l_3_TextChanged(object sender, EventArgs e)
        {
            color_change(l_3.Text, l_3);
        }

        private void l_4_TextChanged(object sender, EventArgs e)
        {
            color_change(l_4.Text, l_4);
        }

        private void l_5_TextChanged(object sender, EventArgs e)
        {
            color_change(l_5.Text, l_5);
        }

        private void l_6_TextChanged(object sender, EventArgs e)
        {
            color_change(l_6.Text, l_6);
        }

        private void l_7_TextChanged(object sender, EventArgs e)
        {
            color_change(l_7.Text, l_7);
        }

        private void l_8_TextChanged(object sender, EventArgs e)
        {
            color_change(l_8.Text, l_8);
        }
        //D面
        private void d_0_TextChanged(object sender, EventArgs e)
        {
            color_change(d_0.Text, d_0);
        }

        private void d_1_TextChanged(object sender, EventArgs e)
        {
            color_change(d_1.Text, d_1);
        }

        private void d_2_TextChanged(object sender, EventArgs e)
        {
            color_change(d_2.Text, d_2);
        }

        private void d_3_TextChanged(object sender, EventArgs e)
        {
            color_change(d_3.Text, d_3);
        }

        private void d_4_TextChanged(object sender, EventArgs e)
        {
            color_change(d_4.Text, d_4);
        }

        private void d_5_TextChanged(object sender, EventArgs e)
        {
            color_change(d_5.Text, d_5);
        }

        private void d_6_TextChanged(object sender, EventArgs e)
        {
            color_change(d_6.Text, d_6);
        }

        private void d_7_TextChanged(object sender, EventArgs e)
        {
            color_change(d_7.Text, d_7);
        }

        private void d_8_TextChanged(object sender, EventArgs e)
        {
            color_change(d_8.Text, d_8);
        }
        //U面
        private void u_0_TextChanged(object sender, EventArgs e)
        {
            color_change(u_0.Text, u_0);
        }

        private void u_1_TextChanged(object sender, EventArgs e)
        {
            color_change(u_1.Text, u_1);
        }

        private void u_2_TextChanged(object sender, EventArgs e)
        {
            color_change(u_2.Text, u_2);
        }

        private void u_3_TextChanged(object sender, EventArgs e)
        {
            color_change(u_3.Text, u_3);
        }

        private void u_4_TextChanged(object sender, EventArgs e)
        {
            color_change(u_4.Text, u_4);
        }

        private void u_5_TextChanged(object sender, EventArgs e)
        {
            color_change(u_5.Text, u_5);
        }

        private void u_6_TextChanged(object sender, EventArgs e)
        {
            color_change(u_6.Text, u_6);
        }

        private void u_7_TextChanged(object sender, EventArgs e)
        {
            color_change(u_7.Text, u_7);
        }

        private void u_8_TextChanged(object sender, EventArgs e)
        {
            color_change(u_8.Text, u_8);
        }
        //B面
        private void b_0_TextChanged(object sender, EventArgs e)
        {
            color_change(b_0.Text, b_0);
        }

        private void b_1_TextChanged(object sender, EventArgs e)
        {
            color_change(b_1.Text, b_1);
        }

        private void b_2_TextChanged(object sender, EventArgs e)
        {
            color_change(b_2.Text, b_2);
        }

        private void b_3_TextChanged(object sender, EventArgs e)
        {
            color_change(b_3.Text, b_3);
        }

        private void b_4_TextChanged(object sender, EventArgs e)
        {
            color_change(b_4.Text, b_4);
        }

        private void b_5_TextChanged(object sender, EventArgs e)
        {
            color_change(b_5.Text, b_5);
        }

        private void b_6_TextChanged(object sender, EventArgs e)
        {
            color_change(b_6.Text, b_6);
        }

        private void b_7_TextChanged(object sender, EventArgs e)
        {
            color_change(b_7.Text, b_7);
        }

        private void b_8_TextChanged(object sender, EventArgs e)
        {
            color_change(b_8.Text, b_8);
        }





    }
}
