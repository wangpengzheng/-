using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace 记账器.Class
{
    class EnCode
    {
        public string SetCode(string s)
        {
            //ASCIIEncoding asc = new ASCIIEncoding();
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(s);
            string ret = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                ret += Convert.ToString(bytes[i]+1, 16).PadLeft(2, '0');
            }
            return ret;
        }

        public String md5(String s)
        {
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(s);
            bytes = md5.ComputeHash(bytes);
            md5.Clear();

            string ret = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                ret += Convert.ToString(bytes[i], 16).PadLeft(2, '0');
            }
            return ret.PadLeft(32, '0');
        }

        //public bool WriteText(string T1, string T2)
        //{

        //    FileStream fTemp = new FileStream(ItemLocation, FileMode.Truncate);
        //    StreamWriter sw = new StreamWriter(fTemp);
        //    sw.WriteLine("Use=1<u>");
        //    sw.WriteLine("DefaultUser=Vincent<d>");
        //    sw.Close();
        //    fTemp.Close();
        //}

        //public string ReadText()
        //{
        //    ////FileStream fsR1 = new FileStream(ItemLocation, FileMode.Open);
        //    //StreamReader sr1 = new StreamReader(fsR1);
        //    //string str = sr1.ReadToEnd();
        //    //sr1.Close();
        //    //fsR1.Close();
        //    //return str;
        //}

        public void PutMd5ToDataBase()
        {

        }

        public void GetMd5FromDataBase()
        {

        }

        public string DelCode(string s)
        {
            //byte[] bs = ChangeStrToByte(s);
            //string str = Encoding.UTF8.GetString(bs);
            //return str;
            byte[] bs = ChangeStrToByte(s);
            string str = Encoding.ASCII.GetString(bs);
            return str;
        }

        private byte[] ChangeStrToByte(string s)
        {
            int i = s.Length / 2;
            byte[] bs = new byte[i];
            for (int j = 0; j < i; j += 1)
            {
                //疑问：反转的AscII码少了1？？？？？？？？？？？？？？？？？？？？？？？？？？？？？
                bs[j]=Convert.ToByte(Convert.ToByte(s.Substring(j*2,2),16)-1);
            }
            return bs;
        }

    }
}
