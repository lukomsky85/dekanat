using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dekanat
{
    public partial class FormStud : Form
    {
        public FormStud()
        {
            InitializeComponent();
        }

        private void FormStud_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSet.Stud". При необходимости она может быть перемещена или удалена.
            this.studTableAdapter.Fill(this.dekanatDataSet.Stud);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStudAdd f = new FormStudAdd(); // создать форму

            if (f.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                // если OK, то добавить работника
                string StudF, StudI, StudO, StudD, StudG, StudK;

                StudF = f.textBox1.Text;
                StudI = f.textBox2.Text;
                StudO = f.textBox3.Text;
                StudD = f.textBox4.Text;
                StudG = f.textBox5.Text;
                StudK = f.textBox6.Text;

                // работает
                this.studTableAdapter.Insert(StudF, StudI, StudO, StudD, StudG, StudK); // вставка
                this.studTableAdapter.Fill(this.dekanatDataSet.Stud); // отображение
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStudEdit f = new FormStudEdit(); // создать форму

            int index;
            string StudF, StudI, StudO, StudD, StudG, StudK;
            int Stud_ID;

            if (dataGridView1.RowCount <= 1) return;

            // получить позицию выделенной строки в dataGridView1
            index = dataGridView1.CurrentRow.Index;

            if (index == dataGridView1.RowCount - 1) return; //

            // получить данные строки
            Stud_ID = (int)dataGridView1.Rows[index].Cells[0].Value;
            StudF = (string)dataGridView1.Rows[index].Cells[1].Value;
            StudI = (string)dataGridView1.Rows[index].Cells[2].Value;
            StudO = (string)dataGridView1.Rows[index].Cells[3].Value;
            StudD = (string)dataGridView1.Rows[index].Cells[4].Value;
            StudG = (string)dataGridView1.Rows[index].Cells[5].Value;
            StudK = (string)dataGridView1.Rows[index].Cells[6].Value;

            // заполнить поля формы f
            f.textBox1.Text = StudF;
            f.textBox2.Text = StudI;
            f.textBox3.Text = StudO;
            f.textBox4.Text = StudD;
            f.textBox5.Text = StudG;
            f.textBox6.Text = StudK;

            if (f.ShowDialog() == DialogResult.OK) // вызвать форму FormEditWorker
            {
                string nStudF, nStudI, nStudO, nStudD, nStudG, nStudK;

                // получить новые (измененные) значения из формы
                nStudF = f.textBox1.Text;
                nStudI = f.textBox2.Text;
                nStudO = f.textBox3.Text;
                nStudD = f.textBox4.Text;
                nStudG = f.textBox5.Text;
                nStudK = f.textBox6.Text;

                // сделать изменения в адаптере
                this.studTableAdapter.Update(nStudF, nStudI, nStudO, nStudD, nStudG, nStudK, Stud_ID, StudF, StudI, StudO, StudD, StudG, StudK);
                this.studTableAdapter.Fill(this.dekanatDataSet.Stud);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormStudDel f = new FormStudDel(); // создать форму
            int index;
            string StudF, StudI, StudO, StudD, StudG, StudK;
            int Stud_ID;

            // взять номер текущей (выделенной) строки в dataGridView1
            index = dataGridView1.CurrentRow.Index;

            // заполнить внутренние переменные из текущей строки dataGridView1
            Stud_ID = Convert.ToInt32(dataGridView1[0, index].Value);
            StudF = Convert.ToString(dataGridView1[1, index].Value);
            StudI = Convert.ToString(dataGridView1[2, index].Value);
            StudO = Convert.ToString(dataGridView1[3, index].Value);
            StudD = Convert.ToString(dataGridView1[4, index].Value);
            StudG = Convert.ToString(dataGridView1[5, index].Value);
            StudK = Convert.ToString(dataGridView1[6, index].Value);

            // сформировать информационную строку
            f.label2.Text = StudF + " " + StudI + " " + StudO;

            if (f.ShowDialog() == DialogResult.OK)
            {
                studTableAdapter.Delete(Stud_ID, StudF, StudI, StudO, StudD, StudG, StudK); // метод Delete
                this.studTableAdapter.Fill(this.dekanatDataSet.Stud);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "Выберите документ для загрузки данных";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                ofd.FileName + ";Extended Properties='Excel 12.0 XML;HDR=YES;IMEX=1';";

            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection(constr);
            con.Open();
            DataSet ds = new DataSet();
            DataTable schemaTable = con.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            string sheet1 = (string)schemaTable.Rows[0].ItemArray[2];
            string select = String.Format("SELECT * FROM [{0}]", sheet1);
            System.Data.OleDb.OleDbDataAdapter ad = new System.Data.OleDb.OleDbDataAdapter(select, con);
            ad.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.Close();
            con.Dispose();
            dataGridView1.DataSource = dt;
        }
    }
}
