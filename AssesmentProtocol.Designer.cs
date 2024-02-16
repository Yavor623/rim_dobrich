namespace RIMDobrich1
{
    partial class AssesmentProtocol
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
            components = new System.ComponentModel.Container();
            updatebtn = new Button();
            deletebtn = new Button();
            addNewbtn = new Button();
            indextxt = new TextBox();
            assesmentProtocolDataGrid = new DataGridView();
            bindingSource1 = new BindingSource(components);
            pricetxt = new TextBox();
            datecal = new DateTimePicker();
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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)assesmentProtocolDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.NavajoWhite;
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Font = new Font("Modern No. 20", 20F, FontStyle.Regular, GraphicsUnit.Point);
            updatebtn.Location = new Point(39, 781);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(667, 75);
            updatebtn.TabIndex = 45;
            updatebtn.Text = "Обнови";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click_1;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.NavajoWhite;
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Modern No. 20", 20F, FontStyle.Regular, GraphicsUnit.Point);
            deletebtn.Location = new Point(39, 862);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(667, 75);
            deletebtn.TabIndex = 44;
            deletebtn.Text = "Премахни";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click_1;
            // 
            // addNewbtn
            // 
            addNewbtn.BackColor = Color.NavajoWhite;
            addNewbtn.FlatStyle = FlatStyle.Flat;
            addNewbtn.Font = new Font("Modern No. 20", 20F, FontStyle.Regular, GraphicsUnit.Point);
            addNewbtn.Location = new Point(39, 700);
            addNewbtn.Name = "addNewbtn";
            addNewbtn.Size = new Size(667, 75);
            addNewbtn.TabIndex = 43;
            addNewbtn.Text = "Добави";
            addNewbtn.UseVisualStyleBackColor = false;
            addNewbtn.Click += addNewbtn_Click_1;
            // 
            // indextxt
            // 
            indextxt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            indextxt.Location = new Point(39, 91);
            indextxt.Multiline = true;
            indextxt.Name = "indextxt";
            indextxt.PlaceholderText = "Индекс";
            indextxt.Size = new Size(667, 50);
            indextxt.TabIndex = 41;
            // 
            // assesmentProtocolDataGrid
            // 
            assesmentProtocolDataGrid.AllowUserToAddRows = false;
            assesmentProtocolDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            assesmentProtocolDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            assesmentProtocolDataGrid.BackgroundColor = Color.Tan;
            assesmentProtocolDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            assesmentProtocolDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assesmentProtocolDataGrid.Location = new Point(731, 91);
            assesmentProtocolDataGrid.Name = "assesmentProtocolDataGrid";
            assesmentProtocolDataGrid.ReadOnly = true;
            assesmentProtocolDataGrid.RowHeadersWidth = 51;
            assesmentProtocolDataGrid.RowTemplate.Height = 29;
            assesmentProtocolDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            assesmentProtocolDataGrid.Size = new Size(1135, 846);
            assesmentProtocolDataGrid.TabIndex = 40;
            assesmentProtocolDataGrid.CellClick += typesDataGrid_CellClick_1;
            // 
            // pricetxt
            // 
            pricetxt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            pricetxt.Location = new Point(39, 547);
            pricetxt.Multiline = true;
            pricetxt.Name = "pricetxt";
            pricetxt.PlaceholderText = "Сума";
            pricetxt.Size = new Size(667, 50);
            pricetxt.TabIndex = 52;
            // 
            // datecal
            // 
            datecal.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datecal.CustomFormat = "yyyy-MM-dd";
            datecal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            datecal.Format = DateTimePickerFormat.Custom;
            datecal.Location = new Point(39, 364);
            datecal.Name = "datecal";
            datecal.Size = new Size(667, 47);
            datecal.TabIndex = 53;
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
            panel1.TabIndex = 54;
            // 
            // assesmentProtocolbtn
            // 
            assesmentProtocolbtn.BackColor = Color.NavajoWhite;
            assesmentProtocolbtn.Enabled = false;
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
            menubtn.Location = new Point(0, 0);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(212, 35);
            menubtn.TabIndex = 0;
            menubtn.Text = "Меню";
            menubtn.UseVisualStyleBackColor = false;
            menubtn.Click += menubtn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 315);
            label1.Name = "label1";
            label1.Size = new Size(422, 35);
            label1.TabIndex = 55;
            label1.Text = "Дата на оценителен протокол";
            // 
            // AssesmentProtocol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1902, 1055);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(datecal);
            Controls.Add(pricetxt);
            Controls.Add(updatebtn);
            Controls.Add(deletebtn);
            Controls.Add(addNewbtn);
            Controls.Add(indextxt);
            Controls.Add(assesmentProtocolDataGrid);
            Name = "AssesmentProtocol";
            Text = "AssesmentProtocol";
            Load += AssesmentProtocol_Load;
            ((System.ComponentModel.ISupportInitialize)assesmentProtocolDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button updatebtn;
        private Button deletebtn;
        private Button addNewbtn;
        private TextBox indextxt;
        private DataGridView assesmentProtocolDataGrid;
        private BindingSource bindingSource1;
        private TextBox pricetxt;
        private DateTimePicker datecal;
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
        private Label label1;
    }
}