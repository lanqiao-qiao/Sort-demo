using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 排序窗体化
{
    public partial class Form2 : Form
    {
        int[][] a = new int[200][];
        int t = 0,tt=0,jj=7;
        int num = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            label8.BackColor = System.Drawing.Color.Transparent;
            label9.BackColor = System.Drawing.Color.Transparent;
            label10.BackColor = System.Drawing.Color.Transparent;
            label11.BackColor = System.Drawing.Color.Transparent;
            label12.BackColor = System.Drawing.Color.Transparent;
            label13.BackColor = System.Drawing.Color.Transparent;
            label14.BackColor = System.Drawing.Color.Transparent;
            label15.BackColor = System.Drawing.Color.Transparent;
            label16.BackColor = System.Drawing.Color.Transparent;
            label17.BackColor = System.Drawing.Color.Transparent;
            label18.BackColor = System.Drawing.Color.Transparent;
            label19.BackColor = System.Drawing.Color.Transparent;
            label20.BackColor = System.Drawing.Color.Transparent;
            label21.BackColor = System.Drawing.Color.Transparent;
            label22.BackColor = System.Drawing.Color.Transparent;
            label23.BackColor = System.Drawing.Color.Transparent;
            label24.BackColor = System.Drawing.Color.Transparent;
            label25.BackColor = System.Drawing.Color.Transparent;
            label26.BackColor = System.Drawing.Color.Transparent;
            label27.BackColor = System.Drawing.Color.Transparent;
            label28.BackColor = System.Drawing.Color.Transparent;
            label29.BackColor = System.Drawing.Color.Transparent;


            string str;
            FileStream path0 = new FileStream("D:\\a_maopao_n.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s0 = new StreamReader(path0);
            str = s0.ReadLine();
            num = int.Parse(str);
            s0.Close();
            FileStream path1 = new FileStream("D:\\a_maopao.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s1 = new StreamReader(path1);
            for(int i=0;i<num;i++)
            {
                string[] x=s1.ReadLine().Split(' ');
                a[i] = new int[200];
                for(int j=0;j<x.Length;j++)
                {
                    string x2 = x[j];
                    //label1.Text = x2;
                    a[i][j] = int.Parse(x2);
                }
            }
            //pictureBox1.SendToBack();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label19.ForeColor = Color.Black;
            label20.ForeColor = Color.Black;
            label21.ForeColor = Color.Black;
            label22.ForeColor = Color.Black;
            label23.ForeColor = Color.Black;
            label24.ForeColor = Color.Black;
            label25.ForeColor = Color.Black;
            label26.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            if (tt==0)
            {
                label19.ForeColor = Color.Blue;
                label20.ForeColor = Color.Blue;
            }
            if (tt == 1)
            {
                label20.ForeColor = Color.Blue;
                label21.ForeColor = Color.Blue;
            }
            if (tt == 2)
            {
                label21.ForeColor = Color.Blue;
                label22.ForeColor = Color.Blue;
            }
            if (tt == 3)
            {
                label22.ForeColor = Color.Blue;
                label23.ForeColor = Color.Blue;
            }
            if (tt == 4)
            {
                label23.ForeColor = Color.Blue;
                label24.ForeColor = Color.Blue;
            }
            if (tt == 5)
            {
                label24.ForeColor = Color.Blue;
                label25.ForeColor = Color.Blue;
            }
            if (tt == 6)
            {
                label25.ForeColor = Color.Blue;
                label26.ForeColor = Color.Blue;
            }
            button1.Text = "下一步";
            if (t < num)
            {
                label10.Text = "第" + (t+1).ToString() + "步： 共"+num.ToString()+"步";
                label1.Text = a[t][0].ToString();
                label2.Text = a[t][1].ToString();
                label3.Text = a[t][2].ToString();
                label4.Text = a[t][3].ToString();
                label5.Text = a[t][4].ToString();
                label6.Text = a[t][5].ToString();
                label7.Text = a[t][6].ToString();
                label8.Text = a[t][7].ToString();
                
                if(t!=0&&t<num-1)
                {
                    if (a[t][0] != a[t-1][0])
                        label1.ForeColor = Color.Red;
                    else
                        label1.ForeColor = Color.Black;
                    if (a[t][1] != a[t - 1][1])
                        label2.ForeColor = Color.Red;
                    else
                        label2.ForeColor = Color.Black;
                    if (a[t][2] != a[t - 1][2])
                        label3.ForeColor = Color.Red;
                    else
                        label3.ForeColor = Color.Black;
                    if (a[t][3] != a[t - 1][3])
                        label4.ForeColor = Color.Red;
                    else
                        label4.ForeColor = Color.Black;
                    if (a[t][4] != a[t - 1][4])
                        label5.ForeColor = Color.Red;
                    else
                        label5.ForeColor = Color.Black;
                    if (a[t][5] != a[t - 1][5])
                        label6.ForeColor = Color.Red;
                    else
                        label6.ForeColor = Color.Black;
                    if (a[t][6] != a[t - 1][6])
                        label7.ForeColor = Color.Red;
                    else
                        label7.ForeColor = Color.Black;
                    if (a[t][7] != a[t - 1][7])
                        label8.ForeColor = Color.Red;
                    else
                        label8.ForeColor = Color.Black;
                }
                if(t>0)
                {
                    label11.Text = a[t-1][0].ToString();
                    label12.Text = a[t-1][1].ToString();
                    label13.Text = a[t-1][2].ToString();
                    label14.Text = a[t-1][3].ToString();
                    label15.Text = a[t-1][4].ToString();
                    label16.Text = a[t-1][5].ToString();
                    label17.Text = a[t-1][6].ToString();
                    label18.Text = a[t-1][7].ToString();
                }
                t++;
                tt++;
                if (tt == jj)
                {
                    tt = 0;
                    jj--;
                }
            }
            else
                label9.Text = "排序完毕";

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
