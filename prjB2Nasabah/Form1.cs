using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjB2Nasabah
{
    public partial class Form1 : Form
    {
        string JenisKelamin;

        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Lajang");
            cmbStatus.Items.Add("Menikah");
            cmbStatus.Items.Add("Duda");
            cmbStatus.Items.Add("Janda");
        }

        private void rbLaki_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLaki.Checked)
            {
                JenisKelamin = rbLaki.Text;
            }
        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPerempuan.Checked)
            {
                JenisKelamin = rbPerempuan.Text;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtNIK.Text == "")
            {
                MessageBox.Show("NIK tidak boleh kosong!");
                txtNIK.Focus();
            } else if (txtNama.Text == "")
            {
                MessageBox.Show("Nama lengkap tidak boleh kosong");
                txtNama.Focus();
            } else if (txtTempat.Text == "")
            {
                MessageBox.Show("Tempat Lahir tidak boleh kosong!");
                txtTempat.Focus();
            } else if (rbLaki.Checked==false && rbPerempuan.Checked==false)
            {
                MessageBox.Show("Jenis Kelamin harus dipilih!");
            } else if (txtAlamat.Text == "")
            {
                MessageBox.Show("Alamat tidak boleh kosong!");
                txtAlamat.Focus();
            } else if (txtTelepon.Text == "")
            {
                MessageBox.Show("Telepon tidak boleh kosong!");
                txtTelepon.Focus();
            } else if(cmbPekerjaan.SelectedIndex==-1)
            {
                MessageBox.Show("Pekerjaan harus dipilih!");
            } else if (cmbStatus.SelectedIndex==-1)
            {
                MessageBox.Show("Status tidak boleh kosong!");
            } else
            {
                rtbView.Clear();
                rtbView.AppendText("NIK                     : " + txtNIK.Text + "\n");
                rtbView.AppendText("Nama Lengkap            : " + txtNama.Text + "\n");
                rtbView.AppendText("Tempat, Tanggal Lahir   : " + txtTempat.Text + " , " + dtpTanggal.Text + "\n");
                rtbView.AppendText("Jenis Kelamin           : " + JenisKelamin + "\n");
                rtbView.AppendText("Alamat                  : " + txtAlamat.Text + "\n");
                rtbView.AppendText("No Telp                 : " + txtTelepon.Text + "\n");
                rtbView.AppendText("Pekerjaan               : " + cmbPekerjaan.Text + "\n");
                rtbView.AppendText("Status Perkawinan       : " + cmbStatus.SelectedItem + "\n");
            }

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbView.Clear();
            txtNIK.Clear();
            txtNama.Text = "";
            txtTempat.Clear();
            txtAlamat.Text = "";
            txtTelepon.Text = "";
            dtpTanggal.ResetText();
            cmbPekerjaan.ResetText();
            cmbStatus.ResetText();
        
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNIK_TextChanged(object sender, EventArgs e)
        {
            string tString = txtNIK.Text;
            if (tString.Trim() == "") return;

            for(int i = 0; i<tString.Length; i++)
            {
                if(!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Silahkan inputkan angka saja!");
                    txtNIK.Text = "";
                    return;
                }
            }
        }

        private void txtTelepon_TextChanged(object sender, EventArgs e)
        {
            string telp = txtTelepon.Text;
            if (telp.Trim() == "") return;

            for (int i = 0; i < telp.Length; i++)
            {
                if (!char.IsNumber(telp[i]))
                {
                    MessageBox.Show("Silahkan inputkan angka saja!");
                    txtTelepon.Text = "";
                    return;
                }

                if (telp.Length > 12)
                {
                    MessageBox.Show("No Telp tidak boleh lebih dari 12 angka");
                    txtTelepon.Text = "";
                    return;
                }
            }
        }
    }
}
