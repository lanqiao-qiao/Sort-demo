using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 排序窗体化
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)//直接排序
        {
            Form2 f1 = new Form2();
            f1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)//简单选择排序
        {
            Form f3 = new Form3();
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form f4 = new zhicha();
            f4.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form f5 = new shell();
            f5.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form f6 = new zheban();
            f6.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form f7 = new kuaipai();
            f7.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Form f8 = new duipai();
            f8.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("lan_qiao做于20.06.04，感谢阿龙阿楠支持", "制作信息，鸣谢");
        }
    }
}
