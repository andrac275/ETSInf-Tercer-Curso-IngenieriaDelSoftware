using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Trip
    {

        //public double carriedWeight
        //{
        //    get;
        //    set;
        //}

        public DateTime? CoopArrival
        {

            get;
            set;
        }

        
        public int Id
        {
            get;
            set;
        }

        public DateTime? ParcelExit
        {

            get;
            set;
        }

        public DateTime? UnloadTime
        {

            get;
            set;
        }

        public virtual Truck Truck
        {
            get;
            set;

        }
        
        public virtual ICollection<Crate> Crates {
            get;
            set;
        }

    }
}
