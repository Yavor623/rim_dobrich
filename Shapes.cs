using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RIMDobrich1
{
    public partial class Shapes : Form
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
        public Shapes()
        {
            InitializeComponent();
        }
        private void SetFontAndColors()
        {
            this.shapeDataGrid.DefaultCellStyle.Font = new Font("Gabriola", 15);
            this.shapeDataGrid.DefaultCellStyle.BackColor = Color.Beige;
            this.shapeDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.shapeDataGrid.DefaultCellStyle.SelectionBackColor = Color.NavajoWhite;
            this.shapeDataGrid.GridColor = Color.BlueViolet;
        }
        public void UploadData()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT shape_id AS 'Индекс', shape_name AS 'Форма' FROM rim_dobrich.description";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDT.Load(sqlRd);

            sqlRd.Close();
            sqlConn.Close();
            shapeDataGrid.DataSource = sqlDT;
        }

        private void addNewbtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            try
            {
                sqlConn.Open();
                sqlQuery = $"INSERT INTO rim_dobrich.description(shape_id,shape_name) VALUES('{shapeidTxt.Text}','{shapeTxt.Text}')";
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

        private void Description_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            UploadData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlQuery = $"DELETE FROM rim_dobrich.description WHERE shape_id={shapeidTxt.Text}";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlRd = sqlCmd.ExecuteReader();
            sqlConn.Close();
            foreach (DataGridViewRow item in this.shapeDataGrid.SelectedRows)
            {
                shapeDataGrid.Rows.RemoveAt(item.Index);

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

                sqlCmd.CommandText = $"UPDATE rim_dobrich.description SET shape_id=@shape_id, shape_name=@shape_name  WHERE shape_id=@shape_id";
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.Parameters.AddWithValue("@shape_id", shapeidTxt.Text);
                sqlCmd.Parameters.AddWithValue("@shape_name", shapeTxt.Text);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();

                UploadData();
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
                shapeidTxt.Text = shapeDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                shapeTxt.Text = shapeDataGrid.SelectedRows[0].Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }
        private void materialsbtn_Click(object sender, EventArgs e)
        {
            Shapes shapes = new Shapes();
            Materials materials = new Materials();
            materials.Show();
            shapes.Close();
            this.Hide();
        }

        private void artefactsbtn_Click(object sender, EventArgs e)
        {
            Shapes shapes = new Shapes();
            Artefactscs artefactscs = new Artefactscs();
            artefactscs.Show();
            shapes.Close();
            this.Hide();
        }

        private void sectionsbtn_Click_1(object sender, EventArgs e)
        {
            Shapes shapes = new Shapes();
            Sections sections = new Sections();
            sections.Show();
            shapes.Close();
            this.Hide();
        }

        private void typesbtn_Click_1(object sender, EventArgs e)
        {
            Shapes description = new Shapes();
            Types types = new Types();
            types.Show();
            description.Close();
            this.Hide();
        }

        private void menubtn_Click_1(object sender, EventArgs e)
        {
            Shapes description = new Shapes();
            Menu menu = new Menu();
            menu.Show();

            description.Close();
            this.Hide();
        }

        private void museumsbtn_Click(object sender, EventArgs e)
        {
            Shapes description = new Shapes();
            NameOfMuseum name = new NameOfMuseum();
            name.Show();
            description.Close();
            this.Hide();
        }

        private void assesmentProtocolbtn_Click(object sender, EventArgs e)
        {
            Shapes shapes = new Shapes();
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            assesmentProtocol.Show();
            shapes.Close();
            this.Hide();
        }

        private void collectionsbtn_Click(object sender, EventArgs e)
        {
        }

        private void quieriesbtn_Click(object sender, EventArgs e)
        {
            Shapes shapes = new Shapes();
            Queries quieries = new Queries();
            quieries.Show();
            shapes.Close();
            this.Hide();
        }
    }
}
