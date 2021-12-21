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
    public partial class CreateNewContract : Form
    {
        private String dni;
        private String cuentaBanco;
        private String SSN;
        private DateTime iniTime;
        private DateTime finTime;
        private double salario;
        private bool isPermanent;

        private ITarongISWService service;
        
        public CreateNewContract(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;

            // Permanent by default
            permanenteRButton.Checked = true;
            finDatePicker.Enabled = false;
            isPermanent = true;

            //  LoadData(); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateNewContract_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceptarClick(object sender, EventArgs e)
        {
            // Processar informació i afegir
            dni = dniText.Text;
            if (!service.CheckPersonId(dni))
            {
                // Si la persona no existeix -> Error
                //dniLabel.ForeColor = Color.Red;

                DialogResult answer = MessageBox.Show(
                    this,
                    "DNI no encontrado en la base de datos.\n" +
                    "Para crear un contrato es necesario añadir a la persona correspondiente primero.\n" +
                    "¿Quieres añadir primero una persona?",
                    "DNI no encontrado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.None
                );

                if (answer == DialogResult.Yes)
                {
                    NewPerson personForm = new NewPerson(service, dni);
                    personForm.ShowDialog();
                }

            }
            else
            {
                // La persona existeix
                //dniLabel.ForeColor = Color.Black;
                SSN = ssnText.Text.Trim();
                cuentaBanco = cuentaText.Text.Trim();
                // Salario = 0 si TryParse falla
                Double.TryParse(salarioText.Text, out salario);
                iniTime = inicioDatePicker.Value;
                
                // Comprovar Camps

                bool correctIniTime = iniTime.Date.CompareTo(DateTime.Now.Date) >= 0;
                bool correctFinTime = true;
                if (!isPermanent && finCheckBox.Checked)
                {
                    finTime = finDatePicker.Value;
                    correctIniTime = iniTime.CompareTo(DateTime.Now) > 0 && iniTime.CompareTo(finTime) < 0;
                    correctFinTime = finTime.CompareTo(DateTime.Now) > 0 && finTime.CompareTo(iniTime) > 0;
                }

                if (!(correctIniTime && correctFinTime))
                {
                    // Error en els temps
                    DialogResult answer = MessageBox.Show(
                        this,                    
                        "Alguna fecha elegida no es correcta\n" +
                        "La fecha de inicio y fin no pueden ser anteriores a hoy,\n" +
                        "y la fecha de inicio debe ser anterior a la de fin.",
                        "Fechas Incorrectas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                );
                    return;
                }
                String errorString = "";
                bool flag = false;

                if (String.IsNullOrEmpty(cuentaBanco))
                {
                    flag = true;
                    errorString += "Cuenta Bancaria en blanco\n";
                }
                if (String.IsNullOrEmpty(SSN))
                {
                    flag = true;
                    errorString += "SSN en blanco\n";
                }
                if (isPermanent && salario == 0)
                {
                    flag = true;
                    errorString += "Salario en blanco o 0\n";
                }
                if (flag)
                {
                    // Error en els temps
                    DialogResult answer = MessageBox.Show(
                        this,
                        errorString,
                        "Campos en blanco",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // Cridar a service

                statusLabel.Text = "Creando contrato...";
                statusLabel.ForeColor = Color.Black;
                try
                {
                    if (isPermanent)
                    {
                        service.CreateNewPermanent(dni, cuentaBanco, iniTime, SSN, salario);
                        DialogResult aviso = MessageBox.Show(this,
                        "Contrato permanente creado",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else if (finCheckBox.Checked)
                    {
                        service.CreateNewTemporary(dni, cuentaBanco, iniTime, finTime, SSN);
                        DialogResult aviso = MessageBox.Show(this,
                        "Contrato temporal creado",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {                    
                        service.CreateNewTemporary(dni, cuentaBanco, iniTime, SSN);
                        DialogResult aviso = MessageBox.Show(this,
                        "Contrato temporal creado",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
                catch (Exception exception)
                {
                    DialogResult answer = MessageBox.Show(
                        this,
                        exception.Message,
                        "Error al crear contrato",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    statusLabel.Text = "Error al crear contrato";
                    statusLabel.ForeColor = Color.Red;
                    return;
                }
                statusLabel.Text = "Creado nuevo contrato";
                statusLabel.ForeColor = Color.Green;
                Console.WriteLine("Success");

            }
        }

        private void cancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newPersonLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dni = dniText.Text;
            NewPerson personForm = new NewPerson(service, dni);
            personForm.ShowDialog();
        }

        private void permanenteChange(object sender, EventArgs e)
        {
            if (permanenteRButton.Checked)
            {
                finDatePicker.Enabled = false;
                salarioText.Enabled = true;
                finCheckBox.Enabled = false;
                isPermanent = true;
            }
        }

        private void temporalChange(object sender, EventArgs e)
        {
            if (temporalRButton.Checked)
            {
                finDatePicker.Enabled = true;
                salarioText.Enabled = false;
                finCheckBox.Enabled = true;
                isPermanent = false;
            }
        }

        private void finCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (finCheckBox.Checked)
            {
                finDatePicker.Enabled = true;
            }
            else
            {
                finDatePicker.Enabled = false;
            }
        }

        private void inicioDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
