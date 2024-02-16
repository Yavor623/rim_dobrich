namespace RIMDobrich1
{
    partial class Sections
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sectionsDataGrid = new DataGridView();
            bindingSource1 = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            addNewbtn = new Button();
            deletebtn = new Button();
            updatebtn = new Button();
            panel1 = new Panel();
            assesmentProtocolbtn = new Button();
            collectionsbtn = new Button();
            museumsbtn = new Button();
            artefactsbtn = new Button();
            quieriesbtn = new Button();
            materialsbtn = new Button();
            shapesbtn = new Button();
            typesbtn = new Button();
            sectionsbtn = new Button();
            menubtn = new Button();
            ((System.ComponentModel.ISupportInitialize)sectionsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sectionsDataGrid
            // 
            sectionsDataGrid.AllowUserToAddRows = false;
            sectionsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sectionsDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            sectionsDataGrid.BackgroundColor = Color.Tan;
            sectionsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            sectionsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sectionsDataGrid.Location = new Point(722, 83);
            sectionsDataGrid.Name = "sectionsDataGrid";
            sectionsDataGrid.ReadOnly = true;
            sectionsDataGrid.RowHeadersWidth = 51;
            sectionsDataGrid.RowTemplate.Height = 29;
            sectionsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sectionsDataGrid.Size = new Size(1135, 890);
            sectionsDataGrid.TabIndex = 0;
            sectionsDataGrid.CellClick += dataGridView1_CellClick;
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(27, 212);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Индекс";
            textBox1.Size = new Size(667, 60);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(27, 480);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Име на секция";
            textBox2.Size = new Size(667, 60);
            textBox2.TabIndex = 2;
            // 
            // addNewbtn
            // 
            addNewbtn.BackColor = Color.NavajoWhite;
            addNewbtn.FlatStyle = FlatStyle.Flat;
            addNewbtn.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point);
            addNewbtn.Location = new Point(27, 751);
            addNewbtn.Name = "addNewbtn";
            addNewbtn.Size = new Size(667, 70);
            addNewbtn.TabIndex = 3;
            addNewbtn.Text = "Добави";
            addNewbtn.UseVisualStyleBackColor = false;
            addNewbtn.Click += addNewbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.NavajoWhite;
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point);
            deletebtn.Location = new Point(27, 903);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(667, 70);
            deletebtn.TabIndex = 4;
            deletebtn.Text = "Премахни";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.NavajoWhite;
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point);
            updatebtn.Location = new Point(27, 827);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(667, 70);
            updatebtn.TabIndex = 5;
            updatebtn.Text = "Обнови";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(assesmentProtocolbtn);
            panel1.Controls.Add(collectionsbtn);
            panel1.Controls.Add(museumsbtn);
            panel1.Controls.Add(artefactsbtn);
            panel1.Controls.Add(quieriesbtn);
            panel1.Controls.Add(materialsbtn);
            panel1.Controls.Add(shapesbtn);
            panel1.Controls.Add(typesbtn);
            panel1.Controls.Add(sectionsbtn);
            panel1.Controls.Add(menubtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1933, 38);
            panel1.TabIndex = 40;
            // 
            // assesmentProtocolbtn
            // 
            assesmentProtocolbtn.BackColor = Color.NavajoWhite;
            assesmentProtocolbtn.FlatAppearance.BorderSize = 0;
            assesmentProtocolbtn.FlatStyle = FlatStyle.Flat;
            assesmentProtocolbtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            assesmentProtocolbtn.Location = new Point(1364, 0);
            assesmentProtocolbtn.Name = "assesmentProtocolbtn";
            assesmentProtocolbtn.Size = new Size(185, 35);
            assesmentProtocolbtn.TabIndex = 35;
            assesmentProtocolbtn.Text = "Оц. протокол";
            assesmentProtocolbtn.UseVisualStyleBackColor = false;
            assesmentProtocolbtn.Click += assesmentProtocolbtn_Click;
            // 
            // collectionsbtn
            // 
            collectionsbtn.BackColor = Color.NavajoWhite;
            collectionsbtn.FlatAppearance.BorderSize = 0;
            collectionsbtn.FlatStyle = FlatStyle.Flat;
            collectionsbtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            collectionsbtn.Location = new Point(1555, 0);
            collectionsbtn.Name = "collectionsbtn";
            collectionsbtn.Size = new Size(185, 35);
            collectionsbtn.TabIndex = 34;
            collectionsbtn.Text = "Колекции";
            collectionsbtn.UseVisualStyleBackColor = false;
            collectionsbtn.Click += collectionsbtn_Click;
            // 
            // museumsbtn
            // 
            museumsbtn.BackColor = Color.NavajoWhite;
            museumsbtn.FlatAppearance.BorderSize = 0;
            museumsbtn.FlatStyle = FlatStyle.Flat;
            museumsbtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            museumsbtn.Location = new Point(1173, 0);
            museumsbtn.Name = "museumsbtn";
            museumsbtn.Size = new Size(185, 35);
            museumsbtn.TabIndex = 33;
            museumsbtn.Text = "Музеи";
            museumsbtn.UseVisualStyleBackColor = false;
            museumsbtn.Click += museumsbtn_Click;
            // 
            // artefactsbtn
            // 
            artefactsbtn.BackColor = Color.NavajoWhite;
            artefactsbtn.FlatAppearance.BorderSize = 0;
            artefactsbtn.FlatStyle = FlatStyle.Flat;
            artefactsbtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            artefactsbtn.Location = new Point(218, 0);
            artefactsbtn.Name = "artefactsbtn";
            artefactsbtn.Size = new Size(185, 35);
            artefactsbtn.TabIndex = 32;
            artefactsbtn.Text = "Артефакти";
            artefactsbtn.UseVisualStyleBackColor = false;
            artefactsbtn.Click += artefactsbtn_Click;
            // 
            // quieriesbtn
            // 
            quieriesbtn.BackColor = Color.NavajoWhite;
            quieriesbtn.FlatAppearance.BorderSize = 0;
            quieriesbtn.FlatStyle = FlatStyle.Flat;
            quieriesbtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            quieriesbtn.Location = new Point(1745, 0);
            quieriesbtn.Name = "quieriesbtn";
            quieriesbtn.Size = new Size(185, 35);
            quieriesbtn.TabIndex = 31;
            quieriesbtn.Text = "Заявки";
            quieriesbtn.UseVisualStyleBackColor = false;
            quieriesbtn.Click += quieriesbtn_Click;
            // 
            // materialsbtn
            // 
            materialsbtn.BackColor = Color.NavajoWhite;
            materialsbtn.FlatAppearance.BorderSize = 0;
            materialsbtn.FlatStyle = FlatStyle.Flat;
            materialsbtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            materialsbtn.Location = new Point(982, 0);
            materialsbtn.Name = "materialsbtn";
            materialsbtn.Size = new Size(185, 35);
            materialsbtn.TabIndex = 30;
            materialsbtn.Text = "Материали";
            materialsbtn.UseVisualStyleBackColor = false;
            materialsbtn.Click += materialsbtn_Click;
            // 
            // shapesbtn
            // 
            shapesbtn.BackColor = Color.NavajoWhite;
            shapesbtn.FlatAppearance.BorderSize = 0;
            shapesbtn.FlatStyle = FlatStyle.Flat;
            shapesbtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            shapesbtn.Location = new Point(791, 0);
            shapesbtn.Name = "shapesbtn";
            shapesbtn.Size = new Size(185, 35);
            shapesbtn.TabIndex = 29;
            shapesbtn.Text = "Форми";
            shapesbtn.UseVisualStyleBackColor = false;
            shapesbtn.Click += shapesbtn_Click;
            // 
            // typesbtn
            // 
            typesbtn.BackColor = Color.NavajoWhite;
            typesbtn.FlatAppearance.BorderSize = 0;
            typesbtn.FlatStyle = FlatStyle.Flat;
            typesbtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            typesbtn.Location = new Point(600, 0);
            typesbtn.Name = "typesbtn";
            typesbtn.Size = new Size(185, 35);
            typesbtn.TabIndex = 28;
            typesbtn.Text = "Видове артефакти";
            typesbtn.UseVisualStyleBackColor = false;
            typesbtn.Click += typesbtn_Click_1;
            // 
            // sectionsbtn
            // 
            sectionsbtn.BackColor = Color.NavajoWhite;
            sectionsbtn.Enabled = false;
            sectionsbtn.FlatAppearance.BorderSize = 0;
            sectionsbtn.FlatStyle = FlatStyle.Flat;
            sectionsbtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sectionsbtn.Location = new Point(409, 0);
            sectionsbtn.Name = "sectionsbtn";
            sectionsbtn.Size = new Size(185, 35);
            sectionsbtn.TabIndex = 2;
            sectionsbtn.Text = "Секции";
            sectionsbtn.UseVisualStyleBackColor = false;
            sectionsbtn.Click += sectionsbtn_Click;
            // 
            // menubtn
            // 
            menubtn.BackColor = Color.NavajoWhite;
            menubtn.FlatAppearance.BorderSize = 0;
            menubtn.FlatStyle = FlatStyle.Flat;
            menubtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            menubtn.Location = new Point(17, 0);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(195, 35);
            menubtn.TabIndex = 0;
            menubtn.Text = "Меню";
            menubtn.UseVisualStyleBackColor = false;
            menubtn.Click += menubtn_Click_1;
            // 
            // Sections
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 205, 153);
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            Controls.Add(updatebtn);
            Controls.Add(deletebtn);
            Controls.Add(addNewbtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(sectionsDataGrid);
            Name = "Sections";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Секции";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sectionsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView sectionsDataGrid;
        private BindingSource bindingSource1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button addNewbtn;
        private Button deletebtn;
        private Button updatebtn;
        private Panel panel1;
        private Button assesmentProtocolbtn;
        private Button collectionsbtn;
        private Button museumsbtn;
        private Button artefactsbtn;
        private Button quieriesbtn;
        private Button materialsbtn;
        private Button shapesbtn;
        private Button typesbtn;
        private Button sectionsbtn;
        private Button menubtn;
    }
}