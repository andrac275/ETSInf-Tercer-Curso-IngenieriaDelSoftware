using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Person
    {
        public Person()
        {
            this.Contracts = new List<Contract>();
            this.Parcels = new List<Parcel>();
        }

        public Person(String Id, String name) : this()
        {
           this.Id = Id;
           this.Name = name; 
        }

        ///*Devuelve el contrato actual de una persona.*/
        //public Contract LastActiveContract()
        //{
        //    return Contracts.LastOrDefault<Contract>();
        //}

        /*Devuelve el contrato activo (si lo hay) de una persona entre varias posibilidades:
            * -Devuelve null si no hay contratos.
            * -Devuelve null si el contrato es temporal y la fecha de finalización ya ha pasado.
            * -Devuelve un contrato si es temporal y la fecha actual esta comprendia entre el inicio del contrato y la fecha fin.
            * -Devuelve un contrato si éste es permanente.
            * -Devuelve un contrato si el contrato es temporal, ya ha pasado del inicio del contrato y no tiene fecha fin.
            */
        public Contract LastActiveContract()
        {
            //Devuelve null si no hay contratos
            
            if (Contracts.Count == 0)
            {
                return null;
            }
            
            //Obtener el último contrato.
            Contract contrato = Contracts.LastOrDefault<Contract>();

            //Devuelve null si el contrato es temporal y la fecha de finalización ya ha pasado.
            if (contrato is Temporary && (contrato as Temporary).FinalDate < DateTime.Now)
            {
                return null;
            }

            //Devuelve un contrato si es temporal y la fecha actual esta comprendia entre el inicio del contrato y la fecha fin.
            if (contrato is Temporary && ((DateTime.Now < (contrato as Temporary).FinalDate)))
            {
                return contrato;
            }

            //Comprobar si el contrato es permanente.
            if (contrato is Permanent)
            {
                //La persona está fija por tanto éste es su último contrato. Se asume que no puede ser fijo y temporal a la vez.                
                return contrato;
            }

            //Devuelve un contrato si el contrato es temporal, ya ha pasado del inicio del contrato y no tiene fecha fin.
            if (contrato is Temporary && contrato.InitialDate < DateTime.Now && ((contrato as Temporary).FinalDate == null))
            {
                return contrato;
            }

            return contrato;
        }

        /*Éste método devuelve si una persona está en más de un grupo. Devuelve false si no lo está y devuelve una excepción en caso contrario.*/
        public bool checkMoreThanAGroup()
        {
            foreach (Contract con in Contracts) {
                if (con.Groups.Count == 1) { throw new Exception("La persona no se la puede añadir a otro grupo si ya está en uno."); }
            }            
            return false;
        }
    }
}
