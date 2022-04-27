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

namespace RealEstateProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
            Init_Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            string sorgu = "SELECT * FROM login where username=@user AND password=@pass";
            con = new SqlConnection(@"Data Source=OMER-GOKCEN\SQLEXPRESS;Initial Catalog=RealEstate;Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", txtUser.Text);
            cmd.Parameters.AddWithValue("@pass", txtPass.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (txtUser.Text == "")
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez");

            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Şifre boş geçilemez");
            }

            else
            {
                if (dr.Read())
                {
                    MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. ");
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                    txtUser.Clear();
                    txtPass.Clear();
                    txtUser.Focus();
                }
                con.Close();
                Save_Data();


            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    txtUser.Text = Properties.Settings.Default.UserName;
                    checkBox1.Checked = true;
                }
                else
                {
                    txtUser.Text = Properties.Settings.Default.UserName;
                }
            }

        }
        private void Save_Data()
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.UserName = txtUser.Text.Trim();
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

