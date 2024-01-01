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
            this.SuspendLayout();
            // 
            // outputTB
            // 
            this.outputTB.Location = new System.Drawing.Point(46, 51);
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.Size = new System.Drawing.Size(679, 248);
            this.outputTB.TabIndex = 0;
            // 
            // lookBtn
            // 
            this.lookBtn.Location = new System.Drawing.Point(46, 305);
            this.lookBtn.Name = "lookBtn";
            this.lookBtn.Size = new System.Drawing.Size(75, 23);
            this.lookBtn.TabIndex = 1;
            this.lookBtn.Text = "Look";
            this.lookBtn.UseVisualStyleBackColor = true;
            this.lookBtn.Click += new System.EventHandler(this.lookBtn_Click);
            // 
            // northBtn
            // 
            this.northBtn.Location = new System.Drawing.Point(572, 305);
            this.northBtn.Name = "northBtn";
            this.northBtn.Size = new System.Drawing.Size(75, 23);
            this.northBtn.TabIndex = 2;
            this.northBtn.Text = "North";
            this.northBtn.UseVisualStyleBackColor = true;
            this.northBtn.Click += new System.EventHandler(this.northBtn_Click);
            // 
            // westBtn
            // 
            this.westBtn.Location = new System.Drawing.Point(492, 348);
            this.westBtn.Name = "westBtn";
            this.westBtn.Size = new System.Drawing.Size(75, 23);
            this.westBtn.TabIndex = 3;
            this.westBtn.Text = "West";
            this.westBtn.UseVisualStyleBackColor = true;
            this.westBtn.Click += new System.EventHandler(this.westBtn_Click);
            // 
            // eastBtn
            // 
            this.eastBtn.Location = new System.Drawing.Point(650, 348);
            this.eastBtn.Name = "eastBtn";
            this.eastBtn.Size = new System.Drawing.Size(75, 23);
            this.eastBtn.TabIndex = 4;
            this.eastBtn.Text = "East";
            this.eastBtn.UseVisualStyleBackColor = true;
            this.eastBtn.Click += new System.EventHandler(this.eastBtn_Click);
            // 
            // southBtn
            // 
            this.southBtn.Location = new System.Drawing.Point(572, 396);
            this.southBtn.Name = "southBtn";
            this.southBtn.Size = new System.Drawing.Size(75, 23);
            this.southBtn.TabIndex = 5;
            this.southBtn.Text = "South";
            this.southBtn.UseVisualStyleBackColor = true;
            this.southBtn.Click += new System.EventHandler(this.southBtn_Click);
            // 
            // roomnameTB
            // 
            this.roomnameTB.Location = new System.Drawing.Point(46, 25);
            this.roomnameTB.Name = "roomnameTB";
            this.roomnameTB.Size = new System.Drawing.Size(146, 20);
            this.roomnameTB.TabIndex = 6;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomnameTB);
            this.Controls.Add(this.southBtn);
            this.Controls.Add(this.eastBtn);
            this.Controls.Add(this.westBtn);
            this.Controls.Add(this.northBtn);
            this.Controls.Add(this.lookBtn);
            this.Controls.Add(this.outputTB);
            this.Name = "Game";
            this.Text = "Adventure Game";
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
    }
}

