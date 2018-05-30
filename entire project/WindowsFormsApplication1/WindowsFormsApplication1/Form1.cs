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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string FileName = "";
        private Form2 a;
        private Form3 turn;
        private bool ifSave = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "无标题";
            TextSize();
            timer1.Interval = 5000;
            //newToolS.Image = Image.FromFile("E:/yhy/网站工作/保护区/images/1.jpg");
        }

        private void TextSize()
        {
            txtBox.Top = menuStrip1.Height;
            txtBox.Height = this.Height - menuStrip1.Height;
            txtBox.Left = 0;
            txtBox.Width = this.Width;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            TextSize();
        }
        
        private void cancelToolS_Click(object sender, EventArgs e)
        {
            txtBox.Undo();
        }

        private void cutToolS_Click(object sender, EventArgs e)
        {
            txtBox.Cut();
        }

        private void copyToolS_Click(object sender, EventArgs e)
        {
            txtBox.Copy();
        }

        private void pasteToolS_Click(object sender, EventArgs e)
        {
            txtBox.Paste();
        }

        private void delToolS_Click(object sender, EventArgs e)
        {
            txtBox.SelectedText = "";
        }

        private void findToolS_Click(object sender, EventArgs e)
        {
            a = new Form2();
            a.Show();
            a.setA(this,0);
        }

        public Form1 getFormAdress()
        {
            return this;
        }

        int[] prestart = new int [1000];
        int start = 0;
        int index = 0;
        public void setStartZero()
        {
            start = 0;
            for (int i = 0; i < 1000; ++i)
                prestart[i] = 0;
        }
        public void setStart()
        {
            if (index > 1 && index < 1000)
            {
                start = prestart[index - 1];
                --index;
            }
            else if (index == 0)
                start = prestart[index] = 0;

        }
        public void Find()
        {
            if(start>0)
            start = txtBox.Text.IndexOf(a.getFindText(),start);
            if (prestart[index] != start)
            {
                prestart[index] = start;
                if (index < 999)
                    ++index;
            }
            if (start >= 0)
            {
                txtBox.SelectionStart = start;
                txtBox.SelectionLength = a.getFindText().Length;
                ++start;
            }
        }

        public bool Replace(string Replacetext)
        {
            if(txtBox.SelectedText=="")
            this.Find();
            if (prestart[index] != start)
            {
                prestart[index] = start-1;
            }
            if (txtBox.SelectedText != "")
            {
                txtBox.SelectedText = Replacetext;
                return true;
            }
            return false;
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            ifSave = false;
        }

        private void findNextToolS_Click(object sender, EventArgs e)
        {
            if (a!=null&&a.getFindText() != "")
            {
                this.Find();
            }
            else
            {
                a = new Form2();
                a.Show();
                a.setA(this,0);
            }

        }

        private void replaceToolS_Click(object sender, EventArgs e)
        {
            a = new Form2();
            a.setA(this,1);
            a.Show();
            if (txtBox.SelectedText != "")
                a.setFindText(txtBox.SelectedText);
        }

        private void newToolS_Click(object sender, EventArgs e)
        {
          
            ifSaveChange();
            FileName = "";
            this.Text = "无标题";
            txtBox.Text = "";
        }
        private void noNameSave()
        {
            saveFileDialog1.Filter = "*.txt|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) ;
            else
            {
                this.Text = saveFileDialog1.FileName;
                FileName = this.Text;
                saveFile();
            }
        }
        private void saveNew()
        {
            DialogResult ans = MessageBox.Show("是否将更改保存到无标题？", "记事本", MessageBoxButtons.YesNoCancel);
            if (ans == DialogResult.OK)
                noNameSave();
            else if (ans == DialogResult.Cancel) ;
            else
                txtBox.Text = "";
            ifSave = true;
        }

        private void saveToolS_Click(object sender, EventArgs e)
        {
            if (FileName == "")
            {
                noNameSave();
            }
            else
            saveFile();
        }

        public void saveFile()
        {
            if (FileName != "")
                this.Text = FileName;
            else
                FileName = "*.txt";
            StreamWriter filewrite = new StreamWriter(FileName, false, Encoding.Default);
            IFormatProvider tcontro= filewrite.FormatProvider;
            String[] temp = txtBox.Text.Split('\n');
            for (int i = 0; i < txtBox.Lines.Length; ++i)
            {
                filewrite.WriteLine(temp[i]);
            }
            filewrite.Close();
            ifSave = true;
        }
        
        private void ifSaveChange()
        {
            if (ifSave == false && this.Text == "无标题"&&txtBox.Text=="")
                saveNew();
            else if (ifSave == false && this.Text != "无标题")
            {
                DialogResult ans = MessageBox.Show("是否将更改保存文件", "记事本", MessageBoxButtons.YesNoCancel);
                if (ans == DialogResult.OK)
                {
                    saveFile();
                }
            }
        }

        private void openToolS_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            ifSaveChange();
            openFileDialog1.Filter = "*.txt文件|*.txt|*.doc文件|*.doc|*.docx文件|*/docx";
            openFileDialog1.ShowDialog();
            FileName = openFileDialog1.FileName;
            StreamReader fileread = new StreamReader(FileName,Encoding.Default);
            txtBox.Text = fileread.ReadToEnd();
            fileread.Close();
            this.Text = FileName;
            ifSave = true;
        }

        private void saveAsToolS_Click(object sender, EventArgs e)
        {
            noNameSave();
        }

        private void turnToolS_Click(object sender, EventArgs e)
        {
            turn = new Form3(this);
            turn.Show();
        }

        public int getTurnLine()
        {
            return txtBox.Lines.Length;
        }

        public int getLineHeight()
        {
            return txtBox.Font.Height;
        }

        public void setCursor(int t)
        {
            txtBox.Focus();
            txtBox.SelectionStart = txtBox.GetFirstCharIndexFromLine(t);
        }

        private void trunPageToolS_Click(object sender, EventArgs e)
        {
            if (txtBox.WordWrap == false)
                txtBox.WordWrap = true;
            else
                txtBox.WordWrap = false;
        }

        private void FontToolS_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtBox.SelectionFont = fontDialog1.Font;
        }

        private void txtBox_TextChanged_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (txtBox.Text != ""){
                ifSave = false;
                findNextToolS.Enabled = true;
                findToolS.Enabled = true;
            }
            else
            {
                copyToolS.Enabled = false;
                cutToolS.Enabled = false;
                delToolS.Enabled = false;
                findNextToolS.Enabled = false;
                findToolS.Enabled = false;
            }
        }

        private void exitToolS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectAllToolS_Click(object sender, EventArgs e)
        {
            txtBox.SelectAll();
        }

        private void dateToolS_Click(object sender, EventArgs e)
        {
            txtBox.Text = DateTime.Now.ToString();
        }

        private void txtBox_SelectionChanged(object sender, EventArgs e)
        {
            if (txtBox.SelectedText != "")
            {
                copyToolS.Enabled = true;
                cutToolS.Enabled = true;
                delToolS.Enabled = true;
            }
        }
        int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = i/10.0;
            --i;
            if (i == 0)
                this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
