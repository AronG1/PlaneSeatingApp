namespace PlaneSeatingApp
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.PrintListBtn = new System.Windows.Forms.Button();
            this.ChooseSeatBtn = new System.Windows.Forms.Button();
            this.SeatingChartBtn = new System.Windows.Forms.Button();
            this.EconomyClassBtn = new System.Windows.Forms.Button();
            this.FirstClassBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.firstClassUserControl2 = new PlaneSeatingApp.FirstClassUserControl();
            this.economyClassUserControl2 = new PlaneSeatingApp.EconomyClassUserControl();
            this.homeUserControl1 = new PlaneSeatingApp.HomeUserControl();
            this.economyClassUserControl1 = new PlaneSeatingApp.EconomyClassUserControl();
            this.firstClassUserControl1 = new PlaneSeatingApp.FirstClassUserControl();
            this.passagerList1 = new PlaneSeatingApp.PassagerListUserControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.PrintListBtn);
            this.panel1.Controls.Add(this.ChooseSeatBtn);
            this.panel1.Controls.Add(this.SeatingChartBtn);
            this.panel1.Controls.Add(this.EconomyClassBtn);
            this.panel1.Controls.Add(this.FirstClassBtn);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 550);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 52);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 80);
            this.SidePanel.TabIndex = 1;
            // 
            // PrintListBtn
            // 
            this.PrintListBtn.FlatAppearance.BorderSize = 0;
            this.PrintListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintListBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrintListBtn.ForeColor = System.Drawing.Color.White;
            this.PrintListBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintListBtn.Image")));
            this.PrintListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintListBtn.Location = new System.Drawing.Point(21, 457);
            this.PrintListBtn.Name = "PrintListBtn";
            this.PrintListBtn.Size = new System.Drawing.Size(190, 80);
            this.PrintListBtn.TabIndex = 0;
            this.PrintListBtn.Text = "Passagers list";
            this.PrintListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintListBtn.UseVisualStyleBackColor = true;
            this.PrintListBtn.Click += new System.EventHandler(this.PrintListBtn_Click);
            // 
            // ChooseSeatBtn
            // 
            this.ChooseSeatBtn.FlatAppearance.BorderSize = 0;
            this.ChooseSeatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseSeatBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChooseSeatBtn.ForeColor = System.Drawing.Color.White;
            this.ChooseSeatBtn.Image = ((System.Drawing.Image)(resources.GetObject("ChooseSeatBtn.Image")));
            this.ChooseSeatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChooseSeatBtn.Location = new System.Drawing.Point(24, 376);
            this.ChooseSeatBtn.Name = "ChooseSeatBtn";
            this.ChooseSeatBtn.Size = new System.Drawing.Size(190, 80);
            this.ChooseSeatBtn.TabIndex = 0;
            this.ChooseSeatBtn.Text = "Choose seat";
            this.ChooseSeatBtn.UseVisualStyleBackColor = true;
            // 
            // SeatingChartBtn
            // 
            this.SeatingChartBtn.FlatAppearance.BorderSize = 0;
            this.SeatingChartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeatingChartBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SeatingChartBtn.ForeColor = System.Drawing.Color.White;
            this.SeatingChartBtn.Image = ((System.Drawing.Image)(resources.GetObject("SeatingChartBtn.Image")));
            this.SeatingChartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeatingChartBtn.Location = new System.Drawing.Point(21, 295);
            this.SeatingChartBtn.Name = "SeatingChartBtn";
            this.SeatingChartBtn.Size = new System.Drawing.Size(190, 80);
            this.SeatingChartBtn.TabIndex = 0;
            this.SeatingChartBtn.Text = "Seating chart";
            this.SeatingChartBtn.UseVisualStyleBackColor = true;
            // 
            // EconomyClassBtn
            // 
            this.EconomyClassBtn.FlatAppearance.BorderSize = 0;
            this.EconomyClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EconomyClassBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EconomyClassBtn.ForeColor = System.Drawing.Color.White;
            this.EconomyClassBtn.Image = ((System.Drawing.Image)(resources.GetObject("EconomyClassBtn.Image")));
            this.EconomyClassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EconomyClassBtn.Location = new System.Drawing.Point(21, 214);
            this.EconomyClassBtn.Name = "EconomyClassBtn";
            this.EconomyClassBtn.Size = new System.Drawing.Size(190, 80);
            this.EconomyClassBtn.TabIndex = 0;
            this.EconomyClassBtn.Text = "Economy Class\r\ncheck in";
            this.EconomyClassBtn.UseVisualStyleBackColor = true;
            this.EconomyClassBtn.Click += new System.EventHandler(this.EconomyClassBtn_Click);
            // 
            // FirstClassBtn
            // 
            this.FirstClassBtn.FlatAppearance.BorderSize = 0;
            this.FirstClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstClassBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FirstClassBtn.ForeColor = System.Drawing.Color.White;
            this.FirstClassBtn.Image = ((System.Drawing.Image)(resources.GetObject("FirstClassBtn.Image")));
            this.FirstClassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstClassBtn.Location = new System.Drawing.Point(21, 133);
            this.FirstClassBtn.Name = "FirstClassBtn";
            this.FirstClassBtn.Size = new System.Drawing.Size(190, 80);
            this.FirstClassBtn.TabIndex = 0;
            this.FirstClassBtn.Text = "First Class\r\ncheck in";
            this.FirstClassBtn.UseVisualStyleBackColor = true;
            this.FirstClassBtn.Click += new System.EventHandler(this.FirstClassBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(21, 52);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(190, 80);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(217, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 17);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(274, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 135);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Airlines";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "C Sharp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(401, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "C# Plane Seating App";
            // 
            // QuitBtn
            // 
            this.QuitBtn.FlatAppearance.BorderSize = 0;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitBtn.Image = ((System.Drawing.Image)(resources.GetObject("QuitBtn.Image")));
            this.QuitBtn.Location = new System.Drawing.Point(942, 29);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(45, 45);
            this.QuitBtn.TabIndex = 4;
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // firstClassUserControl2
            // 
            this.firstClassUserControl2.BackColor = System.Drawing.Color.White;
            this.firstClassUserControl2.Location = new System.Drawing.Point(217, 158);
            this.firstClassUserControl2.Name = "firstClassUserControl2";
            this.firstClassUserControl2.Size = new System.Drawing.Size(783, 392);
            this.firstClassUserControl2.TabIndex = 7;
            this.firstClassUserControl2.Load += new System.EventHandler(this.firstClassUserControl2_Load_1);
            this.firstClassUserControl2.LocationChanged += new System.EventHandler(this.firstClassUserControl2_LocationChanged);
            // 
            // economyClassUserControl2
            // 
            this.economyClassUserControl2.BackColor = System.Drawing.Color.White;
            this.economyClassUserControl2.Location = new System.Drawing.Point(217, 158);
            this.economyClassUserControl2.Name = "economyClassUserControl2";
            this.economyClassUserControl2.Size = new System.Drawing.Size(783, 392);
            this.economyClassUserControl2.TabIndex = 5;
            this.economyClassUserControl2.Load += new System.EventHandler(this.economyClassUserControl2_Load_1);
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.BackColor = System.Drawing.Color.Silver;
            this.homeUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeUserControl1.BackgroundImage")));
            this.homeUserControl1.Location = new System.Drawing.Point(217, 158);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(783, 392);
            this.homeUserControl1.TabIndex = 6;
            // 
            // economyClassUserControl1
            // 
            this.economyClassUserControl1.BackColor = System.Drawing.Color.White;
            this.economyClassUserControl1.Location = new System.Drawing.Point(217, 155);
            this.economyClassUserControl1.Name = "economyClassUserControl1";
            this.economyClassUserControl1.Size = new System.Drawing.Size(783, 392);
            this.economyClassUserControl1.TabIndex = 7;
            // 
            // firstClassUserControl1
            // 
            this.firstClassUserControl1.BackColor = System.Drawing.Color.White;
            this.firstClassUserControl1.Location = new System.Drawing.Point(217, 155);
            this.firstClassUserControl1.Name = "firstClassUserControl1";
            this.firstClassUserControl1.Size = new System.Drawing.Size(783, 392);
            this.firstClassUserControl1.TabIndex = 6;
            this.firstClassUserControl1.Load += new System.EventHandler(this.FirstClassUserControl1_Load);
            // 
            // passagerList1
            // 
            this.passagerList1.BackColor = System.Drawing.SystemColors.Control;
            this.passagerList1.Location = new System.Drawing.Point(217, 158);
            this.passagerList1.Name = "passagerList1";
            this.passagerList1.Size = new System.Drawing.Size(783, 392);
            this.passagerList1.TabIndex = 8;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.firstClassUserControl2);
            this.Controls.Add(this.economyClassUserControl2);
            this.Controls.Add(this.homeUserControl1);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passagerList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plane seating app";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ChooseSeatBtn;
        private System.Windows.Forms.Button SeatingChartBtn;
        private System.Windows.Forms.Button EconomyClassBtn;
        private System.Windows.Forms.Button FirstClassBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button QuitBtn;
        private FirstClassUserControl firstClassUserControl1;
        private EconomyClassUserControl economyClassUserControl1;
        private System.Windows.Forms.Button PrintListBtn;

        public string passagerName;
        private EconomyClassUserControl economyClassUserControl2;
        private HomeUserControl homeUserControl1;
        private FirstClassUserControl firstClassUserControl2;
        private PassagerListUserControl passagerList1;
    }
}

