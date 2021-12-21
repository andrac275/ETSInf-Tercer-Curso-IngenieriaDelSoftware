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
    public partial class AddTripToTruck : Form
    {
        private ITarongISWService service;

        public AddTripToTruck(ITarongISWService service)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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

        /*Comprobar que los datos de la hora y minutos sean numeros y sean horas de 0 a 23 y mins de 0 a 59.
         Devuelve true si es correcto el formato*/
        private Boolean comprobarHoraMinutos()
        {
            int n1; int n2; int hh; int mm;
            if (Int32.TryParse(HHUnloadTime.Text, out n1) && Int32.TryParse(MMUnloadTime.Text, out n2))
            {
                //Convertir de String a entero para hacer las comparaciones.
                hh = Convert.ToInt32(HHUnloadTime.Text);
                mm = Convert.ToInt32(MMUnloadTime.Text);
                //Comprobar rango de horas y minutos.
                if ((hh >= 0 && hh <= 23) && (mm >= 0 && mm <= 59))
                {
                    return true;
                }
                else throw new Exception("La hora tiene que ser entre 0 y 23 y los minutos entre 0 y 59.");
                
            }
            else
            {
                throw new Exception("La hora y minutos debe ser un número, no un texto.");                
            }
            
        }

        /*Este metodo comprueba que la fecha es correcta. Que no estan cruzadas y que puedan ser el mismo dia la salida
         de parcela y la llegada a la coperativa.*/
        private Boolean comprobarFechas()
        {
            DateTime ini = ParcelExitDateTimePicker.Value;
            DateTime fin = CoopArrivalDateTimePicker.Value;
            if (ini < fin || (ini.Year == fin.Year && (ini.Month == fin.Month && ini.Day == fin.Day)))
            {
                return true;
            }
            else throw new Exception("El rango de fechas no es correcto");
        }

        private void AñadirViaje1Click(object sender, EventArgs e)
        {
            String mat = TrucksComboBox.Text;
            DateTime aux; DateTime llegCoperativa; DateTime salirParcela; DateTime horaDescarga;
            int year; int month; int day; int hh; int mm;
            Boolean añadido = true; Boolean datosCorrectos = false;

            try
            {
                //Deja la variable datosCorrectos a true si toda la informacion es correcta.
                if (comprobarHoraMinutos() && comprobarFechas()) { datosCorrectos = true; }
            }
            catch (Exception er)
            {
                mostrarAlerta(er.Message);                
            }



            //Si los datos del formulario son correctos, se procede a introducir el viaje.
            if (datosCorrectos)
            {
                //Guardar el aux el datepicker de la llegada a la coperativa
                aux = CoopArrivalDateTimePicker.Value;
                //Extraer año, mes, dia de dicha fecha
                year = aux.Year; month = aux.Month; day = aux.Day;
                //Crear la llegada a la coperativa con los datos anteriores
                llegCoperativa = new DateTime(year, month, day);
                //Crear la hora de descarga porque es el mismo año,mes,dia que la llegada pero a parte
                //hora y minutos
                hh = Convert.ToInt32(HHUnloadTime.Text);
                mm = Convert.ToInt32(MMUnloadTime.Text);
                // Fromato del Datetime(YYYY,MM, DD,Hour,Min,Sec,Cent)
                horaDescarga = new DateTime(year, month, day, hh, mm, 0, 0);

                //Guardar el aux el datepicker de la salida de la parcela
                aux = ParcelExitDateTimePicker.Value;
                //Extraer año, mes, dia de dicha fecha
                year = aux.Year; month = aux.Month; day = aux.Day;
                //Crear la salida de la parcela con los datos anteriores
                salirParcela = new DateTime(year, month, day);



                try
                {
                    //Llamar al metodo para añadirlo a la BD
                    service.AssignTripToTruck(mat, llegCoperativa, salirParcela, horaDescarga);
                }
                catch (Exception er)
                {
                    mostrarAlerta(er.Message);                    
                    añadido = false;
                }

                if (añadido)
                {
                    //Mensaje viaje añadido
                    mostrarAlerta("Viaje añadido");
                }

            }
        }

        private void AddTripToTruck_Load(object sender, EventArgs e)
        {
            

        }

        private void HHUnloadTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void VolverClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
