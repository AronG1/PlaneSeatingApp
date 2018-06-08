namespace PlaneSeatingApp
{
    partial class FirstClassUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstClassUserControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LastNameFirstClassTxtBx = new System.Windows.Forms.TextBox();
            this.NameFirstClassTextBx = new System.Windows.Forms.TextBox();
            this.CheckInFirstClassBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WarningMessageFirstClass = new System.Windows.Forms.Label();
            this.FirstClassMsgSucFail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "First class check in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(103, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(61, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last name";
            // 
            // LastNameFirstClassTxtBx
            // 
            this.LastNameFirstClassTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.LastNameFirstClassTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameFirstClassTxtBx.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastNameFirstClassTxtBx.Location = new System.Drawing.Point(184, 227);
            this.LastNameFirstClassTxtBx.Name = "LastNameFirstClassTxtBx";
            this.LastNameFirstClassTxtBx.Size = new System.Drawing.Size(168, 33);
            this.LastNameFirstClassTxtBx.TabIndex = 2;
            this.LastNameFirstClassTxtBx.TextChanged += new System.EventHandler(this.LastNameFirstClassTxtBx_TextChanged);
            // 
            // NameFirstClassTextBx
            // 
            this.NameFirstClassTextBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.NameFirstClassTextBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameFirstClassTextBx.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameFirstClassTextBx.Location = new System.Drawing.Point(184, 172);
            this.NameFirstClassTextBx.Name = "NameFirstClassTextBx";
            this.NameFirstClassTextBx.Size = new System.Drawing.Size(168, 33);
            this.NameFirstClassTextBx.TabIndex = 2;
            this.NameFirstClassTextBx.TextChanged += new System.EventHandler(this.NameFirstClassTextBx_TextChanged);
            // 
            // CheckInFirstClassBtn
            // 
            this.CheckInFirstClassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.CheckInFirstClassBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CheckInFirstClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckInFirstClassBtn.Font = new System.Drawing.Font("Century Gothic", 16.25F);
            this.CheckInFirstClassBtn.Location = new System.Drawing.Point(132, 297);
            this.CheckInFirstClassBtn.Name = "CheckInFirstClassBtn";
            this.CheckInFirstClassBtn.Size = new System.Drawing.Size(134, 57);
            this.CheckInFirstClassBtn.TabIndex = 3;
            this.CheckInFirstClassBtn.Text = "Check in";
            this.CheckInFirstClassBtn.UseVisualStyleBackColor = false;
            this.CheckInFirstClassBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(480, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 200);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // WarningMessageFirstClass
            // 
            this.WarningMessageFirstClass.AutoSize = true;
            this.WarningMessageFirstClass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WarningMessageFirstClass.ForeColor = System.Drawing.Color.Red;
            this.WarningMessageFirstClass.Location = new System.Drawing.Point(297, 330);
            this.WarningMessageFirstClass.Name = "WarningMessageFirstClass";
            this.WarningMessageFirstClass.Size = new System.Drawing.Size(227, 24);
            this.WarningMessageFirstClass.TabIndex = 1;
            this.WarningMessageFirstClass.Text = "All fields are required!";
            // 
            // FirstClassMsgSucFail
            // 
            this.FirstClassMsgSucFail.AutoSize = true;
            this.FirstClassMsgSucFail.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.FirstClassMsgSucFail.Location = new System.Drawing.Point(297, 330);
            this.FirstClassMsgSucFail.Name = "FirstClassMsgSucFail";
            this.FirstClassMsgSucFail.Size = new System.Drawing.Size(316, 24);
            this.FirstClassMsgSucFail.TabIndex = 5;
            this.FirstClassMsgSucFail.Text = "Your seat is booked sucessfuly";
            this.FirstClassMsgSucFail.Visible = false;
            // 
            // FirstClassUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FirstClassMsgSucFail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckInFirstClassBtn);
            this.Controls.Add(this.NameFirstClassTextBx);
            this.Controls.Add(this.LastNameFirstClassTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WarningMessageFirstClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FirstClassUserControl";
            this.Size = new System.Drawing.Size(783, 392);
            this.Load += new System.EventHandler(this.FirstClassUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastNameFirstClassTxtBx;
        private System.Windows.Forms.TextBox NameFirstClassTextBx;
        private System.Windows.Forms.Button CheckInFirstClassBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WarningMessageFirstClass;
        private System.Windows.Forms.Label FirstClassMsgSucFail;
    }
}
