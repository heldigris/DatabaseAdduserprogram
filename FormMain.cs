using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DatabaseTest1
{
    public partial class FormMain : Form
    {

        SqlConnection connection;
        string connectionString;

        public FormMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["DatabaseTest1.Properties.Settings.DatabaseTest1ConnectionString"].ConnectionString;
        }

        private void leadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.leadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseTest1DataSet);
            


        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseTest1DataSet.Lead' table. You can move, or remove it, as needed.
            //this.leadTableAdapter.Fill(this.databaseTest1DataSet.Lead);

            PopulateLead();

        }

        private void PopulateLead()
        {
            string query = "select * from Lead";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable LeadTable = new DataTable();
                adapter.Fill(LeadTable);

                ListResultat.DisplayMember = "Fornavn";
                ListResultat.ValueMember = "Id";

                ListResultat.DataSource = LeadTable;
            }

                
        }

        private void btnLead_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Lead" +
                "(Fornavn, Etternavn, Epost, Telefon, Adresse, Postnr, PostSted, Dato, LeadType)" +
                "VALUES (@Fornavn, @Etternavn, @Epost, @Telefon, @Adresse, @Postnr, @PostSted, @Dato, @LeadType)";

                //('" + this.FornavnBox.Text + "','" + this.EtternavnBox.Text + "','" + this.EpostBox.Text + "','" + this.TelefonBox.Text + "','" + this.GateAdresseBox.Text + "','" + this.PostnrBox.Text + "','" + this.PostStedBox.Text + "','" + this.DatoBox.Text + "','" +this.KildeBox.Text + "') ; ";


            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                // Should instert the text entered in the search fields into the databse
                command.Parameters.AddWithValue("@Fornavn", FornavnBox.Text);
                command.Parameters.AddWithValue("@Etternavn", EtternavnBox.Text);
                command.Parameters.AddWithValue("@Epost", EpostBox.Text);
                command.Parameters.AddWithValue("@Telefon", TelefonBox.Text);
                command.Parameters.AddWithValue("@Adresse", GateAdresseBox.Text);
                command.Parameters.AddWithValue("@Postnr", PostnrBox.Text);
                command.Parameters.AddWithValue("@PostSted", PostStedBox.Text);
                command.Parameters.AddWithValue("@Dato", DatoBox.Text);
                command.Parameters.AddWithValue("@LeadType", KildeBox.Text);

                command.ExecuteNonQuery();
                //DataTable LeadTable = new DataTable();
                //adapter.Fill(LeadTable);

                ListResultat.DisplayMember = "Fornavn";
                ListResultat.ValueMember = "Id";


                //ListResultat.DataSource = LeadTable;
            }
            PopulateLead();
        }
    }
}
