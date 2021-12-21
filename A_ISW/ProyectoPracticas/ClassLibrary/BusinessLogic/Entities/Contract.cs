using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Contract

    {


        public Contract()
        {

            //colecciones
            Crates = new List<Crate>();
            Groups = new List<Group>(); 
        }

        public Contract (string bankAccount, DateTime initialDate, string SSN, Person hired)

        {

            this.BankAccount = bankAccount;
            this.InitialDate = initialDate;
            this.SSN = SSN;

            Hired = hired;


            Crates = new List<Crate>();
            Groups = new List<Group>(); 


        }
    }
}
