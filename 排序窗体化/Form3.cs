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
    public partial class Form3 : Form
    {
        int[][] a = new int[200][];
        int t = 0, tt = 1, jj = 1;
        int num = 0;
        int min=9999,nt;

        private void Form3_Load(object sender, EventArgs e)
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
            

            string str;
            FileStream path0 = new FileStream("D:\\a_maopao_n.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s0 = new StreamReader(path0);
            str = s0.ReadLine();
            num = int.Parse(str)+1;
            //num++;
            s0.Close();
            FileStream path1 = new FileStream("D:\\a_jiandan.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
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
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Text = "下一步";
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
            label13.ForeColor = Color.Black;
            label14.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
            label16.ForeColor = Color.Black;
            label17.ForeColor = Color.Black;
            label18.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label20.Text = "";




            if (t < num)
            {
                if (tt == 8)
                {
                    jj++;
                    tt = jj;
                    min = 9999;
                    label20.Text = "此步进行交换";
                }
                min = Math.Min(min, a[t][tt]);
                label19.Text = "当前最小值为:"+min.ToString();

                if (jj == 1)
                    label1.ForeColor = Color.Blue;
                if (jj == 2)
                    label2.ForeColor = Color.Blue;
                if (jj == 3)
                    label3.ForeColor = Color.Blue;
                if (jj == 4)
                    label4.ForeColor = Color.Blue;
                if (jj == 5)
                    label5.ForeColor = Color.Blue;
                if (jj == 6)
                    label6.ForeColor = Color.Blue;
                if (jj == 7)
                    label7.ForeColor = Color.Blue;


                if (tt == 0)
                    label11.ForeColor = Color.Red;
                if (tt == 1)
                    label12.ForeColor = Color.Red;
                if (tt == 2)
                    label13.ForeColor = Color.Red;
                if (tt == 3)
                    label14.ForeColor = Color.Red;
                if (tt == 4)
                    label15.ForeColor = Color.Red;
                if (tt == 5)
                    label16.ForeColor = Color.Red;
                if (tt == 6)
                    label17.ForeColor = Color.Red;
                if (tt == 7)
                    label18.ForeColor = Color.Red;

                label10.Text = "第" + (t + 1).ToString() + "步： 共" + num.ToString() + "步";
                label1.Text = a[t][0].ToString();
                label2.Text = a[t][1].ToString();
                label3.Text = a[t][2].ToString();
                label4.Text = a[t][3].ToString();
                label5.Text = a[t][4].ToString();
                label6.Text = a[t][5].ToString();
                label7.Text = a[t][6].ToString();
                label8.Text = a[t][7].ToString();
                t++;
                tt++;
            }
            else
            {
                label9.Text = "排序完毕";
                label8.ForeColor = Color.Blue;
            }
                
           
        }
    }
}
