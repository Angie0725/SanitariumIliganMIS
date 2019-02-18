using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn
{
    public class LoginDetails
    {
        private static int staffNum = 0;
        private static int pos = 0;

        public int getStaffNum()
        {
            return staffNum;
        }

        public void setStaffNum(int x)
        {
            staffNum = x;
        }

        public int getPOSnum()
        {
            return pos;
        }

        public void setPOSnum(int p)
        {
            pos = p;
        }
    }
}
