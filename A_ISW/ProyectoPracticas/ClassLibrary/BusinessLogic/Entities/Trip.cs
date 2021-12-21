using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Trip
    {
        public Trip()
        {
            Crates = new List<Crate>();
        }

        public Trip(Truck camion)
        {
            this.Truck = camion;
            Crates = new List<Crate>();
            
        }

        public double getCarriedWeight()
        {
            //Devuelve el tareweight que es el peso que lleva el camion.
            return Truck.TareWeight;
        }

        public void añadirCaja(Crate caja) {
            Crates.Add(caja);
        }
    }
        
}
