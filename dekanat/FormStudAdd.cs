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
    public partial class FormStudAdd : Form
    {
        public FormStudAdd()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f7 = new Form2();
            f7.ShowDialog();
        }
    }
}
