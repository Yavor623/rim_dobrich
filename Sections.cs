using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using static System.Collections.Specialized.BitVector32;

namespace RIMDobrich1
{
    public partial class Sections : Form
    {
        Bitmap bitmap;
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDT = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        String server = "127.0.0.1";
        String username = "root";
        String password = "";
        String database = "rim_dobrich";
        public Sections()
        {
            InitializeComponent();
        }
        private void SetFontAndColors()
        {
            this.sectionsDataGrid.DefaultCellStyle.Font = new Font("Gabriola", 15);
            this.sectionsDataGrid.DefaultCellStyle.BackColor = Color.Beige;
            this.sectionsDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.sectionsDataGrid.DefaultCellStyle.SelectionBackColor = Color.NavajoWhite;
            this.sectionsDataGrid.GridColor = Color.BlueViolet;
        }
        public void UploadData()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT section_id AS 'Индекс', section_name AS 'Име' FROM rim_dobrich.sections";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDT.Load(sqlRd);

            sqlRd.Close();
            sqlConn.Close();
            sectionsDataGrid.DataSource = sqlDT;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            UploadData();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void addNewbtn_Click(object sender, EventArgs e)
        {
            int sctsid = int.Parse(textBox1.Text);
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            try
            {
                sqlConn.Open();
                sqlQuery = $"INSERT INTO rim_dobrich.sections(section_id,section_name) VALUES('{sctsid}','{textBox2.Text}')";
                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConn.Close(); }
            UploadData();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            int ss = int.Parse(textBox1.Text);
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlQuery = $"DELETE FROM rim_dobrich.sections WHERE section_id={textBox1.Text};";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlRd = sqlCmd.ExecuteReader();
            sqlConn.Close();
            foreach (DataGridViewRow item in this.sectionsDataGrid.SelectedRows)
            {
                sectionsDataGrid.Rows.RemoveAt(item.Index);

            }
            UploadData();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "UPDATE rim_dobrich.sections SET section_id=@section_id, section_name=@section_name WHERE section_id=@section_id";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@section_id", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@section_name", textBox2.Text);

                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                UploadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = sectionsDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = sectionsDataGrid.SelectedRows[0].Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }







        private void sectionsbtn_Click(object sender, EventArgs e)
        {

        }

        private void collectionsbtn_Click(object sender, EventArgs e)
        {
        }

        private void assesmentProtocolbtn_Click(object sender, EventArgs e)
        {
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            Sections sections = new Sections();
            assesmentProtocol.Show();
            sections.Close();
            this.Hide();
        }

        private void museumsbtn_Click(object sender, EventArgs e)
        {
            Sections sections = new Sections();
            NameOfMuseum name = new NameOfMuseum();
            name.Show();
            sections.Close();
            this.Hide();
        }

        private void materialsbtn_Click(object sender, EventArgs e)
        {
            Materials materials = new Materials();
            Sections sections = new Sections();
            materials.Show();
            sections.Close();
            this.Hide();
        }

        private void shapesbtn_Click(object sender, EventArgs e)
        {
            Sections sections = new Sections();
            Shapes description = new Shapes();
            description.Show();
            sections.Close();
            this.Hide();
        }

        private void typesbtn_Click_1(object sender, EventArgs e)
        {
            Sections sections = new Sections();
            Types types = new Types();
            types.Show();
            sections.Close();
            this.Hide();
        }

        private void quieriesbtn_Click(object sender, EventArgs e)
        {
            Queries quieries = new Queries();
            Sections sections = new Sections();
            quieries.Show();
            sections.Close();
            this.Hide();
        }

        private void artefactsbtn_Click(object sender, EventArgs e)
        {
            Artefactscs artefactscs = new Artefactscs();
            Sections sections = new Sections();
            artefactscs.Show();
            sections.Close();
            this.Hide();
        }

        private void menubtn_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Sections sections = new Sections();
            menu.Show();
            sections.Close();
            this.Hide();
        }
    }
}