namespace FuzzyLogic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LevelBTN = new System.Windows.Forms.Button();
            this.TempBTN = new System.Windows.Forms.Button();
            this.CBTN = new System.Windows.Forms.Button();
            this.DefuzzifyBTN = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.NewLevelBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fuzzyLogicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFuzzyLogicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Initial Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "HeatKnob Output";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(147, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox2.Location = new System.Drawing.Point(211, 98);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 27);
            this.textBox2.TabIndex = 4;
            // 
            // LevelBTN
            // 
            this.LevelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LevelBTN.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelBTN.Location = new System.Drawing.Point(350, 52);
            this.LevelBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LevelBTN.Name = "LevelBTN";
            this.LevelBTN.Size = new System.Drawing.Size(91, 30);
            this.LevelBTN.TabIndex = 5;
            this.LevelBTN.Text = "Fuzzify";
            this.LevelBTN.UseVisualStyleBackColor = false;
            this.LevelBTN.Click += new System.EventHandler(this.LevelBTN_Click);
            // 
            // TempBTN
            // 
            this.TempBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TempBTN.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempBTN.Location = new System.Drawing.Point(350, 98);
            this.TempBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TempBTN.Name = "TempBTN";
            this.TempBTN.Size = new System.Drawing.Size(91, 29);
            this.TempBTN.TabIndex = 6;
            this.TempBTN.Text = "Fuzzify";
            this.TempBTN.UseVisualStyleBackColor = false;
            this.TempBTN.Click += new System.EventHandler(this.TempBTN_Click);
            // 
            // CBTN
            // 
            this.CBTN.BackColor = System.Drawing.SystemColors.Desktop;
            this.CBTN.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTN.Location = new System.Drawing.Point(458, 51);
            this.CBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBTN.Name = "CBTN";
            this.CBTN.Size = new System.Drawing.Size(199, 231);
            this.CBTN.TabIndex = 7;
            this.CBTN.Text = "            \"Click Here\"                                 for                    1" +
    " Step Process";
            this.CBTN.UseVisualStyleBackColor = false;
            this.CBTN.Click += new System.EventHandler(this.CBTN_Click);
            // 
            // DefuzzifyBTN
            // 
            this.DefuzzifyBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DefuzzifyBTN.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefuzzifyBTN.Location = new System.Drawing.Point(211, 142);
            this.DefuzzifyBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DefuzzifyBTN.Name = "DefuzzifyBTN";
            this.DefuzzifyBTN.Size = new System.Drawing.Size(230, 40);
            this.DefuzzifyBTN.TabIndex = 8;
            this.DefuzzifyBTN.Text = "Defuzzify";
            this.DefuzzifyBTN.UseVisualStyleBackColor = false;
            this.DefuzzifyBTN.Click += new System.EventHandler(this.DefuzzifyBTN_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox3.Location = new System.Drawing.Point(211, 199);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 27);
            this.textBox3.TabIndex = 9;
            // 
            // NewLevelBTN
            // 
            this.NewLevelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NewLevelBTN.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewLevelBTN.Location = new System.Drawing.Point(211, 242);
            this.NewLevelBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewLevelBTN.Name = "NewLevelBTN";
            this.NewLevelBTN.Size = new System.Drawing.Size(230, 40);
            this.NewLevelBTN.TabIndex = 10;
            this.NewLevelBTN.Text = "Create New Level";
            this.NewLevelBTN.UseVisualStyleBackColor = false;
            this.NewLevelBTN.Click += new System.EventHandler(this.NewLevelBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "By: Jie Ann V.  Leonor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "BSCS-3 CS345-F1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuzzyLogicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fuzzyLogicToolStripMenuItem
            // 
            this.fuzzyLogicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFuzzyLogicToolStripMenuItem});
            this.fuzzyLogicToolStripMenuItem.Name = "fuzzyLogicToolStripMenuItem";
            this.fuzzyLogicToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fuzzyLogicToolStripMenuItem.Text = "Fuzzy Logic";
            // 
            // createFuzzyLogicToolStripMenuItem
            // 
            this.createFuzzyLogicToolStripMenuItem.Name = "createFuzzyLogicToolStripMenuItem";
            this.createFuzzyLogicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createFuzzyLogicToolStripMenuItem.Text = "Create Fuzzy Logic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewLevelBTN);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.DefuzzifyBTN);
            this.Controls.Add(this.CBTN);
            this.Controls.Add(this.TempBTN);
            this.Controls.Add(this.LevelBTN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Fuzzy Logic Controller: Water Heater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button LevelBTN;
        private System.Windows.Forms.Button TempBTN;
        private System.Windows.Forms.Button CBTN;
        private System.Windows.Forms.Button DefuzzifyBTN;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button NewLevelBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fuzzyLogicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFuzzyLogicToolStripMenuItem;
    }
}

