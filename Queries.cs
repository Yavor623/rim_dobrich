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
    public partial class Queries : Form
    {
        public Queries()
        {
            InitializeComponent();
        }

        private void collectionsbtn_Click(object sender, EventArgs e)
        {

        }

        private void artefactsbtn_Click(object sender, EventArgs e)
        {
            Queries queries = new Queries();
            Artefactscs artefactscs = new Artefactscs();
            artefactscs.Show();
            queries.Close();
            this.Hide();
        }

        private void sectionsbtn_Click(object sender, EventArgs e)
        {
            Queries queries = new Queries();
            Sections sections = new Sections();
            sections.Show();
            queries.Close();
            this.Hide();
        }

        private void typesbtn_Click(object sender, EventArgs e)
        {
            Queries queries = new Queries();
            Types types = new Types();
            types.Show();
            queries.Close();
            this.Hide();
        }

        private void shapesbtn_Click(object sender, EventArgs e)
        {
            Queries queries = new Queries();
            Shapes description = new Shapes();
            description.Show();
            queries.Close();
            this.Hide();
        }

        private void materialsbtn_Click(object sender, EventArgs e)
        {
            Queries queries = new Queries();
            Materials materials = new Materials();
            materials.Show();
            queries.Close();
            this.Hide();
        }

        private void museumsbtn_Click(object sender, EventArgs e)
        {
            Queries queries = new Queries();
            NameOfMuseum name = new NameOfMuseum();
            name.Show();
            queries.Close();
            this.Hide();
        }

        private void assesmentProtocolbtn_Click(object sender, EventArgs e)
        {
            Queries queries = new Queries();
            AssesmentProtocol assesmentProtocol = new AssesmentProtocol();
            assesmentProtocol.Show();
            queries.Close();
            this.Hide();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            Queries queries = new Queries();
            Menu menu = new Menu();
            menu.Show();

            queries.Close();
            this.Hide();
        }
    }
}
