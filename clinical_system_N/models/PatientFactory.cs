using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinical_system_N.models
{
    internal static class PatientFactory
    {

        public static Patient FindIfExist(string phone, string email)
        {
            DBController dBController = new DBController();
            try
            {
                string query = string.Format("SELECT * FROM PATIENT WHERE EMAIL = {0}", email);
                string PatientId = string.Empty;
                string PatientName = string.Empty;
                string DoB = string.Empty;
                string NationalID = string.Empty;
                string gender = string.Empty;
                string Email = string.Empty;
                string Phone = string.Empty;
                string Address = string.Empty;
                string MaritialStatus = string.Empty;
                string Proffession = string.Empty;
                if (dBController.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, dBController.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        PatientId = dataReader["PATIENT_ID"].ToString();
                        PatientName = dataReader["F_NAME"].ToString() + ' ' + dataReader["L_NAME"].ToString();
                        DoB = dataReader["DATE_OF_BIRTH"].ToString();
                        NationalID = dataReader["NATIONAL_ID"].ToString();
                        gender = dataReader["GENDER"].ToString();
                        Email = dataReader["EMAIL"].ToString();
                        Phone = dataReader["PHONE"].ToString();
                        Address = dataReader["ADDRESS"].ToString();
                        MaritialStatus = dataReader["MARITIAL_STATUS"].ToString();
                        Proffession = dataReader["PROFESSION"].ToString();
                    }
                    dataReader.Close();
                    
                    dBController.CloseConnection();

                }
                Gender gender1;
                MaritialStatus maritialStatus;
                if (MaritialStatus == "Married")
                {
                    maritialStatus = global::MaritialStatus.Married;
                }
                else if (MaritialStatus == "Divorced")
                {
                    maritialStatus = global::MaritialStatus.Divorced;
                }
                else if (MaritialStatus == "Widowed")
                {
                    maritialStatus = global::MaritialStatus.Widowed;
                }
                else
                {
                    maritialStatus = global::MaritialStatus.Single;
                }
                if (gender == "Male")
                {
                     gender1 = Gender.male;
                }
                else { gender1 = Gender.female; }

                PatientInformation information = new PatientInformation(PatientId, PatientName, DoB, NationalID, gender1, Email, Phone, Address, maritialStatus, Proffession);
                Patient patient = new Patient(information);
                return patient;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Patient CreatePatient(string lname ,string fname, string dob, string nationalID, string gender, string email, string phone, string address, string MaritialStatus, string proffession)
        {
            string patientID = Guid.NewGuid().ToString();
            Gender gender1;
            MaritialStatus maritialStatus;
            if (MaritialStatus == "Married")
            {
                maritialStatus = global::MaritialStatus.Married;
            }
            else if (MaritialStatus == "Divorced")
            {
                maritialStatus = global::MaritialStatus.Divorced;
            }
            else if (MaritialStatus == "Widowed")
            {
                maritialStatus = global::MaritialStatus.Widowed;
            }
            else
            {
                maritialStatus = global::MaritialStatus.Single;
            }
            if (gender == "Male")
            {
                gender1 = Gender.male;
            }
            else { gender1 = Gender.female; }
            string name = fname + " " + lname;
            PatientInformation information = new PatientInformation(patientID, name, dob, nationalID, gender1, email, phone, address, maritialStatus, proffession);

            Patient patient = new Patient(information);

            // insert into database

            DBController db = new DBController();

            string q = string.Format("insert into PATIENT values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",
                patientID, fname, lname, dob, nationalID, gender, email, phone, address, MaritialStatus, proffession);
            try
            {
                if (db.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(q, db.connection);
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                    DirectoryManager.ReadyPatient(patientID);
                    SaveMeta(information);

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            return patient;
        }
        public static void SaveMeta(PatientInformation information)
        {
            JsonManager jsonManager = new JsonManager();
            jsonManager.AddMetaData(information.PatientId, information);
        }
        public static List<Patient> GetAllPatients()
        {
            List<Patient> list = new List<Patient>();

            JsonManager jsonManager = new JsonManager();
            var infos = jsonManager.GetAllInfo();
            foreach (var info in infos)
            {
                Patient patient = new Patient(info);
                list.Add(patient);
            }
            return list;
        }

        public static List<PerscribedMedicine> GetAllPrescribedMeds()
        {
            List<PerscribedMedicine> list = new List<PerscribedMedicine>();

            JsonManager jsonManager = new JsonManager();
            var infos = jsonManager.GetMedInfo();
            Console.WriteLine(infos.ToString());
            foreach (var info in infos)
            {
                PerscribedMedicine perscribedMedicine = new PerscribedMedicine(info.MedicineName.ToString(), info.Duration.ToString(), info.Dose.ToString(), info.How.ToString(), info.ActiveIngredient.ToString());
                list.Add(perscribedMedicine);
            }
            return list;
        }
    }
}
