namespace Haitoku
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.t2 = new System.Windows.Forms.Timer(this.components);
            this.l2 = new System.Windows.Forms.LinkLabel();
            this.l1 = new System.Windows.Forms.Label();
            this.minimaltheme = new System.Windows.Forms.RadioButton();
            this.carameltheme = new System.Windows.Forms.RadioButton();
            this.limetheme = new System.Windows.Forms.RadioButton();
            this.magmatheme = new System.Windows.Forms.RadioButton();
            this.oceantheme = new System.Windows.Forms.RadioButton();
            this.zergtheme = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(298, 305);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 39);
            this.button7.TabIndex = 38;
            this.button7.Tag = "themeable";
            this.button7.Text = "OK";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(298, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 39);
            this.button1.TabIndex = 39;
            this.button1.Tag = "themeable";
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t1
            // 
            this.t1.Interval = 350;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // t2
            // 
            this.t2.Interval = 350;
            this.t2.Tick += new System.EventHandler(this.t2_Tick);
            // 
            // l2
            // 
            this.l2.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.l2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.l2.Location = new System.Drawing.Point(12, 312);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 32);
            this.l2.TabIndex = 60;
            this.l2.Tag = "themeable";
            this.l2.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.l2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l2_LinkClicked);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(128, 12);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 32);
            this.l1.TabIndex = 59;
            // 
            // minimaltheme
            // 
            this.minimaltheme.AutoSize = true;
            this.minimaltheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimaltheme.ForeColor = System.Drawing.Color.Gray;
            this.minimaltheme.Location = new System.Drawing.Point(153, 248);
            this.minimaltheme.Name = "minimaltheme";
            this.minimaltheme.Size = new System.Drawing.Size(106, 32);
            this.minimaltheme.TabIndex = 76;
            this.minimaltheme.Text = "Minimal";
            this.minimaltheme.UseVisualStyleBackColor = true;
            this.minimaltheme.CheckedChanged += new System.EventHandler(this.minimaltheme_CheckedChanged);
            // 
            // carameltheme
            // 
            this.carameltheme.AutoSize = true;
            this.carameltheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carameltheme.ForeColor = System.Drawing.Color.DarkOrange;
            this.carameltheme.Location = new System.Drawing.Point(153, 172);
            this.carameltheme.Name = "carameltheme";
            this.carameltheme.Size = new System.Drawing.Size(106, 32);
            this.carameltheme.TabIndex = 75;
            this.carameltheme.Text = "Caramel";
            this.carameltheme.UseVisualStyleBackColor = true;
            this.carameltheme.CheckedChanged += new System.EventHandler(this.carameltheme_CheckedChanged);
            // 
            // limetheme
            // 
            this.limetheme.AutoSize = true;
            this.limetheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limetheme.ForeColor = System.Drawing.Color.LimeGreen;
            this.limetheme.Location = new System.Drawing.Point(153, 210);
            this.limetheme.Name = "limetheme";
            this.limetheme.Size = new System.Drawing.Size(77, 32);
            this.limetheme.TabIndex = 74;
            this.limetheme.Text = "Lime";
            this.limetheme.UseVisualStyleBackColor = true;
            this.limetheme.CheckedChanged += new System.EventHandler(this.limetheme_CheckedChanged);
            // 
            // magmatheme
            // 
            this.magmatheme.AutoSize = true;
            this.magmatheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magmatheme.ForeColor = System.Drawing.Color.Tomato;
            this.magmatheme.Location = new System.Drawing.Point(37, 210);
            this.magmatheme.Name = "magmatheme";
            this.magmatheme.Size = new System.Drawing.Size(101, 32);
            this.magmatheme.TabIndex = 73;
            this.magmatheme.Text = "Magma";
            this.magmatheme.UseVisualStyleBackColor = true;
            this.magmatheme.CheckedChanged += new System.EventHandler(this.magmatheme_CheckedChanged);
            // 
            // oceantheme
            // 
            this.oceantheme.AutoSize = true;
            this.oceantheme.Checked = true;
            this.oceantheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oceantheme.ForeColor = System.Drawing.Color.DodgerBlue;
            this.oceantheme.Location = new System.Drawing.Point(37, 172);
            this.oceantheme.Name = "oceantheme";
            this.oceantheme.Size = new System.Drawing.Size(90, 32);
            this.oceantheme.TabIndex = 72;
            this.oceantheme.TabStop = true;
            this.oceantheme.Text = "Ocean";
            this.oceantheme.UseVisualStyleBackColor = true;
            this.oceantheme.CheckedChanged += new System.EventHandler(this.oceantheme_CheckedChanged);
            // 
            // zergtheme
            // 
            this.zergtheme.AutoSize = true;
            this.zergtheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zergtheme.ForeColor = System.Drawing.Color.MediumOrchid;
            this.zergtheme.Location = new System.Drawing.Point(37, 248);
            this.zergtheme.Name = "zergtheme";
            this.zergtheme.Size = new System.Drawing.Size(75, 32);
            this.zergtheme.TabIndex = 71;
            this.zergtheme.Text = "Zerg";
            this.zergtheme.UseVisualStyleBackColor = true;
            this.zergtheme.CheckedChanged += new System.EventHandler(this.zergtheme_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label27.Location = new System.Drawing.Point(12, 123);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(238, 35);
            this.label27.TabIndex = 70;
            this.label27.Tag = "themeable";
            this.label27.Text = "Choose your theme";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.button7;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CancelButton = this.button7;
            this.ClientSize = new System.Drawing.Size(455, 356);
            this.Controls.Add(this.minimaltheme);
            this.Controls.Add(this.carameltheme);
            this.Controls.Add(this.limetheme);
            this.Controls.Add(this.magmatheme);
            this.Controls.Add(this.oceantheme);
            this.Controls.Add(this.zergtheme);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Timer t2;
        private System.Windows.Forms.LinkLabel l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.RadioButton minimaltheme;
        private System.Windows.Forms.RadioButton carameltheme;
        private System.Windows.Forms.RadioButton limetheme;
        private System.Windows.Forms.RadioButton magmatheme;
        private System.Windows.Forms.RadioButton oceantheme;
        private System.Windows.Forms.RadioButton zergtheme;
        private System.Windows.Forms.Label label27;
    }
}