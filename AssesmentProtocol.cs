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
    public partial class AssesmentProtocol : Form
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
        public AssesmentProtocol()
        {
            InitializeComponent();
        }
        private void SetFontAndColors()
        {
            this.assesmentProtocolDataGrid.DefaultCellStyle.Font = new Font("Gabriola", 15);
            this.assesmentProtocolDataGrid.DefaultCellStyle.BackColor = Color.Beige;
            this.assesmentProtocolDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.assesmentProtocolDataGrid.DefaultCellStyle.SelectionBackColor = Color.NavajoWhite;
            this.assesmentProtocolDataGrid.GridColor = Color.BlueViolet;
        }
        public void UploadData()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database};convert zero datetime=true";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT assesmentpr_id AS 'Индекс', assesmentpr_date AS 'Дата',assesmentpr_price AS 'Сума' FROM rim_dobrich.assesmentprotocol";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDT.Load(sqlRd);

            sqlRd.Close();
            sqlConn.Close();
            assesmentProtocolDataGrid.DataSource = sqlDT;
        }

        private void AssesmentProtocol_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            UploadData();

        }

        private void sectionsbtn_Click(object sender, EventArgs e)
        {
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            Sections sections = new Sections();
            sections.Show();
            assesmentProtocol.Close();
            this.Hide();

        }

        private void assesmentProtocolbtn_Click(object sender, EventArgs e)
        {

        }

        private void museumsbtn_Click(object sender, EventArgs e)
        {
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            NameOfMuseum name = new NameOfMuseum();
            name.Show();
            assesmentProtocol.Close();
            this.Hide();
        }

        private void materialsbtn_Click(object sender, EventArgs e)
        {
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            Materials materials = new Materials();
            materials.Show();
            assesmentProtocol.Close();
            this.Hide();
        }

        private void shapesbtn_Click(object sender, EventArgs e)
        {
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            Shapes description = new Shapes();
            description.Show();
            assesmentProtocol.Close();
            this.Hide();
        }

        private void typesbtn_Click_1(object sender, EventArgs e)
        {
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            Types types = new Types();
            types.Show();
            assesmentProtocol.Close();
            this.Hide();
        }

        private void quieriesbtn_Click(object sender, EventArgs e)
        {
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            Queries quieries = new Queries();
            quieries.Show();
            assesmentProtocol.Close();
            this.Hide();
        }

        private void artefactsbtn_Click(object sender, EventArgs e)
        {
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            Artefactscs artefactscs = new Artefactscs();
            artefactscs.Show();
            assesmentProtocol.Close();
            this.Hide();
        }

        private void menubtn_Click_1(object sender, EventArgs e)
        {
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            Menu menu = new Menu();
            menu.Show();
            assesmentProtocol.Close();
            this.Hide();
        }



        private void addNewbtn_Click_1(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database};convert zero datetime=true";
            try
            {

                sqlConn.Open();
                sqlQuery = $"INSERT INTO rim_dobrich.assesmentprotocol(assesmentpr_id,assesmentpr_date,assesmentpr_price) VALUES('{indextxt.Text}','{datecal.Text}','{pricetxt.Text}')";
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
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database} ;convert zero datetime=true";
            sqlConn.Open();
            try
            {

                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "UPDATE rim_dobrich.assesmentprotocol SET assesmentpr_id=@assesmentpr_id, assesmentpr_date=@assesmentpr_date, assesmentpr_price=@assesmentpr_price WHERE assesmentpr_id=@assesmentpr_id";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@assesmentpr_id", indextxt.Text);
                sqlCmd.Parameters.AddWithValue("@assesmentpr_date", datecal.Text);
                sqlCmd.Parameters.AddWithValue("@assesmentpr_price", pricetxt.Text);

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
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database};convert zero datetime=true";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlQuery = $"DELETE FROM rim_dobrich.assesmentprotocol WHERE assesmentpr_id={indextxt.Text};";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlRd = sqlCmd.ExecuteReader();
            sqlConn.Close();
            foreach (DataGridViewRow item in this.assesmentProtocolDataGrid.SelectedRows)
            {
                assesmentProtocolDataGrid.Rows.RemoveAt(item.Index);

            }
            UploadData();
        }

        private void typesDataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indextxt.Text = assesmentProtocolDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                datecal.Text = assesmentProtocolDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                pricetxt.Text = assesmentProtocolDataGrid.SelectedRows[0].Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }
    }
}
