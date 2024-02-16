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
    public partial class Collections : Form
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
        public Collections()
        {
            InitializeComponent();
        }
        public void UploadData()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT collection_id AS 'Индекс', collection_name AS 'Колекция' FROM rim_dobrich.collections";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDT.Load(sqlRd);

            sqlRd.Close();
            sqlConn.Close();
            materialDataGrid.DataSource = sqlDT;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlQuery = $"DELETE FROM rim_dobrich.collections WHERE collection_id={materialidTxt.Text};";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlRd = sqlCmd.ExecuteReader();
            sqlConn.Close();
            foreach (DataGridViewRow item in this.materialDataGrid.SelectedRows)
            {
                materialDataGrid.Rows.RemoveAt(item.Index);

            }
            UploadData();
        }

        private void addNewbtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            try
            {
                sqlConn.Open();
                sqlQuery = $"INSERT INTO rim_dobrich.collections(collection_id,collection_name) VALUES('{materialidTxt.Text}','{materialTxt.Text}')";
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}";
            sqlConn.Open();
            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = $"UPDATE rim_dobrich.collections SET collection_id=@collection_id, collection_name=@collection_name  WHERE collection_id=@collection_id";
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.Parameters.AddWithValue("@collection_id", materialidTxt.Text);
                sqlCmd.Parameters.AddWithValue("@collection_name", materialTxt.Text);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();

                UploadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Collections_Load(object sender, EventArgs e)
        {
            UploadData();
        }

        private void materialDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
