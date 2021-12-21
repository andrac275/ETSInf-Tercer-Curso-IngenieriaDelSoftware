using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Parcel
    {
        public Parcel()
        {
            this.Groups = new List<Group>();     
        }

        public Parcel(String CadastralReference, String Name, Product Product, double Size, Person Owner) : this()
        {
            this.CadastralReference = CadastralReference;
            this.Name = Name;
            this.Owner = Owner;
            this.Product = Product;
            this.Size = Size;
        }

        /*Devuelve el ultimo grupo de una parcela*/
        public Group LastGroup()
        {
            return Groups.LastOrDefault<Group>();
        }

        /*Devuelve todos los grupos asignados a una parcela*/
        public ICollection<Group> GetAllGroupsOfaParcel()
        {
            return this.Groups;
        }
    }
}
