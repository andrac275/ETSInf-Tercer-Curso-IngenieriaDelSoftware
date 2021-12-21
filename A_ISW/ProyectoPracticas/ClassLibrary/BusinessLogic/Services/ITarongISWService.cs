using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarongISW.Entities;
using TarongISW.Persistence;

namespace TarongISW.Services
{
    public interface ITarongISWService
    {
        //void TarongISWService(IDAL dal);

        void RemoveAllData(); //Borra los datos de la base de datos

        void Commit(); //Realiza comit de los cambios en la base de datos

        void AddPerson(Person person); //Añade una nueva persona a la base de datos 

        void AddParcel(Parcel parcel);  //Añade una nueva parcela a la base de datos

        void AddTruck(Truck truck);  //Añade un nuevo camión a la base de datos

        //void AddCrate(Crate crate); //Añade una nueva caja a la base de datos

        //void AddGroup(Group group);  //Añade una nueva cuadrilla Group a la base de datos

        void AddTrip(Trip t);  //Añade un nuevo viaje a la base de datos.

        void CreateNewPermanent(String dni, String bankAccount, DateTime initialDate, String SSN, double salary); //Caso 1: Crea un nuevo contrato permanente

        void CreateNewTemporary(String dni, String bankAccount, DateTime initialDate, String SSN); //Caso 1: Crea un nuevo contrato temporal sin fecha fin
        void CreateNewTemporary(String dni, String bankAccount, DateTime initialDate, DateTime? endDate, String SSN); //Caso 1: Crea un nuevo contrato temporal con fecha fin

        bool CheckPersonId(String dni); //Comprueba si una persona existe en la base de datos.

        bool CheckTruckId(String dni); //Comprueba si un camión existe en la base de datos.

        bool CheckParcelId(String catastro); //Comprueba si una parcela existe en la base de datos

        void NewPerson(String dni, String name); //Caso 2: Crea una nueva persona y la añade a la base de datos.

        void CreateNewGroup(Parcel p, List<Contract> members, DateTime d); //Caso 3: Crear una nueva cuadrilla para una parcela y un dia.

        void AssignTripToTruck(String mat, DateTime llegCoperativa, DateTime salirParcela, DateTime horaDescarga); // Caso 4: Asigna un viaje a un camión

        void AddCrateToTrip(String catastro, String dni, String mat, double peso); //Caso 5: Añade una caja al viaje de un camión

        List<Trip> ListTripsOfATruck(String mat, DateTime ini, DateTime fin); //Caso 6: Obtiene lista de viajes de un camión entre dos fechas dadas.

        Truck FindTruckById(String mat); //Obtiene objeto camión asociado a una matricula.

        Parcel FindParcelById(String catastro); //Obtiene objeto Parcel asociado a un catastro.

        Person FindPersonById(String dni); //Obtiene objeto persona asociado a un dni.

        ICollection<Trip> GetAllTrips();  //Obtiene todos los viajes de la base de datos.

        ICollection<Group> GetAllGroups();  //Obtiene todos los grupos de la base de datos.

        ICollection<Crate> GetAllCrates();  //Obtiene todas las cajas de la base de datos.

        ICollection<Contract> GetAllContracts();  //Obtiene todos los contratos de la base de datos.

        ICollection<Parcel> GetAllParcels();    //Obtiene todas las parcelas de la base de datos.

        ICollection<Truck> GetAllTrucks();      //Obtiene todos los camiones de la base de datos.

        ICollection<Person> GetAllPeople();      //Obtiene todas las personas de la base de datos.

        Contract FindContractByID(String id); 

    }
}
