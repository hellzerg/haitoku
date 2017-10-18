namespace Haitoku
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.lblUser = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.animeListView = new System.Windows.Forms.ListView();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblOnHold = new System.Windows.Forms.Label();
            this.lblWatching = new System.Windows.Forms.Label();
            this.lblDropped = new System.Windows.Forms.Label();
            this.lblPlanToWatch = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(189, 35);
            this.lblUser.TabIndex = 3;
            this.lblUser.Tag = "themeable";
            this.lblUser.Text = "ConnectedUser";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatar
            // 
            this.avatar.ErrorImage = null;
            this.avatar.InitialImage = null;
            this.avatar.Location = new System.Drawing.Point(18, 47);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(284, 260);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 5;
            this.avatar.TabStop = false;
            // 
            // animeListView
            // 
            this.animeListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animeListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.animeListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animeListView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animeListView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animeListView.ForeColor = System.Drawing.Color.White;
            this.animeListView.Location = new System.Drawing.Point(308, 47);
            this.animeListView.MultiSelect = false;
            this.animeListView.Name = "animeListView";
            this.animeListView.Size = new System.Drawing.Size(693, 619);
            this.animeListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.animeListView.TabIndex = 6;
            this.animeListView.UseCompatibleStateImageBehavior = false;
            this.animeListView.SelectedIndexChanged += new System.EventHandler(this.animeListView_SelectedIndexChanged);
            this.animeListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.animeListView_MouseDoubleClick);
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.White;
            this.lblCompleted.Location = new System.Drawing.Point(-5, 66);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(138, 28);
            this.lblCompleted.TabIndex = 9;
            this.lblCompleted.Text = "Completed: ...";
            // 
            // lblOnHold
            // 
            this.lblOnHold.AutoSize = true;
            this.lblOnHold.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnHold.ForeColor = System.Drawing.Color.White;
            this.lblOnHold.Location = new System.Drawing.Point(-4, 94);
            this.lblOnHold.Name = "lblOnHold";
            this.lblOnHold.Size = new System.Drawing.Size(112, 28);
            this.lblOnHold.TabIndex = 10;
            this.lblOnHold.Text = "On hold: ...";
            // 
            // lblWatching
            // 
            this.lblWatching.AutoSize = true;
            this.lblWatching.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatching.ForeColor = System.Drawing.Color.White;
            this.lblWatching.Location = new System.Drawing.Point(-5, 38);
            this.lblWatching.Name = "lblWatching";
            this.lblWatching.Size = new System.Drawing.Size(123, 28);
            this.lblWatching.TabIndex = 11;
            this.lblWatching.Text = "Watching: ...";
            // 
            // lblDropped
            // 
            this.lblDropped.AutoSize = true;
            this.lblDropped.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropped.ForeColor = System.Drawing.Color.White;
            this.lblDropped.Location = new System.Drawing.Point(-4, 122);
            this.lblDropped.Name = "lblDropped";
            this.lblDropped.Size = new System.Drawing.Size(118, 28);
            this.lblDropped.TabIndex = 12;
            this.lblDropped.Text = "Dropped: ...";
            // 
            // lblPlanToWatch
            // 
            this.lblPlanToWatch.AutoSize = true;
            this.lblPlanToWatch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanToWatch.ForeColor = System.Drawing.Color.White;
            this.lblPlanToWatch.Location = new System.Drawing.Point(-5, 150);
            this.lblPlanToWatch.Name = "lblPlanToWatch";
            this.lblPlanToWatch.Size = new System.Drawing.Size(196, 28);
            this.lblPlanToWatch.TabIndex = 13;
            this.lblPlanToWatch.Text = "Planned to watch: ...";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.Color.White;
            this.lblStats.Location = new System.Drawing.Point(-4, 178);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(226, 28);
            this.lblStats.TabIndex = 14;
            this.lblStats.Text = "Days spent watching: ...";
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAll.ForeColor = System.Drawing.Color.White;
            this.lblAll.Location = new System.Drawing.Point(-4, 10);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(123, 28);
            this.lblAll.TabIndex = 15;
            this.lblAll.Text = "All anime: ...";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(399, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(602, 34);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 35);
            this.label1.TabIndex = 17;
            this.label1.Tag = "themeable";
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lblDropped);
            this.panel1.Controls.Add(this.lblCompleted);
            this.panel1.Controls.Add(this.lblOnHold);
            this.panel1.Controls.Add(this.lblAll);
            this.panel1.Controls.Add(this.lblWatching);
            this.panel1.Controls.Add(this.lblStats);
            this.panel1.Controls.Add(this.lblPlanToWatch);
            this.panel1.Location = new System.Drawing.Point(18, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 318);
            this.panel1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(124, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 29;
            this.button1.Tag = "themeable";
            this.button1.Text = "Options";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 41);
            this.button2.TabIndex = 28;
            this.button2.Tag = "themeable";
            this.button2.Text = "MyAnimeList";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(12, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 35);
            this.label2.TabIndex = 19;
            this.label2.Tag = "themeable";
            this.label2.Text = "Anime stats";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAvatar.Location = new System.Drawing.Point(93, 153);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(125, 35);
            this.lblAvatar.TabIndex = 20;
            this.lblAvatar.Tag = "themeable";
            this.lblAvatar.Text = "Loading...";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblView
            // 
            this.lblView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblView.Location = new System.Drawing.Point(587, 310);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(125, 35);
            this.lblView.TabIndex = 21;
            this.lblView.Tag = "themeable";
            this.lblView.Text = "Loading...";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1013, 678);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.lblAvatar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.animeListView);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.lblUser);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haitoku ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileForm_FormClosing);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.ListView animeListView;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblOnHold;
        private System.Windows.Forms.Label lblWatching;
        private System.Windows.Forms.Label lblDropped;
        private System.Windows.Forms.Label lblPlanToWatch;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}