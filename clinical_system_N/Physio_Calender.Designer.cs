namespace clinical_system_N
{
    partial class Physio_Calender
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
            this.lblPatient1 = new System.Windows.Forms.Label();
            this.lblPatient2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPatient1
            // 
            this.lblPatient1.AutoSize = true;
            this.lblPatient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient1.Location = new System.Drawing.Point(4, 3);
            this.lblPatient1.Name = "lblPatient1";
            this.lblPatient1.Size = new System.Drawing.Size(83, 25);
            this.lblPatient1.TabIndex = 0;
            this.lblPatient1.Text = "Patient1";
            this.lblPatient1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPatient2
            // 
            this.lblPatient2.AutoSize = true;
            this.lblPatient2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient2.Location = new System.Drawing.Point(3, 16);
            this.lblPatient2.Name = "lblPatient2";
            this.lblPatient2.Size = new System.Drawing.Size(83, 25);
            this.lblPatient2.TabIndex = 1;
            this.lblPatient2.Text = "Patient2";
            this.lblPatient2.Click += new System.EventHandler(this.lblPatient2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPatient1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 37);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.lblPatient2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 172);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 41);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Physio_Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Physio_Calender";
            this.Size = new System.Drawing.Size(254, 212);
            this.Load += new System.EventHandler(this.CalendarBlock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPatient1;
        private System.Windows.Forms.Label lblPatient2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
