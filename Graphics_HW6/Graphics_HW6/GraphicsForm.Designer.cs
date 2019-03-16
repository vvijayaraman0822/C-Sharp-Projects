namespace Graphics_HW6
{
    partial class GraphicsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Surprise_Button = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DrawingPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Controls.Add(this.groupBox1);
            this.DrawingPanel.Controls.Add(this.radioButton1);
            this.DrawingPanel.Controls.Add(this.tabControl1);
            this.DrawingPanel.Controls.Add(this.listView1);
            this.DrawingPanel.Controls.Add(this.comboBox1);
            this.DrawingPanel.Controls.Add(this.listBox1);
            this.DrawingPanel.Controls.Add(this.Surprise_Button);
            this.DrawingPanel.Controls.Add(this.menuStrip1);
            this.DrawingPanel.Location = new System.Drawing.Point(3, 0);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(2000, 1500);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_OnPaint);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(580, 202);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 165);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(88, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 173);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Surprise_Button
            // 
            this.Surprise_Button.Location = new System.Drawing.Point(340, 91);
            this.Surprise_Button.Name = "Surprise_Button";
            this.Surprise_Button.Size = new System.Drawing.Size(163, 23);
            this.Surprise_Button.TabIndex = 0;
            this.Surprise_Button.Text = "Click to see the Surprise!";
            this.Surprise_Button.UseVisualStyleBackColor = true;
            this.Surprise_Button.Click += new System.EventHandler(this.Surprise_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.notMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2000, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.screwToolStripMenuItem,
            this.thisToolStripMenuItem,
            this.meToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // notMenuToolStripMenuItem
            // 
            this.notMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuckToolStripMenuItem,
            this.thisToolStripMenuItem1,
            this.shitToolStripMenuItem});
            this.notMenuToolStripMenuItem.Name = "notMenuToolStripMenuItem";
            this.notMenuToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.notMenuToolStripMenuItem.Text = "Not Menu";
            // 
            // screwToolStripMenuItem
            // 
            this.screwToolStripMenuItem.Name = "screwToolStripMenuItem";
            this.screwToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.screwToolStripMenuItem.Text = "Screw";
            // 
            // thisToolStripMenuItem
            // 
            this.thisToolStripMenuItem.Name = "thisToolStripMenuItem";
            this.thisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thisToolStripMenuItem.Text = "This";
            // 
            // meToolStripMenuItem
            // 
            this.meToolStripMenuItem.Name = "meToolStripMenuItem";
            this.meToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.meToolStripMenuItem.Text = "Me";
            // 
            // fuckToolStripMenuItem
            // 
            this.fuckToolStripMenuItem.Name = "fuckToolStripMenuItem";
            this.fuckToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fuckToolStripMenuItem.Text = "Fuck ";
            this.fuckToolStripMenuItem.Click += new System.EventHandler(this.fuckToolStripMenuItem_Click);
            // 
            // thisToolStripMenuItem1
            // 
            this.thisToolStripMenuItem1.Name = "thisToolStripMenuItem1";
            this.thisToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.thisToolStripMenuItem1.Text = "This";
            // 
            // shitToolStripMenuItem
            // 
            this.shitToolStripMenuItem.Name = "shitToolStripMenuItem";
            this.shitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shitToolStripMenuItem.Text = "Shit";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(142, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(624, 45);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(370, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 466);
            this.Controls.Add(this.DrawingPanel);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GraphicsForm";
            this.Text = "Welcome to Graphics Form!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DrawingPanel.ResumeLayout(false);
            this.DrawingPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Surprise_Button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

