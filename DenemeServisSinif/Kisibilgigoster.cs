using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;

namespace DenemeServisSinif
{

    public class Kisibilgigoster : IKisibilgigoster
    {
        DataSet IKisibilgigoster.Kisibilgigoster()
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.InitialCatalog = "AsmxDB";
            sqlConnectionStringBuilder.DataSource = @"DESKTOP-ECI1EV7\SQLEXPRESS";
            sqlConnectionStringBuilder.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);

            string sorgu = "select * from tblkisibilgi";
            SqlDataAdapter dt = new SqlDataAdapter(sorgu, con);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            return ds;
        }
    }
}
