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
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void descriptionbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Shapes description = new Shapes();
            description.Show();

            this.Hide();
            menu.Close();
        }

        private void sectionsbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Sections sections = new Sections();
            sections.Show();

            this.Hide();
            menu.Close();
        }

        private void nameOfMuseumbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            NameOfMuseum name = new NameOfMuseum();
            name.Show();

            this.Hide();
            menu.Close();
        }

        private void typesbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Types types = new Types();
            types.Show();
            this.Hide();
            menu.Close();

        }

        private void artefactsbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Artefactscs artefactscs = new Artefactscs();
            artefactscs.Show();
            this.Hide();
            menu.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            assesmentProtocol.Show();
            this.Hide();
            menu.Close();
        }

        private void materialsbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Materials materials = new Materials();
            materials.Show();
            this.Hide();
            menu.Close();
        }

        private void queriesbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            Queries queries = new Queries();
            queries.Show();
            this.Hide();
            menu.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Collections collections = new Collections();
            Menu menu = new Menu();

            collections.Show();
            this.Hide();
            menu.Close();
        }
    }
}
