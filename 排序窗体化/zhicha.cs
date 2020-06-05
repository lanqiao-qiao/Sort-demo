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
    public partial class zhicha : Form
    {
        int[][] a = new int[200][];
        int[] n = new int[200];
        int t = 0, tt = 1, jj = 0,ii=1,ttt=0;//ttt控制蓝标,tt控制红标
        int t_num = 0,num=0;

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Text = "下一步";
            if (t < num)
            {
                label11.Text = "红色为当前比较待替换项\n蓝色为本次比较项";
                if (ttt + 1 == tt)
                    label10.Text = "当前值为" + a[t][tt].ToString();
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;

                if (tt == 1)
                    label2.ForeColor = Color.Red;
                if (tt == 2)
                    label3.ForeColor = Color.Red;
                if (tt == 3)
                    label4.ForeColor = Color.Red;
                if (tt == 4)
                    label5.ForeColor = Color.Red;
                if (tt == 5)
                    label6.ForeColor = Color.Red;
                if (tt == 6)
                    label7.ForeColor = Color.Red;
                if (tt == 7)
                    label8.ForeColor = Color.Red;
                if (ttt == 0)
                    label1.ForeColor = Color.Blue;
                if (ttt == 1)
                    label2.ForeColor = Color.Blue;
                if (ttt == 2)
                    label3.ForeColor = Color.Blue;
                if (ttt == 3)
                    label4.ForeColor = Color.Blue;
                if (ttt == 4)
                    label5.ForeColor = Color.Blue;
                if (ttt == 5)
                    label6.ForeColor = Color.Blue;
                if (ttt == 6)
                    label7.ForeColor = Color.Blue;


                label1.Text = a[t][0].ToString();
                label2.Text = a[t][1].ToString();
                label3.Text = a[t][2].ToString();
                label4.Text = a[t][3].ToString();
                label5.Text = a[t][4].ToString();
                label6.Text = a[t][5].ToString();
                label7.Text = a[t][6].ToString();
                label8.Text = a[t][7].ToString();

                if (jj < n[ii])
                {
                    jj++;
                    ttt--;
                }
                else
                {
                    jj = 0;
                    tt++;
                    ii++;
                    ttt = tt - 1;
                }

                t++;
            }
            else
            {
                label9.Text = "排序完毕";
                label10.Text = "";
                label11.Text = "";
            }
                
        }

        int min = 9999, nt;
        public zhicha()
        {
            InitializeComponent();
        }

        private void Zhicha_Load(object sender, EventArgs e)
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
            string str;
            FileStream path0 = new FileStream("D:\\a_zhicha_n.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s0 = new StreamReader(path0);
            for(int i=1;i<8;i++)
            {
                str = s0.ReadLine();
                n[i] = int.Parse(str);
                t_num += n[i];
            }
            num = t_num + 8;
            FileStream path1 = new FileStream("D:\\a_zhicha.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s1 = new StreamReader(path1);
            for (int i = 0; i < num; i++)
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
            //label10.Text = t_num.ToString();
        }
    }
}
