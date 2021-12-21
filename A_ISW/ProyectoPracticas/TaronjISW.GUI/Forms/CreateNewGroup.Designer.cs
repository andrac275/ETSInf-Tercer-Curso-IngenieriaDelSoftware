
namespace TarongISW.GUI.Forms
{
    partial class CreateNewGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ParcelComboBox = new System.Windows.Forms.ComboBox();
            this.parcelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ParcelText = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FechaText = new System.Windows.Forms.Label();
            this.RightArrowButton = new System.Windows.Forms.Button();
            this.LeftArrowButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.GroupListBox = new System.Windows.Forms.ListBox();
            this.crearButton = new System.Windows.Forms.Button();
            this.SearchContractBox = new System.Windows.Forms.ComboBox();
            this.contractsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BuscarText = new System.Windows.Forms.Label();
            this.contractsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ContractsListBox = new System.Windows.Forms.CheckedListBox();
            this.VolverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parcelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "titulo";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Grupo";
            // 
            // ParcelComboBox
            // 
            this.ParcelComboBox.AccessibleName = "ParcelComboBox";
            this.ParcelComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParcelComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ParcelComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ParcelComboBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ParcelComboBox.FormattingEnabled = true;
            this.ParcelComboBox.Location = new System.Drawing.Point(299, 87);
            this.ParcelComboBox.Name = "ParcelComboBox";
            this.ParcelComboBox.Size = new System.Drawing.Size(200, 21);
            this.ParcelComboBox.TabIndex = 0;
            this.ParcelComboBox.SelectedIndexChanged += new System.EventHandler(this.ParcelComboBox_SelectedIndexChanged);
            // 
            // parcelsBindingSource
            // 
            this.parcelsBindingSource.DataMember = "Parcels";
            // 
            // ParcelText
            // 
            this.ParcelText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParcelText.AutoSize = true;
            this.ParcelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParcelText.Location = new System.Drawing.Point(236, 87);
            this.ParcelText.Name = "ParcelText";
            this.ParcelText.Size = new System.Drawing.Size(58, 16);
            this.ParcelText.TabIndex = 2;
            this.ParcelText.Text = "Parcela:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FechaText
            // 
            this.FechaText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FechaText.AutoSize = true;
            this.FechaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaText.Location = new System.Drawing.Point(236, 120);
            this.FechaText.Name = "FechaText";
            this.FechaText.Size = new System.Drawing.Size(49, 16);
            this.FechaText.TabIndex = 4;
            this.FechaText.Text = "Fecha:";
            // 
            // RightArrowButton
            // 
            this.RightArrowButton.AccessibleName = "RightArrow";
            this.RightArrowButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightArrowButton.Location = new System.Drawing.Point(345, 268);
            this.RightArrowButton.Name = "RightArrowButton";
            this.RightArrowButton.Size = new System.Drawing.Size(47, 37);
            this.RightArrowButton.TabIndex = 6;
            this.RightArrowButton.Text = ">>";
            this.RightArrowButton.UseVisualStyleBackColor = true;
            this.RightArrowButton.Click += new System.EventHandler(this.addContractClick);
            // 
            // LeftArrowButton
            // 
            this.LeftArrowButton.AccessibleName = "LeftArrow";
            this.LeftArrowButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftArrowButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LeftArrowButton.Location = new System.Drawing.Point(345, 311);
            this.LeftArrowButton.Name = "LeftArrowButton";
            this.LeftArrowButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LeftArrowButton.Size = new System.Drawing.Size(47, 37);
            this.LeftArrowButton.TabIndex = 7;
            this.LeftArrowButton.Text = "<<";
            this.LeftArrowButton.UseVisualStyleBackColor = true;
            this.LeftArrowButton.Click += new System.EventHandler(this.RemoveContractClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contractsBindingSource
            // 
            this.contractsBindingSource.DataMember = "Contracts";
            this.contractsBindingSource.DataSource = this.bindingSource2;
            // 
            // bindingSource2
            // 
            this.bindingSource2.CurrentChanged += new System.EventHandler(this.bindingSource2_CurrentChanged);
            // 
            // GroupListBox
            // 
            this.GroupListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupListBox.FormattingEnabled = true;
            this.GroupListBox.Location = new System.Drawing.Point(414, 214);
            this.GroupListBox.Name = "GroupListBox";
            this.GroupListBox.Size = new System.Drawing.Size(250, 160);
            this.GroupListBox.TabIndex = 5;
            this.GroupListBox.SelectedIndexChanged += new System.EventHandler(this.GroupListBox_SelectedIndexChanged);
            // 
            // crearButton
            // 
            this.crearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.crearButton.Location = new System.Drawing.Point(566, 426);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(75, 23);
            this.crearButton.TabIndex = 8;
            this.crearButton.Text = "Crear";
            this.crearButton.UseVisualStyleBackColor = true;
            this.crearButton.Click += new System.EventHandler(this.CreateGroupClick);
            // 
            // SearchContractBox
            // 
            this.SearchContractBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchContractBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchContractBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SearchContractBox.FormattingEnabled = true;
            this.SearchContractBox.Location = new System.Drawing.Point(73, 214);
            this.SearchContractBox.Name = "SearchContractBox";
            this.SearchContractBox.Size = new System.Drawing.Size(250, 21);
            this.SearchContractBox.TabIndex = 3;
            this.SearchContractBox.SelectedIndexChanged += new System.EventHandler(this.SearchContractBox_SelectedIndexChanged);
            // 
            // contractsBindingSource1
            // 
            this.contractsBindingSource1.DataMember = "Contracts";
            this.contractsBindingSource1.DataSource = this.bindingSource2;
            // 
            // BuscarText
            // 
            this.BuscarText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BuscarText.AutoSize = true;
            this.BuscarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarText.Location = new System.Drawing.Point(70, 182);
            this.BuscarText.Name = "BuscarText";
            this.BuscarText.Size = new System.Drawing.Size(60, 16);
            this.BuscarText.TabIndex = 18;
            this.BuscarText.Text = "Buscar:";
            // 
            // contractsBindingSource2
            // 
            this.contractsBindingSource2.DataMember = "Contracts";
            this.contractsBindingSource2.DataSource = this.bindingSource2;
            // 
            // ContractsListBox
            // 
            this.ContractsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContractsListBox.FormattingEnabled = true;
            this.ContractsListBox.Location = new System.Drawing.Point(73, 250);
            this.ContractsListBox.Name = "ContractsListBox";
            this.ContractsListBox.Size = new System.Drawing.Size(250, 124);
            this.ContractsListBox.TabIndex = 4;
            // 
            // VolverButton
            // 
            this.VolverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolverButton.Location = new System.Drawing.Point(647, 426);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(75, 23);
            this.VolverButton.TabIndex = 9;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverClick);
            // 
            // CreateNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.ContractsListBox);
            this.Controls.Add(this.BuscarText);
            this.Controls.Add(this.SearchContractBox);
            this.Controls.Add(this.crearButton);
            this.Controls.Add(this.GroupListBox);
            this.Controls.Add(this.LeftArrowButton);
            this.Controls.Add(this.RightArrowButton);
            this.Controls.Add(this.FechaText);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ParcelText);
            this.Controls.Add(this.ParcelComboBox);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "CreateNewGroup";
            this.Text = "CreateNewGroup";
            this.Load += new System.EventHandler(this.CreateNewGroup_Load);
            //((System.ComponentModel.ISupportInitialize)(this.parcelsBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ParcelComboBox;
        private System.Windows.Forms.Label ParcelText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label FechaText;
        private System.Windows.Forms.Button RightArrowButton;
        private System.Windows.Forms.Button LeftArrowButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox GroupListBox;
        private System.Windows.Forms.BindingSource bindingSource2;
        
        private System.Windows.Forms.BindingSource contractsBindingSource;
        
        
        private System.Windows.Forms.BindingSource parcelsBindingSource;
        
        private System.Windows.Forms.Button crearButton;
        private System.Windows.Forms.ComboBox SearchContractBox;
        private System.Windows.Forms.BindingSource contractsBindingSource1;
        private System.Windows.Forms.Label BuscarText;
        private System.Windows.Forms.BindingSource contractsBindingSource2;
        private System.Windows.Forms.CheckedListBox ContractsListBox;
        private System.Windows.Forms.Button VolverButton;
    }
}