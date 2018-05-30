using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        private Form1 a;
        public Form3(Form1 T)
        {
            a = T;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a.getTurnLine() < Convert.ToInt32(textBox1.Text)){
                DialogResult ans = MessageBox.Show("行数跳过了总行数", "记事本-跳行", MessageBoxButtons.OK);
            }
            else
                a.setCursor(Convert.ToInt32(textBox1.Text));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
