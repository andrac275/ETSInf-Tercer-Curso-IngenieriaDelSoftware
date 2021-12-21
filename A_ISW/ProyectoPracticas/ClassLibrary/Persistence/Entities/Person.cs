using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Person
    {
        [Key]
        public String Id
        {
            get;
            set;
        }
        public String Name
        {
            get;
            set;
        }
        public virtual ICollection<Parcel> Parcels
        {
            get;
            set;
        }
 
        public virtual ICollection<Contract> Contracts
        {
            get;
            set;
        }
    }
}
