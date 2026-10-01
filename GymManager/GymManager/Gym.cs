using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GymManager
{
    public class Gym
    {
        private string _name;
        private List<Membership> _membership;

        public string Name { get { return _name; } set { _name = value; } }
        public List<Membership> Membership { get { return _membership; } }

        public Gym(string name)
        {
            _name = name;
            _membership = new List<Membership> { };
        }

        public void AddMembership(Membership membership)
        {
            _membership.Add(membership);
        }

        public int TotalIncome()
        {
            int total = 0;

            foreach (Membership membership in _membership)
            {
                total += membership.MonthlyPrice;
            }
            return total;
        }

        public Member MostActive()
        {
            Member mostActive = _membership[0].Owner;

            foreach (Membership membership in _membership)
            {
                if (membership.Owner.Visits > mostActive.Visits)
                {
                    mostActive = membership.Owner;
                }
            }
            return mostActive;
        }

        public Membership BestValue()
        {
            Membership best = _membership[0];

            foreach (Membership membership in _membership)
            {
                if (membership.MonthlyPrice < best.MonthlyPrice)
                {
                    best = membership;
                }
            }
            return best;
        }
    }
}
