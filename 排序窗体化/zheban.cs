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
    public partial class zheban : Form
    {
        int[][] a = new int[200][];
        int[][] n = new int[200][];
        //int[] nn = new int[200];
        int t = 0, tt = 1, jj = 1;
        int num = 0;
        int min = 9999, nt;

        private void Button1_Click(object sender, EventArgs e)
        {
            if(t<num)
            {
                jj = n[t][2];
                label11.Text = "当前第" + (t + 1) + "步，共" + num + "步";
                button1.Text = "下一步";
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
                if (jj == 0)
                    label1.ForeColor = Color.Blue;
                if (jj == 1)
                    label2.ForeColor = Color.Blue;
                if (jj == 2)
                    label3.ForeColor = Color.Blue;
                if (jj == 3)
                    label4.ForeColor = Color.Blue;
                if (jj == 4)
                    label5.ForeColor = Color.Blue;
                if (jj == 5)
                    label6.ForeColor = Color.Blue;
                if (jj == 6)
                    label7.ForeColor = Color.Blue;
                if (jj == 7)
                    label8.ForeColor = Color.Blue;


                label1.Text = a[t][0].ToString();
                label2.Text = a[t][1].ToString();
                label3.Text = a[t][2].ToString();
                label4.Text = a[t][3].ToString();
                label5.Text = a[t][4].ToString();
                label6.Text = a[t][5].ToString();
                label7.Text = a[t][6].ToString();
                label8.Text = a[t][7].ToString();
                //label9.Text = n[t][0].ToString();
                //label10.Text = n[t][1].ToString();
                //label11.Text = n[t][2].ToString();
                label9.Text = "当前L=" + n[t][0] + " 当前R=" + n[t][1];
                label10.Text = "蓝色为M " + n[t][2];



                if(n[t][0]==n[t][1])
                {
                    tt++;
                }

                t++;
            }
            else
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label12.Text = "排序完毕";
                label1.Text = a[t][0].ToString();
                label2.Text = a[t][1].ToString();
                label3.Text = a[t][2].ToString();
                label4.Text = a[t][3].ToString();
                label5.Text = a[t][4].ToString();
                label6.Text = a[t][5].ToString();
                label7.Text = a[t][6].ToString();
                label8.Text = a[t][7].ToString();
            }
        }

        public zheban()
        {
            InitializeComponent();
        }

        private void Zheban_Load(object sender, EventArgs e)
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
            label14.BackColor = System.Drawing.Color.Transparent;
            label15.BackColor = System.Drawing.Color.Transparent;
            label16.BackColor = System.Drawing.Color.Transparent;
            label17.BackColor = System.Drawing.Color.Transparent;
            label18.BackColor = System.Drawing.Color.Transparent;
            label19.BackColor = System.Drawing.Color.Transparent;
            label20.BackColor = System.Drawing.Color.Transparent;
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
            FileStream path0 = new FileStream("D:\\a_zheban.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s0 = new StreamReader(path0);
            FileStream path1 = new FileStream("D:\\a_zheban_n.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s1 = new StreamReader(path1);
            FileStream path2 = new FileStream("D:\\a_zheban_num.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s2 = new StreamReader(path2);
            string s;
            s = s2.ReadLine();
            num = int.Parse(s);//获取个数
            for (int i = 0; i < num+1; i++)
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
            for (int i = 0; i < num; i++)
            {
                string[] x = s1.ReadLine().Split(' ');
                n[i] = new int[200];
                for (int j = 0; j < x.Length; j++)
                {
                    string x2 = x[j];
                    //label1.Text = x2;
                    n[i][j] = int.Parse(x2);
                }
            }
        }
    }
}
