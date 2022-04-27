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
    public partial class Form3 : Form
    {
        public Form3()
        {

            InitializeComponent();

        }
        
        SqlBaglantim bgl = new SqlBaglantim();
        


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("insert into addsection(Type,HomeType,SqrMeters,Rooms,Price,BuildingAge,FlrLocation,NumberOfFlr,DoorNumber,Furnished,Adress,SellerName,SellerTelNO,SellerID,Notes) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15)", bgl.baglanti());

            cmd.Parameters.AddWithValue("@p1", CmbType.Text);
            cmd.Parameters.AddWithValue("@p2", CmbHType.Text);
            cmd.Parameters.AddWithValue("@p3", TxtSqrMt.Text);
            cmd.Parameters.AddWithValue("@p4", CmbRooms.Text);
            cmd.Parameters.AddWithValue("@p5", TxtPrice.Text);
            cmd.Parameters.AddWithValue("@p6", TxtBAge.Text);
            cmd.Parameters.AddWithValue("@p7", TxtFlrLoca.Text);
            cmd.Parameters.AddWithValue("@p8", TxtNoFlr.Text);
            cmd.Parameters.AddWithValue("@p9", TxtDoorNo.Text);
            cmd.Parameters.AddWithValue("@p10", CmbFurnished.Text);
            cmd.Parameters.AddWithValue("@p11", RtbAdress.Text);
            cmd.Parameters.AddWithValue("@p12", TxtSName.Text);
            cmd.Parameters.AddWithValue("@p13", maskedTelNo.Text);
            cmd.Parameters.AddWithValue("@p14", maskedID.Text);
            cmd.Parameters.AddWithValue("@p15", RtbNotes.Text);
            
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Eklendi");
            this.addsectionTableAdapter.Fill(this.realEstateDataSet1.addsection);


        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            this.addsectionTableAdapter.Fill(this.realEstateDataSet1.addsection);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from addsection where SellerID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", maskedID.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Silindi");
                this.addsectionTableAdapter.Fill(this.realEstateDataSet1.addsection);
                TxtSqrMt.Clear();
                TxtPrice.Clear();
                TxtBAge.Clear();
                TxtFlrLoca.Clear();
                TxtNoFlr.Clear();
                TxtDoorNo.Clear();
                RtbAdress.Clear();
                TxtSName.Clear();
                maskedTelNo.Clear();
                maskedID.Clear();
                RtbNotes.Clear();
                CmbType.Focus();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            


        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            CmbType.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            CmbHType.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSqrMt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbRooms.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtPrice.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtBAge.Text=dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtFlrLoca.Text=dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtNoFlr.Text=dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtDoorNo.Text= dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            CmbFurnished.Text= dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            RtbAdress.Text= dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            TxtSName.Text= dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            maskedTelNo.Text= dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            maskedID.Text= dataGridView1.Rows[secilen].Cells[13].Value.ToString();
            RtbNotes.Text= dataGridView1.Rows[secilen].Cells[14].Value.ToString();


        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            

            SqlCommand komut2 = new SqlCommand("update addsection set Type=@p1,HomeType=@p2,SqrMeters=@p3,Rooms=@p4,Price=@p5,BuildingAge=@p6,FlrLocation=@p7,NumberOfFlr=@p8,DoorNumber=@p9,Furnished=@p10,Adress=@p11,SellerName=@p12,SellerTelNO=@p13,Notes=@p15 where SellerID=@p14", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", CmbType.Text);
            komut2.Parameters.AddWithValue("@p2", CmbHType.Text);
            komut2.Parameters.AddWithValue("@p3", TxtSqrMt.Text);
            komut2.Parameters.AddWithValue("@p4", CmbRooms.Text);
            komut2.Parameters.AddWithValue("@p5", TxtPrice.Text);
            komut2.Parameters.AddWithValue("@p6", TxtBAge.Text);
            komut2.Parameters.AddWithValue("@p7", TxtFlrLoca.Text);
            komut2.Parameters.AddWithValue("@p8", TxtNoFlr.Text);
            komut2.Parameters.AddWithValue("@p9", TxtDoorNo.Text);
            komut2.Parameters.AddWithValue("@p10", CmbFurnished.Text);
            komut2.Parameters.AddWithValue("@p11", RtbAdress.Text);
            komut2.Parameters.AddWithValue("@p12", TxtSName.Text);
            komut2.Parameters.AddWithValue("@p13", maskedTelNo.Text);
            komut2.Parameters.AddWithValue("@p15", RtbNotes.Text);
            komut2.Parameters.AddWithValue("@p14", maskedID.Text);
            komut2.ExecuteNonQuery();
            this.addsectionTableAdapter.Fill(this.realEstateDataSet1.addsection);
        }

        private void CmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }
    }
}

