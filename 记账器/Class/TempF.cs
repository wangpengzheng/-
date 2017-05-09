using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 记账器.Class
{
    class TempF
    {
        public string date, what, which, about;
        TempF(string date1,string what1,string which1,string about1)
        {
            date = date1;
            what = what1;
            which = which1;
            about = about1;
        }

        bool Chk(string date2, string what2, string which2, string about2)
        {
            if (date != date2 || what != what2 || which != which2 || about != about2)
            {
                return false;
            }
            return true;
        }
    }
}
