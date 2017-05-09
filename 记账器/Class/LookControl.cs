using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace 记账器.Class
{
    class LookControl
    {
        public LookControl(DataView dvC,int Amount,int NowPlace)
        {
            Mount = Amount;
            place = NowPlace;
            dv = dvC;
        }
        //记录总量
        public int Mount;
        //当前寻找记录的位置
        public int place;
        public string LKDate;
        public string LKWhat;
        public string LKWhith;
        public string LKMoney;
        public string LKAbout;
        private DataView dv;

        //cmb的选择
        private void ShowText()
        {
            LKDate = dv[place-1]["MyTime"].ToString();
            LKMoney = dv[place-1]["UseMoney"].ToString();
            LKAbout = dv[place-1]["About"].ToString();
        }

        //datagridview 的选择
        private void ShowText(bool FromDate)
        {
            LKWhat = dv[place - 1]["Item"].ToString();
            LKWhith = dv[place - 1]["Attribute"].ToString();
            LKMoney = dv[place - 1]["UseMoney"].ToString();
            LKAbout = dv[place - 1]["About"].ToString();
        }

        public bool GoNext()
        {
            if (place == Mount)
                return false;
            place++;
            ShowText();
            return true;
        }
        //重载
        public bool GoNext(bool FromDate)
        {
            if (place == Mount)
                return false;
            place++;
            ShowText(true);
            return true;
        }

        public bool GoPre()
        {
            if (place == 1)
                return false;
            place -= 1;
            ShowText();
            return true;
        }
        //重载
        public bool GoPre(bool FromDate)
        {
            if (place == 1)
                return false;
            place -= 1;
            ShowText(true);
            return true;
        }

        public void GoAhead()
        {
            place = 1;
            ShowText();
        }
        //重载
        public void GoAhead(bool FromDate)
        {
            place = 1;
            ShowText(true);
        }

        public void GoLast()
        {
            place = Mount;
            ShowText();
        }

        //重载
        public void GoLast(bool FromDate)
        {
            place = Mount;
            ShowText(true);
        }
    }
}
