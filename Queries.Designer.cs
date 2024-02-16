namespace RIMDobrich1
{
    partial class Queries
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            comboBox3 = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Изведи всички...", "Изведи броя на..." });
            comboBox1.Location = new Point(54, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(433, 28);
            comboBox1.TabIndex = 41;
            comboBox1.Text = "Изберете вида на заявката";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Артефакти", "Форми", "Материали", "Секции", "Колекции", "Име на музей", "Видове артефакти", "Оценителен протокол" });
            comboBox2.Location = new Point(54, 141);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(433, 28);
            comboBox2.TabIndex = 42;
            comboBox2.Text = "Изберете таблицата, за която ще се изпълни";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(569, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1321, 984);
            dataGridView1.TabIndex = 43;
            // 
            // comboBox3
            // 
            comboBox3.Enabled = false;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(54, 193);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(433, 28);
            comboBox3.TabIndex = 44;
            comboBox3.Text = "Изберете таблицата, за която ще се изпълни";
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
            panel1.TabIndex = 45;
            // 
            // assesmentProtocolbtn
            // 
            assesmentProtocolbtn.BackColor = Color.NavajoWhite;
            assesmentProtocolbtn.FlatAppearance.BorderSize = 0;
            assesmentProtocolbtn.FlatStyle = FlatStyle.Flat;
            assesmentProtocolbtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
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
            collectionsbtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
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
            museumsbtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
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
            artefactsbtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
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
            quieriesbtn.Enabled = false;
            quieriesbtn.FlatAppearance.BorderSize = 0;
            quieriesbtn.FlatStyle = FlatStyle.Flat;
            quieriesbtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            quieriesbtn.Location = new Point(1745, 0);
            quieriesbtn.Name = "quieriesbtn";
            quieriesbtn.Size = new Size(156, 35);
            quieriesbtn.TabIndex = 31;
            quieriesbtn.Text = "Заявки";
            quieriesbtn.UseVisualStyleBackColor = false;
            // 
            // materialsbtn
            // 
            materialsbtn.BackColor = Color.NavajoWhite;
            materialsbtn.FlatAppearance.BorderSize = 0;
            materialsbtn.FlatStyle = FlatStyle.Flat;
            materialsbtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
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
            shapesbtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
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
            typesbtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            typesbtn.Location = new Point(600, 0);
            typesbtn.Name = "typesbtn";
            typesbtn.Size = new Size(185, 35);
            typesbtn.TabIndex = 28;
            typesbtn.Text = "Видове артефакти";
            typesbtn.UseVisualStyleBackColor = false;
            typesbtn.Click += typesbtn_Click;
            // 
            // sectionsbtn
            // 
            sectionsbtn.BackColor = Color.NavajoWhite;
            sectionsbtn.FlatAppearance.BorderSize = 0;
            sectionsbtn.FlatStyle = FlatStyle.Flat;
            sectionsbtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
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
            menubtn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            menubtn.Location = new Point(17, 0);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(195, 35);
            menubtn.TabIndex = 0;
            menubtn.Text = "Меню";
            menubtn.UseVisualStyleBackColor = false;
            menubtn.Click += menubtn_Click;
            // 
            // Queries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 205, 153);
            ClientSize = new Size(1902, 1055);
            Controls.Add(panel1);
            Controls.Add(comboBox3);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Queries";
            Text = "Queries";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private ComboBox comboBox3;
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