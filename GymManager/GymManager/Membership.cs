using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymManager
{
    public class Membership
    {
        private Member _owner;
        private int _monthlyPrice;
        private int _months;

        public Member Owner { get { return _owner; } }
        public int MonthlyPrice { get { return _monthlyPrice; } }
        public int Months { get { return _months; } }

        public Membership(Member owner, int monthlyPrice, int months)
        {
            _owner = owner;
            _monthlyPrice = monthlyPrice;
            _months = months;
        }
    }
}
