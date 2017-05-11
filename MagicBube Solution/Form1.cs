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
        ****************************
        *** 執行步驟數、矩陣宣告 ***
        ****************************
        */
        int step_num = 0;
        List<char> steps = new List<char>();
        /*
        ********************************************************
        *** 這裡撰寫變色方法, 傳入(字串內容,物件本身) (成功) ***
        ********************************************************
        */
        public static void color_change(string i, TextBox self, ref string side)
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
                side = i;
                
            }
            else if (i[0] == color_R)
            {
                self.BackColor = Color.Red;
                side = i;
            }
            else if (i[0] == color_G)
            {
                self.BackColor = Color.Green;
                side = i;
            }
            else if (i[0] == color_B)
            {
                self.BackColor = Color.Blue;
                side = i;
            }
            else if (i[0] == color_Y)
            {
                self.BackColor = Color.Yellow;
                side = i;
            }
            else if (i[0] == color_O)
            {
                self.BackColor = Color.Orange;
                side = i;
            }
            self.Text = "";  //消除文字
        }

        /*
        *************************************
        ** 這裡撰寫矩陣 & 色塊同步更新方法 **
        *************************************
        */
        public void array_cube_update()
        {
            f_0.Text = F_side[0];
            f_1.Text = F_side[1];
            f_2.Text = F_side[2];
            f_3.Text = F_side[3];
            f_4.Text = F_side[4];
            f_5.Text = F_side[5];
            f_6.Text = F_side[6];
            f_7.Text = F_side[7];
            f_8.Text = F_side[8];

            b_0.Text = B_side[0];
            b_1.Text = B_side[1];
            b_2.Text = B_side[2];
            b_3.Text = B_side[3];
            b_4.Text = B_side[4];
            b_5.Text = B_side[5];
            b_6.Text = B_side[6];
            b_7.Text = B_side[7];
            b_8.Text = B_side[8];

            r_0.Text = R_side[0];
            r_1.Text = R_side[1];
            r_2.Text = R_side[2];
            r_3.Text = R_side[3];
            r_4.Text = R_side[4];
            r_5.Text = R_side[5];
            r_6.Text = R_side[6];
            r_7.Text = R_side[7];
            r_8.Text = R_side[8];

            l_0.Text = L_side[0];
            l_1.Text = L_side[1];
            l_2.Text = L_side[2];
            l_3.Text = L_side[3];
            l_4.Text = L_side[4];
            l_5.Text = L_side[5];
            l_6.Text = L_side[6];
            l_7.Text = L_side[7];
            l_8.Text = L_side[8];

            u_0.Text = U_side[0];
            u_1.Text = U_side[1];
            u_2.Text = U_side[2];
            u_3.Text = U_side[3];
            u_4.Text = U_side[4];
            u_5.Text = U_side[5];
            u_6.Text = U_side[6];
            u_7.Text = U_side[7];
            u_8.Text = U_side[8];

            d_0.Text = D_side[0];
            d_1.Text = D_side[1];
            d_2.Text = D_side[2];
            d_3.Text = D_side[3];
            d_4.Text = D_side[4];
            d_5.Text = D_side[5];
            d_6.Text = D_side[6];
            d_7.Text = D_side[7];
            d_8.Text = D_side[8];

        }


        /*
        *************************************************
        *** 這裡要撰寫 F,B,R,L,U,D 旋轉方法(皆順時針) ***
        *************************************************
        */
        /*
        *************
        ** F轉方法 **
        *************
        */
        public void f_turn(int times)
        {
            string[] x = new string[3];
            
            //防止倒轉負號錯誤
            if (times == -1)
            {
                times = 3;
            }else if (times == -2)
            {
                times = 2;
            }else if (times == -3)
            {
                times = 1;
            }

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
                
                //F面四橫面
                x[0] = R_side[0];
                x[1] = R_side[3];
                x[2] = R_side[6];

                R_side[0] = U_side[6];
                R_side[3] = U_side[7];
                R_side[6] = U_side[8];

                U_side[6] = L_side[8];
                U_side[7] = L_side[5];
                U_side[8] = L_side[2];

                L_side[8] = D_side[2];
                L_side[5] = D_side[1];
                L_side[2] = D_side[0];

                D_side[2] = x[0];
                D_side[1] = x[1];
                D_side[0] = x[2];
                //更新方法套入
                array_cube_update();

                step_num++;
                //steps[step_num - 1] = 'F';
                steps.Add('F');
                //info_box.AppendText("總共花了:" + step_num + " 個步驟" + Environment.NewLine);

                //這裡要寫SHOW出全部的LIST值
                /*foreach (char k in steps)
                {
                    info_box.AppendText(k.ToString() + " ");
                }
                info_box.AppendText(Environment.NewLine);*/
            }
        }
        /*
        *************
        ** B轉方法 **
        *************
        */
        public void b_turn(int times)
        {
            string[] x = new string[3];

            //防止倒轉負號錯誤
            if (times == -1)
            {
                times = 3;
            }
            else if (times == -2)
            {
                times = 2;
            }
            else if (times == -3)
            {
                times = 1;
            }
            for (int j = 0; j < times; j++)
            {
                //B面四角
                x[0] = B_side[0];
                B_side[0] = B_side[6];
                B_side[6] = B_side[8];
                B_side[8] = B_side[2];
                B_side[2] = x[0];

                //B面四邊
                x[0] = B_side[3];
                B_side[3] = B_side[7];
                B_side[7] = B_side[5];
                B_side[5] = B_side[1];
                B_side[1] = x[0];

                //B面四橫面
                x[0] = L_side[0];
                x[1] = L_side[3];
                x[2] = L_side[6];

                L_side[0] = U_side[2];
                L_side[3] = U_side[1];
                L_side[6] = U_side[0];

                U_side[2] = R_side[8];
                U_side[1] = R_side[5];
                U_side[0] = R_side[2];

                R_side[8] = D_side[6];
                R_side[5] = D_side[7];
                R_side[2] = D_side[8];

                D_side[6] = x[0];
                D_side[7] = x[1];
                D_side[8] = x[2];
                //更新方法套入
                array_cube_update();

                step_num++;
                //steps[step_num - 1] = 'B';
                steps.Add('B');
                //info_box.AppendText("總共花了:" + step_num + " 個步驟" + Environment.NewLine);

                //這裡要寫SHOW出全部的LIST值
                /*foreach (char k in steps)
                {
                    info_box.AppendText(k.ToString() + " ");
                }
                info_box.AppendText(Environment.NewLine);*/
            }
        }
        /*
        *************
        ** L轉方法 **
        *************
        */
        public void l_turn(int times)
        {
            string[] x = new string[3];

            //防止倒轉負號錯誤
            if (times == -1)
            {
                times = 3;
            }
            else if (times == -2)
            {
                times = 2;
            }
            else if (times == -3)
            {
                times = 1;
            }
            for (int j = 0; j < times; j++)
            {
                //L面四角
                x[0] = L_side[8];
                L_side[8] = L_side[2];
                L_side[2] = L_side[0];
                L_side[0] = L_side[6];
                L_side[6] = x[0];

                //L面四邊
                x[0] = L_side[5];
                L_side[5] = L_side[1];
                L_side[1] = L_side[3];
                L_side[3] = L_side[7];
                L_side[7] = x[0];

                //L面四橫面
                x[0] = F_side[0];
                x[1] = F_side[3];
                x[2] = F_side[6];

                F_side[0] = U_side[0];
                F_side[3] = U_side[3];
                F_side[6] = U_side[6];

                U_side[0] = B_side[0];
                U_side[3] = B_side[3];
                U_side[6] = B_side[6];

                B_side[0] = D_side[0];
                B_side[3] = D_side[3];
                B_side[6] = D_side[6];

                D_side[0] = x[0];
                D_side[3] = x[1];
                D_side[6] = x[2];
                //更新方法套入
                array_cube_update();

                step_num++;
                //steps[step_num - 1] = 'L';
                steps.Add('L');
                //info_box.AppendText("總共花了:" + step_num + " 個步驟" + Environment.NewLine);

                //這裡要寫SHOW出全部的LIST值
                /*foreach (char k in steps)
                {
                    info_box.AppendText(k.ToString() + " ");
                }
                info_box.AppendText(Environment.NewLine);*/
            }
        }
        /*
        *************
        ** R轉方法 **
        *************
        */
        public void r_turn(int times)
        {
            string[] x = new string[3];

            //防止倒轉負號錯誤
            if (times == -1)
            {
                times = 3;
            }
            else if (times == -2)
            {
                times = 2;
            }
            else if (times == -3)
            {
                times = 1;
            }
            for (int j = 0; j < times; j++)
            {
                //R面四角
                x[0] = R_side[8];
                R_side[8] = R_side[2];
                R_side[2] = R_side[0];
                R_side[0] = R_side[6];
                R_side[6] = x[0];

                //R面四邊
                x[0] = R_side[5];
                R_side[5] = R_side[1];
                R_side[1] = R_side[3];
                R_side[3] = R_side[7];
                R_side[7] = x[0];

                //R面四橫面
                x[0] = B_side[8];
                x[1] = B_side[5];
                x[2] = B_side[2];

                B_side[8] = U_side[8];
                B_side[5] = U_side[5];
                B_side[2] = U_side[2];

                U_side[8] = F_side[8];
                U_side[5] = F_side[5];
                U_side[2] = F_side[2];

                F_side[8] = D_side[8];
                F_side[5] = D_side[5];
                F_side[2] = D_side[2];

                D_side[8] = x[0];
                D_side[5] = x[1];
                D_side[2] = x[2];
                //更新方法套入
                array_cube_update();

                step_num++;
                //steps[step_num - 1] = 'R';
                steps.Add('R');
                //info_box.AppendText("總共花了:" + step_num + " 個步驟" + Environment.NewLine);

                //這裡要寫SHOW出全部的LIST值
                /*foreach (char k in steps)
                {
                    info_box.AppendText(k.ToString() + " ");
                }
                info_box.AppendText(Environment.NewLine);*/
            }
        }
        /*
        *************
        ** U轉方法 **
        *************
        */
        public void u_turn(int times)
        {
            string[] x = new string[3];

            //防止倒轉負號錯誤
            if (times == -1)
            {
                times = 3;
            }
            else if (times == -2)
            {
                times = 2;
            }
            else if (times == -3)
            {
                times = 1;
            }
            for (int j = 0; j < times; j++)
            {
                //U面四角
                x[0] = U_side[8];
                U_side[8] = U_side[2];
                U_side[2] = U_side[0];
                U_side[0] = U_side[6];
                U_side[6] = x[0];

                //U面四邊
                x[0] = U_side[5];
                U_side[5] = U_side[1];
                U_side[1] = U_side[3];
                U_side[3] = U_side[7];
                U_side[7] = x[0];

                //U面四橫面
                x[0] = R_side[2];
                x[1] = R_side[1];
                x[2] = R_side[0];

                R_side[2] = B_side[6];
                R_side[1] = B_side[7];
                R_side[0] = B_side[8];

                B_side[6] = L_side[2];
                B_side[7] = L_side[1];
                B_side[8] = L_side[0];

                L_side[2] = F_side[2];
                L_side[1] = F_side[1];
                L_side[0] = F_side[0];

                F_side[2] = x[0];
                F_side[1] = x[1];
                F_side[0] = x[2];
                //更新方法套入
                array_cube_update();

                step_num++;
                //steps[step_num - 1] = 'U';
                steps.Add('U');
                //info_box.AppendText("總共花了:" + step_num + " 個步驟" + Environment.NewLine);

                //這裡要寫SHOW出全部的LIST值
                /*foreach (char k in steps)
                {
                    info_box.AppendText(k.ToString() + " ");
                }
                info_box.AppendText(Environment.NewLine);*/
            }
        }
        /*
        *************
        ** D轉方法 **
        *************
        */
        public void d_turn(int times)
        {
            string[] x = new string[3];

            //防止倒轉負號錯誤
            if (times == -1)
            {
                times = 3;
            }
            else if (times == -2)
            {
                times = 2;
            }
            else if (times == -3)
            {
                times = 1;
            }
            for (int j = 0; j < times; j++)
            {
                //D面四角
                x[0] = D_side[8];
                D_side[8] = D_side[2];
                D_side[2] = D_side[0];
                D_side[0] = D_side[6];
                D_side[6] = x[0];

                //D面四邊
                x[0] = D_side[5];
                D_side[5] = D_side[1];
                D_side[1] = D_side[3];
                D_side[3] = D_side[7];
                D_side[7] = x[0];

                //D面四橫面
                x[0] = R_side[6];
                x[1] = R_side[7];
                x[2] = R_side[8];

                R_side[6] = F_side[6];
                R_side[7] = F_side[7];
                R_side[8] = F_side[8];

                F_side[6] = L_side[6];
                F_side[7] = L_side[7];
                F_side[8] = L_side[8];

                L_side[6] = B_side[2];
                L_side[7] = B_side[1];
                L_side[8] = B_side[0];

                B_side[2] = x[0];
                B_side[1] = x[1];
                B_side[0] = x[2];
                //更新方法套入
                array_cube_update();

                step_num++;
                //steps[step_num - 1] = 'D';
                steps.Add('D');
                //info_box.AppendText("總共花了:" + step_num + " 個步驟" + Environment.NewLine);

                //這裡要寫SHOW出全部的LIST值
                /*foreach (char k in steps)
                {
                    info_box.AppendText(k.ToString() + " ");
                }
                info_box.AppendText(Environment.NewLine);*/
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
            color_change(f_0.Text, f_0, ref F_side[0]);
        }

        private void f_1_TextChanged(object sender, EventArgs e)
        {
            color_change(f_1.Text, f_1, ref F_side[1]);
        }

        private void f_2_TextChanged(object sender, EventArgs e)
        {
            color_change(f_2.Text, f_2, ref F_side[2]);
        }

        private void f_3_TextChanged(object sender, EventArgs e)
        {
            color_change(f_3.Text, f_3, ref F_side[3]);
        }

        private void f_4_TextChanged(object sender, EventArgs e)
        {
            color_change(f_4.Text, f_4, ref F_side[4]);
        }

        private void f_5_TextChanged(object sender, EventArgs e)
        {
            color_change(f_5.Text, f_5, ref F_side[5]);
        }

        private void f_6_TextChanged(object sender, EventArgs e)
        {
            color_change(f_6.Text, f_6, ref F_side[6]);
        }

        private void f_7_TextChanged(object sender, EventArgs e)
        {
            color_change(f_7.Text, f_7, ref F_side[7]);
        }

        private void f_8_TextChanged(object sender, EventArgs e)
        {
            color_change(f_8.Text, f_8, ref F_side[8]);
        }
        //R面
        private void r_0_TextChanged(object sender, EventArgs e)
        {
            color_change(r_0.Text, r_0, ref R_side[0]);
        }

        private void r_1_TextChanged(object sender, EventArgs e)
        {
            color_change(r_1.Text, r_1, ref R_side[1]);
        }

        private void r_2_TextChanged(object sender, EventArgs e)
        {
            color_change(r_2.Text, r_2, ref R_side[2]);
        }

        private void r_3_TextChanged(object sender, EventArgs e)
        {
            color_change(r_3.Text, r_3, ref R_side[3]);
        }

        private void r_4_TextChanged(object sender, EventArgs e)
        {
            color_change(r_4.Text, r_4, ref R_side[4]);
        }

        private void r_5_TextChanged(object sender, EventArgs e)
        {
            color_change(r_5.Text, r_5, ref R_side[5]);
        }

        private void r_6_TextChanged(object sender, EventArgs e)
        {
            color_change(r_6.Text, r_6, ref R_side[6]);
        }

        private void r_7_TextChanged(object sender, EventArgs e)
        {
            color_change(r_7.Text, r_7, ref R_side[7]);
        }

        private void r_8_TextChanged(object sender, EventArgs e)
        {
            color_change(r_8.Text, r_8, ref R_side[8]);
        }
        //L面
        private void l_0_TextChanged(object sender, EventArgs e)
        {
            color_change(l_0.Text, l_0, ref L_side[0]);
        }

        private void l_1_TextChanged(object sender, EventArgs e)
        {
            color_change(l_1.Text, l_1, ref L_side[1]);
        }

        private void l_2_TextChanged(object sender, EventArgs e)
        {
            color_change(l_2.Text, l_2, ref L_side[2]);
        }

        private void l_3_TextChanged(object sender, EventArgs e)
        {
            color_change(l_3.Text, l_3, ref L_side[3]);
        }

        private void l_4_TextChanged(object sender, EventArgs e)
        {
            color_change(l_4.Text, l_4, ref L_side[4]);
        }

        private void l_5_TextChanged(object sender, EventArgs e)
        {
            color_change(l_5.Text, l_5, ref L_side[5]);
        }

        private void l_6_TextChanged(object sender, EventArgs e)
        {
            color_change(l_6.Text, l_6, ref L_side[6]);
        }

        private void l_7_TextChanged(object sender, EventArgs e)
        {
            color_change(l_7.Text, l_7, ref L_side[7]);
        }

        private void l_8_TextChanged(object sender, EventArgs e)
        {
            color_change(l_8.Text, l_8, ref L_side[8]);
        }
        //D面
        private void d_0_TextChanged(object sender, EventArgs e)
        {
            color_change(d_0.Text, d_0, ref D_side[0]);
        }

        private void d_1_TextChanged(object sender, EventArgs e)
        {
            color_change(d_1.Text, d_1, ref D_side[1]);
        }

        private void d_2_TextChanged(object sender, EventArgs e)
        {
            color_change(d_2.Text, d_2, ref D_side[2]);
        }

        private void d_3_TextChanged(object sender, EventArgs e)
        {
            color_change(d_3.Text, d_3, ref D_side[3]);
        }

        private void d_4_TextChanged(object sender, EventArgs e)
        {
            color_change(d_4.Text, d_4, ref D_side[4]);
        }

        private void d_5_TextChanged(object sender, EventArgs e)
        {
            color_change(d_5.Text, d_5, ref D_side[5]);
        }

        private void d_6_TextChanged(object sender, EventArgs e)
        {
            color_change(d_6.Text, d_6, ref D_side[6]);
        }

        private void d_7_TextChanged(object sender, EventArgs e)
        {
            color_change(d_7.Text, d_7, ref D_side[7]);
        }

        private void d_8_TextChanged(object sender, EventArgs e)
        {
            color_change(d_8.Text, d_8, ref D_side[8]);
        }
        //U面
        private void u_0_TextChanged(object sender, EventArgs e)
        {
            color_change(u_0.Text, u_0, ref U_side[0]);
        }

        private void u_1_TextChanged(object sender, EventArgs e)
        {
            color_change(u_1.Text, u_1, ref U_side[1]);
        }

        private void u_2_TextChanged(object sender, EventArgs e)
        {
            color_change(u_2.Text, u_2, ref U_side[2]);
        }

        private void u_3_TextChanged(object sender, EventArgs e)
        {
            color_change(u_3.Text, u_3, ref U_side[3]);
        }

        private void u_4_TextChanged(object sender, EventArgs e)
        {
            color_change(u_4.Text, u_4, ref U_side[4]);
        }

        private void u_5_TextChanged(object sender, EventArgs e)
        {
            color_change(u_5.Text, u_5, ref U_side[5]);
        }

        private void u_6_TextChanged(object sender, EventArgs e)
        {
            color_change(u_6.Text, u_6, ref U_side[6]);
        }

        private void u_7_TextChanged(object sender, EventArgs e)
        {
            color_change(u_7.Text, u_7, ref U_side[7]);
        }

        private void u_8_TextChanged(object sender, EventArgs e)
        {
            color_change(u_8.Text, u_8, ref U_side[8]);
        }
        //B面
        private void b_0_TextChanged(object sender, EventArgs e)
        {
            color_change(b_0.Text, b_0, ref B_side[0]);
        }

        private void b_1_TextChanged(object sender, EventArgs e)
        {
            color_change(b_1.Text, b_1, ref B_side[1]);
        }

        private void b_2_TextChanged(object sender, EventArgs e)
        {
            color_change(b_2.Text, b_2, ref B_side[2]);
        }

        private void b_3_TextChanged(object sender, EventArgs e)
        {
            color_change(b_3.Text, b_3, ref B_side[3]);
        }

        private void b_4_TextChanged(object sender, EventArgs e)
        {
            color_change(b_4.Text, b_4, ref B_side[4]);
        }

        private void b_5_TextChanged(object sender, EventArgs e)
        {
            color_change(b_5.Text, b_5, ref B_side[5]);
        }

        private void b_6_TextChanged(object sender, EventArgs e)
        {
            color_change(b_6.Text, b_6, ref B_side[6]);
        }

        private void b_7_TextChanged(object sender, EventArgs e)
        {
            color_change(b_7.Text, b_7, ref B_side[7]);
        }

        private void b_8_TextChanged(object sender, EventArgs e)
        {
            color_change(b_8.Text, b_8, ref B_side[8]);
        }


        /*
        ***************
        *** F轉按鈕 ***
        ***************
        */
        private void F_Click(object sender, EventArgs e)
        {
            f_turn(1);
            trace_back.Enabled = true;
        }
        /*
        ***************
        *** B轉按鈕 ***
        ***************
        */
        private void B_Click(object sender, EventArgs e)
        {
            b_turn(1);
            trace_back.Enabled = true;
        }
        /*
        ***************
        *** R轉按鈕 ***
        ***************
        */
        private void R_Click_1(object sender, EventArgs e)
        {
            r_turn(1);
            trace_back.Enabled = true;
        }
        /*
        ***************
        *** L轉按鈕 ***
        ***************
        */
        private void L_Click_1(object sender, EventArgs e)
        {
            l_turn(1);
            trace_back.Enabled = true;
        }
        /*
        ***************
        *** U轉按鈕 ***
        ***************
        */
        private void U_Click(object sender, EventArgs e)
        {
            u_turn(1);
            trace_back.Enabled = true;
        }
        /*
        ***************
        *** D轉按鈕 ***
        ***************
        */
        private void D_Click(object sender, EventArgs e)
        {
            d_turn(1);
            trace_back.Enabled = true;
        }
        /*
        ****************
        *** 復原按鈕 ***
        ****************
        */
        private void return_to_default_Click(object sender, EventArgs e)
        {
            for(int i = 0;i< F_side.Length; i++)
            {
                F_side[i] = "W";
                B_side[i] = "O";
                R_side[i] = "R";
                L_side[i] = "B";
                U_side[i] = "Y";
                D_side[i] = "G";
            }
            array_cube_update();

            step_num = 0;
            steps.Clear();
            info_box.Clear();
            trace_back.Enabled = false;


        }
        /*
        ****************
        *** 回朔按鈕 ***
        ****************
        */
        private void trace_back_Click(object sender, EventArgs e)
        {
           
            //info_box.AppendText((steps[step_num-1]).ToString());
            //將步驟倒回去看
            List<string> trace_back_steps = new List<string>();
            for (int i = step_num-1; i >=0; i--)
            {
                switch (steps[i])
                {
                    case 'F':
                        f_turn(-1);
                        trace_back_steps.Add("F(-1)");
                        //Task.Delay(1).Wait();         //這邊原本想讓色塊有時間跑，但是還是追不上，太快了！！
                        break;

                    case 'B':
                        b_turn(-1);
                        trace_back_steps.Add("B(-1)");
                        //Task.Delay(1).Wait();
                        break;

                    case 'R':
                        r_turn(-1);
                        trace_back_steps.Add("R(-1)");
                        //Task.Delay(1).Wait();
                        break;

                    case 'L':
                        l_turn(-1);
                        trace_back_steps.Add("L(-1)");
                        //Task.Delay(1).Wait();
                        break;

                    case 'U':
                        u_turn(-1);
                        trace_back_steps.Add("U(-1)");
                        //Task.Delay(1).Wait();
                        break;

                    case 'D':
                        d_turn(-1);
                        trace_back_steps.Add("D(-1)");
                        //Task.Delay(1).Wait();
                        break;
                }
            }
            steps.Clear();
            trace_back.Enabled = false;
            step_num = 0;
            //以下為顯示"回朔步驟數"與"回朔步驟"
            info_box.AppendText("共有：" + trace_back_steps.Count + " 個步驟" + Environment.NewLine);
            info_box.AppendText("步驟為：");
            foreach(string k in trace_back_steps)
            {
                info_box.AppendText(k + " ");
            }
            info_box.AppendText(Environment.NewLine);

        }
    }
}
