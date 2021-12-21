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

namespace TarongISW.GUI.Forms
{
    public partial class ListTripsOfaTruck : Form
    {
        private ITarongISWService service;

        public ListTripsOfaTruck(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }

        public void LoadData()
        {            
            ICollection<Truck> camiones = service.GetAllTrucks();
                      
            foreach (Entities.Truck t in camiones)
            {
                TrucksComboBox.Items.Add(t.Id);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ListTripsOfaTruck_Load(object sender, EventArgs e)
        {
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TrucksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TripsListBox.Items.Add(TrucksComboBox.SelectedValue);
        }

        private void mostrarAlerta(String mensaje)
        {
            DialogResult aviso = MessageBox.Show(this,
                mensaje,
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ConsultarClick(object sender, EventArgs e)
        {

            try { 
                List<Trip> viajes = service.ListTripsOfATruck(TrucksComboBox.Text, InitialDateTimePicker.Value, FinalDateTimePicker.Value);

                if (viajes.Count == 0)
                {
                    //Limpiar la lista de la interfaz.
                    TripsListBox.Items.Clear();
                    mostrarAlerta("El camión no tiene viajes en ese rango");
                }
                else
                {
                    //Limpiar la lista de la interfaz a causa de otras consultas  antes de añadir los viajes de ésta consulta.
                    TripsListBox.Items.Clear();

                    //Rellenar la lista con los resultados de la consulta.
                    foreach (Trip viaje in viajes)
                    {
                        
                        if (viaje.Crates.Count == 0)
                        {
                            mostrarAlerta("El camión tiene viajes pero no tiene cajas asignadas");                            
                            break;
                        }
                        else
                        {
                            //Extrae la primera caja de la lista de Crates del viaje, de esa caja saca el Group y con el grupo se saca
                            //la parcela y el nombre.
                            String nombreParcela = viaje.Crates.ElementAt<Crate>(0).Group.Parcel.Name;

                            TripsListBox.Items.Add("Parcela: " + nombreParcela + ", fecha viaje: " + viaje.ParcelExit + ", cajas transportadas: " + viaje.Crates.Count + ", peso total: " + viaje.getCarriedWeight());
                        }
                    }
                }

                viajes.Clear();
            }
            catch (Exception er)
            {
                mostrarAlerta(er.Message);
            }
                        
        }

        private void VolverClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
