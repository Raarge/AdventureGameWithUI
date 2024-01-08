namespace Game04
{
    partial class Game
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
            this.outputTB = new System.Windows.Forms.TextBox();
            this.lookBtn = new System.Windows.Forms.Button();
            this.northBtn = new System.Windows.Forms.Button();
            this.westBtn = new System.Windows.Forms.Button();
            this.eastBtn = new System.Windows.Forms.Button();
            this.southBtn = new System.Windows.Forms.Button();
            this.roomnameTB = new System.Windows.Forms.TextBox();
            this.takeBtn = new System.Windows.Forms.Button();
            this.dropBtn = new System.Windows.Forms.Button();
            this.invBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InputTB = new System.Windows.Forms.TextBox();
            this.LookAtBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.upBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdTB = new System.Windows.Forms.TextBox();
            this.cmdBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputTB
            // 
            this.outputTB.Location = new System.Drawing.Point(46, 78);
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.Size = new System.Drawing.Size(679, 263);
            this.outputTB.TabIndex = 0;
            // 
            // lookBtn
            // 
            this.lookBtn.Location = new System.Drawing.Point(360, 418);
            this.lookBtn.Name = "lookBtn";
            this.lookBtn.Size = new System.Drawing.Size(75, 23);
            this.lookBtn.TabIndex = 1;
            this.lookBtn.Text = "Look";
            this.lookBtn.UseVisualStyleBackColor = true;
            this.lookBtn.Click += new System.EventHandler(this.lookBtn_Click);
            // 
            // northBtn
            // 
            this.northBtn.Location = new System.Drawing.Point(538, 379);
            this.northBtn.Name = "northBtn";
            this.northBtn.Size = new System.Drawing.Size(75, 23);
            this.northBtn.TabIndex = 2;
            this.northBtn.Text = "North";
            this.northBtn.UseVisualStyleBackColor = true;
            this.northBtn.Click += new System.EventHandler(this.northBtn_Click);
            // 
            // westBtn
            // 
            this.westBtn.Location = new System.Drawing.Point(458, 408);
            this.westBtn.Name = "westBtn";
            this.westBtn.Size = new System.Drawing.Size(75, 23);
            this.westBtn.TabIndex = 3;
            this.westBtn.Text = "West";
            this.westBtn.UseVisualStyleBackColor = true;
            this.westBtn.Click += new System.EventHandler(this.westBtn_Click);
            // 
            // eastBtn
            // 
            this.eastBtn.Location = new System.Drawing.Point(616, 408);
            this.eastBtn.Name = "eastBtn";
            this.eastBtn.Size = new System.Drawing.Size(75, 23);
            this.eastBtn.TabIndex = 4;
            this.eastBtn.Text = "East";
            this.eastBtn.UseVisualStyleBackColor = true;
            this.eastBtn.Click += new System.EventHandler(this.eastBtn_Click);
            // 
            // southBtn
            // 
            this.southBtn.Location = new System.Drawing.Point(538, 428);
            this.southBtn.Name = "southBtn";
            this.southBtn.Size = new System.Drawing.Size(75, 23);
            this.southBtn.TabIndex = 5;
            this.southBtn.Text = "South";
            this.southBtn.UseVisualStyleBackColor = true;
            this.southBtn.Click += new System.EventHandler(this.southBtn_Click);
            // 
            // roomnameTB
            // 
            this.roomnameTB.Location = new System.Drawing.Point(46, 42);
            this.roomnameTB.Name = "roomnameTB";
            this.roomnameTB.Size = new System.Drawing.Size(146, 20);
            this.roomnameTB.TabIndex = 6;
            // 
            // takeBtn
            // 
            this.takeBtn.Location = new System.Drawing.Point(6, 71);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(75, 23);
            this.takeBtn.TabIndex = 7;
            this.takeBtn.Text = "Take";
            this.takeBtn.UseVisualStyleBackColor = true;
            this.takeBtn.Click += new System.EventHandler(this.takeBtn_Click);
            // 
            // dropBtn
            // 
            this.dropBtn.Location = new System.Drawing.Point(105, 71);
            this.dropBtn.Name = "dropBtn";
            this.dropBtn.Size = new System.Drawing.Size(75, 23);
            this.dropBtn.TabIndex = 8;
            this.dropBtn.Text = "Drop";
            this.dropBtn.UseVisualStyleBackColor = true;
            this.dropBtn.Click += new System.EventHandler(this.dropBtn_Click);
            // 
            // invBtn
            // 
            this.invBtn.Location = new System.Drawing.Point(360, 447);
            this.invBtn.Name = "invBtn";
            this.invBtn.Size = new System.Drawing.Size(75, 23);
            this.invBtn.TabIndex = 9;
            this.invBtn.Text = "Inventory";
            this.invBtn.UseVisualStyleBackColor = true;
            this.invBtn.Click += new System.EventHandler(this.invBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InputTB);
            this.groupBox1.Controls.Add(this.LookAtBtn);
            this.groupBox1.Controls.Add(this.takeBtn);
            this.groupBox1.Controls.Add(this.dropBtn);
            this.groupBox1.Location = new System.Drawing.Point(46, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Object";
            // 
            // InputTB
            // 
            this.InputTB.Location = new System.Drawing.Point(6, 31);
            this.InputTB.Name = "InputTB";
            this.InputTB.Size = new System.Drawing.Size(277, 20);
            this.InputTB.TabIndex = 12;
            // 
            // LookAtBtn
            // 
            this.LookAtBtn.Location = new System.Drawing.Point(208, 71);
            this.LookAtBtn.Name = "LookAtBtn";
            this.LookAtBtn.Size = new System.Drawing.Size(75, 23);
            this.LookAtBtn.TabIndex = 11;
            this.LookAtBtn.Text = "Look At";
            this.LookAtBtn.UseVisualStyleBackColor = true;
            this.LookAtBtn.Click += new System.EventHandler(this.LookAtBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "&Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // upBtn
            // 
            this.upBtn.Location = new System.Drawing.Point(650, 347);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(75, 23);
            this.upBtn.TabIndex = 12;
            this.upBtn.Text = "Up";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.Location = new System.Drawing.Point(650, 470);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(75, 23);
            this.downBtn.TabIndex = 13;
            this.downBtn.Text = "Down";
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter a command:";
            // 
            // cmdTB
            // 
            this.cmdTB.Location = new System.Drawing.Point(148, 354);
            this.cmdTB.Name = "cmdTB";
            this.cmdTB.Size = new System.Drawing.Size(250, 20);
            this.cmdTB.TabIndex = 15;
            this.cmdTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdTB_KeyDown);
            // 
            // cmdBtn
            // 
            this.cmdBtn.Font = new System.Drawing.Font("Wingdings 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cmdBtn.Location = new System.Drawing.Point(404, 347);
            this.cmdBtn.Name = "cmdBtn";
            this.cmdBtn.Size = new System.Drawing.Size(42, 34);
            this.cmdBtn.TabIndex = 16;
            this.cmdBtn.Text = "P";
            this.cmdBtn.UseVisualStyleBackColor = true;
            this.cmdBtn.Click += new System.EventHandler(this.cmdBtn_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.cmdBtn);
            this.Controls.Add(this.cmdTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.invBtn);
            this.Controls.Add(this.roomnameTB);
            this.Controls.Add(this.southBtn);
            this.Controls.Add(this.eastBtn);
            this.Controls.Add(this.westBtn);
            this.Controls.Add(this.northBtn);
            this.Controls.Add(this.lookBtn);
            this.Controls.Add(this.outputTB);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Game";
            this.Text = "Adventure Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTB;
        private System.Windows.Forms.Button lookBtn;
        private System.Windows.Forms.Button northBtn;
        private System.Windows.Forms.Button westBtn;
        private System.Windows.Forms.Button eastBtn;
        private System.Windows.Forms.Button southBtn;
        private System.Windows.Forms.TextBox roomnameTB;
        private System.Windows.Forms.Button takeBtn;
        private System.Windows.Forms.Button dropBtn;
        private System.Windows.Forms.Button invBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox InputTB;
        private System.Windows.Forms.Button LookAtBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cmdTB;
        private System.Windows.Forms.Button cmdBtn;
    }
}

