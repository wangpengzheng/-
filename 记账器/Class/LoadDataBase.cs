using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace 记账器.Class
{

    class LoadDataBase
    {
        public string ConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=88189;Data Source=" + FrmMain.DataBaseLoc;
        private OleDbConnection Conn=new OleDbConnection();

        public void Open()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn = new OleDbConnection(ConStr);
                Conn.Open();
            }
        }

        public void Close()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        public DataView RunSelectSql(string str)
        {
   //         try
 //           {
                this.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(str, Conn);
                da.Fill(ds);
                this.Close();
                return ds.Tables[0].DefaultView;
    //        }
       //     catch 
       //     {
        //        return null;
       //     }
        }

        public void RunDelOrInsSQL(string str)
        {
                this.Open();
                OleDbCommand Cmd = new OleDbCommand(str,Conn);
                Cmd.ExecuteNonQuery();
                this.Close();
        }
    }
}
