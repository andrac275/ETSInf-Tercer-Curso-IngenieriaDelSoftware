using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Truck
    {
        public Truck()
        {
            Trips = new List<Trip>();
        }

        public Truck(string Id, double MaximumAuthorisedMass, double TareWeight)
        {
            this.Id = Id;
            this.MaximumAuthorisedMass = MaximumAuthorisedMass;
            this.TareWeight = TareWeight;
            Trips = new List<Trip>();

        }

        public double getMaximunWeight() {
            return MaximumAuthorisedMass - TareWeight;
        }

        /*Añade un viaje a un camión*/
        public void AddTrip(Trip viaje) {
            Trips.Add(viaje);
        }

        /*Devuelve el último viaje de un camión*/
        public Trip LastTrip()
        {
            return Trips.LastOrDefault<Trip>();
        }

        /*Devuelve un listado de viajes comprendido entre dos fechas.*/
        public List<Trip> TripsByDate(DateTime initialDate, DateTime finalDate)
        {
            List<Trip> viajes= new List<Trip>();
            foreach (Trip viaje in Trips)
                {
                    //Si la fecha del viaje esta entre la fecha inicio y la fecha fin, la añade a la lista
                    //ANDREU: Preguntar que fecha tener en cuenta.
                    if ((initialDate < viaje.ParcelExit) && (viaje.ParcelExit < finalDate)) { 
                        viajes.Add(viaje);
                    }                    
                    
                }
            return viajes;
        }
    }
}
