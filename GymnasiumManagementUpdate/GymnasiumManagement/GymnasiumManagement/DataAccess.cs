using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace GymnasiumManagement
{
    class DataAccess
    {
        string sqlConn = "Data Source=JAYEM;User ID=sa;Password=section[N]";

        //private SqlCommand sqlCom;
        public SqlConnection SqlCon { set; get; }
        public SqlCommand SqlCom { set; get; }
        public SqlDataAdapter Sdt { set; get; }
        public DataSet ds { set; get; }

        public DataAccess()
        {
            this.SqlCon = new SqlConnection(sqlConn);
            this.SqlCon.Open();
        }

        public DataSet GetAllDAta(string sqlQuery)
        {
            this.SqlCom = new SqlCommand(sqlQuery, this.SqlCon);
            this.Sdt = new SqlDataAdapter(this.SqlCom);
            this.ds = new DataSet();
            this.Sdt.Fill(ds);
            return this.ds;
        }


    }
}
