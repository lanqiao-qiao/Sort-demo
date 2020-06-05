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
    public partial class kuaipai : Form
    {
        int[][] a = new int[200][];
        int[][] n = new int[200][];
        int[] nn = new int[200];
        int t = 0, tt = 0, jj = 1,jjj=0;
        int num = 0;
        int min = 9999, nt;
        int x, y;
        int q = 0;
        int nnn;

        private void Button1_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            if (t<num)
            {
                if(q==0)
                {
                    jjj = n[t][0];
                    q = 1;
                    label12.Text = "当前初始L：" + n[t][0] + "\n当前初始R:" + n[t][1];
                }
                button1.Text = "开始";
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label1.BackColor = label9.BackColor;
                label2.BackColor = label9.BackColor;
                label3.BackColor = label9.BackColor;
                label4.BackColor = label9.BackColor;
                label5.BackColor = label9.BackColor;
                label6.BackColor = label9.BackColor;
                label7.BackColor = label9.BackColor;
                label8.BackColor = label9.BackColor;
                if(tt==nn[jj]-1)
                {
                    label11.Text = "下步交换l,r的值";
                }
                if (tt==nn[jj-1])
                {
                    jj++;
                    tt = 0;
                    //label11.Text = "此步交换";
                }
                label1.Text = a[jj][0].ToString();
                label2.Text = a[jj][1].ToString();
                label3.Text = a[jj][2].ToString();
                label4.Text = a[jj][3].ToString();
                label5.Text = a[jj][4].ToString();
                label6.Text = a[jj][5].ToString();
                label7.Text = a[jj][6].ToString();
                label8.Text = a[jj][7].ToString();
                //label9.Text = n[t][0].ToString();
                //label10.Text = n[t][1].ToString();
                x = n[t][0];
                y = n[t][1];

                if (jjj == 0)
                    label1.BackColor = Color.Gray;
                if (jjj == 1)
                    label2.BackColor = Color.Gray;
                if (jjj == 2)
                    label3.BackColor = Color.Gray;
                if (jjj == 3)
                    label4.BackColor = Color.Gray;
                if (jjj == 4)
                    label5.BackColor = Color.Gray;
                if (jjj == 5)
                    label6.BackColor = Color.Gray;
                if (jjj == 6)
                    label7.BackColor = Color.Gray;
                if (jjj == 7)
                    label8.BackColor = Color.Gray;
                if (x == 0)
                    label1.ForeColor = Color.Red;
                if (x == 1)
                    label2.ForeColor = Color.Red;
                if (x == 2)
                    label3.ForeColor = Color.Red;
                if (x == 3)
                    label4.ForeColor = Color.Red;
                if (x == 4)
                    label5.ForeColor = Color.Red;
                if (x == 5)
                    label6.ForeColor = Color.Red;
                if (x == 6)
                    label7.ForeColor = Color.Red;
                if (x == 7)
                    label8.ForeColor = Color.Red;

                if (y == 0)
                    label1.ForeColor = Color.Red;
                if (y == 1)
                    label2.ForeColor = Color.Red;
                if (y == 2)
                    label3.ForeColor = Color.Red;
                if (y == 3)
                    label4.ForeColor = Color.Red;
                if (y == 4)
                    label5.ForeColor = Color.Red;
                if (y == 5)
                    label6.ForeColor = Color.Red;
                if (y == 6)
                    label7.ForeColor = Color.Red;
                if (y == 7)
                    label8.ForeColor = Color.Red;
                if (x == y && x == 0)
                    label1.ForeColor = Color.Purple;
                if (x == y && x == 1)
                    label2.ForeColor = Color.Purple;
                if (x == y && x == 2)
                    label3.ForeColor = Color.Purple;
                if (x == y && x == 3)
                    label4.ForeColor = Color.Purple;
                if (x == y && x == 4)
                    label5.ForeColor = Color.Purple;
                if (x == y && x == 5)
                    label6.ForeColor = Color.Purple;
                if (x == y && x == 6)
                    label7.ForeColor = Color.Purple;
                if (x == y && x == 7)
                    label8.ForeColor = Color.Purple;
                if (x == y)
                {
                    
                   
                    label11.Text = "此步若基准值大于紫色值，则两者交换";
                    q = 0;
                }
                    





                t++;
                tt++;
            }
            else
            {
                label13.Text = "排序完毕";
                label1.Text = a[nnn+1][0].ToString();
                label2.Text = a[nnn+1][1].ToString();
                label3.Text = a[nnn+1][2].ToString();
                label4.Text = a[nnn + 1][3].ToString();
                label5.Text = a[nnn + 1][4].ToString();
                label6.Text = a[nnn + 1][5].ToString();
                label7.Text = a[nnn + 1][6].ToString();
                label8.Text = a[nnn + 1][7].ToString();
            }
        }

        public kuaipai()
        {
            InitializeComponent();
        }

        private void Kuaipai_Load(object sender, EventArgs e)
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
            label13.Text = "";
            FileStream path0 = new FileStream("D:\\a_kuaipai.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s0 = new StreamReader(path0);
            FileStream path1 = new FileStream("D:\\a_kuaipai_n.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s1 = new StreamReader(path1);
            FileStream path2 = new FileStream("D:\\a_kuaipai_num.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s2 = new StreamReader(path2);
            FileStream path3 = new FileStream("D:\\a_kuaipai_nn.txt", FileMode.Open, FileAccess.Read);//c#的文件输入流
            StreamReader s3 = new StreamReader(path3);
            string s;
            s = s3.ReadLine();
            nnn = int.Parse(s);
            for (int i = 0; i < nnn+2; i++)
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
            for (int i = 0; i < nnn; i++)
            {
                s = s2.ReadLine();
                nn[i] = int.Parse(s);
                num =num+ nn[i];
            }
            for(int i=0;i<num;i++)
            {
                string[] x = s1.ReadLine().Split(' ');
                n[i] = new int[200];
                for (int j = 0; j < 2; j++)
                {
                    string x2 = x[j];
                    //label1.Text = x2;
                    n[i][j] = int.Parse(x2);
                }
            }
            label1.Text = a[0][0].ToString();
            label2.Text = a[0][1].ToString();
            label3.Text = a[0][2].ToString();
            label4.Text = a[0][3].ToString();
            label5.Text = a[0][4].ToString();
            label6.Text = a[0][5].ToString();
            label7.Text = a[0][6].ToString();
            label8.Text = a[0][7].ToString();
        }
    }
}
