namespace clinical_system_N
{
    partial class PatientUserControl
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
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.BtnOpenRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(14, 20);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(129, 25);
            this.lblPatientName.TabIndex = 0;
            this.lblPatientName.Text = "Patient Name";
            this.lblPatientName.Click += new System.EventHandler(this.lblPatientName_Click);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(243, 20);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(96, 25);
            this.lblPatientID.TabIndex = 1;
            this.lblPatientID.Text = "Patient ID";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(582, 21);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(133, 25);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "01068037112";
            // 
            // BtnOpenRecord
            // 
            this.BtnOpenRecord.Location = new System.Drawing.Point(1114, 15);
            this.BtnOpenRecord.Name = "BtnOpenRecord";
            this.BtnOpenRecord.Size = new System.Drawing.Size(135, 40);
            this.BtnOpenRecord.TabIndex = 3;
            this.BtnOpenRecord.Text = "Open";
            this.BtnOpenRecord.UseVisualStyleBackColor = true;
            this.BtnOpenRecord.Click += new System.EventHandler(this.BtnOpenRecord_Click);
            // 
            // PatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.BtnOpenRecord);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblPatientName);
            this.Name = "PatientUserControl";
            this.Size = new System.Drawing.Size(1261, 67);
            this.Load += new System.EventHandler(this.PatientUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button BtnOpenRecord;
    }
}
