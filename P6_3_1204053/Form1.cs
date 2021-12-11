using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace P6_3_1204053
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rbLaki.Checked = false;
            rbPerempuan.Checked = false;

            //string myConnectionString = "integrated security=true;data source=.;initial catalog=LAPTOP-PH1JF1U0\BELAJARIT\P6_1204053";

            SqlConnection myConnection = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT; Initial Catalog=P6_1204053;Integrated Security=True");
            myConnection.Open();
            SqlCommand sc = new SqlCommand("SELECT * FROM msprodi", myConnection);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable tabel = new DataTable();
            tabel.Columns.Add("id_prodi", typeof(string));
            tabel.Columns.Add("singkatan", typeof(string));
            tabel.Load(reader);

            cbPS.ValueMember = "id_prodi";
            cbPS.DisplayMember = "singkatan";
            cbPS.DataSource = tabel;

            myConnection.Close();
        }

        private void ntbNPM_Leave(object sender, EventArgs e)
        {
            if (ntbNPM.Text.Length == 7)
            {
                epcorrect.SetError(ntbNPM, "CORRECT !");
            }
            else if (ntbNPM.Text == "")
            {
                epwrong.SetError(ntbNPM, "NPM tidak boleh > dari 7 angka, Harap diisi dengan benar!");
            }
            else
            {
                epwrong.SetError(ntbNPM, "");
            }
        }

        private void tbNama_Leave(object sender, EventArgs e)
        {

            if (tbNama.Text == "")
            {
                epwarning.SetError(tbNama, "Nama tidak boleh kosong! Harap diisi dengan benar!");
            }
            else
            {
                epwrong.SetError(tbNama, "");
            }
        }

        private void tbAlamat_Leave(object sender, EventArgs e)
        {
            if (tbAlamat.Text == "")
            {
                epwarning.SetError(tbAlamat, "Kolom alamat tidak boleh kosong !");
            }
            else
            {
                epcorrect.SetError(tbAlamat, "CORRECT");
            }
        }

        private void tbNo_Leave(object sender, EventArgs e)
        {
            if (tbNo.Text == "")
            {
                epwarning.SetError(tbNo, "No harap diisi! tidak boleh kosong !");
            }
            else
            {
                epwrong.SetError(tbNo, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ntbNPM.Text != "" && ntbNPM.TextLength == 7)
            {
                if (tbNama.Text != "")
                {
                    if (dtTGL.Text != "")
                    {
                        if (!rbLaki.Checked || rbPerempuan.Checked)
                        {
                            if (tbAlamat.Text != "")
                            {
                                if (tbNo.Text != "")
                                {
                                    if (cbPS.Text != "--Pilih Program Studi--")
                                    {
                                        string npm = ntbNPM.Text;
                                        string nama = tbNama.Text;
                                        string tgllahir = dtTGL.Text;
                                        string jeniskelamin = "";
                                        if (rbLaki.Checked)
                                        {
                                            jeniskelamin = rbLaki.Text;
                                        }
                                        if (rbPerempuan.Checked)
                                        {
                                            jeniskelamin = rbPerempuan.Text;
                                        }
                                        string alamat = tbAlamat.Text;
                                        string telepon = tbNo.Text;
                                        string prodi = cbPS.Text;

                                        SqlConnection myConnection = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT; Initial Catalog=P6_1204053;Integrated Security=True");
                                        string sql = "INSERT INTO msmhs ([nim],[nama],[tgl_lahir],[jenis_kelamin],[alamat]," + "[telepon],[id_prodi]) VALUES (@npm,@nama,@tgllahir,@jeniskelamin,@alamat,@no,@idprodi)";

                                        using(SqlConnection Connection = new SqlConnection(@"Data Source=LAPTOP-PH1JF1U0\BELAJARIT; Initial Catalog=P6_1204053;Integrated Security=True"))
                                        {
                                            try
                                            {
                                                Connection.Open();

                                                using (SqlCommand command = new SqlCommand(sql, Connection))
                                                {
                                                    command.Parameters.Add("@npm", SqlDbType.VarChar).Value = npm;
                                                    command.Parameters.Add("@nama", SqlDbType.VarChar).Value = nama;
                                                    command.Parameters.Add("@tgllahir", SqlDbType.Date).Value = tgllahir;
                                                    command.Parameters.Add("@jeniskelamin", SqlDbType.VarChar).Value = jeniskelamin;
                                                    command.Parameters.Add("@alamat", SqlDbType.VarChar).Value = alamat;
                                                    command.Parameters.Add("@no", SqlDbType.VarChar).Value = telepon;
                                                    command.Parameters.Add("@idprodi", SqlDbType.VarChar).Value = prodi;

                                                    int rowsAdded = command.ExecuteNonQuery();
                                                    if (rowsAdded > 0)
                                                        MessageBox.Show("Data berhasil disimpan");
                                                    else
                                                        MessageBox.Show("Data tidak disimpan");

                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("ERROR:" + ex.Message);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Silahkan Pilih Program Studi !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No.Telepon harus diisi !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Alamat harus diisi !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Pilih salah satu dari jenis kelamin !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tanggal Lahir harus diisi !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nama harus diisi !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nama harus diisi !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ntbNPM.Text = null;
            tbAlamat.Text = null;
            tbNama.Text = null;
            tbNo.Text = null;
            rbPerempuan.Checked = false;
            rbLaki.Checked = false;
            cbPS.SelectedIndex = 0;
        }
    }
}

