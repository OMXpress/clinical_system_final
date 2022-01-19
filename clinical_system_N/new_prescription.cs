using clinical_system_N.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinical_system_N
{
    internal partial class new_prescription : UserControl
    {
        private PerscribedMedicine _prescription;
        public new_prescription(PerscribedMedicine prescription)
        {
            InitializeComponent();
            _prescription = prescription;
        }

        private void use_label(object sender, EventArgs e)
        {

        }

        private void duration_label(object sender, EventArgs e)
        {
            
        }

        private void med_name_label(object sender, EventArgs e)
        {

        }

        private void act_sub_label(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void new_prescription_Load(object sender, EventArgs e)
        {
            Name_Med.Text = _prescription.MedicineName;
            Active_Substance.Text = _prescription.ActiveIngredient;
            Med_Uses.Text = _prescription.How;
            Med_Duration.Text = _prescription.Duration;
            Delete.Text = "Delete";
        }
    }
}
