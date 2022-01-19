
namespace clinical_system_N
{
    partial class AppointmentControl
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
            this.type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(12, 6);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(68, 25);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.Location = new System.Drawing.Point(416, 6);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(113, 25);
            this.phone_label.TabIndex = 1;
            this.phone_label.Text = "Phone No.";
            // 
            // start_t_label
            // 
            this.start_t_label.AutoSize = true;
            this.start_t_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_t_label.Location = new System.Drawing.Point(727, 6);
            this.start_t_label.Name = "start_t_label";
            this.start_t_label.Size = new System.Drawing.Size(118, 25);
            this.start_t_label.TabIndex = 2;
            this.start_t_label.Text = "Start_Time";
            this.start_t_label.Click += new System.EventHandler(this.start_t_label_Click);
            // 
            // medical_record_btn
            // 
            this.medical_record_btn.AutoSize = true;
            this.medical_record_btn.Location = new System.Drawing.Point(970, 6);
            this.medical_record_btn.Name = "medical_record_btn";
            this.medical_record_btn.Size = new System.Drawing.Size(120, 30);
            this.medical_record_btn.TabIndex = 3;
            this.medical_record_btn.Text = "Medical Record";
            this.medical_record_btn.UseVisualStyleBackColor = true;
            this.medical_record_btn.Click += new System.EventHandler(this.medical_record_btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.AutoSize = true;
            this.open_btn.Location = new System.Drawing.Point(1119, 6);
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
            this.Delete_btn.Location = new System.Drawing.Point(1237, 6);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(27, 30);
            this.Delete_btn.TabIndex = 5;
            this.Delete_btn.Text = "X";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(211, 6);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(61, 25);
            this.type.TabIndex = 6;
            this.type.Text = "Type";
            // 
            // AppointmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.type);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.medical_record_btn);
            this.Controls.Add(this.start_t_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.name_label);
            this.Name = "AppointmentControl";
            this.Size = new System.Drawing.Size(1278, 39);
            this.Load += new System.EventHandler(this.AppointmentControl_Load);
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
        private System.Windows.Forms.Label type;
    }
}
