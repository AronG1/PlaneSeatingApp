namespace PlaneSeatingApp
{
    partial class PassagerListUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.LstViewName = new System.Windows.Forms.ListView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.LstViewLastName = new System.Windows.Forms.ListView();
            this.lblRow = new System.Windows.Forms.Label();
            this.LstViewRow = new System.Windows.Forms.ListView();
            this.lblSeat = new System.Windows.Forms.Label();
            this.LstViewSeat = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passagers on this flight: ";
            // 
            // LstViewName
            // 
            this.LstViewName.BackColor = System.Drawing.SystemColors.Control;
            this.LstViewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstViewName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LstViewName.Location = new System.Drawing.Point(33, 98);
            this.LstViewName.Name = "LstViewName";
            this.LstViewName.Size = new System.Drawing.Size(125, 278);
            this.LstViewName.TabIndex = 1;
            this.LstViewName.UseCompatibleStateImageBehavior = false;
            this.LstViewName.View = System.Windows.Forms.View.List;
            this.LstViewName.SelectedIndexChanged += new System.EventHandler(this.PassagersLst_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.lblName.Location = new System.Drawing.Point(29, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.lblLastName.Location = new System.Drawing.Point(160, 71);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(97, 21);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last name";
            // 
            // LstViewLastName
            // 
            this.LstViewLastName.BackColor = System.Drawing.SystemColors.Control;
            this.LstViewLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstViewLastName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LstViewLastName.Location = new System.Drawing.Point(164, 98);
            this.LstViewLastName.Name = "LstViewLastName";
            this.LstViewLastName.Size = new System.Drawing.Size(125, 278);
            this.LstViewLastName.TabIndex = 3;
            this.LstViewLastName.UseCompatibleStateImageBehavior = false;
            this.LstViewLastName.View = System.Windows.Forms.View.List;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.lblRow.Location = new System.Drawing.Point(291, 71);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(45, 21);
            this.lblRow.TabIndex = 6;
            this.lblRow.Text = "Row";
            // 
            // LstViewRow
            // 
            this.LstViewRow.BackColor = System.Drawing.SystemColors.Control;
            this.LstViewRow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstViewRow.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LstViewRow.Location = new System.Drawing.Point(295, 98);
            this.LstViewRow.Name = "LstViewRow";
            this.LstViewRow.Size = new System.Drawing.Size(41, 278);
            this.LstViewRow.TabIndex = 5;
            this.LstViewRow.UseCompatibleStateImageBehavior = false;
            this.LstViewRow.View = System.Windows.Forms.View.List;
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.lblSeat.Location = new System.Drawing.Point(338, 71);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(48, 21);
            this.lblSeat.TabIndex = 8;
            this.lblSeat.Text = "Seat";
            // 
            // LstViewSeat
            // 
            this.LstViewSeat.BackColor = System.Drawing.SystemColors.Control;
            this.LstViewSeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstViewSeat.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LstViewSeat.Location = new System.Drawing.Point(342, 98);
            this.LstViewSeat.Name = "LstViewSeat";
            this.LstViewSeat.Size = new System.Drawing.Size(44, 278);
            this.LstViewSeat.TabIndex = 7;
            this.LstViewSeat.UseCompatibleStateImageBehavior = false;
            this.LstViewSeat.View = System.Windows.Forms.View.List;
            // 
            // PassagerListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.LstViewSeat);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.LstViewRow);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.LstViewLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.LstViewName);
            this.Controls.Add(this.label1);
            this.Name = "PassagerListUserControl";
            this.Size = new System.Drawing.Size(783, 392);
            this.Load += new System.EventHandler(this.PassagerListUserControl_Load);
            this.VisibleChanged += new System.EventHandler(this.PassagerListUserControl_VisibleChanged);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.PassagerListUserControl_DragOver);
            this.Enter += new System.EventHandler(this.PassagerListUserControl_Enter);
            this.Move += new System.EventHandler(this.PassagerListUserControl_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LstViewName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ListView LstViewLastName;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.ListView LstViewRow;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.ListView LstViewSeat;
    }
}
