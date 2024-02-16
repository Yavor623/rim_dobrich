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

namespace RIMDobrich1
{
    public partial class Materials : Form
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
        public Materials()
        {
            InitializeComponent();
        }
        private void SetFontAndColors()
        {
            this.materialDataGrid.DefaultCellStyle.Font = new Font("Gabriola", 15);
            this.materialDataGrid.DefaultCellStyle.BackColor = Color.Beige;
            this.materialDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.materialDataGrid.DefaultCellStyle.SelectionBackColor = Color.NavajoWhite;
            this.materialDataGrid.GridColor = Color.BlueViolet;
        }
        public void UploadData()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT material_id AS 'Индекс', material_name AS 'Материал' FROM rim_dobrich.materials";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDT.Load(sqlRd);

            sqlRd.Close();
            sqlConn.Close();
            materialDataGrid.DataSource = sqlDT;
        }

        private void addNewbtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            try
            {
                sqlConn.Open();
                sqlQuery = $"INSERT INTO rim_dobrich.materials(material_id,material_name) VALUES('{materialidTxt.Text}','{materialTxt.Text}')";
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

        private void Materials_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            UploadData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlQuery = $"DELETE FROM rim_dobrich.materials WHERE material_id={materialidTxt.Text};";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlRd = sqlCmd.ExecuteReader();
            sqlConn.Close();
            foreach (DataGridViewRow item in this.materialDataGrid.SelectedRows)
            {
                materialDataGrid.Rows.RemoveAt(item.Index);

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

                sqlCmd.CommandText = $"UPDATE rim_dobrich.materials SET material_id=@material_id, material_name=@material_name  WHERE material_id=@material_id";
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.Parameters.AddWithValue("@material_id", materialidTxt.Text);
                sqlCmd.Parameters.AddWithValue("@material_name", materialTxt.Text);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();

                UploadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = sqlDT.DefaultView;
                dv.RowFilter = string.Format("Материал like'%{0}%'", searchtxt.Text);
                materialDataGrid.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void descriprionDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                materialidTxt.Text = materialDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                materialTxt.Text = materialDataGrid.SelectedRows[0].Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            Shapes description = new Shapes();
            Menu menu = new Menu();
            menu.Show();

            description.Close();
            this.Hide();
        }

        private void sectionsbtn_Click(object sender, EventArgs e)
        {
            Shapes description = new Shapes();
            Sections sections = new Sections();
            sections.Show();

            description.Close();
            this.Hide();
        }

        private void amountbtn_Click(object sender, EventArgs e)
        {
            int count = materialDataGrid.SelectedRows.Count;
        }

        private void nameOfMuseumbtn_Click(object sender, EventArgs e)
        {
            Shapes description = new Shapes();
            NameOfMuseum name = new NameOfMuseum();
            name.Show();
            description.Close();
            this.Hide();
        }

        private void typesbtn_Click(object sender, EventArgs e)
        {
            Shapes description = new Shapes();
            Types types = new Types();
            types.Show();
            description.Close();
            this.Hide();
        }

        private void collectionsbtn_Click(object sender, EventArgs e)
        {

        }

        private void artefactsbtn_Click(object sender, EventArgs e)
        {
            Materials materials = new Materials();
            Artefactscs artefactscs = new Artefactscs();
            artefactscs.Show();
            materials.Close();
            this.Hide();
        }

        private void sectionsbtn_Click_1(object sender, EventArgs e)
        {
            Materials materials = new Materials();
            Sections sections = new Sections();
            sections.Show();
            materials.Close();
            this.Hide();
        }

        private void typesbtn_Click_1(object sender, EventArgs e)
        {
            Materials materials = new Materials();
            Types types = new Types();
            types.Show();
            materials.Close();
            this.Hide();
        }

        private void shapesbtn_Click(object sender, EventArgs e)
        {
            Materials materials = new Materials();
            Shapes description = new Shapes();
            description.Show();
            materials.Close();
            this.Hide();
        }

        private void museumsbtn_Click(object sender, EventArgs e)
        {
            Materials materials = new Materials();
            NameOfMuseum name = new NameOfMuseum();
            name.Show();
            materials.Close();
            this.Hide();
        }

        private void assesmentProtocolbtn_Click(object sender, EventArgs e)
        {

            Materials materials = new Materials();
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            assesmentProtocol.Show();
            materials.Close();
            this.Hide();
        }

        private void menubtn_Click_1(object sender, EventArgs e)
        {
            Materials materials = new Materials();
            Menu menu = new Menu();
            menu.Show();
            materials.Close();
            this.Hide();
        }

        private void quieriesbtn_Click(object sender, EventArgs e)
        {
            Materials materials = new Materials();
            Queries quieries = new Queries();
            quieries.Show();
            materials.Close();
            this.Hide();
        }
    }
}
