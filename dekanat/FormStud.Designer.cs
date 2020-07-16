namespace dekanat
{
    partial class FormStud
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStud));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dekanatDataSet = new dekanat.dekanatDataSet();
            this.studTableAdapter = new dekanat.dekanatDataSetTableAdapters.StudTableAdapter();
            this.dekanatDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(616, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Отменить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studIDDataGridViewTextBoxColumn,
            this.studFDataGridViewTextBoxColumn,
            this.studIDataGridViewTextBoxColumn,
            this.studODataGridViewTextBoxColumn,
            this.studDDataGridViewTextBoxColumn,
            this.studGDataGridViewTextBoxColumn,
            this.studKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(73, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 249);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studBindingSource
            // 
            this.studBindingSource.DataMember = "Stud";
            this.studBindingSource.DataSource = this.dekanatDataSet;
            // 
            // dekanatDataSet
            // 
            this.dekanatDataSet.DataSetName = "dekanatDataSet";
            this.dekanatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studTableAdapter
            // 
            this.studTableAdapter.ClearBeforeFill = true;
            // 
            // dekanatDataSetBindingSource
            // 
            this.dekanatDataSetBindingSource.DataSource = this.dekanatDataSet;
            this.dekanatDataSetBindingSource.Position = 0;
            // 
            // studIDDataGridViewTextBoxColumn
            // 
            this.studIDDataGridViewTextBoxColumn.DataPropertyName = "Stud_ID";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.studIDDataGridViewTextBoxColumn.HeaderText = "Stud_ID";
            this.studIDDataGridViewTextBoxColumn.Name = "studIDDataGridViewTextBoxColumn";
            this.studIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // studFDataGridViewTextBoxColumn
            // 
            this.studFDataGridViewTextBoxColumn.DataPropertyName = "StudF";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.studFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.studFDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.studFDataGridViewTextBoxColumn.Name = "studFDataGridViewTextBoxColumn";
            this.studFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studIDataGridViewTextBoxColumn
            // 
            this.studIDataGridViewTextBoxColumn.DataPropertyName = "StudI";
            this.studIDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.studIDataGridViewTextBoxColumn.Name = "studIDataGridViewTextBoxColumn";
            this.studIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studODataGridViewTextBoxColumn
            // 
            this.studODataGridViewTextBoxColumn.DataPropertyName = "StudO";
            this.studODataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.studODataGridViewTextBoxColumn.Name = "studODataGridViewTextBoxColumn";
            this.studODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studDDataGridViewTextBoxColumn
            // 
            this.studDDataGridViewTextBoxColumn.DataPropertyName = "StudD";
            this.studDDataGridViewTextBoxColumn.HeaderText = "Дата зачисления";
            this.studDDataGridViewTextBoxColumn.Name = "studDDataGridViewTextBoxColumn";
            this.studDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studGDataGridViewTextBoxColumn
            // 
            this.studGDataGridViewTextBoxColumn.DataPropertyName = "StudG";
            this.studGDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.studGDataGridViewTextBoxColumn.Name = "studGDataGridViewTextBoxColumn";
            this.studGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studKDataGridViewTextBoxColumn
            // 
            this.studKDataGridViewTextBoxColumn.DataPropertyName = "StudK";
            this.studKDataGridViewTextBoxColumn.HeaderText = "Факультет";
            this.studKDataGridViewTextBoxColumn.Name = "studKDataGridViewTextBoxColumn";
            this.studKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(373, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "Сохранить в";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(642, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Фильтр";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 7;
            // 
            // FormStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(799, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormStud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список студентов";
            this.Load += new System.EventHandler(this.FormStud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dekanatDataSet dekanatDataSet;
        private System.Windows.Forms.BindingSource studBindingSource;
        private dekanatDataSetTableAdapters.StudTableAdapter studTableAdapter;
        private System.Windows.Forms.BindingSource dekanatDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studKDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
    }
}