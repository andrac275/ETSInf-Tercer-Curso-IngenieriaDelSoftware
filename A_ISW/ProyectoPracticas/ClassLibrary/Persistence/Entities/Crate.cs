using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Crate
    {
        //public double? Loss
        //{
        //    get;
        //    set;
        //}

        
        public int Id
        {
            get;
            set;
        }

        public Product Product
        {
            get;
            set;
        }

        public double? WeightInCoop
        {
            get;
            set;
        }

        public double WeightInParcel
        {
            get;
            set;
        }

        
        public virtual Group Group
        {
            get;
            set;
        }

        
        public virtual Contract Contract
        {
            get;
            set;
        }

        public virtual Trip Trip
        {
            get;
            set;
        }

    }
}
