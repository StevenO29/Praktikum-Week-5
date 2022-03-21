using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_5
{
    public partial class FormMateri : Form
    {
        public FormMateri()
        {
            InitializeComponent();
        }

        private void FormMateri_Load(object sender, EventArgs e)
        {
            radBtnMerah.Checked = true;
            lblHasil.ForeColor = Color.Black;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHasil.Text = listBoxKoleksi.SelectedItem.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBoxKoleksi.Items.Add(txtBoxInput.Text);
            txtBoxInput.Text = "";
            if (listBoxKoleksi.Items.Contains(txtBoxInput.Text))
                MessageBox.Show("Data sudah ada! Input kembali");
        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                if (radBtnMerah.Checked == true)
                    lblHasil.ForeColor = Color.Red;
                else if (radBtnBiru.Checked == true)
                    lblHasil.ForeColor = Color.Blue;
            }
            else
                lblHasil.ForeColor = Color.Black;
        }

        private void radBtnMerah_CheckedChanged(object sender, EventArgs e)
        {
            lblHasil.ForeColor = Color.Red;
        }

        private void radBtnBiru_CheckedChanged(object sender, EventArgs e)
        {
            lblHasil.ForeColor = Color.Blue;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxInput.Clear();
            listBoxKoleksi.Items.Clear();
            checkBoxAktif.Checked = false;
            radBtnMerah.Checked = true;
            lblHasil.ForeColor = Color.Black;
            lblHasil.Text = "";
        }
    }
}
