namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSetUpToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.turnToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.trunPageToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolS = new System.Windows.Forms.ToolStripMenuItem();
            this.watchMenuS = new System.Windows.Forms.ToolStripMenuItem();
            this.状态栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuS = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于记事本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolS,
            this.editToolS,
            this.typeToolS,
            this.watchMenuS,
            this.helpMenuS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(653, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolS
            // 
            this.fileToolS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolS,
            this.openToolS,
            this.saveToolS,
            this.saveAsToolS,
            this.toolStripMenuItem1,
            this.pageSetUpToolS,
            this.printToolS,
            this.toolStripMenuItem2,
            this.exitToolS});
            this.fileToolS.Name = "fileToolS";
            this.fileToolS.Size = new System.Drawing.Size(58, 21);
            this.fileToolS.Text = "文件(F)";
            // 
            // newToolS
            // 
            this.newToolS.BackColor = System.Drawing.SystemColors.Control;
            this.newToolS.Name = "newToolS";
            this.newToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolS.Size = new System.Drawing.Size(183, 22);
            this.newToolS.Text = "新建(N)...";
            this.newToolS.Click += new System.EventHandler(this.newToolS_Click);
            // 
            // openToolS
            // 
            this.openToolS.Name = "openToolS";
            this.openToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolS.Size = new System.Drawing.Size(183, 22);
            this.openToolS.Text = "打开(O)...";
            this.openToolS.Click += new System.EventHandler(this.openToolS_Click);
            // 
            // saveToolS
            // 
            this.saveToolS.Name = "saveToolS";
            this.saveToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolS.Size = new System.Drawing.Size(183, 22);
            this.saveToolS.Text = "保存(S)...";
            this.saveToolS.Click += new System.EventHandler(this.saveToolS_Click);
            // 
            // saveAsToolS
            // 
            this.saveAsToolS.Name = "saveAsToolS";
            this.saveAsToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.saveAsToolS.Size = new System.Drawing.Size(183, 22);
            this.saveAsToolS.Text = "另存为(A)...";
            this.saveAsToolS.Click += new System.EventHandler(this.saveAsToolS_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 6);
            // 
            // pageSetUpToolS
            // 
            this.pageSetUpToolS.Name = "pageSetUpToolS";
            this.pageSetUpToolS.Size = new System.Drawing.Size(183, 22);
            this.pageSetUpToolS.Text = "页面设置(U)...";
            // 
            // printToolS
            // 
            this.printToolS.Name = "printToolS";
            this.printToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolS.Size = new System.Drawing.Size(183, 22);
            this.printToolS.Text = "打印(P)...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 6);
            // 
            // exitToolS
            // 
            this.exitToolS.Name = "exitToolS";
            this.exitToolS.Size = new System.Drawing.Size(183, 22);
            this.exitToolS.Text = "退出(X)";
            this.exitToolS.Click += new System.EventHandler(this.exitToolS_Click);
            // 
            // editToolS
            // 
            this.editToolS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolS,
            this.cutToolS,
            this.copyToolS,
            this.pasteToolS,
            this.delToolS,
            this.toolStripMenuItem3,
            this.findToolS,
            this.findNextToolS,
            this.replaceToolS,
            this.turnToolS,
            this.toolStripMenuItem4,
            this.selectAllToolS,
            this.dateToolS});
            this.editToolS.Name = "editToolS";
            this.editToolS.Size = new System.Drawing.Size(59, 21);
            this.editToolS.Text = "编辑(E)";
            // 
            // cancelToolS
            // 
            this.cancelToolS.Name = "cancelToolS";
            this.cancelToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cancelToolS.Size = new System.Drawing.Size(175, 22);
            this.cancelToolS.Text = "撤销(U)...";
            this.cancelToolS.Click += new System.EventHandler(this.cancelToolS_Click);
            // 
            // cutToolS
            // 
            this.cutToolS.Enabled = false;
            this.cutToolS.Name = "cutToolS";
            this.cutToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolS.Size = new System.Drawing.Size(175, 22);
            this.cutToolS.Text = "剪切(T)...";
            this.cutToolS.Click += new System.EventHandler(this.cutToolS_Click);
            // 
            // copyToolS
            // 
            this.copyToolS.Enabled = false;
            this.copyToolS.Name = "copyToolS";
            this.copyToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolS.Size = new System.Drawing.Size(175, 22);
            this.copyToolS.Text = "复制(C)...";
            this.copyToolS.Click += new System.EventHandler(this.copyToolS_Click);
            // 
            // pasteToolS
            // 
            this.pasteToolS.Name = "pasteToolS";
            this.pasteToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolS.Size = new System.Drawing.Size(175, 22);
            this.pasteToolS.Text = "粘贴(P)...";
            this.pasteToolS.Click += new System.EventHandler(this.pasteToolS_Click);
            // 
            // delToolS
            // 
            this.delToolS.Enabled = false;
            this.delToolS.Name = "delToolS";
            this.delToolS.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.delToolS.Size = new System.Drawing.Size(175, 22);
            this.delToolS.Text = "删除(L)...";
            this.delToolS.Click += new System.EventHandler(this.delToolS_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(172, 6);
            // 
            // findToolS
            // 
            this.findToolS.Enabled = false;
            this.findToolS.Name = "findToolS";
            this.findToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolS.Size = new System.Drawing.Size(175, 22);
            this.findToolS.Text = "查找(F)...";
            this.findToolS.Click += new System.EventHandler(this.findToolS_Click);
            // 
            // findNextToolS
            // 
            this.findNextToolS.Enabled = false;
            this.findNextToolS.Name = "findNextToolS";
            this.findNextToolS.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.findNextToolS.Size = new System.Drawing.Size(175, 22);
            this.findNextToolS.Text = "查找下一个(N)";
            this.findNextToolS.Click += new System.EventHandler(this.findNextToolS_Click);
            // 
            // replaceToolS
            // 
            this.replaceToolS.Name = "replaceToolS";
            this.replaceToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceToolS.Size = new System.Drawing.Size(175, 22);
            this.replaceToolS.Text = "替换(R)...";
            this.replaceToolS.Click += new System.EventHandler(this.replaceToolS_Click);
            // 
            // turnToolS
            // 
            this.turnToolS.Name = "turnToolS";
            this.turnToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.turnToolS.Size = new System.Drawing.Size(175, 22);
            this.turnToolS.Text = "转到(G)...";
            this.turnToolS.Click += new System.EventHandler(this.turnToolS_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(172, 6);
            // 
            // selectAllToolS
            // 
            this.selectAllToolS.Name = "selectAllToolS";
            this.selectAllToolS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolS.Size = new System.Drawing.Size(175, 22);
            this.selectAllToolS.Text = "全选(A)";
            this.selectAllToolS.Click += new System.EventHandler(this.selectAllToolS_Click);
            // 
            // dateToolS
            // 
            this.dateToolS.Name = "dateToolS";
            this.dateToolS.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.dateToolS.Size = new System.Drawing.Size(175, 22);
            this.dateToolS.Text = "时间/日期(D)";
            this.dateToolS.Click += new System.EventHandler(this.dateToolS_Click);
            // 
            // typeToolS
            // 
            this.typeToolS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trunPageToolS,
            this.FontToolS});
            this.typeToolS.Name = "typeToolS";
            this.typeToolS.Size = new System.Drawing.Size(62, 21);
            this.typeToolS.Text = "格式(O)";
            // 
            // trunPageToolS
            // 
            this.trunPageToolS.Name = "trunPageToolS";
            this.trunPageToolS.Size = new System.Drawing.Size(144, 22);
            this.trunPageToolS.Text = "自动换行(W)";
            this.trunPageToolS.Click += new System.EventHandler(this.trunPageToolS_Click);
            // 
            // FontToolS
            // 
            this.FontToolS.Name = "FontToolS";
            this.FontToolS.Size = new System.Drawing.Size(144, 22);
            this.FontToolS.Text = "字体(F)...";
            this.FontToolS.Click += new System.EventHandler(this.FontToolS_Click);
            // 
            // watchMenuS
            // 
            this.watchMenuS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态栏ToolStripMenuItem});
            this.watchMenuS.Name = "watchMenuS";
            this.watchMenuS.Size = new System.Drawing.Size(60, 21);
            this.watchMenuS.Text = "查看(V)";
            // 
            // 状态栏ToolStripMenuItem
            // 
            this.状态栏ToolStripMenuItem.CheckOnClick = true;
            this.状态栏ToolStripMenuItem.Name = "状态栏ToolStripMenuItem";
            this.状态栏ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.状态栏ToolStripMenuItem.Text = "状态栏";
            // 
            // helpMenuS
            // 
            this.helpMenuS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem,
            this.关于记事本ToolStripMenuItem});
            this.helpMenuS.Name = "helpMenuS";
            this.helpMenuS.Size = new System.Drawing.Size(61, 21);
            this.helpMenuS.Text = "帮助(H)";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助";
            // 
            // 关于记事本ToolStripMenuItem
            // 
            this.关于记事本ToolStripMenuItem.Name = "关于记事本ToolStripMenuItem";
            this.关于记事本ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关于记事本ToolStripMenuItem.Text = "关于记事本";
            // 
            // txtBox
            // 
            this.txtBox.ContextMenuStrip = this.contextMenuStrip1;
            this.txtBox.HideSelection = false;
            this.txtBox.Location = new System.Drawing.Point(1, 33);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(445, 332);
            this.txtBox.TabIndex = 1;
            this.txtBox.Text = "";
            this.txtBox.SelectionChanged += new System.EventHandler(this.txtBox_SelectionChanged);
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.toolStripSeparator1,
            this.fbToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(89, 54);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.aToolStripMenuItem.Text = "a";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // fbToolStripMenuItem
            // 
            this.fbToolStripMenuItem.Name = "fbToolStripMenuItem";
            this.fbToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fbToolStripMenuItem.Text = "fb";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 408);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolS;
        private System.Windows.Forms.ToolStripMenuItem newToolS;
        private System.Windows.Forms.ToolStripMenuItem openToolS;
        private System.Windows.Forms.ToolStripMenuItem saveToolS;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolS;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pageSetUpToolS;
        private System.Windows.Forms.ToolStripMenuItem printToolS;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolS;
        private System.Windows.Forms.ToolStripMenuItem editToolS;
        private System.Windows.Forms.ToolStripMenuItem cancelToolS;
        private System.Windows.Forms.ToolStripMenuItem cutToolS;
        private System.Windows.Forms.ToolStripMenuItem copyToolS;
        private System.Windows.Forms.ToolStripMenuItem pasteToolS;
        private System.Windows.Forms.ToolStripMenuItem delToolS;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem findToolS;
        private System.Windows.Forms.ToolStripMenuItem findNextToolS;
        private System.Windows.Forms.ToolStripMenuItem turnToolS;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolS;
        private System.Windows.Forms.ToolStripMenuItem dateToolS;
        private System.Windows.Forms.ToolStripMenuItem typeToolS;
        private System.Windows.Forms.ToolStripMenuItem trunPageToolS;
        private System.Windows.Forms.ToolStripMenuItem FontToolS;
        private System.Windows.Forms.ToolStripMenuItem watchMenuS;
        private System.Windows.Forms.ToolStripMenuItem 状态栏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuS;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于记事本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fbToolStripMenuItem;
    }
}

