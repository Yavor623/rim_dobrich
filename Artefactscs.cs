using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RIMDobrich1
{
    public partial class Artefactscs : Form
    {
        Bitmap bitmap;
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlConnection sqlConn1 = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        MySqlCommand sqlCmd1 = new MySqlCommand();

        DataTable sqlDT = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;
        MySqlDataReader sqlRd1;

        DataSet DS = new DataSet();

        String server = "127.0.0.1";
        String username = "root";
        String password = "";
        String database = "rim_dobrich";
        String pictureName = "";
        String chosenPictureAddress = "";
        String fullDirection = "";
        String path;
        public Artefactscs()
        {
            InitializeComponent();
        }
        private void SetFontAndColors()
        {
            this.artefactsDataGrid.DefaultCellStyle.Font = new Font("Gabriola", 15);
            this.artefactsDataGrid.DefaultCellStyle.BackColor = Color.Beige;
            this.artefactsDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.artefactsDataGrid.DefaultCellStyle.SelectionBackColor = Color.NavajoWhite;
            this.artefactsDataGrid.GridColor = Color.BlueViolet;
        }
        public void UploadData()
        {

            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database};convert zero datetime=true";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "SELECT id AS 'Номер',rim_dobrich.nameofmuseum.museum_name AS 'Музей',rim_dobrich.sections.section_name AS 'Секция',rim_dobrich.collections.collection_name AS 'Колекция' ,rim_dobrich.types.type_name AS 'Вид',artefact_name AS 'Име',cipher AS 'Шифър',dateofregistration AS 'Дата на регистрация',oldinventoryid AS 'Стар инвентарен номер',idofactofadmission AS 'Номер на акт за приемане',rim_dobrich.description.shape_name AS 'Форма',rim_dobrich.materials.material_name AS 'Материал',technology AS 'Техника',inscriptionordate AS 'Надписи или дати', sizeorweight AS 'Размер или тегло',era AS 'Епоха',conditionofartefact AS 'Състояние',amountoftheartefact AS 'Брой',historicalenquiryid AS 'Историческа справка' ,sellerordonater AS 'Продавач или дарител',assesmentprotocol_id AS 'Номер на оц.протокол' ,rim_dobrich.assesmentprotocol.assesmentpr_date AS 'Дата на оц.протокол',rim_dobrich.assesmentprotocol.assesmentpr_price AS 'Сума на оц.протокол',storagelocation_id AS 'Местосъхранение',locationoffinding AS 'Местонахождение',idofphotonegative AS 'Номер на фотонегатива',registrationidofNMF AS 'Регистрационен номер на НМФ',bibliographicenquiry AS 'Библиографска справка',scientificpublications AS 'Научни публикации',conservationandrestorationid AS 'Консервация и реставрация',participationinexhibitions AS 'Участие в изложби',copiesmade AS 'Направени копия',marriageprotocolandactofliquidation AS 'Протокол за брак и акт за ликвидация',madethescientificpassport AS 'Изготвил научния паспорт',dateofcreationofthescientificpassport AS 'Дата на създаване на НП',identification AS 'Идентификация',pictureaddress AS 'Адрес на снимката' FROM rim_dobrich.artefacts  " +
            "LEFT JOIN rim_dobrich.sections ON rim_dobrich.sections.section_id =rim_dobrich.artefacts.section_id " +
            "LEFT JOIN rim_dobrich.types ON rim_dobrich.types.type_id = rim_dobrich.artefacts.type_id " +
            "LEFT JOIN rim_dobrich.nameofmuseum ON rim_dobrich.nameofmuseum.museum_id = rim_dobrich.artefacts.museum_id " +
            "LEFT JOIN rim_dobrich.description ON rim_dobrich.description.shape_id=rim_dobrich.artefacts.shape_id " +
            "LEFT JOIN rim_dobrich.collections ON rim_dobrich.collections.collection_id = rim_dobrich.artefacts.collection_id " +
            "LEFT JOIN rim_dobrich.assesmentprotocol ON rim_dobrich.assesmentprotocol.assesmentpr_id=rim_dobrich.artefacts.assesmentprotocol_id " +
            "LEFT JOIN rim_dobrich.materials ON rim_dobrich.materials.material_id=rim_dobrich.artefacts.material_id;";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDT.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();

            artefactsDataGrid.DataSource = sqlDT;
            AutomaticComboBoxData();

        }
        public void UploadComboBoxDataAssesmentProtocol()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database};convert zero datetime=true";

            sqlCmd.CommandText = "SELECT * FROM rim_dobrich.assesmentprotocol";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            MySqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                assesmentpridcb.Items.Add(reader.GetInt16("assesmentpr_id"));
            }
            sqlConn.Close();
        }
        public void UploadComboBoxDataCollections()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database};convert zero datetime=true";

            sqlCmd.CommandText = "SELECT * FROM rim_dobrich.collections";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            MySqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                collectionscb.Items.Add(reader.GetString("collection_name"));
            }
            sqlConn.Close();
        }
        public void UploadComboBoxDataShapes()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database};convert zero datetime=true";

            sqlCmd.CommandText = "SELECT * FROM rim_dobrich.description";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            MySqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                shapecb.Items.Add(reader.GetString("shape_name"));
            }
            sqlConn.Close();
        }
        public void UploadComboBoxDataMaterials()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database} ;convert zero datetime=true";

            sqlCmd.CommandText = "SELECT * FROM rim_dobrich.materials";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            MySqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                materialcb.Items.Add(reader.GetString("material_name"));
            }
            sqlConn.Close();
        }
        public void UploadComboBoxDataNameOfMuseum()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database};convert zero datetime=true";

            sqlCmd.CommandText = "SELECT * FROM rim_dobrich.nameofmuseum";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            MySqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                nameofmuseumcb.Items.Add(reader.GetString("museum_name"));
            }
            sqlConn.Close();
        }

        public void UploadComboBoxDataSections()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database} ;convert zero datetime=true";

            sqlCmd.CommandText = "SELECT * FROM rim_dobrich.sections";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            MySqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                sectionscb.Items.Add(reader.GetString("section_name"));
            }
            sqlConn.Close();
        }
        public void UploadComboBoxTypes()
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database};convert zero datetime=true";

            sqlCmd.CommandText = "SELECT * FROM rim_dobrich.types";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            MySqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                typecb.Items.Add(reader.GetString("type_name"));
            }
            sqlConn.Close();
        }
        public void AutomaticComboBoxData()
        {


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void nameMustxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void indextxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void addNewbtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database} ;convert zero datetime=true";
            sqlConn.Open();
            try
            {
                int nameOfMuseumId = nameofmuseumcb.SelectedIndex + 1;
                int sectionsId = sectionscb.SelectedIndex + 1;
                int typesId = typecb.SelectedIndex + 1;
                int shapesId = shapecb.SelectedIndex + 1;
                int materialsId = materialcb.SelectedIndex + 1;
                int collectionsId = collectionscb.SelectedIndex + 1;
                string idAssesmentProtocol = assesmentpridcb.SelectedItem.ToString();
                Convert.ToInt16(idAssesmentProtocol);
                sqlCmd.Connection = sqlConn;

                sqlQuery = $"INSERT INTO rim_dobrich.artefacts(id,museum_id,section_id ,collection_id,type_id ,artefact_name,cipher,dateofregistration,oldinventoryid,idofactofadmission,shape_id,material_id,technology,inscriptionordate,sizeorweight,era,conditionofartefact,amountoftheartefact,historicalenquiryid,sellerordonater,assesmentprotocol_id," +
                    $"storagelocation_id,locationoffinding,idofphotonegative" +
                    $",registrationidofNMF,bibliographicenquiry,scientificpublications,conservationandrestorationid,participationinexhibitions,copiesmade,marriageprotocolandactofliquidation,madethescientificpassport,dateofcreationofthescientificpassport" +
                    $",identification,pictureaddress) " +
                    $"VALUES('{indextxt.Text}','{nameOfMuseumId}','{sectionsId}','{collectionsId}','{typesId}','{artefact_nametx.Text}','{ciphertxt.Text}','{dateOfRegistration.Text}','{oldinventoryidtxt.Text}'," +
                    $"'{idofactofadmissiontxt.Text}','{shapesId}','{materialsId}','{technology.Text}','{inscriptionordatetxt.Text}','{sizeorweighttxt.Text}','{eratxt.Text}','{conditionofartefacttxt.Text}','{amountofartefacttxt.Text}','{historicalinquirytext.Text}'," +
                    $"'{sellerordonatertxt.Text}','{idAssesmentProtocol}','{storagelocationtxt.Text}','{locationoffinding.Text}','{idofphotonegative.Text}','{registrationidofNMF.Text}','{bibliographicenquiry.Text}','{scientificpublications.Text}','{conservationandrestorationtxt.Text}','{participationinexhibitionstxt.Text}'," +
                    $"'{copiesmadetxt.Text}','{marriageprotocolandactofliquidationtxt.Text}','{madethescientificpassporttxt.Text}','{dateOfCreationOfTheScientificPassport.Text}','{identificationTxt.Text}','{fullDirection}')";
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
                int nameOfMuseumId = nameofmuseumcb.SelectedIndex + 1;
                int sectionsId = sectionscb.SelectedIndex + 1;
                int typesId = typecb.SelectedIndex + 1;
                int shapesId = shapecb.SelectedIndex + 1;
                int materialsId = materialcb.SelectedIndex + 1;
                int collectionsId = collectionscb.SelectedIndex + 1;
                string idAssesmentProtocol = assesmentpridcb.SelectedItem.ToString();
                Convert.ToInt16(idAssesmentProtocol);
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = $"UPDATE rim_dobrich.artefacts SET id=@id,museum_id=@museum_id,section_id=@section_id ,collection_id=@collection_id,type_id=@type_id ,artefact_name=@artefact_name,cipher=@cipher,dateofregistration=@dateofregistration," +
                    $"oldinventoryid=@oldinventoryid,idofactofadmission=@idofactofadmission,shape_id=@shape_id,material_id=@material_id,technology=@technology,inscriptionordate=@inscriptionordate,sizeorweight=@sizeorweight,era=@era,conditionofartefact=@conditionofartefact_id,amountoftheartefact=@amountoftheartefact,historicalenquiryid=@historicalenquiry_id" +
                    $",sellerordonater=@sellerordonater,assesmentprotocol_id=@assesmentprotocol_id,storagelocation_id=@storagelocation_id,locationoffinding=@locationoffinding,idofphotonegative=@idofphotonegative,registrationidofNMF=@registrationidofNMF," +
                    $"bibliographicenquiry=@bibliographicenquiry,scientificpublications=@scientificpublications,conservationandrestorationid=@conservationandrestoration_id,participationinexhibitions=@participationinexhibitions" +
                    $",copiesmade=@copiesmade,marriageprotocolandactofliquidation=@marriageprotocolandactofliquidation,madethescientificpassport=@madethescientificpassport,dateofcreationofthescientificpassport=@dateofcreationofthescientificpassport ,identification=@identification,pictureaddress=@pictureaddress  WHERE id=@id";
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.Parameters.AddWithValue("@id", indextxt.Text);
                sqlCmd.Parameters.AddWithValue("@museum_id", nameOfMuseumId);
                sqlCmd.Parameters.AddWithValue("@section_id", sectionsId);
                sqlCmd.Parameters.AddWithValue("@collection_id", collectionsId);
                sqlCmd.Parameters.AddWithValue("@type_id", typesId);
                sqlCmd.Parameters.AddWithValue("@artefact_name", artefact_nametx.Text);
                sqlCmd.Parameters.AddWithValue("@cipher", ciphertxt.Text);
                sqlCmd.Parameters.AddWithValue("@dateofregistration", dateOfRegistration.Text);
                sqlCmd.Parameters.AddWithValue("@oldinventoryid", oldinventoryidtxt.Text);
                sqlCmd.Parameters.AddWithValue("@idofactofadmission", idofactofadmissiontxt.Text);
                sqlCmd.Parameters.AddWithValue("@shape_id", shapesId);
                sqlCmd.Parameters.AddWithValue("@material_id", materialsId);
                sqlCmd.Parameters.AddWithValue("@technology", technology.Text);
                sqlCmd.Parameters.AddWithValue("@inscriptionordate", inscriptionordatetxt.Text);
                sqlCmd.Parameters.AddWithValue("@sizeorweight", sizeorweighttxt.Text);
                sqlCmd.Parameters.AddWithValue("@era", eratxt.Text);
                sqlCmd.Parameters.AddWithValue("@conditionofartefact_id", conditionofartefacttxt.Text);
                sqlCmd.Parameters.AddWithValue("@amountoftheartefact", amountofartefacttxt.Text);
                sqlCmd.Parameters.AddWithValue("@historicalenquiry_id", historicalinquirytext.Text);
                sqlCmd.Parameters.AddWithValue("@sellerordonater", sellerordonatertxt.Text);
                sqlCmd.Parameters.AddWithValue("@assesmentprotocol_id", idAssesmentProtocol);
                sqlCmd.Parameters.AddWithValue("@storagelocation_id", storagelocationtxt.Text);
                sqlCmd.Parameters.AddWithValue("@locationoffinding", locationoffinding.Text);
                sqlCmd.Parameters.AddWithValue("@idofphotonegative", idofphotonegative.Text);
                sqlCmd.Parameters.AddWithValue("@registrationidofNMF", registrationidofNMF.Text);
                sqlCmd.Parameters.AddWithValue("@bibliographicenquiry", bibliographicenquiry.Text);
                sqlCmd.Parameters.AddWithValue("@scientificpublications", scientificpublications.Text);
                sqlCmd.Parameters.AddWithValue("@conservationandrestoration_id", conservationandrestorationtxt.Text);
                sqlCmd.Parameters.AddWithValue("@participationinexhibitions", participationinexhibitionstxt.Text);
                sqlCmd.Parameters.AddWithValue("@copiesmade", copiesmadetxt.Text);
                sqlCmd.Parameters.AddWithValue("@marriageprotocolandactofliquidation", marriageprotocolandactofliquidationtxt.Text);
                sqlCmd.Parameters.AddWithValue("@madethescientificpassport", madethescientificpassporttxt.Text);
                sqlCmd.Parameters.AddWithValue("@dateofcreationofthescientificpassport", dateOfCreationOfTheScientificPassport.Text);
                sqlCmd.Parameters.AddWithValue("@identification", identificationTxt.Text);
                sqlCmd.Parameters.AddWithValue("@pictureaddress", fullDirection);

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
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database};convert zero datetime=true";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlQuery = $"DELETE FROM rim_dobrich.artefacts WHERE id={indextxt.Text};";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlRd = sqlCmd.ExecuteReader();
            sqlConn.Close();
            foreach (DataGridViewRow item in this.artefactsDataGrid.SelectedRows)
            {
                artefactsDataGrid.Rows.RemoveAt(item.Index);

            }
            UploadData();
        }
        private void Artefactscs_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            UploadData();
            UploadComboBoxDataNameOfMuseum();
            UploadComboBoxDataSections();
            UploadComboBoxTypes();
            UploadComboBoxDataShapes();
            UploadComboBoxDataMaterials();
            UploadComboBoxDataCollections();
            UploadComboBoxDataAssesmentProtocol();
        }

        private void artefactsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indextxt.Text = artefactsDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                nameofmuseumcb.Text = artefactsDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                sectionscb.Text = artefactsDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                collectionscb.Text = artefactsDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                typecb.Text = artefactsDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                artefact_nametx.Text = artefactsDataGrid.SelectedRows[0].Cells[5].Value.ToString();
                ciphertxt.Text = artefactsDataGrid.SelectedRows[0].Cells[6].Value.ToString();
                dateAssesmentProtocol.Text = artefactsDataGrid.SelectedRows[0].Cells[7].Value.ToString();
                oldinventoryidtxt.Text = artefactsDataGrid.SelectedRows[0].Cells[8].Value.ToString();
                idofactofadmissiontxt.Text = artefactsDataGrid.SelectedRows[0].Cells[9].Value.ToString();
                shapecb.Text = artefactsDataGrid.SelectedRows[0].Cells[10].Value.ToString();
                materialcb.Text = artefactsDataGrid.SelectedRows[0].Cells[11].Value.ToString();
                technology.Text = artefactsDataGrid.SelectedRows[0].Cells[12].Value.ToString();
                inscriptionordatetxt.Text = artefactsDataGrid.SelectedRows[0].Cells[13].Value.ToString();
                sizeorweighttxt.Text = artefactsDataGrid.SelectedRows[0].Cells[14].Value.ToString();
                eratxt.Text = artefactsDataGrid.SelectedRows[0].Cells[15].Value.ToString();
                conditionofartefacttxt.Text = artefactsDataGrid.SelectedRows[0].Cells[16].Value.ToString();
                amountofartefacttxt.Text = artefactsDataGrid.SelectedRows[0].Cells[17].Value.ToString();
                historicalinquirytext.Text = artefactsDataGrid.SelectedRows[0].Cells[18].Value.ToString();
                sellerordonatertxt.Text = artefactsDataGrid.SelectedRows[0].Cells[19].Value.ToString();
                assesmentpridcb.Text = artefactsDataGrid.SelectedRows[0].Cells[20].Value.ToString();
                dateOfRegistration.Text = artefactsDataGrid.SelectedRows[0].Cells[21].Value.ToString();
                pricetxt.Text = artefactsDataGrid.SelectedRows[0].Cells[22].Value.ToString();
                storagelocationtxt.Text = artefactsDataGrid.SelectedRows[0].Cells[23].Value.ToString();
                locationoffinding.Text = artefactsDataGrid.SelectedRows[0].Cells[24].Value.ToString();
                idofphotonegative.Text = artefactsDataGrid.SelectedRows[0].Cells[25].Value.ToString();
                registrationidofNMF.Text = artefactsDataGrid.SelectedRows[0].Cells[26].Value.ToString();
                bibliographicenquiry.Text = artefactsDataGrid.SelectedRows[0].Cells[27].Value.ToString();
                scientificpublications.Text = artefactsDataGrid.SelectedRows[0].Cells[28].Value.ToString();
                conservationandrestorationtxt.Text = artefactsDataGrid.SelectedRows[0].Cells[29].Value.ToString();
                participationinexhibitionstxt.Text = artefactsDataGrid.SelectedRows[0].Cells[30].Value.ToString();
                copiesmadetxt.Text = artefactsDataGrid.SelectedRows[0].Cells[31].Value.ToString();
                marriageprotocolandactofliquidationtxt.Text = artefactsDataGrid.SelectedRows[0].Cells[32].Value.ToString();
                madethescientificpassporttxt.Text = artefactsDataGrid.SelectedRows[0].Cells[33].Value.ToString();
                dateOfCreationOfTheScientificPassport.Text = artefactsDataGrid.SelectedRows[0].Cells[34].Value.ToString();
                identificationTxt.Text = artefactsDataGrid.SelectedRows[0].Cells[35].Value.ToString();
                fullDirection = artefactsDataGrid.SelectedRows[0].Cells[36].Value.ToString();
                pictureBox.ImageLocation = fullDirection;


            }
            catch (Exception ex)
            {
            }
        }
        private void picturebtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFileDialog1.FileName.ToString();
                pictureName = Path.GetFileName(openFileDialog1.FileName);
                chosenPictureAddress = Path.GetDirectoryName(openFileDialog1.FileName);
                path = Path.Combine(chosenPictureAddress);
                fullDirection = path + "\\" + pictureName;

            }
        }
        private void menubtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Artefactscs artefactscs = new Artefactscs();
            menu.Show();
            this.Hide();
            artefactscs.Close();
        }
        private void pricetxt_Click(object sender, EventArgs e)
        {

        }
        private void assesmentpridcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database};convert zero datetime=true";
            sqlConn.Open();

            sqlCmd.Connection = sqlConn;
            if (assesmentpridcb.Text != string.Empty)
            {
                string id = assesmentpridcb.SelectedItem.ToString();
                Convert.ToUInt16(id);
                sqlQuery = $"SELECT * FROM rim_dobrich.assesmentprotocol WHERE assesmentpr_id={id}";
                sqlCmd.Parameters.AddWithValue(dateAssesmentProtocol.Text, "@assesmentpr_date");
                sqlCmd.Parameters.AddWithValue(pricetxt.Text, "@assesmentpr_price");
                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();
                if (sqlRd.Read())
                {
                    if (id != null)
                    {
                        dateAssesmentProtocol.Value = sqlRd.GetDateTime("assesmentpr_date");
                        pricetxt.Text = sqlRd.GetString("assesmentpr_price");
                    }
                }
            }
            else
            {
                MessageBox.Show("No data");
            }
            sqlConn.Close();
        }

        private void quieriesbtn_Click(object sender, EventArgs e)
        {
            Artefactscs artefactscs = new Artefactscs();
            Queries quieries = new Queries();
            quieries.Show();
            artefactscs.Close();
            this.Hide();
        }

        private void sections_Click(object sender, EventArgs e)
        {
            Artefactscs artefactscs = new Artefactscs();
            Sections sections = new Sections();
            sections.Show();
            artefactscs.Close();
            this.Hide();
        }

        private void typesbtn_Click(object sender, EventArgs e)
        {
            Artefactscs artefactscs = new Artefactscs();
            Types types = new Types();
            types.Show();
            artefactscs.Close();
            this.Hide();
        }

        private void shapesbtn_Click(object sender, EventArgs e)
        {
            Artefactscs artefactscs = new Artefactscs();
            Shapes description = new Shapes();
            description.Show();
            artefactscs.Close();
            this.Hide();
        }

        private void materialsbtn_Click(object sender, EventArgs e)
        {
            Artefactscs artefactscs = new Artefactscs();
            Materials materials = new Materials();
            materials.Show();
            artefactscs.Close();
            this.Hide();
        }

        private void museumsbtn_Click(object sender, EventArgs e)
        {
            NameOfMuseum name = new NameOfMuseum();
            Artefactscs artefactscs = new Artefactscs();
            name.Show();
            artefactscs.Close();
            this.Hide();
        }

        private void assesmentProtocolbtn_Click(object sender, EventArgs e)
        {
            Artefactscs artefactscs = new Artefactscs();
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            assesmentProtocol.Show();
            artefactscs.Close();
            this.Hide();
        }

        private void collectionsbtn_Click(object sender, EventArgs e)
        {
        }

        private void artefactsbtn_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = sqlDT.DefaultView;
                dv.RowFilter = string.Format("Име like'%{0}%'", searchTxt.Text);
                artefactsDataGrid.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
