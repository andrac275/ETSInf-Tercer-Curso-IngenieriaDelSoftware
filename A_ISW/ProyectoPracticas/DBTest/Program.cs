using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TarongISW.Entities;
using TarongISW.Persistence;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EntityFrameworkDAL dal = new EntityFrameworkDAL(new TarongISWDbContext("Base de dades Taronges"));

                new Program(dal);


            }
            catch (Exception e)
            {
                printError(e);
                Console.WriteLine("Press any key.");
                Console.ReadLine();
            }

        }

        public Program(IDAL dal)
        {
            createSampleDB(dal);
            Console.WriteLine("\n\n\n");
            displayData(dal);
        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }

        private void createSampleDB(IDAL dal)
        {
            // Remove all data from DB
            dal.RemoveAllData();

            Console.WriteLine("Creando los datos y almacenándolos en la BD.");
            Person p1 = new Person("12345678Z", "Juan Abelló");
            dal.Insert<Person>(p1);
            dal.Commit();

            Parcel parcel = new Parcel("1234567AB9999C0001DE", "El Lobillo, Alhambra (Ciudad Real)", Product.Kiwi, 10000, p1);
            dal.Insert<Parcel>(parcel);
            p1.Parcels.Add(parcel);
            dal.Commit();

            // Populate here the rest of the database with data
            DateTime d1 = new DateTime(2020, 11,02); //Any, mes, dia
            Contract c1 = new Contract("1234",d1,"numeroSSN",p1);
            dal.Insert<Contract>(c1);
            p1.Contracts.Add(c1);
            dal.Commit();

            Permanent pm1 = new Permanent("1234",d1,"numeroSSN",p1,500.0);
            dal.Insert<Permanent>(pm1);
            dal.Commit();

            Temporary tem1 = new Temporary("5678", d1, "numeroSSN232", p1);
            dal.Insert<Temporary>(tem1);
            dal.Commit();

            Group g1 = new Group(d1,parcel);
            g1.Members.Add(c1);
            dal.Insert<Group>(g1);
            dal.Commit();

            //Preguntar
            Product prod1 = new Product();
            //dal.Insert<Product>(prod1);
            //dal.Commit();

            Truck truck1 = new Truck("5612", 500.0, 100.0);
            dal.Insert<Truck>(truck1);
            dal.Commit();

            Trip trp1 = new Trip(truck1);
            truck1.Trips.Add(trp1);
            dal.Insert<Trip>(trp1);
            dal.Commit();

            Crate cr1 = new Crate(prod1, 300.0, c1,g1,trp1);
            g1.Crates.Add(cr1);
            trp1.Crates.Add(cr1);            
            dal.Insert<Crate>(cr1);
            dal.Commit();
             
        }

        private void displayData(IDAL dal)
        {

            Console.WriteLine("Accediendo a los datos almacenados.");

            Console.WriteLine("\nPeople");
            foreach (Person p in dal.GetAll<Person>())
            {
                Console.WriteLine("   " + p.Name + ", " + p.Id);
            }

            Console.WriteLine("\nParcels");
            foreach (Parcel parcel in dal.GetAll<Parcel>())
            {
                Console.WriteLine("   " + parcel.Name + ", " + parcel.Owner.Name);
            }

            // Display here the information stored in the rest of the database tables

        }
    }
}
