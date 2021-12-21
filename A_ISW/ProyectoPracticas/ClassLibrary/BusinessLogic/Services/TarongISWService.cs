using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Entities;
using TarongISW.Persistence;


namespace TarongISW.Services
{
    public class TarongISWService : ITarongISWService
    {
        private readonly IDAL dal;

        public TarongISWService(IDAL dal)
        {
            this.dal = dal;
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }



        //METODOS AUXILIARES

       

        public void AddPerson(Person person)
        {
            // Restricción: No puede haber dos personas con el mismo DNI
            if (dal.GetById<Person>(person.Id) == null)
            {
                dal.Insert<Person>(person);
                dal.Commit();
            }
            else throw new ServiceException("Person with Id " + person.Id + " already exists.");
        }

        public void AddParcel(Parcel parcel)
        {
            // Restricción: No puede haber dos parcelas con el mismo nombre
            if (!dal.GetWhere<Parcel>(x => x.Name == parcel.Name).Any())
            {
                dal.Insert<Parcel>(parcel);
                dal.Commit();
            }
            else throw new ServiceException("La parcela de nombre " + parcel.Name + " ya existe.");
        }

        public void AddTruck(Truck truck)
        {
            // Restricción: No puede haber dos camiones con la misma matrícula
            if (dal.GetById<Truck>(truck.Id) == null)
            {
                dal.Insert<Truck>(truck);
                dal.Commit();
            }
            else throw new ServiceException("El camión con matrícula " + truck.Id + " ya existe.");
        }

        public void AddCrate(Crate crate)
        {
            // Restricción: No puede haber dos cajas con el mismo nombre
            if (dal.GetById<Crate>(crate.Id) == null)
            {
                dal.Insert<Crate>(crate);
                dal.Commit();
            }
            else throw new ServiceException("La caja con Id " + crate + " ya existe.");
        }

        /*Añade un objeto Group a la base de datos*/
        public void AddGroup(Group group)
        {
            // Restricción: No puede haber dos grupo con el mismo nombre
            if (dal.GetById<Group>(group.Id) == null)
            {
                dal.Insert<Group>(group);
                dal.Commit();
            }
            else throw new ServiceException("El Grupo con Id " + group + " ya existe.");
        }

        /*Devuelve un objeto parcela perteneciente a un catastro dado.*/
        public Parcel FindParcelById(String catastro)
        {
            if (CheckParcelId(catastro))
            {
                Parcel parcela = dal.GetById<Parcel>(catastro);
                return parcela;
            }
            else throw new ServiceException("La parcela con la Referencia " + catastro + " no existe.");
        }


        public bool CheckTruckId(String mat)
        {
            return (dal.GetById<Truck>(mat) != null);
        }
        /*Devuelve true si una parcela dado un catastro está en la base de datos. False en caso contrario*/
        public bool CheckParcelId(String catastro)
        {
            return (dal.GetById<Parcel>(catastro) != null);
        }

        /*Dada una matricula, devuleve el objeto camión perteneciente a dicha matricula. Si no existe devuelve excepcion*/
        public Truck FindTruckById(String mat)
        {
            if (CheckTruckId(mat))
            {
                Truck camio = dal.GetById<Truck>(mat);
                return camio;
            }
            else throw new ServiceException("El camión con la matrícula " + mat + " no existe.");
        }

        public Contract FindContractByID(String id)
        {
            int valor = Int32.Parse(id);
            Contract contrato = dal.GetById<Contract>(valor);
            return contrato;
        }



        /*Devuelve una lista con todos los grupos.*/
        public ICollection<Group> GetAllGroups()
        {
            IEnumerable<Group> grupos = dal.GetAll<Group>();
            return grupos.ToList();
        }

        /*Devuelve una lista con todos los viajes.*/
        public ICollection<Trip> GetAllTrips()
        {
            IEnumerable<Trip> viajes = dal.GetAll<Trip>();
            return viajes.ToList();
        }

        /*Devuelve una lista con todos los camiones.*/
        public ICollection<Truck> GetAllTrucks()
        {
            IEnumerable<Truck> camiones = dal.GetAll<Truck>();
            return camiones.ToList();
        }

        /*Devuelve una lista con todas las personas.*/
        public ICollection<Person> GetAllPeople()
        {
            IEnumerable<Person> personas = dal.GetAll<Person>();
            return personas.ToList();
        }

        /*Devuelve una lista con todas las Crates.*/
        public ICollection<Crate> GetAllCrates()
        {
            IEnumerable<Crate> cajas = dal.GetAll<Crate>();
            return cajas.ToList();
        }

        //AÑADIR CONTRATO PERMANENTE A LA BASE DE DATOS
        public void AddPermanent(Permanent per)
        {
            dal.Insert<Permanent>(per);
            dal.Commit();

            //// Restricción: No puede haber dos contratos con el mismo identificador          
            //if (dal.GetById<Contract>(per.Id) == null)
            //{
            //    dal.Insert<Contract>(per);
            //    dal.Commit();
            //}
            //else throw new ServiceException("Permanent contract with Id " + per.Id + " already exists.");
        }

        //AÑADIR CONTRATO TERMPORAL A LA BASE DE DATOS
        public void AddTemporary(Temporary tem)
        {
            dal.Insert<Temporary>(tem);
            dal.Commit();
            //// Restricción: No puede haber dos personas con el mismo DNI
            //if (dal.GetById<Temporary>(tem.Id) == null)
            //{
            //    dal.Insert<Temporary>(tem);
            //    dal.Commit();
            //}
            //else throw new ServiceException("Temporary contract with Id " + tem.Id + " already exists.");
        }

        // COMPROBAR DNI PERSONA
        public bool CheckPersonId(String dni)
        {
            return (dal.GetById<Person>(dni) != null);
        }

        //ENCONTRAR PERSONA POR ID
        public Person FindPersonById(String dni)
        {
            if (CheckPersonId(dni))
            {
                Person persona = dal.GetById<Person>(dni);
                return persona;
            }
            else throw new ServiceException("La persona con el dni " + dni + " no existe.");
        }

        public ICollection<Contract> GetAllContracts() //Devuelve todos los contratos en una lista
        {
            IEnumerable<Contract> contratos = dal.GetAll<Contract>();
            return contratos.ToList();
        }

        public ICollection<Parcel> GetAllParcels() //Devuelve todos los contratos en una lista
        {
            IEnumerable<Parcel> parcelas = dal.GetAll<Parcel>();
            return parcelas.ToList();

        }

        /*Devuelve un grupo 'g' de la lista de grupos de un 'contrato' si ese grupo 'g' tiene
         la misma referencia cadastral.
        Si el contrato de la persona no está asociado a ninguna parcela, devuelve grupo null*/
        private Group CheckGroupInParcel(Parcel parcela, Contract contrato)
        {
            foreach(Group g in contrato.Groups)
            {
                //Si coincide el catastro del grupo que analizamos con el de la parcela que se recolecta, devuelve el grupo.
                if (g.Parcel.CadastralReference.Equals(parcela.CadastralReference)) { return g;}
            }
            return null;
            
        }

        private bool CheckGroupInParcel(Parcel p, DateTime a) //Devuelve todos los contratos en una lista
        {
            List<Group> grupos = (dal.GetAll<Group>()).ToList();
            foreach(Group g in grupos)
            {
                if (g.Date == a && g.Parcel.CadastralReference == p.CadastralReference)
                {
                    return true;
                }
            }
            return false; 
        }
        /*Devuelve verdadero si un contrato 'c' pertenece a más de un grupo*/
        private bool CheckContractInVariousGroups(Contract c)
        {
            List<Group> grupos = (dal.GetAll<Group>()).ToList();
            foreach (Group g in grupos)
            {
                //Prueba para cada grupo si el contrato 'c' está entre los contratos del grupo (g.Members)
                foreach(Contract contrato in g.Members)
                {
                    if (contrato.Equals(c)) return true;
                }
            }
            return false;
        }

        private bool CheckContractInGroups(Contract c, DateTime d)
        {
            List<Group> grupos = (dal.GetAll<Group>()).ToList();
            foreach(Group g in grupos)
            {
                if(g.Date == d && g.Members.Contains(c))
                {
                    return true; 
                }
            }
            return false;
        }

        private void CheckActiveContract(Person person, DateTime initialDate)
        {
                ICollection<Contract> listContracts = person.Contracts;
                if (listContracts.Count != 0) {
                    foreach (Contract c in listContracts)
                        //Si el último contrato es permanente
                        if (c is Permanent && c.Equals(listContracts.Last<Contract>()))
                        {
                            throw new ServiceException("La persona ya tiene un contrato permanente");
                        }
                        else if (c is Temporary)
                        {
                            if (((Temporary) c).FinalDate != null && initialDate<((Temporary) c).FinalDate)
                            {
                                throw new ServiceException("La persona ya tiene un contrato temporal activo");
                            }
                            if (((Temporary)c).FinalDate == null && initialDate > ((Temporary)c).InitialDate)
                            {
                                throw new ServiceException("La persona ya tiene un contrato temporal activo");
                            }
                        }
                        else
                        {
                            throw new ServiceException("El contrato no es temporal ni permanente");
                        }
                }
                
            }

        //METODOS PRINCIPALES
        public void CreateNewPermanent(String dni, String bankAccount, DateTime initialDate, String SSN, double salary)
        {
            // Tendremos que añadir el contrato a crear a la persona con el dni pasado como parámetro.
            // Solo se llama a este metodo si ya existe
            // Demanar al DAL la persona corresponent amb el DNI
            Person person = FindPersonById(dni);

            // Comprovar que el contrat no esta assignat
            Contract last_contract = person.LastActiveContract();

            /* Hem deduït que si un contrat comença despres de que acabe un, no hi hauria conflicte
             * per tant l'ultim contrat que hem afegit no tindria per que ser l'actiu
             * i hem d'iterar per tots els contrats de la persona fins trobar un actiu */

            CheckActiveContract(person,initialDate);            
            
            Permanent contract = new Permanent(bankAccount, initialDate, SSN, person, salary);
            
            // Afegir contrat a la llista de contrats de la persona
            person.Contracts.Add(contract);
            
            // Afegir contrat al DAL
            AddPermanent(contract);
            
        }

        public void CreateNewTemporary(String dni, String bankAccount, DateTime initialDate, String SSN)
        {
            //Metodo lanzadera para cuando no se recibe una fecha fin del contrato.
            CreateNewTemporary(dni, bankAccount, initialDate, null, SSN);
        }

        public void CreateNewTemporary(String dni, String bankAccount, DateTime initialDate, DateTime? endDate, String SSN)
        {
            // EN EL CONSTRUCTOR DEL PROGRAM TENEMOS QUE ESTABLECER UN FINAL DATE PARA EL CONTRATO QUE CREEMOS PARA COMPARARLO CON INITIAL DATE Y VER SI ESTÁ ACTIVO
            // Tendremos que añadir el contrato a crear a la persona con el dni pasado como parámetro.
            // Solo se llama a este metodo si ya existe
            // Demanar al DAL la persona corresponent amb el DNI
            Person person = FindPersonById(dni);


            /* Hem deduït que si un contrat comença despres de que acabe un, no hi hauria conflicte
             * per tant l'ultim contrat que hem afegit no tindria per que ser l'actiu
             * i hem d'iterar per tots els contrats de la persona fins trobar un actiu */

            CheckActiveContract(person, initialDate);
            
            Temporary contract = new Temporary(bankAccount, initialDate, SSN, person);
            
            //Si se ha introducido una fecha fin, ponerla.
            if (endDate != null) { contract.FinalDate = endDate; }

            // Afegir contrat a la llista de contrats de la persona
            person.Contracts.Add(contract);

            // Afegir contrat al DAL
            AddTemporary(contract);
        }

        public void NewPerson(String dni, String name)
        {
            
            if (CheckPersonId(dni))
            {                
                throw new ServiceException("La persona ya existe, por favor introduce una información diferente");
            }
            else
            {                
                Person person = new Person(dni, name);
                AddPerson(person);
            }
        }

        public void CreateNewGroup(Parcel p, List<Contract> members, DateTime d)
        { //este grupo pasado como lista de contratos se añadira a la lista de groups del parcel pasado como parámetro
            
            if (FindParcelById(p.CadastralReference) != null && CheckGroupInParcel(p, d) == false)
            {                
                Group grupo = new Group(d, p);

                foreach (Contract c in members)
                {
                    if(CheckContractInVariousGroups(c)) { throw new ServiceException("La persona no puede estar en más de un grupo."); }
                    if (grupo.Members.Contains(c) || CheckContractInGroups(c, d) == true)
                    {
                        throw new ServiceException("Este contrato ya existe en el grupo o el contrato ya está en otra parcela el mismo día");
                    }
                    else
                    {         
                        //Añadir los miembros al grupo
                        grupo.Members.Add(c); 
                    }
                }

                //Añadir el grupo a la BD con los miembros ya añadidos.
                AddGroup(grupo);
            }
            else
            {
                throw new ServiceException("La parcela no existe o ya se ha asignado a un grupo el mismo día");
            }
                        
        }
       

        /*Añade un nuevo viaje a la base de datos*/
        public void AddTrip(Trip trip)
        {
            // Restricción: No puede haber dos viajes con el mismo identificador
            if (dal.GetById<Trip>(trip.Id) == null)
            {
                dal.Insert<Trip>(trip);
                dal.Commit();
            }
            else throw new ServiceException("El viaje con la  Id " + trip.Id + " ya existe.");
        }



        /*Añade un objeto Crate a la base de datos*/



        //Caso 4
        /*Antes de llamar al metodo AssignTripToTruck, hay que utilizar el metodo 
         FindTruckById para comprobar que existe el camión dada la matrícula*/

        //Cuando se decide introducir un nuevo viaje para asignarlo a un camión.
        public void AssignTripToTruck(String mat, DateTime llegCoperativa, DateTime salirParcela, DateTime horaDescarga)
        {
            //Pedir al DAL el camion asociado a una matricula.
            Truck camion = FindTruckById(mat);

            //Crear el viaje
            Trip viaje = new Trip(camion);
            //Asignar al viaje creado la llegada a coperativa, fecha salida y hora descarga.
            viaje.CoopArrival = llegCoperativa;
            viaje.ParcelExit = salirParcela;
            viaje.UnloadTime = horaDescarga;

            //Añadirle a la lista de viajes del camión el viaje introducido
            camion.Trips.Add(viaje);

            //Actualizar BD
            Commit();

        }


        //Caso 5
        public void AddCrateToTrip(String catastro, String dni, String mat, double peso)
        {
            //Solicitar al DAL la parcela asociada a un catastro.
            Parcel parcela = FindParcelById(catastro);

            //Solicitar al DAL la persona asociada a un DNI.
            Person persona = FindPersonById(dni);

            //Buscar contrato activo de la persona.

            Contract contrato = persona.LastActiveContract();
            
            if (contrato == null)
            {
                throw new ServiceException("La persona no tiene un contrato activo");
            }

            //Buscar en el DAL el grupo en el que trabaja la persona.
            //Se obtiene un grupo que pertenece a un contrato de una persona y a una parcela asociada a una referencia catastral.
            //Si dicha persona no esta asignada a una parcela, devuelve grupo null.            
            Group grupo = CheckGroupInParcel(parcela, contrato);
            if (grupo == null)
            {
                throw new ServiceException("La persona no está en un grupo asignado a la parcela");
            }
                        
            //Pedir al DAL el camion asociado a una matricula.
            Truck camion = FindTruckById(mat);

            //Último viaje del camión
            Trip viaje = camion.LastTrip();

            //Crear una caja a partir de la información proporcionada
            Crate caja = new Crate(parcela.Product, peso, contrato, grupo, viaje);

            //PesoActual del camion con las cajas que tiene cargadas
            double pesoActual = camion.TareWeight;
            
            //Comprobar que el peso de la caja a cargar + pesoActual del camion
            //no excede la masa maxima autorizada
            if ((caja.WeightInParcel + pesoActual) < camion.MaximumAuthorisedMass)
            {
                //Actualizar peso del camión
                camion.TareWeight += caja.WeightInParcel;
                //Añadir a la lista de Crates del Trip 'viaje' la caja 'c' 
                viaje.añadirCaja(caja);
                //viaje.Crates.Add(caja);
            }
            else throw new ServiceException("Peso máximo del camión alcanzado");

            //Actualizar BD
            Commit();
        }

        //Caso 6
        public List<Trip> ListTripsOfATruck(String mat, DateTime ini, DateTime fin)
        {
            //Pedir al DAL el camion asociado a una matricula.
            Truck camion = dal.GetById<Truck>(mat);

            //if (ini < fin)
            if (ini<fin ||(ini.Year == fin.Year &&(ini.Month == fin.Month && ini.Day == fin.Day)) )
            {
                //El metodo tripsByDate de un Truck devuelve un listado de viajes entre
                //dos fechas dadas.
                if (CheckTruckId(mat))
                {
                    return camion.TripsByDate(ini, fin);
                }
                else throw new ServiceException("El camión con dicha matrícula no existe.");
            }
            else throw new ServiceException("El rango de fechas no es correcto");

            

        }

    }
}
