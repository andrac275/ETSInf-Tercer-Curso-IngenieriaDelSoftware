using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarongISW.Services;
using TarongISW.Entities;
using System.Data.Entity.Validation;

namespace TarongISW.GUI.Forms
{
    public partial class AddCrateToTruck : Form
    {
        private ITarongISWService service;

        public AddCrateToTruck(ITarongISWService service)
        {
            InitializeComponent();            
            this.service = service;
            LoadData(); 
        }

        public void LoadData()
        {
            ICollection<Parcel> parcelas = service.GetAllParcels();
            ICollection<Person> personas = service.GetAllPeople();
            ICollection<Truck> camiones = service.GetAllTrucks();
            
            foreach (Entities.Parcel p in parcelas)
            {               
                ParcelsComboBox.Items.Add(p.Name + " " + p.CadastralReference);                
            }
            foreach (Entities.Person p in personas)
            {
                DNIComboBox.Items.Add(p.Id + " " + p.Name);
            }
            foreach (Entities.Truck t in camiones)
            {
                TrucksComboBox.Items.Add(t.Id);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AddCrateToTruck_Load(object sender, EventArgs e)
        {
            
        }

        private void mostrarAlerta(String mensaje)
        {
            DialogResult aviso = MessageBox.Show(this,
                mensaje,
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void AñadirCajaButtonClick(object sender, EventArgs e)
        {
            Trip trip;
            Crate c1;
            Parcel parcel;
            Contract contract;
            Group g;
            Person person;
            Truck truck;
            Boolean añadido = true;
            Double n1;

            try { 
                parcel = service.FindParcelById(GetRefCatastralFromParcelCombobox());
                g = parcel.LastGroup();
                trip = service.FindTruckById(TrucksComboBox.Text).LastTrip();
                truck = service.FindTruckById(TrucksComboBox.Text);
                Console.WriteLine("Marca 1");
                person = service.FindPersonById(GetDNIFromPersonComboBox());
                Console.WriteLine("Marca 2:"+ person.Id);
                contract = service.FindPersonById(GetDNIFromPersonComboBox()).LastActiveContract();
                //Comprobar el campo del peso de lacaja es un numero y no un texto.
                if (Double.TryParse(WeightInParcelTextBox.Text, out n1))
                {
                    c1 = new Crate(parcel.Product, Convert.ToDouble(WeightInParcelTextBox.Text), contract, g, trip);
                    //AddCrateToTrip(catastro, dni, matriculaCamion, pesoCaja);
                    service.AddCrateToTrip(parcel.CadastralReference, person.Id, truck.Id, c1.WeightInParcel);
                }
                else
                { mostrarAlerta("El peso de la caja debe ser un número, no un texto."); añadido = false; }
                
            }catch (Exception er)
            {
                mostrarAlerta(er.Message);                
                añadido = false;
            }

            if (añadido)
            {
                mostrarAlerta("Caja añadida.");
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void volverClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Metodo que devuelve el DNI del combobox solo el DNI, ignorando el nombre*/
        private String GetDNIFromPersonComboBox() {            
            //Del combobox que tiene nombre y dni, devuelve solo el dni.
            String dni = DNIComboBox.Text.Trim().Substring(DNIComboBox.Text.Trim().LastIndexOf(' ')).Trim();
            return dni;
        }

        /*Metodo que devuelve la referencia catastral del combobox y solo la referencia. Ignorando el nombre de la parcela*/
        private String GetRefCatastralFromParcelCombobox() {
            String catastro = ParcelsComboBox.Text.Trim();
            //Del combobox que tiene nombre y referencia catastral, guarda SOLO la referenciaCatastral
            String referenciaCatastral = ParcelsComboBox.Text.Trim().Substring(catastro.LastIndexOf(' ')).Trim();
            return referenciaCatastral;
        }

        private void ParcelaCambiada(object sender, EventArgs e)
        {
            DNIComboBox.Items.Clear();
            DNIComboBox.Text="";
            String referenciaCatastral = GetRefCatastralFromParcelCombobox();
            //Si existe la parcela introducida...
            if (service.CheckParcelId(referenciaCatastral))
            {                
                Parcel parcela = service.FindParcelById(referenciaCatastral);
                ICollection<Group> grupos = parcela.GetAllGroupsOfaParcel();
                foreach (Group g in grupos)
                {
                    ICollection<Contract> miembros = g.GetAllMembersOfaGroup();
                    foreach (Contract c in miembros)
                    {
                        DNIComboBox.Items.Add(c.Hired.Name + " " + c.Hired.Id);
                    }

                }
            }


        }

        private void TrucksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
