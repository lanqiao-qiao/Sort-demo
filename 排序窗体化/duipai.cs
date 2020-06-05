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
    public partial class duipai : Form
    {
        int[][] a = new int[200][];
        //int[][] n = new int[200][];
        int[] n = new int[200];
        int t = 0, tt = -1, jj =-1, jjj = 0;
        int num1 = 0,num2=0,num;
        int min = 9999, nt;

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label9.Text ="";
            if (t<num1+num2+1)
            {
                label13.Text = "第" + (t+1) + "步，共" + (num1 + num2+1) + "步";
                label11.Text = "当前步判断蓝色项是否比子项大";
                button1.Text = "下一步";
                if(label1.ForeColor!=Color.Red)
                    label1.ForeColor = Color.Black;
                if (label2.ForeColor != Color.Red)
                    label2.ForeColor = Color.Black;
                if (label3.ForeColor != Color.Red)
                    label3.ForeColor = Color.Black;
                if (label4.ForeColor != Color.Red)
                    label4.ForeColor = Color.Black;
                if (label5.ForeColor != Color.Red)
                    label5.ForeColor = Color.Black;
                if (label6.ForeColor != Color.Red)
                    label6.ForeColor = Color.Black;
                if (label7.ForeColor != Color.Red)
                    label7.ForeColor = Color.Black;
                if (label8.ForeColor != Color.Red)
                    label8.ForeColor = Color.Black;


                if (t == num1 - 1)
                    label9.Text = "最小堆构建完成\n开始堆排序";
                if(t<num1)
                {
                    tt = n[t];

                }
                if(t>=num1)
                {
                    label12.Text = "红色为已排序";
                    if(n[t]<10)
                    {
                        tt = n[t];
                    }
                    else
                    {
                        jj = n[t] / 10;
                    }
                }
                if (jj == 0)
                    label1.ForeColor = Color.Red;
                if (jj == 1)
                    label2.ForeColor = Color.Red;
                if (jj == 2)
                    label3.ForeColor = Color.Red;
                if (jj == 3)
                    label4.ForeColor = Color.Red;
                if (jj == 4)
                    label5.ForeColor = Color.Red;
                if (jj == 5)
                    label6.ForeColor = Color.Red;
                if (jj == 6)
                    label7.ForeColor = Color.Red;
                if (jj == 7)
                    label8.ForeColor = Color.Red;

                if (tt == 0)
                    label1.ForeColor = Color.Blue;
                if (tt == 1)
                    label2.ForeColor = Color.Blue;
                if (tt == 2)
                    label3.ForeColor = Color.Blue;
                if (tt == 3)
                    label4.ForeColor = Color.Blue;
                if (tt == 4)
                    label5.ForeColor = Color.Blue;
                if (tt == 5)
                    label6.ForeColor = Color.Blue;
                if (tt == 6)
                    label7.ForeColor = Color.Blue;
                if (tt == 7)
                    label8.ForeColor = Color.Blue;


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
                label1.ForeColor = Color.Red;
                label10.Text = "排序完毕";
            }
        }

        int x, y;
        int q = 0;
        int nnn;
        public duipai()
        {
            InitializeComponent();
        }

        private void Duipai_Load(object sender, EventArgs e)
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
            label12.BackColor = System.Drawing.Color.Transparent;
            label13.BackColor = System.Drawing.Color.Transparent;
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
            label12.Text = "";
            label13.Text = "";
            FileStream path0 = new FileStream("D:\\a_duipai.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s0 = new StreamReader(path0);
            FileStream path1 = new FileStream("D:\\a_duipai_n.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s1 = new StreamReader(path1);
            FileStream path2 = new FileStream("D:\\a_duipai_num.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s2 = new StreamReader(path2);
            string s;
            num1 = int.Parse(s1.ReadLine()) - 1;
            num2 = int.Parse(s1.ReadLine());
            for (int i = 0; i < num1+num2+1; i++)
            {
                string[] x = s0.ReadLine().Split(' ');
                a[i] = new int[200];
                for (int j = 0; j < x.Length; j++)
                {
                    string x2 = x[j];
                    //label1.Text = x2;
                    a[i][j] = int.Parse(x2);
                }
            }
            for(int i=0;i<num1+num2;i++)
            {
                s = s2.ReadLine();
                n[i] = int.Parse(s);
            }
        }
    }
}
