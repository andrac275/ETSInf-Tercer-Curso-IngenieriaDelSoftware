using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarongISW.Services;
using TarongISW.Entities;
using System.Collections;

namespace TarongISW.GUI.Forms
{
    public partial class CreateNewGroup : Form
    {

        private ITarongISWService service;
        public Parcel p;
        List<Entities.Contract> contratosGen = new List<Entities.Contract>(); 





        public CreateNewGroup(ITarongISWService service)
        { 
            InitializeComponent();
            this.service = service;
            LoadData(); 
        }


        public void LoadData()
        {

            ICollection<Parcel> parcelas = service.GetAllParcels(); 
            ContractsListBox.Items.Clear();
            ICollection contracts = (ICollection)service.GetAllContracts();
            SearchContractBox.Items.Clear();
            foreach (Entities.Contract c in contracts)
            {
                string text = c.Hired.Name;
                SearchContractBox.Items.Add(text + " " + c.Hired.Id + " " + c.Id);
                ContractsListBox.Items.Add(text + " " + c.Hired.Id + " " + c.Id);

            }
            ParcelComboBox.Items.Clear(); 
            foreach(Parcel p in parcelas)
            {
                ParcelComboBox.Items.Add(p.Name + " " + p.CadastralReference);
            }

        }

        private void CreateNewGroup_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'parcelsDataSet.Parcels' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'contractsDataSet.Contracts' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'parcelsDataSet.Parcels' Puede moverla o quitarla según sea necesario.



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ParcelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SSN = ParcelComboBox.Text.Split(' ').Last();
            p = service.FindParcelById(SSN);
            Console.WriteLine(p.Name);
        }

        private void parcelsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void addContractClick(object sender, EventArgs e)
        {

            ICollection seleccionados = ContractsListBox.CheckedItems;
            ICollection contracts = (ICollection)service.GetAllContracts();
            foreach (String c in seleccionados)
            {
                string[] id = c.Split(' ');
                Entities.Contract contrato = service.FindContractByID(id.Last());
                GroupListBox.Items.Add(contrato.Hired.Name + " " + contrato.SSN + " " + contrato.Id);

            }


        }

        private void RemoveContractClick(object sender, EventArgs e)
        {
            GroupListBox.Items.Remove(GroupListBox.SelectedItem);
            

        }

        private void ExitClick(object sender, EventArgs e)
        {

        }

       
        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void SearchContractBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = SearchContractBox.Text;
            ContractsListBox.SelectedIndex = ContractsListBox.FindStringExact(valor);
        }

        private void SelectRowClick(object sender, DataGridViewCellEventArgs e)
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

        private void CreateGroupClick(object sender, EventArgs e)
        {
           


            try
            {
                ICollection contratos = GroupListBox.Items;
                foreach (Object o in contratos)
                {

                    String id = o.ToString().Split(' ').Last();
                    Entities.Contract c = service.FindContractByID(id);
                    contratosGen.Add(c);


                }

                    service.CreateNewGroup(p, contratosGen, dateTimePicker1.Value);
                    mostrarAlerta("Grupo Creado con éxito");


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

        private void GroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
