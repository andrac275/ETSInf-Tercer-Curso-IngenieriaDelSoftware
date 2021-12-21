using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Group
    {
        public Group() {
            //Coleccions
            Members = new List<Contract>();
            Crates = new List<Crate>();
        }

        public Group(DateTime date, Parcel parcel) {
            this.Parcel = parcel;
            this.Date = date;

            //Coleccions
            Members = new List<Contract>();
            Crates = new List<Crate>();
        }

        /*Añade un miembro a la lista de miembros del contrato*/
        public void AddMember(Contract contrato)
        {
            foreach(Contract c in Members)
            {
                if (c.Equals(contrato)) throw new Exception("Person is already on the group.");
                
            }

            Members.Add(contrato);

        }

        /*Devuelve todos los miembros de un grupo*/
        public ICollection<Contract> GetAllMembersOfaGroup()
        {
            return this.Members;
        }
    }
}
