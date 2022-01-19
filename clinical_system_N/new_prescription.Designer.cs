
namespace clinical_system_N
{
    partial class new_prescription
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
            this.Name_Med = new System.Windows.Forms.Label();
            this.Active_Substance = new System.Windows.Forms.Label();
            this.Med_Uses = new System.Windows.Forms.Label();
            this.Med_Duration = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_Med
            // 
            this.Name_Med.AutoSize = true;
            this.Name_Med.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Med.Location = new System.Drawing.Point(16, 25);
            this.Name_Med.Name = "Name_Med";
            this.Name_Med.Size = new System.Drawing.Size(161, 25);
            this.Name_Med.TabIndex = 0;
            this.Name_Med.Text = "Medicine Name";
            this.Name_Med.Click += new System.EventHandler(this.med_name_label);
            // 
            // Active_Substance
            // 
            this.Active_Substance.AutoSize = true;
            this.Active_Substance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active_Substance.Location = new System.Drawing.Point(225, 25);
            this.Active_Substance.Name = "Active_Substance";
            this.Active_Substance.Size = new System.Drawing.Size(181, 25);
            this.Active_Substance.TabIndex = 1;
            this.Active_Substance.Text = "Active Substance";
            this.Active_Substance.Click += new System.EventHandler(this.act_sub_label);
            // 
            // Med_Uses
            // 
            this.Med_Uses.AutoSize = true;
            this.Med_Uses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Med_Uses.Location = new System.Drawing.Point(455, 25);
            this.Med_Uses.Name = "Med_Uses";
            this.Med_Uses.Size = new System.Drawing.Size(50, 25);
            this.Med_Uses.TabIndex = 2;
            this.Med_Uses.Text = "Use";
            this.Med_Uses.Click += new System.EventHandler(this.use_label);
            // 
            // Med_Duration
            // 
            this.Med_Duration.AutoSize = true;
            this.Med_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Med_Duration.Location = new System.Drawing.Point(563, 25);
            this.Med_Duration.Name = "Med_Duration";
            this.Med_Duration.Size = new System.Drawing.Size(93, 25);
            this.Med_Duration.TabIndex = 3;
            this.Med_Duration.Text = "Duration";
            this.Med_Duration.Click += new System.EventHandler(this.duration_label);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(757, 25);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(103, 30);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // new_prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Med_Duration);
            this.Controls.Add(this.Med_Uses);
            this.Controls.Add(this.Active_Substance);
            this.Controls.Add(this.Name_Med);
            this.Name = "new_prescription";
            this.Size = new System.Drawing.Size(882, 77);
            this.Load += new System.EventHandler(this.new_prescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Med;
        private System.Windows.Forms.Label Active_Substance;
        private System.Windows.Forms.Label Med_Uses;
        private System.Windows.Forms.Label Med_Duration;
        private System.Windows.Forms.Button Delete;
    }
}
