using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace WinForm
{
    public partial class Form1 : Form
    {
        private Repository _repository;
        public Form1()
        {
            InitializeComponent();

            _repository = new Repository();

            dataGridView1.DataSource = _repository.DataSet.Tables[0];

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            _repository.SaveToDatabase();
        }

        private void Btn_SaveToXML_Click(object sender, EventArgs e)
        {
            _repository.SaveToXML();
        }
    }
}
