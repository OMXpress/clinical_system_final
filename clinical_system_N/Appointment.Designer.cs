
namespace clinical_system_N
{
    partial class Appointment
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
            this.name_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.start_t_label = new System.Windows.Forms.Label();
            this.medical_record_btn = new System.Windows.Forms.Button();
            this.open_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(12, 22);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(68, 25);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.Location = new System.Drawing.Point(104, 22);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(113, 25);
            this.phone_label.TabIndex = 1;
            this.phone_label.Text = "Phone No.";
            // 
            // start_t_label
            // 
            this.start_t_label.AutoSize = true;
            this.start_t_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_t_label.Location = new System.Drawing.Point(243, 22);
            this.start_t_label.Name = "start_t_label";
            this.start_t_label.Size = new System.Drawing.Size(118, 25);
            this.start_t_label.TabIndex = 2;
            this.start_t_label.Text = "Start_Time";
            this.start_t_label.Click += new System.EventHandler(this.start_t_label_Click);
            // 
            // medical_record_btn
            // 
            this.medical_record_btn.AutoSize = true;
            this.medical_record_btn.Location = new System.Drawing.Point(384, 22);
            this.medical_record_btn.Name = "medical_record_btn";
            this.medical_record_btn.Size = new System.Drawing.Size(120, 30);
            this.medical_record_btn.TabIndex = 3;
            this.medical_record_btn.Text = "Medical_Record";
            this.medical_record_btn.UseVisualStyleBackColor = true;
            // 
            // open_btn
            // 
            this.open_btn.AutoSize = true;
            this.open_btn.Location = new System.Drawing.Point(510, 22);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(103, 30);
            this.open_btn.TabIndex = 4;
            this.open_btn.Text = "Open";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.AutoSize = true;
            this.Delete_btn.BackColor = System.Drawing.Color.Red;
            this.Delete_btn.Location = new System.Drawing.Point(619, 22);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(27, 30);
            this.Delete_btn.TabIndex = 5;
            this.Delete_btn.Text = "X";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.medical_record_btn);
            this.Controls.Add(this.start_t_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.name_label);
            this.Name = "Appointment";
            this.Size = new System.Drawing.Size(659, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label start_t_label;
        private System.Windows.Forms.Button medical_record_btn;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button Delete_btn;
    }
}
