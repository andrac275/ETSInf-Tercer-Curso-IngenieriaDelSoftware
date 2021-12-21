using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Crate{
        public Crate() { 
            
        }

        public Crate(Product product, double weightInParcel, Contract contract, 
          Group group, Trip trip){
            this.Product = product;
            this.WeightInParcel = weightInParcel;
            this.Group = group;
            this.Contract = contract;
            this.Trip = trip;

        }

        public double getLoss() {
            return (double)(WeightInParcel - WeightInCoop);
        }
    }
}
