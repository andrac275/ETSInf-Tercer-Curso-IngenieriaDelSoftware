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

namespace TarongISW.GUI
{
    public partial class NewPerson : Form
    {
        private String dni;
        private String nombre;

        private ITarongISWService service;

        public NewPerson(ITarongISWService service, String dni)
        {
            InitializeComponent();
            this.service = service;
            this.dni = dni;
            dniText.Text = dni;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            dni = dniText.Text.Trim();
            nombre = nombreText.Text.Trim();


            // Check for correct formatting
            bool dniCorrect = dni.Length == 9 && int.TryParse(dni.Substring(0, dni.Length - 1), out _) && Char.IsLetter(dni[dni.Length - 1]);
            bool nombreCorrect = nombre.Length > 0 && nombre.Length < 50;
            if (!(dniCorrect && nombreCorrect))
            {
                // Format error
                DialogResult answer = MessageBox.Show(
                    this,
                    "Formato de dni o nombre incorrecto:\n\n" +
                    "- El DNI tiene 8 digitos y una letra al final\n" +
                    "- El Nombre no puede estar vacío",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } 
            else
            {
                // Call service to check that dni does not exist
                if (service.CheckPersonId(dni))
                {
                    // Error: person exists
                    DialogResult answer = MessageBox.Show(
                        this,
                        "La persona correspondiente a este DNI ya existe.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );                  
                }
                else
                {
                    // Person does not exist
                    statusLabel.Text = "Añadiendo persona...";
                    service.NewPerson(dni, nombre);
                    statusLabel.ForeColor = Color.Black;
                    Console.WriteLine("Añadida persona: " + nombre);
                    statusLabel.Text = "Añadida persona: " + nombre;
                    statusLabel.ForeColor = Color.Green;

                    DialogResult answer = MessageBox.Show(
                       this,
                       "Persona añadida: " + nombre,
                       "Persona añadida con éxito",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                   );

                    this.Close();

                }

            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
