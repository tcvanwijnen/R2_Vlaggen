namespace R2_Vlaggen
{
    partial class Form1
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
            this.lbLanden = new System.Windows.Forms.ListBox();
            this.pbVlag = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFlagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flagQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.lblCaption = new System.Windows.Forms.Label();
            this.pbFlagQuiz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVlag)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlagQuiz)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLanden
            // 
            this.lbLanden.FormattingEnabled = true;
            this.lbLanden.Location = new System.Drawing.Point(12, 27);
            this.lbLanden.Name = "lbLanden";
            this.lbLanden.Size = new System.Drawing.Size(250, 446);
            this.lbLanden.TabIndex = 0;
            this.lbLanden.SelectedIndexChanged += new System.EventHandler(this.lbLanden_SelectedIndexChanged);
            // 
            // pbVlag
            // 
            this.pbVlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbVlag.Location = new System.Drawing.Point(268, 65);
            this.pbVlag.Name = "pbVlag";
            this.pbVlag.Size = new System.Drawing.Size(550, 368);
            this.pbVlag.TabIndex = 1;
            this.pbVlag.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFlagsToolStripMenuItem,
            this.flagQuizToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fIleToolStripMenuItem.Text = "MODE";
            // 
            // viewFlagsToolStripMenuItem
            // 
            this.viewFlagsToolStripMenuItem.Name = "viewFlagsToolStripMenuItem";
            this.viewFlagsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.viewFlagsToolStripMenuItem.Text = "&View Flags";
            // 
            // flagQuizToolStripMenuItem
            // 
            this.flagQuizToolStripMenuItem.Name = "flagQuizToolStripMenuItem";
            this.flagQuizToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.flagQuizToolStripMenuItem.Text = "Flag &Quiz";
            this.flagQuizToolStripMenuItem.Click += new System.EventHandler(this.flagQuizToolStripMenuItem_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(200, 439);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(104, 34);
            this.btnA.TabIndex = 3;
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Visible = false;
            this.btnA.Click += new System.EventHandler(this.btnQuiz);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(310, 439);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(104, 34);
            this.btnB.TabIndex = 4;
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Visible = false;
            this.btnB.Click += new System.EventHandler(this.btnQuiz);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(420, 439);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(104, 34);
            this.btnC.TabIndex = 5;
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Visible = false;
            this.btnC.Click += new System.EventHandler(this.btnQuiz);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(530, 439);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(104, 34);
            this.btnD.TabIndex = 6;
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Visible = false;
            this.btnD.Click += new System.EventHandler(this.btnQuiz);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(215, 27);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(423, 31);
            this.lblCaption.TabIndex = 9;
            this.lblCaption.Text = "Which country\'s flag is seen below?";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaption.Visible = false;
            // 
            // pbFlagQuiz
            // 
            this.pbFlagQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFlagQuiz.Location = new System.Drawing.Point(141, 67);
            this.pbFlagQuiz.Name = "pbFlagQuiz";
            this.pbFlagQuiz.Size = new System.Drawing.Size(550, 368);
            this.pbFlagQuiz.TabIndex = 10;
            this.pbFlagQuiz.TabStop = false;
            this.pbFlagQuiz.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 502);
            this.Controls.Add(this.pbFlagQuiz);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.pbVlag);
            this.Controls.Add(this.lbLanden);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVlag)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlagQuiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLanden;
        private System.Windows.Forms.PictureBox pbVlag;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFlagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flagQuizToolStripMenuItem;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.PictureBox pbFlagQuiz;
    }
}

