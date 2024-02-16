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
    public partial class Types : Form
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
        public Types()
        {
            InitializeComponent();
        }
        private void SetFontAndColors()
        {
            this.typesDataGrid.DefaultCellStyle.Font = new Font("Gabriola", 15);
            this.typesDataGrid.DefaultCellStyle.BackColor = Color.Beige;
            this.typesDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.typesDataGrid.DefaultCellStyle.SelectionBackColor = Color.NavajoWhite;
            this.typesDataGrid.GridColor = Color.BlueViolet;
        }
        public void UploadData()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT type_id AS 'Индекс', type_name AS 'Име' FROM rim_dobrich.types";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDT.Load(sqlRd);

            sqlRd.Close();
            sqlConn.Close();
            typesDataGrid.DataSource = sqlDT;
        }

        private void Types_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            UploadData();
        }


        private void searchbtn_Click_1(object sender, EventArgs e)
        {
            try
            {

                DataView dv = sqlDT.DefaultView;
                dv.RowFilter = string.Format("Име like'%{0}%'", searchtxt.Text);
                typesDataGrid.DataSource = dv.ToTable();
                UploadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addNewbtn_Click_1(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            try
            {
                sqlConn.Open();
                sqlQuery = $"INSERT INTO rim_dobrich.types(type_id,type_name) VALUES('{indextxt.Text}','{typeNametxt.Text}')";
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

        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "UPDATE rim_dobrich.types SET type_id=@type_id, type_name=@type_name WHERE type_id=@type_id";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@type_id", indextxt.Text);
                sqlCmd.Parameters.AddWithValue("@type_name", typeNametxt.Text);

                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                UploadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebtn_Click_1(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlQuery = $"DELETE FROM rim_dobrich.types WHERE type_id={indextxt.Text};";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlRd = sqlCmd.ExecuteReader();
            sqlConn.Close();
            foreach (DataGridViewRow item in this.typesDataGrid.SelectedRows)
            {
                typesDataGrid.Rows.RemoveAt(item.Index);

            }
            UploadData();
        }

        private void typesDataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indextxt.Text = typesDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                typeNametxt.Text = typesDataGrid.SelectedRows[0].Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }

        private void sectionsbtn_Click(object sender, EventArgs e)
        {
            Types types = new Types();
            Sections sections = new Sections();
            sections.Show();
            types.Close();
            this.Hide();
        }

        private void artefactsbtn_Click(object sender, EventArgs e)
        {
            Types types = new Types();
            Artefactscs artefactscs = new Artefactscs();
            artefactscs.Show();
            types.Close();
            this.Hide();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            Types types = new Types();
            Menu menu = new Menu();
            menu.Show();

            types.Close();
            this.Hide();
        }

        private void shapesbtn_Click(object sender, EventArgs e)
        {
            Types types = new Types();
            Shapes description = new Shapes();
            description.Show();
            types.Close();
            this.Hide();
        }

        private void materialsbtn_Click(object sender, EventArgs e)
        {
            Types types = new Types();
            Materials materials = new Materials();
            materials.Show();
            types.Close();
            this.Hide();
        }

        private void museumsbtn_Click(object sender, EventArgs e)
        {
            Types types = new Types();
            NameOfMuseum name = new NameOfMuseum();
            name.Show();
            types.Close();
            this.Hide();
        }

        private void assesmentProtocolbtn_Click(object sender, EventArgs e)
        {
            Types types = new Types();
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            assesmentProtocol.Show();
            types.Close();
            this.Hide();
        }

        private void collectionsbtn_Click(object sender, EventArgs e)
        {
        }

        private void quieriesbtn_Click(object sender, EventArgs e)
        {
            Types types = new Types();
            Queries quieries = new Queries();
            quieries.Show();
            types.Close();
            this.Hide();
        }
    }
}
