namespace Tetris
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
            this.components = new System.ComponentModel.Container();
            this.playzone = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAUSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gIỚITHIỆUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futurebrick = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumLine = new System.Windows.Forms.Label();
            this.lblv = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playzone)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.futurebrick)).BeginInit();
            this.SuspendLayout();
            // 
            // playzone
            // 
            this.playzone.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playzone.Location = new System.Drawing.Point(410, 18);
            this.playzone.Name = "playzone";
            this.playzone.Size = new System.Drawing.Size(260, 420);
            this.playzone.TabIndex = 0;
            this.playzone.TabStop = false;
            this.playzone.Click += new System.EventHandler(this.playzone_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.BackgroundImage = global::Tetris.Properties.Resources.pngtree_cartoon_hand_painted_outskirts_picnic_image_7496;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gAMEToolStripMenuItem,
            this.gIỚITHIỆUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gAMEToolStripMenuItem
            // 
            this.gAMEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTARTToolStripMenuItem,
            this.pAUSEToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.gAMEToolStripMenuItem.Name = "gAMEToolStripMenuItem";
            this.gAMEToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.gAMEToolStripMenuItem.Text = "GAME";
            // 
            // sTARTToolStripMenuItem
            // 
            this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.sTARTToolStripMenuItem.Text = "START";
            this.sTARTToolStripMenuItem.Click += new System.EventHandler(this.sTARTToolStripMenuItem_Click);
            // 
            // pAUSEToolStripMenuItem
            // 
            this.pAUSEToolStripMenuItem.Name = "pAUSEToolStripMenuItem";
            this.pAUSEToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.pAUSEToolStripMenuItem.Text = "PAUSE";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            // 
            // gIỚITHIỆUToolStripMenuItem
            // 
            this.gIỚITHIỆUToolStripMenuItem.Name = "gIỚITHIỆUToolStripMenuItem";
            this.gIỚITHIỆUToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.gIỚITHIỆUToolStripMenuItem.Text = "GIỚI THIỆU";
            this.gIỚITHIỆUToolStripMenuItem.Click += new System.EventHandler(this.gIỚITHIỆUToolStripMenuItem_Click);
            // 
            // futurebrick
            // 
            this.futurebrick.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.futurebrick.Location = new System.Drawing.Point(123, 42);
            this.futurebrick.Name = "futurebrick";
            this.futurebrick.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.futurebrick.Size = new System.Drawing.Size(100, 100);
            this.futurebrick.TabIndex = 2;
            this.futurebrick.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "số dòng đã phá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "cấp độ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điểm số :";
            // 
            // lblNumLine
            // 
            this.lblNumLine.AutoSize = true;
            this.lblNumLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumLine.Location = new System.Drawing.Point(243, 171);
            this.lblNumLine.Name = "lblNumLine";
            this.lblNumLine.Size = new System.Drawing.Size(0, 24);
            this.lblNumLine.TabIndex = 6;
            this.lblNumLine.Click += new System.EventHandler(this.lblNumLine_Click);
            // 
            // lblv
            // 
            this.lblv.AutoSize = true;
            this.lblv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblv.Location = new System.Drawing.Point(243, 227);
            this.lblv.Name = "lblv";
            this.lblv.Size = new System.Drawing.Size(0, 24);
            this.lblv.TabIndex = 7;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(243, 278);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 24);
            this.lblScore.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.pngtree_cartoon_hand_painted_outskirts_picnic_image_7496;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblv);
            this.Controls.Add(this.lblNumLine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.futurebrick);
            this.Controls.Add(this.playzone);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XepGach_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.XepGach_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.playzone)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.futurebrick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playzone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAUSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.PictureBox futurebrick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumLine;
        private System.Windows.Forms.Label lblv;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem gIỚITHIỆUToolStripMenuItem;
    }
}

