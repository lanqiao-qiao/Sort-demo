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
    public partial class shell : Form
    {
        int[][] a = new int[200][];
        int[] n = new int[200];
        int[] nn = new int[200];
        int t = 0, tt = 1, jj = 1;
        int num = 0;
        int min = 9999, nt;

        private void Button1_Click(object sender, EventArgs e)
        {
            if (t < num)
            {

                button1.Text = "下一步";
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;

                if (t < nn[7])
                    tt = 7;
                if (t < nn[6])
                    tt = 6;
                if (t < nn[5])
                    tt = 5;
                if (t < nn[4])
                    tt = 4;
                if (t < nn[3])
                    tt = 3;
                if (t < nn[2])
                    tt = 2;
                if (t < nn[1])
                    tt = 1;

                if(tt==1)
                    jj = t;
                if (tt == 2)
                    jj = t - nn[1];
                if (tt == 3)
                    jj = t - nn[2];
                if (tt == 4)
                    jj = t - nn[3];
                if (tt == 5)
                    jj = t - nn[4];
                if (tt == 6)
                    jj = t - nn[5];
                if (tt == 7)
                    jj = t - nn[6];

                if (tt == 1 || tt == 2 || t == 3 || tt == 4)
                    nt = 4;
                if (tt == 5 || tt == 6)
                    nt = 2;
                if (tt == 7)
                    nt = 1;
                label9.Text = "当前每组个数: " + (n[tt]+1).ToString() + "\n总步骤，第" + (t + 1).ToString() + "步，共" + num.ToString() + "步";
                label10.Text = "第"+(jj + 1).ToString()+"步 / 共" +n[tt].ToString()+"步";

                if (tt==1)
                {
                    label1.ForeColor = Color.Red;
                    label5.ForeColor = Color.Red;
                }
                if (tt == 2)
                {
                    label2.ForeColor = Color.Red;
                    label6.ForeColor = Color.Red;
                }
                if (tt == 3)
                {
                    label3.ForeColor = Color.Red;
                    label7.ForeColor = Color.Red;
                }
                if (tt == 4)
                {
                    label4.ForeColor = Color.Red;
                    label8.ForeColor = Color.Red;
                }
                if(tt==5)
                {
                    label1.ForeColor = Color.Red;
                    label3.ForeColor = Color.Red;
                    label5.ForeColor = Color.Red;
                    label7.ForeColor = Color.Red;
                }
                if(tt==6)
                {
                    label2.ForeColor = Color.Red;
                    label4.ForeColor = Color.Red;
                    label6.ForeColor = Color.Red;
                    label8.ForeColor = Color.Red;
                }
                if(tt==7)
                {
                    label1.ForeColor = Color.Red;
                    label3.ForeColor = Color.Red;
                    label5.ForeColor = Color.Red;
                    label7.ForeColor = Color.Red;
                    label2.ForeColor = Color.Red;
                    label4.ForeColor = Color.Red;
                    label6.ForeColor = Color.Red;
                    label8.ForeColor = Color.Red;
                }

                label1.Text = a[t][0].ToString();
                label2.Text = a[t][1].ToString();
                label3.Text = a[t][2].ToString();
                label4.Text = a[t][3].ToString();
                label5.Text = a[t][4].ToString();
                label6.Text = a[t][5].ToString();
                label7.Text = a[t][6].ToString();
                label8.Text = a[t][7].ToString();

                

                t++;
            }
            else
            {
                label11.Text = "排序完毕";
            }
        }

        public shell()
        {
            InitializeComponent();
        }

        private void Shell_Load(object sender, EventArgs e)
        {
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
            button1.Text = "开始";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            nn[0] = 0;
            string str;
            FileStream path0 = new FileStream("D:\\a_shell_n.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s0 = new StreamReader(path0);
            for(int i=1;i<8;i++)
            {
                str = s0.ReadLine();
                n[i] = int.Parse(str);
                num += n[i];
                nn[i] = n[i] + nn[i - 1];
            }
            s0.Close();
            FileStream path1 = new FileStream("D:\\a_shell.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s1 = new StreamReader(path1);
            for(int i=0;i<num;i++)
            {
                string[] x = s1.ReadLine().Split(' ');
                a[i] = new int[200];
                for (int j = 0; j < x.Length; j++)
                {
                    string x2 = x[j];
                    //label1.Text = x2;
                    a[i][j] = int.Parse(x2);
                }
            }
        }
    }
}
