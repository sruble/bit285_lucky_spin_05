using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin.Models
{
    public class Repository
    {

        private  List<Spin> spins = new List<Spin>();

        public IEnumerable<Spin> Luck
            {
            get
            {
                return spins;
            }
            }

        public void AddSpins(Spin s)
        {          
             spins.Add(s);

        }
    }
}
