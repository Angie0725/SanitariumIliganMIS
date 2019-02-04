using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn.Models
{
    public class SessionMeta
    {
        public int staffNum = 0;

        private int getStaffNum()
        {
            return this.staffNum;
        }

        private void setStaffNum(int staffNum)
        {
            this.staffNum = staffNum;
        }
    }
}
