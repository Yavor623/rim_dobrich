namespace RIMDobrich1
{
    partial class Materials
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            addNewbtn = new Button();
            materialDataGrid = new DataGridView();
            materialTxt = new TextBox();
            materialidTxt = new TextBox();
            searchtxt = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)materialDataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.NavajoWhite;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point);
            searchbtn.Location = new Point(22, 533);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(861, 55);
            searchbtn.TabIndex = 26;
            searchbtn.Text = "Търси";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.NavajoWhite;
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point);
            updatebtn.Location = new Point(22, 864);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(861, 70);
            updatebtn.TabIndex = 25;
            updatebtn.Text = "Обнови";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.NavajoWhite;
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point);
            deletebtn.Location = new Point(22, 940);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(861, 70);
            deletebtn.TabIndex = 24;
            deletebtn.Text = "Премахни";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // addNewbtn
            // 
            addNewbtn.BackColor = Color.NavajoWhite;
            addNewbtn.FlatStyle = FlatStyle.Flat;
            addNewbtn.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point);
            addNewbtn.Location = new Point(22, 788);
            addNewbtn.Name = "addNewbtn";
            addNewbtn.Size = new Size(861, 70);
            addNewbtn.TabIndex = 23;
            addNewbtn.Text = "Добави";
            addNewbtn.UseVisualStyleBackColor = false;
            addNewbtn.Click += addNewbtn_Click;
            // 
            // materialDataGrid
            // 
            materialDataGrid.AccessibleRole = AccessibleRole.None;
            materialDataGrid.AllowUserToAddRows = false;
            materialDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            materialDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            materialDataGrid.BackgroundColor = Color.Tan;
            materialDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materialDataGrid.Location = new Point(907, 67);
            materialDataGrid.Name = "materialDataGrid";
            materialDataGrid.ReadOnly = true;
            materialDataGrid.RowHeadersWidth = 51;
            materialDataGrid.RowTemplate.Height = 29;
            materialDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            materialDataGrid.Size = new Size(976, 943);
            materialDataGrid.TabIndex = 22;
            materialDataGrid.CellClick += descriprionDataGrid_CellClick;
            // 
            // materialTxt
            // 
            materialTxt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            materialTxt.Location = new Point(22, 283);
            materialTxt.Multiline = true;
            materialTxt.Name = "materialTxt";
            materialTxt.PlaceholderText = "Име на материал";
            materialTxt.Size = new Size(861, 50);
            materialTxt.TabIndex = 21;
            // 
            // materialidTxt
            // 
            materialidTxt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            materialidTxt.Location = new Point(22, 67);
            materialidTxt.Multiline = true;
            materialidTxt.Name = "materialidTxt";
            materialidTxt.PlaceholderText = "Индекс";
            materialidTxt.Size = new Size(861, 50);
            materialidTxt.TabIndex = 20;
            // 
            // searchtxt
            // 
            searchtxt.BackColor = SystemColors.Control;
            searchtxt.Cursor = Cursors.IBeam;
            searchtxt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            searchtxt.Location = new Point(22, 477);
            searchtxt.Multiline = true;
            searchtxt.Name = "searchtxt";
            searchtxt.PlaceholderText = "Търсене";
            searchtxt.Size = new Size(861, 50);
            searchtxt.TabIndex = 30;
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
            panel1.TabIndex = 41;
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
            materialsbtn.Enabled = false;
            materialsbtn.FlatAppearance.BorderSize = 0;
            materialsbtn.FlatStyle = FlatStyle.Flat;
            materialsbtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            materialsbtn.Location = new Point(982, 0);
            materialsbtn.Name = "materialsbtn";
            materialsbtn.Size = new Size(185, 35);
            materialsbtn.TabIndex = 30;
            materialsbtn.Text = "Материали";
            materialsbtn.UseVisualStyleBackColor = false;
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
            sectionsbtn.FlatAppearance.BorderSize = 0;
            sectionsbtn.FlatStyle = FlatStyle.Flat;
            sectionsbtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sectionsbtn.Location = new Point(409, 0);
            sectionsbtn.Name = "sectionsbtn";
            sectionsbtn.Size = new Size(185, 35);
            sectionsbtn.TabIndex = 2;
            sectionsbtn.Text = "Секции";
            sectionsbtn.UseVisualStyleBackColor = false;
            sectionsbtn.Click += sectionsbtn_Click_1;
            // 
            // menubtn
            // 
            menubtn.BackColor = Color.NavajoWhite;
            menubtn.FlatAppearance.BorderSize = 0;
            menubtn.FlatStyle = FlatStyle.Flat;
            menubtn.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            menubtn.Location = new Point(3, 0);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(209, 35);
            menubtn.TabIndex = 0;
            menubtn.Text = "Меню";
            menubtn.UseVisualStyleBackColor = false;
            menubtn.Click += menubtn_Click_1;
            // 
            // Materials
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 205, 153);
            ClientSize = new Size(1902, 1055);
            Controls.Add(panel1);
            Controls.Add(searchbtn);
            Controls.Add(updatebtn);
            Controls.Add(deletebtn);
            Controls.Add(addNewbtn);
            Controls.Add(materialDataGrid);
            Controls.Add(materialTxt);
            Controls.Add(materialidTxt);
            Controls.Add(searchtxt);
            Name = "Materials";
            Text = "Материали";
            Load += Materials_Load;
            ((System.ComponentModel.ISupportInitialize)materialDataGrid).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button searchbtn;
        private Button updatebtn;
        private Button deletebtn;
        private Button addNewbtn;
        private DataGridView materialDataGrid;
        private TextBox materialTxt;
        private TextBox materialidTxt;
        private TextBox searchtxt;
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