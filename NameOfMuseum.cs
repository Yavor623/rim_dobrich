using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RIMDobrich1
{
    public partial class NameOfMuseum : Form
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
        public NameOfMuseum()
        {
            InitializeComponent();
        }
        private void SetFontAndColors()
        {
            this.nameOfMuseumDataGrid.DefaultCellStyle.Font = new Font("Gabriola", 15);
            this.nameOfMuseumDataGrid.DefaultCellStyle.BackColor = Color.Beige;
            this.nameOfMuseumDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.nameOfMuseumDataGrid.DefaultCellStyle.SelectionBackColor = Color.NavajoWhite;
            this.nameOfMuseumDataGrid.GridColor = Color.BlueViolet;
        }
        public void UploadData()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT museum_id AS 'Индекс', museum_name AS 'Име' FROM rim_dobrich.nameofmuseum";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDT.Load(sqlRd);

            sqlRd.Close();
            sqlConn.Close();
            nameOfMuseumDataGrid.DataSource = sqlDT;
        }

        private void addNewbtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            try
            {
                sqlConn.Open();
                sqlQuery = $"INSERT INTO rim_dobrich.nameofmuseum(museum_id,museum_name) VALUES('{indextxt.Text}','{nameMustxt.Text}')";
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

        private void NameOfMuseum_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
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

                sqlCmd.CommandText = "UPDATE rim_dobrich.nameofmuseum SET museum_id=@museum_id, museum_name=@museum_name WHERE museum_id=@museum_id";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@museum_id", indextxt.Text);
                sqlCmd.Parameters.AddWithValue("@museum_name", nameMustxt.Text);

                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                UploadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlQuery = $"DELETE FROM rim_dobrich.nameofmuseum WHERE museum_id={indextxt.Text};";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlRd = sqlCmd.ExecuteReader();
            sqlConn.Close();
            foreach (DataGridViewRow item in this.nameOfMuseumDataGrid.SelectedRows)
            {
                nameOfMuseumDataGrid.Rows.RemoveAt(item.Index);

            }
            UploadData();
        }



        private void nameOfMuseumDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indextxt.Text = nameOfMuseumDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                nameMustxt.Text = nameOfMuseumDataGrid.SelectedRows[0].Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }

        private void museumsbtn_Click(object sender, EventArgs e)
        {

        }

        private void materialsbtn_Click(object sender, EventArgs e)
        {
            NameOfMuseum name = new NameOfMuseum();
            Materials materials = new Materials();
            materials.Show();
            name.Close();
            this.Hide();
        }

        private void shapesbtn_Click(object sender, EventArgs e)
        {
            NameOfMuseum name = new NameOfMuseum();
            Shapes description = new Shapes();
            description.Show();
            name.Close();
            this.Hide();
        }

        private void typesbtn_Click_1(object sender, EventArgs e)
        {
            NameOfMuseum name = new NameOfMuseum();
            Types types = new Types();
            types.Show();
            name.Close();
            this.Hide();
        }

        private void quieriesbtn_Click(object sender, EventArgs e)
        {
            NameOfMuseum name = new NameOfMuseum();
            Queries quieries = new Queries();
            quieries.Show();
            name.Close();
            this.Hide();
        }

        private void artefactsbtn_Click(object sender, EventArgs e)
        {
            NameOfMuseum name = new NameOfMuseum();
            Artefactscs artefactscs = new Artefactscs();
            artefactscs.Show();
            name.Close();
            this.Hide();
        }

        private void menubtn_Click_1(object sender, EventArgs e)
        {
            NameOfMuseum name = new NameOfMuseum();
            Menu menu = new Menu();
            menu.Show();
            name.Close();
            this.Hide();
        }

        private void sectionsbtn_Click(object sender, EventArgs e)
        {
            NameOfMuseum name = new NameOfMuseum();
            Sections sections = new Sections();
            sections.Show();
            name.Close();
            this.Hide();

        }

        private void assesmentProtocolbtn_Click(object sender, EventArgs e)
        {
            NameOfMuseum name = new NameOfMuseum();
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            assesmentProtocol.Show();
            name.Close();
            this.Hide();
        }
    }
}
