using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace RealEstateProject
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=OMER-GOKCEN\SQLEXPRESS;Initial Catalog=RealEstate;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
