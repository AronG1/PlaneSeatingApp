namespace PlaneSeatingApp
{
    partial class EconomyClassUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EconomyClassUserControl));
            this.CheckInEconomyBtn = new System.Windows.Forms.Button();
            this.NameEconomyTxtBx = new System.Windows.Forms.TextBox();
            this.LastNameEconomyTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EconomyClassMsgSucFail = new System.Windows.Forms.Label();
            this.WarningMessageEconomyClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckInEconomyBtn
            // 
            this.CheckInEconomyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.CheckInEconomyBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CheckInEconomyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckInEconomyBtn.Font = new System.Drawing.Font("Century Gothic", 16.25F);
            this.CheckInEconomyBtn.Location = new System.Drawing.Point(132, 297);
            this.CheckInEconomyBtn.Name = "CheckInEconomyBtn";
            this.CheckInEconomyBtn.Size = new System.Drawing.Size(134, 57);
            this.CheckInEconomyBtn.TabIndex = 10;
            this.CheckInEconomyBtn.Text = "Check in";
            this.CheckInEconomyBtn.UseVisualStyleBackColor = false;
            this.CheckInEconomyBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // NameEconomyTxtBx
            // 
            this.NameEconomyTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.NameEconomyTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameEconomyTxtBx.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameEconomyTxtBx.Location = new System.Drawing.Point(184, 172);
            this.NameEconomyTxtBx.Name = "NameEconomyTxtBx";
            this.NameEconomyTxtBx.Size = new System.Drawing.Size(168, 33);
            this.NameEconomyTxtBx.TabIndex = 8;
            this.NameEconomyTxtBx.TextChanged += new System.EventHandler(this.NameEconomyTxtBx_TextChanged);
            // 
            // LastNameEconomyTxtBx
            // 
            this.LastNameEconomyTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.LastNameEconomyTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameEconomyTxtBx.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastNameEconomyTxtBx.Location = new System.Drawing.Point(184, 227);
            this.LastNameEconomyTxtBx.Name = "LastNameEconomyTxtBx";
            this.LastNameEconomyTxtBx.Size = new System.Drawing.Size(168, 33);
            this.LastNameEconomyTxtBx.TabIndex = 9;
            this.LastNameEconomyTxtBx.TextChanged += new System.EventHandler(this.LastNameEconomyTxtBx_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(61, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(103, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Economy class check in";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(480, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 200);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // EconomyClassMsgSucFail
            // 
            this.EconomyClassMsgSucFail.AutoSize = true;
            this.EconomyClassMsgSucFail.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.EconomyClassMsgSucFail.Location = new System.Drawing.Point(312, 330);
            this.EconomyClassMsgSucFail.Name = "EconomyClassMsgSucFail";
            this.EconomyClassMsgSucFail.Size = new System.Drawing.Size(316, 24);
            this.EconomyClassMsgSucFail.TabIndex = 13;
            this.EconomyClassMsgSucFail.Text = "Your seat is booked sucessfuly";
            this.EconomyClassMsgSucFail.Visible = false;
            // 
            // WarningMessageEconomyClass
            // 
            this.WarningMessageEconomyClass.AutoSize = true;
            this.WarningMessageEconomyClass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WarningMessageEconomyClass.ForeColor = System.Drawing.Color.Red;
            this.WarningMessageEconomyClass.Location = new System.Drawing.Point(312, 330);
            this.WarningMessageEconomyClass.Name = "WarningMessageEconomyClass";
            this.WarningMessageEconomyClass.Size = new System.Drawing.Size(227, 24);
            this.WarningMessageEconomyClass.TabIndex = 12;
            this.WarningMessageEconomyClass.Text = "All fields are required!";
            // 
            // EconomyClassUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EconomyClassMsgSucFail);
            this.Controls.Add(this.WarningMessageEconomyClass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckInEconomyBtn);
            this.Controls.Add(this.NameEconomyTxtBx);
            this.Controls.Add(this.LastNameEconomyTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EconomyClassUserControl";
            this.Size = new System.Drawing.Size(783, 392);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CheckInEconomyBtn;
        private System.Windows.Forms.TextBox NameEconomyTxtBx;
        private System.Windows.Forms.TextBox LastNameEconomyTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EconomyClassMsgSucFail;
        private System.Windows.Forms.Label WarningMessageEconomyClass;
    }
}
