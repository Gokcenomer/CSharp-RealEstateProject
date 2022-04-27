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
    public partial class Form4 : Form
    {
        SqlDataAdapter adapt;
        DataTable dt;
        
        public Form4()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl=new SqlBaglantim();
        private void Form4_Load(object sender, EventArgs e)
        {

            adapt = new SqlDataAdapter("select * from addsection", bgl.baglanti());
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            this.addsectionTableAdapter.Fill(this.realEstateDataSet2.addsection);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void TxtSName_TextChanged(object sender, EventArgs e)
        {
            
            adapt = new SqlDataAdapter("select * from addsection where SellerName like '" + TxtSName.Text + "%'", bgl.baglanti());
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            
        }
    }
}
