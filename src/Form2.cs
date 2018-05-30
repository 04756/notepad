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

    public partial class Form2 : Form
    {
        private Form1 a;

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                a.setStart();
            a.Find();
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            a.setStartZero();   
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            a.Replace(textBoxReplace.Text);
        }

        public void setFindText(string t)
        {
            textBoxFind.Text = t;
        }

        public String getFindText()
        {
            return textBoxFind.Text;
        }

        public void setA(Form1 b, int flag)
        {
            this.a = b;
            if(flag == 1)
            {
                radioButton1.Hide();
                radioButton2.Hide();
                groupBox1.Hide();
                this.Text = "替换";
               
            }
            else
            {
                buttonReplace.Hide();
                buttonReplaceAll.Hide();
                this.Text = "查找";
            }
        }

        private void buttonReplaceAll_Click(object sender, EventArgs e)
        {
            while (a.Replace(textBoxReplace.Text)) ;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                a.setStart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
