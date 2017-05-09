using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace 记账器.Class
{
    class ReNewOldText
    {
        //历史数据
        private string DateT="";
        private string What = "";
        private string Which = "";
        private string HowMuch = "";
        private string About = "";

        //跟新后的数据
        private string NDateT = "";
        private string NWhat = "";
        private string NWhich = "";
        private string NHowMuch = "";
        private string NAbout = "";

        private string CurUs;

        public ReNewOldText(string user,string x, string y, string z, string n, string m)
        {
            CurUs = user;
            DateT = x;
            What = y;
            Which = z;
            HowMuch = n;
            About = m;
        }

        public void loadNewData(string x, string y, string z, string n, string m)
        {
            NDateT = x;
            NWhat = y;
            NWhich = z;
            NHowMuch = n;
            NAbout = m;
        }

        public bool Chk()
        {
            if ((DateT != NDateT) || (What != NWhat) || (Which != NWhich) || (HowMuch != NHowMuch) || (About != NAbout))
            {
                return true;
            }
            else
                return false;
        }
         
        //返回1,2,3,ex,Message 均为出错,否则0为正确执行
        public string Update()
        {
            LoadDataBase db = new LoadDataBase();
            DataView dv = new DataView();
            string str = "select * from " + CurUs + " where MyTime='" + DateT + "' and Item='" + What +
                            "' and Attribute='" + Which + "' and UseMoney='" + HowMuch + "' and About='" + About + "'";
            string strN = "select * from " + CurUs + " where MyTime='" + NDateT + "' and Item='" + NWhat +
                            "' and Attribute='" + NWhich + "' and UseMoney='" + NHowMuch + "' and About='" + NAbout + "'";
            dv = db.RunSelectSql(str);
            //不存在需要更改的记录
            if (dv.Count == 0)
            {
                return "1";
            }
            //已存在要更改的记录
            dv = db.RunSelectSql(strN);
            if (dv.Count!=0)
            {
                return "2";
            }
            //未作任何更改
            if (!Chk())
            {
                return "3";
            }
            //开始修改
            string strDel = "delete * from " + CurUs + " where MyTime='" + DateT + "' and Item='" + What +
                            "' and Attribute='" + Which + "' and UseMoney='" + HowMuch + "' and About='" + About + "'";
            string strInsert = "Insert into "+ CurUs + " values('"  + NWhat + "','" + NWhich + "','"+ NDateT + "','" + NHowMuch + "','" + NAbout + "')";
            try
            {
                db.RunDelOrInsSQL(strDel);
                db.RunDelOrInsSQL(strInsert);
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }
    }
}
