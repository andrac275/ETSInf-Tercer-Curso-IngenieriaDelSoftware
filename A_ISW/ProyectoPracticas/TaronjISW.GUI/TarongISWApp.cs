 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarongISW.Entities;
using TarongISW.GUI.Forms;
using TarongISW.Services;

namespace TarongISW.GUI
{
    public partial class TarongISWApp : Form
    {
        private CreateNewContract cnc;
        private CreateNewGroup cng;
        private AddTripToTruck attt;
        private AddCrateToTruck actt;
        private ListTripsOfaTruck ltoat;
        private ITarongISWService service;
    

        public TarongISWApp(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;
            // TODO : Crear les coses quan apretes el botó         
            


        }

        private void TarongISWApp_Load(object sender, EventArgs e)
        {

        }

        private void InicializarBDClick(object sender, EventArgs e)
        {
            service.RemoveAllData();

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

            parcel = new Parcel("7654321AB1111C0001XX", "Casa Floro (Valencia)", Product.Kiwi, 16000, p1);
            service.AddParcel(parcel);

            Truck t = new Truck("1234AAA", 3200, 3000);
            service.AddTruck(t);

            t = new Truck("1234BJP", 3500, 2660);
            service.AddTruck(t);

            t = new Truck("1234LKP", 18000, 3660);
            service.AddTruck(t);

            //Añadir personas a la base de datos:
            service.NewPerson("87654321Z", "Armando Guerra");
            service.NewPerson("76543210S", "Andrés Trozado");
            service.NewPerson("65432109F", "Helen Chufe");
            service.NewPerson("87654321X", "Juan Sin Nombre");
            service.NewPerson("98765432M", "Aitor Tilla");
            service.NewPerson("12341234A", "Pepito El Becario");
            service.NewPerson("43214321B", "Fernanda la funcionaria");

            //Crear contratos permanentes
            service.CreateNewPermanent("76543210S", "ES9812340100951757864321", DateTime.Today.AddYears(-6), "SSN0033111144", 14000.00);
            service.CreateNewPermanent("65432109F", "ES9812340100951757864321", DateTime.Today.AddYears(-2), "SSN4433221100", 18000.00);

            //Crear contratos temporales
            service.CreateNewTemporary("87654321X", "ES9812340100951757864321", DateTime.Today, DateTime.Today.AddDays(10), "SSN0011223344");
            service.CreateNewTemporary("98765432M", "ES9812340100951757864321", DateTime.Today.AddDays(-20), "SSN0112233354");

            //Crear grupos
            {
                {
                    Group grupo;
                    DateTime fecha;
                    Person persona;
                    Contract ultimoContrato;
                    List<Contract> members = new List<Contract>();
                    List<Contract> todosLosContratos = AllContracts();

                    // Metodo auxiliar para obtener todos los contratos
                    List<Contract> AllContracts()
                    {
                        List<Contract> res = new List<Contract>();
                        foreach (Contract con in service.GetAllContracts())
                        {
                            res.Add(con);
                        }
                        return res;
                    }

                    //CREAR GRUPO 1
                    parcel = service.FindParcelById("1234567AB9999C0001DE");
                    fecha = DateTime.Today;
                    //Añadir a la lista 'members' los contratos que queremos añadir a la cuadrilla.                
                    members.Add(todosLosContratos.ElementAt<Contract>(1));  //Helen Chufe 
                                                                            //Llamar al metodo de service pasando la parcela y la lista de miembros con la fecha.
                    service.CreateNewGroup(parcel, members, fecha);

                    //Borrar contenido de la lista auxiliar 'members' para futuras pruebas.
                    members.Clear();

                    ////////////////////////////////
                    //AÑADIR PERSONA AL GRUPO                
                    parcel = service.FindParcelById("1234567AB9999C0001DE");
                    grupo = parcel.LastGroup();

                    persona = service.FindPersonById("76543210S");  //Andres Trozado
                                                                    //Obtener el ultimo contrato de la persona
                    ultimoContrato = persona.LastActiveContract();

                    //Añadir una persona al grupo. Devuelve error si ya esta en el grupo.
                    grupo.AddMember(ultimoContrato);
                    service.Commit();

                    ////////////////////////////////
                    //AÑADIR PERSONA AL GRUPO                 
                    parcel = service.FindParcelById("1234567AB9999C0001DE");
                    grupo = parcel.LastGroup();

                    persona = service.FindPersonById("98765432M");  //Aitor Tilla
                                                                    //Obtener el ultimo contrato de la persona
                    ultimoContrato = persona.LastActiveContract();

                    //Añadir una persona al grupo. Devuelve error si ya esta en el grupo.
                    grupo.AddMember(ultimoContrato);
                    service.Commit();


                    ////////////////////////////////
                    //CREAR UN SEGUNDO GRUPO EN OTRA PARCELA  
                    {
                        parcel = service.FindParcelById("7654321AB9999C0001DE");
                        fecha = DateTime.Today;

                        members.Add(todosLosContratos.ElementAt<Contract>(2));  //Juan Sin Nombre                                                                                             

                        //Llamar al metodo de service pasando la parcela y la lista de miembros con la fecha.
                        service.CreateNewGroup(parcel, members, fecha);

                        //Borrar contenido de la lista auxiliar 'members' para futuras pruebas.
                        members.Clear();
                    }

                }


                //Añadir viajes a camiones
                {
                    t = service.FindTruckById("1234AAA");
                    Trip trip = new Trip(t);
                    trip.CoopArrival = DateTime.Today.AddDays(1);
                    trip.ParcelExit = DateTime.Today.AddDays(-2);
                    trip.UnloadTime = DateTime.Today.AddDays(1).AddHours(15);
                    service.AddTrip(trip);

                    //Añadir cajas al camión
                    Crate c1, c2, c3;
                    Contract contract;
                    Group g;
                    Person person;
                    Truck truck;
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

                        //Añadir otro viaje al mismo camión
                        trip = new Trip(t);
                        trip.CoopArrival = DateTime.Today.AddDays(5);
                        trip.ParcelExit = DateTime.Today.AddDays(2);
                        trip.UnloadTime = DateTime.Today.AddDays(5).AddHours(10);
                        service.AddTrip(trip);
                    }

                    parcel = service.FindParcelById("1234567AB9999C0001DE");
                    g = parcel.LastGroup();
                    trip = service.FindTruckById("1234AAA").LastTrip();
                    truck = service.FindTruckById("1234AAA");
                    person = service.FindPersonById("65432109F");
                    contract = service.FindPersonById("65432109F").LastActiveContract();

                    c1 = new Crate(parcel.Product, 20, contract, g, trip);
                    //AddCrateToTrip(catastro, dni, matriculaCamion, pesoCaja);
                    service.AddCrateToTrip(parcel.CadastralReference, person.Id, truck.Id, c1.WeightInParcel);

                    c2 = new Crate(parcel.Product, 30, contract, g, trip);
                    //AddCrateToTrip(catastro, dni, matriculaCamion, pesoCaja);
                    service.AddCrateToTrip(parcel.CadastralReference, person.Id, truck.Id, c2.WeightInParcel);


                    //Añadir viajes a camiones
                    t = service.FindTruckById("1234BJP");
                    trip = new Trip(t);
                    trip.CoopArrival = DateTime.Today.AddDays(-1);
                    trip.ParcelExit = DateTime.Today.AddDays(-5);
                    trip.UnloadTime = DateTime.Today.AddDays(-1).AddHours(5);
                    service.AddTrip(trip);

                    trip = new Trip(t);
                    trip.CoopArrival = DateTime.Today.AddDays(7);
                    trip.ParcelExit = DateTime.Today.AddDays(3);
                    trip.UnloadTime = DateTime.Today.AddDays(7).AddHours(3);
                    service.AddTrip(trip);

                }
            }
            service.Commit();

            //Mensaje base de datos creada
            DialogResult aviso = MessageBox.Show(this,
            "Base de datos inicializada",
            "Iniciar Base de Datos",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        }

        private void CreateNewContractClick(object sender, EventArgs e)
        {
            cnc = new CreateNewContract(service);
            cnc.ShowDialog();
        }

        private void CreateNewGroupClick(object sender, EventArgs e)
        {
            cng = new CreateNewGroup(service);
            cng.ShowDialog(); 
        }


        private void AddTripToTruckClick(object sender, EventArgs e)
        {
            attt = new AddTripToTruck(service);           
            attt.ShowDialog();
        }

        private void AddCrateToTripClick(object sender, EventArgs e)
        {
            actt = new AddCrateToTruck(service);           
            actt.ShowDialog();
        }

        private void TripsOfaTruckButtonClick(object sender, EventArgs e)
        {
            ltoat = new ListTripsOfaTruck(service);
            ltoat.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


           
        
    

