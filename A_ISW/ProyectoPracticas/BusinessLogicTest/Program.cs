using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Validation;
using System.IO.Ports;

using TarongISW.Entities;
using TarongISW.Persistence;
using TarongISW.Services;


namespace BusinessLogicTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ITarongISWService service = new TarongISWService(new EntityFrameworkDAL(new TarongISWDbContext("Base de dades Taronges")));
                
                new Program(service);
            }
            catch (Exception e)
            {
                printError(e);
                Console.WriteLine("Press any key.");
                Console.ReadLine();
            }


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


        private ITarongISWService service;

        Program(ITarongISWService service)
        {
            this.service = service;
            //service.RemoveAllData();
            DBInitialization();

            NewPersonTest();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddPermanentContractsTest();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddTemporaryContractsTest();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddGroupsTest();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddTripToTruckTest();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            AddCratesToTrip();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            MoreGroupsTripsCrates();

            QueryTravelsMadeByTruckTest();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        void DBInitialization()
        {
            service.RemoveAllData();

            Console.WriteLine("INITIALIZATING DB...");

            Person p1;
            p1 = new Person("12345678Z", "Juan Abelló"); 
            service.AddPerson(p1);

            Parcel parcel = new Parcel("1234567AB9999C0001DE", "El Lobillo, Alhambra (Ciudad Real)", Product.Orange, 10000, p1);
            service.AddParcel(parcel);

            p1 = new Person("23456789D", "José María Aristrian"); 
            service.AddPerson(p1);

            parcel = new Parcel("7654321AB9999C0001DE", "Valdepuercas, Alia (Cáceres)", Product.Avocado, 18000, p1);
            service.AddParcel(parcel);

            p1 = new Person("34567890V", "Junta de Andalucía"); 
            service.AddPerson(p1);

            parcel = new Parcel("7654321AB1111C0001DE", "La Almoraima (Cadiz)", Product.Kiwi, 16000, p1);
            service.AddParcel(parcel);

            Truck t = new Truck("1234AAA", 3200, 3000);
            service.AddTruck(t);
           
            t = new Truck("1234BJP", 3500, 2660);
            service.AddTruck(t);
                       
            t = new Truck("1234LKP", 18000, 3660);
            service.AddTruck(t);

            service.Commit();

            Console.WriteLine("DATA CREATED.");
        }

        
        void NewPersonTest()
        {
            Console.WriteLine();
            Console.WriteLine("TEST CASE 2: ADDING NEW PERSON...");
            String dni_nuevo;
            String name_nuevo;

            //Andreu: Metodo para añadir la persona a la base de datos comprobando si existe antes.
            void AddPersonMethod(String dni, String name){
                if (!service.CheckPersonId(dni))
                {
                    Console.WriteLine("Person does not, exist, creating...");
                    Console.WriteLine("Person added: " + dni + " " + name);
                    service.NewPerson(dni, name);
                }
                else throw new Exception("Person with DNI: " + dni + " already exists, please try again.");                    
            }

            try
            {
                //Persona que no existe con anterioridad
                dni_nuevo = "87654321Z";
                name_nuevo = "Armando Guerra";
                AddPersonMethod(dni_nuevo, name_nuevo);
                
            }
            catch (Exception e)
            {
                printError(e);
            }

            Console.WriteLine("---");

            try { 
                //Persona que existe. Vamos a añadir de nuevo a Benito
                Console.WriteLine("Test: Add an existing person.");
                dni_nuevo = "87654321Z";
                name_nuevo = "Armando Guerra";
                AddPersonMethod(dni_nuevo, name_nuevo);

            }
            catch (Exception e)
            {
                printError(e);
            }
           
            Console.WriteLine("-----------------------------");
        }

        void AddPermanentContractsTest() {
            Console.WriteLine();
            Console.WriteLine("TEST CASE 1a: ADDING PERMANENT CONTRACTS...");
                       
            String dni;
            String bankAccount;
            DateTime initialDate;
            String SSN;
            String tempName;
            double salary;
            
            //Andreu: Metodo para introducir en la BD una persona que no existe. Se ha comprobado con anterioridad que no existe.
            void AddPersonMethod(String newDni, String newName)
            {                    
                Console.WriteLine("Person does not, exist, creating...");
                Console.WriteLine("Person added: " + newDni + " " + newName);
                service.NewPerson(dni, newName);                    
            }

            try
            {
                //Intentar contratar a alguien que no existe en la BD            
                dni = "76543210S";
                bankAccount = "ES9812340100951757864321";
                initialDate = DateTime.Today.AddYears(-6);
                SSN = "SSN0033111144";
                salary = 14000.00;

                if (!service.CheckPersonId(dni)) //Si no existe la persona...
                {
                    tempName = "Andrés Trozado"; //Se introduce el nombre de la persona manualmente
                    AddPersonMethod(dni, tempName);

                    Console.WriteLine("Creating new Permanent contract for: " + dni);
                    service.CreateNewPermanent(dni, bankAccount, initialDate, SSN, salary);
                    Console.WriteLine("Permanent contract created");
                }
                
                else //Si existe la persona...
                {
                    Console.WriteLine("Creating new Permanent contract for: " + dni);
                    service.CreateNewPermanent(dni, bankAccount, initialDate, SSN, salary);
                }
            }
            catch (Exception e)
            {
                printError(e);
            }

            Console.WriteLine("---");
            try { 
                //Intentar contratar a alguien que no existe en la BD
            
                dni = "65432109F";
                bankAccount = "ES9812340100951757864321";
                initialDate = DateTime.Today.AddYears(-2);
                SSN = "SSN4433221100";
                salary = 18000.00;

                if (!service.CheckPersonId(dni)) //Si no existe la persona...
                {
                    tempName = "Helen Chufe"; //Se introduce el nombre de la persona manualmente
                    AddPersonMethod(dni, tempName);

                    Console.WriteLine("Creating new Permanent contract for: " + dni);
                    service.CreateNewPermanent(dni, bankAccount, initialDate, SSN, salary);
                    Console.WriteLine("Permanent contract created");
                }
                else //Si existe la persona...
                {
                    Console.WriteLine("Creating new Permanent contract for: " + dni);
                    service.CreateNewPermanent(dni, bankAccount, initialDate, SSN, salary);
                }
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("---");
            try
            {
                // Ya está contratada
            
                Console.WriteLine("Añadiendo a alguien ya contratado");
                dni = "76543210S";
                bankAccount = "ES9812340100951757864321";
                initialDate = DateTime.Today.AddYears(-1);
                SSN = "SSN0033111144";
                salary = 17000.00;

                if (!service.CheckPersonId(dni)) //Si no existe la persona...
                {
                    tempName = "Andrés Trozado"; //Se introduce el nombre de la persona manualmente
                    AddPersonMethod(dni, tempName);

                    Console.WriteLine("Creating new Permanent contract for: " + dni);
                    service.CreateNewPermanent(dni, bankAccount, initialDate, SSN, salary);
                    Console.WriteLine("Permanent contract created");
                }
                else //Si existe la persona...
                {
                    Console.WriteLine("Creating new Permanent contract for: " + dni);
                    service.CreateNewPermanent(dni, bankAccount, initialDate, SSN, salary);
                }
            
                Console.WriteLine("---");
            }
            catch (Exception e)
            {
               printError(e);
            }

            Console.WriteLine("---");
            Console.WriteLine("Showing all Permanent contracts information: ");
            foreach (Contract c in service.GetAllContracts())
            {
                Console.WriteLine("Contract: " + c.Id + ", Id: " + c.Hired.Id + ", Name: " + c.Hired.Name);
            }
            
            Console.WriteLine("-----------------------------");
        }

        void AddTemporaryContractsTest()
        {
            Console.WriteLine();
             Console.WriteLine("TEST CASE 1b: ADDING TEMPORARY CONTRACTS...");

            String dni;
            String bankAccount;
            DateTime initialDate;
            DateTime? endDate;
            String SSN;
            String tempName;
            
            //Andreu: Metodo para introducir en la BD una persona que no existe. Se ha comprobado con anterioridad que no existe.
            void AddPersonMethod(String newDni, String newName)
            {
                Console.WriteLine("Person does not, exist, creating...");
                Console.WriteLine("Person added: " + newDni + " " + newName);
                service.NewPerson(dni, newName);
            }

            try { 
                //Intentar contratar a alguien que no existe en la BD
            
                dni = "87654321X";
                bankAccount = "ES8912340100951757864321";
                initialDate = DateTime.Today;
                endDate = DateTime.Today.AddDays(10);
                SSN = "SSN0011223344";

                if (!service.CheckPersonId(dni)) //Si no existe la persona...
                {
                    tempName = "Juan Sin Nombre"; //Se introduce el nombre de la persona manualmente
                    AddPersonMethod(dni, tempName);

                    Console.WriteLine("Creating new Temporary contract for: " + dni + " WITH final date");
                    service.CreateNewTemporary(dni, bankAccount, initialDate, endDate, SSN);
                    Console.WriteLine("Permanent contract created");
                }
                else //Si existe la persona...
                {
                    Console.WriteLine("Creating new Temporary contract for: " + dni);
                    service.CreateNewTemporary(dni, bankAccount, initialDate, endDate, SSN);
                }
            }
            catch (Exception e)
            {
                printError(e);
            }

            Console.WriteLine("---");
            try { 
                //Intentar contratar a alguien que no existe en la BD            
            
                dni = "98765432M";
                bankAccount = "ES9812340100951757864321";
                initialDate = DateTime.Today.AddDays(-20);
                SSN = "SSN0112233354";

                if (!service.CheckPersonId(dni)) //Si no existe la persona...
                {
                    tempName = "Aitor Tilla"; //Se introduce el nombre de la persona manualmente
                    AddPersonMethod(dni, tempName);

                    Console.WriteLine("Creating new Temporary contract for: " + dni + " WITHOUT final date");
                    service.CreateNewTemporary(dni, bankAccount, initialDate, SSN);
                    Console.WriteLine("Permanent contract created");
                }
                else //Si existe la persona...
                {
                    Console.WriteLine("Creating new Temporary contract for: " + dni);
                    service.CreateNewTemporary(dni, bankAccount, initialDate, SSN);
                }
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("---");
            try { 
                // Si está contratado no se puede volver a contratar
            
                Console.WriteLine("Añadiendo a alguien ya contratado 1");
                dni = "98765432M";
                bankAccount = "ES8912340100951757864321";
                initialDate = DateTime.Today;
                endDate = DateTime.Today.AddDays(10);
                SSN = "SSN0112233354";

                if (!service.CheckPersonId(dni)) //Si no existe la persona...
                {
                    tempName = "Aitor Tilla"; //Se introduce el nombre de la persona manualmente
                    AddPersonMethod(dni, tempName);

                    Console.WriteLine("Creating new Temporary contract for: " + dni + " WITH final date");
                    service.CreateNewTemporary(dni, bankAccount, initialDate, endDate, SSN);
                    Console.WriteLine("Permanent contract created");
                }
                else //Si existe la persona...
                {
                    Console.WriteLine("Creating new Temporary contract for: " + dni);
                    service.CreateNewTemporary(dni, bankAccount, initialDate, endDate, SSN);

                }
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("---");

            try { 
                // Si está contratado no se puede volver a contratar
            
                Console.WriteLine("Añadiendo a alguien ya contratado 2");
                dni = "87654321X";
                bankAccount = "ES9812340100951757864321";
                initialDate = DateTime.Today;
                endDate = DateTime.Today.AddDays(10);
                SSN = "SSN0011223344";

                if (!service.CheckPersonId(dni)) //Si no existe la persona...
                {
                    tempName = "Juan Sin Nombre"; //Se introduce el nombre de la persona manualmente
                    AddPersonMethod(dni, tempName);

                    Console.WriteLine("Creating new Temporary contract for: " + dni + " WITH final date");
                    service.CreateNewTemporary(dni, bankAccount, initialDate, endDate, SSN);
                    Console.WriteLine("Permanent contract created");
                }
                else //Si existe la persona...
                {
                    Console.WriteLine("Creating new Temporary contract for: " + dni);
                    service.CreateNewTemporary(dni, bankAccount, initialDate, endDate, SSN);
                }
            }
            catch (Exception e)
            {
                printError(e);
            }

            Console.WriteLine("---");

            try { 
                // Si está contratado no se puede volver a contratar
            
                Console.WriteLine("Añadiendo a alguien ya contratado 3");
                dni = "76543210S";
                bankAccount = "ES9812340100951757864321";
                initialDate = DateTime.Today;
                endDate = DateTime.Today.AddDays(10);
                SSN = "SSN0033111144";

                if (!service.CheckPersonId(dni)) //Si no existe la persona...
                {
                    tempName = "Andrés Trozado"; //Se introduce el nombre de la persona manualmente
                    AddPersonMethod(dni, tempName);

                    Console.WriteLine("Creating new Temporary contract for: " + dni + " WITH final date");
                    service.CreateNewTemporary(dni, bankAccount, initialDate, endDate, SSN);
                    Console.WriteLine("Permanent contract created");
                }
                else //Si existe la persona...
                {
                    Console.WriteLine("Creating new Permanent contract for: " + dni);
                    service.CreateNewTemporary(dni, bankAccount, initialDate, endDate, SSN);
                }
            
                Console.WriteLine("---");
            }
            catch (Exception e)
            {
                printError(e);
            }

            Console.WriteLine("---");
            Console.WriteLine("Showing all Temporary contracts information: ");
            foreach (Contract c in service.GetAllContracts())
            {
                if (c is Temporary)
                    Console.WriteLine("Contract: " + c.Id + ", Id: " + c.Hired.Id + ", Name: " + c.Hired.Name +", InitialDate: " + c.InitialDate + ", FinalDate: " + (c as Temporary).FinalDate);
            }
            Console.WriteLine("-----------------------------");
        }

       void AddGroupsTest()
       {
            Console.WriteLine();
            Console.WriteLine("TEST CASE 3: ADDING GROUPS AND ASSIGN PEOPLE...");

            Group grupo;
            DateTime fecha;
            Parcel parcel;
            Person persona;
            Contract ultimoContrato;
            
            List<Contract> members= new List<Contract>();
            List<Contract> todosLosContratos = AllContracts();

            //Andreu: Metodo auxiliar para obtener todos los contratos
            List<Contract> AllContracts(){
                List<Contract> res = new List<Contract>();
                foreach (Contract con in service.GetAllContracts()){
                    res.Add(con);
                }
                return res;
            }

                       

            try
            {
                Console.WriteLine("Creating Group 1: On parcel 1234567AB9999C0001DE");
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                fecha = DateTime.Today;
                //Añadir a la lista 'members' los contratos que queremos añadir a la cuadrilla.
                    //members.Add(todosLosContratos.ElementAt<Contract>(0));  //Andres Trozado
                    members.Add(todosLosContratos.ElementAt<Contract>(1));  //Helen Chufe
                    //members.Add(todosLosContratos.ElementAt<Contract>(2));  //Juan Sin Nombre
                    //members.Add(todosLosContratos.ElementAt<Contract>(3));  //Aitor Tilla                    

                //Llamar al metodo de service pasando la parcela y la lista de miembros con la fecha.
                service.CreateNewGroup(parcel, members,fecha); 
                //Mostrar personas añadidas.
                    foreach (Contract c in members)
                    {
                        Console.WriteLine(c.Hired.Name + " added to parcel "+parcel.CadastralReference );
                    }
                Console.WriteLine("Group1 Created");
                
            }
            catch (Exception e)
            {
                printError(e);
            }

            //Borrar contenido de la lista auxiliar 'members' para futuras pruebas.
            members.Clear();

            Console.WriteLine("---");
            try
            {
                Console.WriteLine("Add person to existing group on parcel 1234567AB9999C0001DE");
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                grupo = parcel.LastGroup();

                persona = service.FindPersonById("76543210S");  //Andres Trozado
                //Obtener el ultimo contrato de la persona
                ultimoContrato = persona.LastActiveContract();

                //Añadir una persona al grupo. Devuelve error si ya esta en el grupo.
                grupo.AddMember(ultimoContrato);
                service.Commit();
                Console.WriteLine("Person added to parcel 1234567AB9999C0001DE");
            }
            catch (Exception e)
            {
                printError(e);
            }

            
            Console.WriteLine("---");
            try
            {
                Console.WriteLine("Add person to existing group on parcel 1234567AB9999C0001DE");
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                grupo = parcel.LastGroup();

                persona = service.FindPersonById("98765432M");  //Aitor Tilla
                //Obtener el ultimo contrato de la persona
                ultimoContrato = persona.LastActiveContract();

                //Añadir una persona al grupo. Devuelve error si ya esta en el grupo.
                grupo.AddMember(ultimoContrato);
                service.Commit();
                Console.WriteLine("Person added to parcel 1234567AB9999C0001DE");

            }
            catch (Exception e)
            {
                printError(e);
            }

            Console.WriteLine("---");
            // dos grupos el mismo día en la misma parcela
            try
            {
                Console.WriteLine("Test: two groups, same parcel, same day.");
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                fecha = DateTime.Today;
                //Añadir a la lista 'members' los contratos que queremos añadir a la cuadrilla.
                //members.Add(todosLosContratos.ElementAt<Contract>(0));  //Andres Trozado
                //members.Add(todosLosContratos.ElementAt<Contract>(1));  //Helen Chufe
                members.Add(todosLosContratos.ElementAt<Contract>(2));  //Juan Sin Nombre
                //members.Add(todosLosContratos.ElementAt<Contract>(3));  //Aitor Tilla                    

                //Llamar al metodo de service pasando la parcela y la lista de miembros con la fecha.
                service.CreateNewGroup(parcel, members, fecha);
                //Mostrar personas añadidas.
                foreach (Contract c in members)
                {
                    Console.WriteLine(c.Hired.Name + " added to parcel " + parcel.CadastralReference);
                }
                Console.WriteLine("Group Created");
                //Borrar el contenido de members por si en el programa se vuelve a utilizar 'service.CreateNewGroup(parcel, members,fecha);'
                //esté la lista limpia.
                //members.Clear();

            }
            catch (Exception e)
            {
                printError(e);
            }

            //Borrar contenido de la lista auxiliar 'members' para futuras pruebas.
            members.Clear();
           
            Console.WriteLine("---");
            // Dos veces la misma persona en un grupo
            try
            {
                Console.WriteLine("Test: duplicated person in the same group");
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                grupo = parcel.LastGroup();

                persona = service.FindPersonById("98765432M");  //Aitor Tilla
                //Obtener el ultimo contrato de la persona
                ultimoContrato = persona.LastActiveContract();

                //Añadir una persona al grupo. Devuelve error si ya esta en el grupo.
                grupo.AddMember(ultimoContrato);
                service.Commit();
                Console.WriteLine("Person added to parcel 1234567AB9999C0001DE");

            }
            catch (Exception e)
            {
                printError(e);
            }


            Console.WriteLine("---");
            // La misma persona en dos cuadrillas distintas el mismo día
            try
            {
                Console.WriteLine("Test: Same person on two different groups the same day.");
                parcel = service.FindParcelById("7654321AB9999C0001DE");
                fecha = DateTime.Today;
                //Añadir a la lista 'members' los contratos que queremos añadir a la cuadrilla.
                //members.Add(todosLosContratos.ElementAt<Contract>(0));  //Andres Trozado
                members.Add(todosLosContratos.ElementAt<Contract>(1));  //Helen Chufe
                //members.Add(todosLosContratos.ElementAt<Contract>(2));  //Juan Sin Nombre
                //members.Add(todosLosContratos.ElementAt<Contract>(3));  //Aitor Tilla                    

                //Llamar al metodo de service pasando la parcela y la lista de miembros con la fecha.
                service.CreateNewGroup(parcel, members, fecha);
                //Mostrar personas añadidas.
                foreach (Contract c in members)
                {
                    Console.WriteLine(c.Hired.Name + " added to parcel " + parcel.CadastralReference);
                }
                Console.WriteLine("Group Created");

            }
            catch (Exception e)
            {
                printError(e);
            }
            
            //Borrar contenido de la lista auxiliar 'members' para futuras pruebas.
            members.Clear();
            Console.WriteLine("---");
            
            try
            {
                Console.WriteLine("Creating Group 2: On parcel 7654321AB9999C0001DE");
                parcel = service.FindParcelById("7654321AB9999C0001DE");
                fecha = DateTime.Today;
                //Añadir a la lista 'members' los contratos que queremos añadir a la cuadrilla.
                //members.Add(todosLosContratos.ElementAt<Contract>(0));  //Andres Trozado
                //members.Add(todosLosContratos.ElementAt<Contract>(1));  //Helen Chufe
                members.Add(todosLosContratos.ElementAt<Contract>(2));  //Juan Sin Nombre
                //members.Add(todosLosContratos.ElementAt<Contract>(3));  //Aitor Tilla                    

                //Llamar al metodo de service pasando la parcela y la lista de miembros con la fecha.
                service.CreateNewGroup(parcel, members, fecha);
                //Mostrar personas añadidas.
                foreach (Contract c in members)
                {
                    Console.WriteLine(c.Hired.Name + " added to parcel " + parcel.CadastralReference);
                }
                Console.WriteLine("Group2 Created");
            }
            catch (Exception e)
            {
                printError(e);
            }

            //Borrar contenido de la lista auxiliar 'members' para futuras pruebas.
            members.Clear();

            Console.WriteLine("---");
            // Una persona que ya esta en un grupo no puede añadirse a otro
            try
            {
                Console.WriteLine("Test: A person in a group can't be added to another group.");
                parcel = service.FindParcelById("7654321AB9999C0001DE");
                grupo = parcel.LastGroup();

                persona = service.FindPersonById("98765432M");  //Aitor Tilla
                //Obtener el ultimo contrato de la persona
                ultimoContrato = persona.LastActiveContract();

                //Añadir una persona al grupo. Devuelve error si esta en mas de un grupo                
                if (!persona.checkMoreThanAGroup()) { grupo.AddMember(ultimoContrato); }
                service.Commit();
                Console.WriteLine("Person added to parcel 7654321AB9999C0001DE");

            }
            catch (Exception e)
            {
                printError(e);
            }

            Console.WriteLine("---");
            Console.WriteLine("Showing all Groups and members information: ");

            // Mostrar la información almacenada de los grupos y sus miembros
            foreach (Group group in service.GetAllGroups())
            {
                Console.WriteLine("Group: " + group.Id + ", Date: " + group.Date + ", Parcel: " + group.Parcel.CadastralReference + ", Parcel.Name: " + group.Parcel.Name);
                foreach(Contract contract in group.Members)
                {
                    Console.WriteLine("   Member: " + contract.Hired.Name + ", DNI: " + contract.Hired.Id);
                }
            }
            Console.WriteLine("-----------------------------");
        }

            
        void AddTripToTruckTest()
        {
            Console.WriteLine();
            Console.WriteLine("TEST CASE 4: ADD TRIP TO TRUCK....");

            //Metodo para añadir el camion a la base de datos comprobando si existe antes.
            void AddTripToTruckMethod(String mat, DateTime llegCop, DateTime salParc, DateTime horaDesc)
            {
                if (service.CheckTruckId(mat))
                {
                    Console.WriteLine("Added trip to Truck: " + mat);
                    service.AssignTripToTruck(mat, llegCop, salParc, horaDesc);
                }
                else throw new Exception("Truck with plate: " + mat + " doesn't exist, please introduce an existing truck plate number.");
                
            }

            // Fromato del Datetime(YYYY,MM, DD,Hour,Min,Sec,Cent)
            DateTime llegCoperativa = DateTime.Today.AddDays(1);
            DateTime salirParcela = DateTime.Today.AddDays(-2);
            DateTime horaDescarga = DateTime.Today.AddDays(1).AddHours(15);
            String matricula;
            
            try{
                //Añadir viaje a un camión que si que existe.
                matricula= "1234BJP";
                AddTripToTruckMethod(matricula, llegCoperativa, salirParcela, horaDescarga);
            }
            catch (Exception e)
            {
                printError(e);
            }
            try { 
                matricula = "1234AAA";
                AddTripToTruckMethod(matricula, llegCoperativa, salirParcela, horaDescarga);
            }
            catch (Exception e)
            {
                printError(e);
            }

            Console.WriteLine("---");
            try { 
                Console.WriteLine("Test: Add a non existing truck.");
                matricula = "FakePlateNumber19512";
                AddTripToTruckMethod(matricula, llegCoperativa, salirParcela, horaDescarga);
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("---");

            // Mostrar la información de los viajes creados
            Console.WriteLine("Showing all the trips information: ");
            foreach (Trip tr in service.GetAllTrips())
            {
                Console.WriteLine("Trip: " + tr.Id + ", Truck: " + tr.Truck.Id + ", LlegadaCoop: " +tr.CoopArrival +", Salida Parcela: "+ tr.ParcelExit +", Hora Descarga: " + tr.UnloadTime);
                foreach (Crate cr in tr.Crates)
                {
                    Console.WriteLine("   Crate: " + cr.Id + ", Product: " + cr.Product + ", WeightInParcel: " + cr.WeightInParcel + ", WeightInCoop: " + cr.WeightInCoop);
                }
            }

            Console.WriteLine("-----------------------------");
        }

        void AddCratesToTrip()
        {
            Console.WriteLine();
            Console.WriteLine("TEST CASE 5: ADDING CRATES TO TRIP...");

            Trip trip;
            Crate c1, c2, c3;
            Parcel parcel;
            Contract contract;
            Group g;
            Person person;
            Truck truck;

            try
            {
                parcel = service.FindParcelById("7654321AB9999C0001DE");
                g = parcel.LastGroup();
                trip = service.FindTruckById("1234AAA").LastTrip();
                truck = service.FindTruckById("1234AAA");
                person = service.FindPersonById("87654321X");
                contract = service.FindPersonById("87654321X").LastActiveContract();
                
                c1 = new Crate(parcel.Product, 20, contract, g, trip);
                //AddCrateToTrip(catastro, dni, matriculaCamion, pesoCaja);
                service.AddCrateToTrip(parcel.CadastralReference, person.Id, truck.Id, c1.WeightInParcel);

                c2 = new Crate(parcel.Product, 30, contract, g, trip);
                //AddCrateToTrip(catastro, dni, matriculaCamion, pesoCaja);
                service.AddCrateToTrip(parcel.CadastralReference, person.Id, truck.Id, c2.WeightInParcel);

                c3 = new Crate(parcel.Product, 25.5, contract, g, trip);
                //AddCrateToTrip(catastro, dni, matriculaCamion, pesoCaja);
                service.AddCrateToTrip(parcel.CadastralReference, person.Id, truck.Id, c3.WeightInParcel);
                Console.WriteLine("Crates added to Truck: "+ truck.Id);
            }
            catch (Exception e)
            {
                printError(e);
            }

            Console.WriteLine("---");

            try
            {
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                g = parcel.LastGroup();
                trip = service.FindTruckById("1234BJP").LastTrip();
                truck = service.FindTruckById("1234BJP");
                person = service.FindPersonById("98765432M");
                contract = service.FindPersonById("98765432M").LastActiveContract();

                c1 = new Crate(parcel.Product, 50, contract, g, trip);
                //AddCrateToTrip(catastro, dni, matriculaCamion, pesoCaja);
                service.AddCrateToTrip(parcel.CadastralReference, person.Id, truck.Id, c1.WeightInParcel);

                c2 = new Crate(parcel.Product, 45, contract, g, trip);
                //AddCrateToTrip(catastro, dni, matriculaCamion, pesoCaja);
                service.AddCrateToTrip(parcel.CadastralReference, person.Id, truck.Id, c2.WeightInParcel);

                c3 = new Crate(parcel.Product, 35.5, contract, g, trip);
                //AddCrateToTrip(catastro, dni, matriculaCamion, pesoCaja);
                service.AddCrateToTrip(parcel.CadastralReference, person.Id, truck.Id, c3.WeightInParcel);
                Console.WriteLine("Crates added to Truck: " + truck.Id);

            }
            catch (Exception e)
            {
                printError(e);
            }

            Console.WriteLine("---");

            // Miembro que no pertenece al grupo
            try
            {
                Console.WriteLine("Test: Member doesn't belong to group.");
                parcel = service.FindParcelById("7654321AB9999C0001DE");
                g = parcel.LastGroup();
                trip = service.FindTruckById("1234BJP").LastTrip();
                truck = service.FindTruckById("1234BJP");
                person = service.FindPersonById("65432109F");
                contract = service.FindPersonById("65432109F").LastActiveContract();

                c1 = new Crate(parcel.Product, 50, contract, g, trip);
                //AddCrateToTrip(catastro, dni, matriculaCamion, pesoCaja);
                service.AddCrateToTrip(parcel.CadastralReference, person.Id, truck.Id, c1.WeightInParcel);
                Console.WriteLine("Crates added to Truck: " + truck.Id);

            }
            catch (Exception e)
            {
                printError(e);
            }

            Console.WriteLine("---");

            // Se añade una caja que excede el peso del camión
            try
            {
                Console.WriteLine("Test: Reach the maximum authorized mass.");
                parcel = service.FindParcelById("7654321AB9999C0001DE");
                g = parcel.LastGroup();
                trip = service.FindTruckById("1234AAA").LastTrip();
                truck = service.FindTruckById("1234AAA");
                person = service.FindPersonById("87654321X");
                contract = service.FindPersonById("87654321X").LastActiveContract();

                c1 = new Crate(parcel.Product, 125, contract, g, trip);
                //AddCrateToTrip(catastro, dni, matriculaCamion, pesoCaja);
                service.AddCrateToTrip(parcel.CadastralReference, person.Id, truck.Id, c1.WeightInParcel);
                                
            }
            catch (Exception e)
            {
                printError(e);
            }

            Console.WriteLine("---");

            // Mostrar la información de las cajas creadas
            Console.WriteLine("Showing the information of all the created crates: ");
            foreach (Crate cr in service.GetAllCrates())
                Console.WriteLine("Crate: " + cr.Id + ", Member:" + cr.Contract.Hired.Name + ", Weight: " + cr.WeightInParcel + ", Truck: " + cr.Trip.Truck.Id + ", Parcel: " + cr.Group.Parcel.Name);
            
            Console.WriteLine("-----------------------------");
        }

        
        void MoreGroupsTripsCrates()
        {
            Group grupo;
            DateTime fecha;
            Parcel parcel;
            Person persona;
            Trip trip;
            Truck truck;
            Contract ultimoContrato;
            List<Contract> members = new List<Contract>();
            List<Contract> todosLosContratos;
            

            //Andreu: Metodo auxiliar para obtener todos los contratos
            List<Contract> AllContracts()
            {
                List<Contract> res = new List<Contract>();
                foreach (Contract con in service.GetAllContracts())
                {
                    res.Add(con);
                }
                return res;
            }
            try
            {
                Console.WriteLine("TEST MORE GROUPS TRIPS CRATES");
                parcel = service.FindParcelById("1234567AB9999C0001DE");
                Person p = service.FindPersonById("87654321Z");
                service.CreateNewPermanent("87654321Z", "ES9812340100951757864321", DateTime.Today.AddYears(-10), "SSN87987897987897", 2000.0);
                //Conseguir todos los contratos del sistema, incluido el creado en la linea anterior
                todosLosContratos = AllContracts();

                fecha = DateTime.Today.AddDays(1);
                
                //Añadir a la lista 'members' los contratos que queremos añadir a la cuadrilla.
                //members.Add(todosLosContratos.ElementAt<Contract>(0));  //Andres Trozado
                //members.Add(todosLosContratos.ElementAt<Contract>(1));  //Helen Chufe
                //members.Add(todosLosContratos.ElementAt<Contract>(2));  //Juan Sin Nombre
                //members.Add(todosLosContratos.ElementAt<Contract>(3));  //Aitor Tilla
                members.Add(todosLosContratos.ElementAt<Contract>(4));  //Armando Guerra 

                //Llamar al metodo de service pasando la parcela y la lista de miembros con la fecha.
                service.CreateNewGroup(parcel, members, fecha);

                // Mostrar la información almacenada de los grupos y sus miembros
                foreach (Group group in service.GetAllGroups())
                {
                    Console.WriteLine("Group: " + group.Id + ", Date: " + group.Date + ", Parcel: " + group.Parcel.CadastralReference + ", Parcel.Name: " + group.Parcel.Name);
                    foreach (Contract contract in group.Members)
                    {
                        Console.WriteLine("   Member: " + contract.Hired.Name + ", DNI: " + contract.Hired.Id);
                    }
                }

                Truck t = service.FindTruckById("1234LKP");
                //AssignTripToTruck(matricula, llegCop, salParc, horaDesc);
                service.AssignTripToTruck("1234LKP", DateTime.Today.AddDays(2), DateTime.Today, DateTime.Today.AddDays(2).AddHours(5));
                                
                grupo = parcel.LastGroup();
                trip = service.FindTruckById("1234LKP").LastTrip();
                truck = service.FindTruckById("1234LKP");
                persona = service.FindPersonById("87654321Z");
                ultimoContrato = service.FindPersonById("87654321Z").LastActiveContract();

                Crate c1 = new Crate(parcel.Product, 20, ultimoContrato, grupo, trip);
                service.AddCrateToTrip(parcel.CadastralReference, persona.Id, truck.Id, c1.WeightInParcel);

                c1 = new Crate(parcel.Product, 20, ultimoContrato, grupo, trip);
                service.AddCrateToTrip(parcel.CadastralReference, persona.Id, truck.Id, c1.WeightInParcel);

                c1 = new Crate(parcel.Product, 21, ultimoContrato, grupo, trip);
                service.AddCrateToTrip(parcel.CadastralReference, persona.Id, truck.Id, c1.WeightInParcel);

                foreach (Crate cr in service.GetAllCrates())
                    Console.WriteLine("Crate: " + cr.Id + ", Member:" + cr.Contract.Hired.Name + ", Weight: " + cr.WeightInParcel + ", Truck: " + cr.Trip.Truck.Id + ", Parcel: " + cr.Group.Parcel.Name);

            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("-----------------------------");
        }

        void QueryTravelsMadeByTruckTest()
        {
            Console.WriteLine();
            Console.WriteLine("TEST CASE 6: QUERY TRIPS MADE BY TRUCK...");
            DateTime initialDate;
            DateTime finalDate;

            try
            {
                initialDate = DateTime.Today.AddDays(-10);
                finalDate = DateTime.Today.AddDays(10); 

                Truck truck = service.FindTruckById("1234BJP");                
                List<Trip> ltrips = service.ListTripsOfATruck(truck.Id,initialDate, finalDate);

                Console.WriteLine("Trips by truck " + truck.Id + ", Number of trips: " + ltrips.Count);

                Console.WriteLine("Those are the existing trips with their Dates...");
                {
                    foreach (Trip tr in ltrips)
                    {

                        Console.WriteLine("Trip: " + tr.Id + ", Truck: " + tr.Truck.Id + ", Arrival Date: " + tr.CoopArrival + ", Departure Date: " + tr.ParcelExit + ", Unload Time: " + tr.UnloadTime);

                    }
                }
            }
            catch (Exception e)
            {
                    printError(e);
            }
            Console.WriteLine("-----------------------------");

        }


    }


}
