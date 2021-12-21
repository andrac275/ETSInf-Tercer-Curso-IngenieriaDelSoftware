
namespace TarongISW.GUI.Forms
{
    partial class AddCrateToTruck
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label5 = new System.Windows.Forms.Label();
            this.ParcelsComboBox = new System.Windows.Forms.ComboBox();
            this.parcelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcelsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label9 = new System.Windows.Forms.Label();
            this.AñadirCajaButton = new System.Windows.Forms.Button();
            this.WeightInParcelTextBox = new System.Windows.Forms.TextBox();
            this.TrucksComboBox = new System.Windows.Forms.ComboBox();
            this.trucksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DNIComboBox = new System.Windows.Forms.ComboBox();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VolverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parcelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trucksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añadir caja a camión";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parcela:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matrícula camión:";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 4;
            // 
            // ParcelsComboBox
            // 
            this.ParcelsComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParcelsComboBox.ForeColor = System.Drawing.Color.Black;
            this.ParcelsComboBox.FormattingEnabled = true;
            this.ParcelsComboBox.Location = new System.Drawing.Point(194, 161);
            this.ParcelsComboBox.Name = "ParcelsComboBox";
            this.ParcelsComboBox.Size = new System.Drawing.Size(213, 21);
            this.ParcelsComboBox.TabIndex = 0;
            this.ParcelsComboBox.SelectedIndexChanged += new System.EventHandler(this.ParcelaCambiada);
            // 
            // parcelsBindingSource
            // 
            this.parcelsBindingSource.DataMember = "Parcels";
            this.parcelsBindingSource.DataSource = this.parcelsDataSetBindingSource;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Peso de la caja:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // AñadirCajaButton
            // 
            this.AñadirCajaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AñadirCajaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AñadirCajaButton.Location = new System.Drawing.Point(308, 425);
            this.AñadirCajaButton.Name = "AñadirCajaButton";
            this.AñadirCajaButton.Size = new System.Drawing.Size(79, 24);
            this.AñadirCajaButton.TabIndex = 4;
            this.AñadirCajaButton.Text = "Añadir caja";
            this.AñadirCajaButton.UseVisualStyleBackColor = true;
            this.AñadirCajaButton.Click += new System.EventHandler(this.AñadirCajaButtonClick);
            // 
            // WeightInParcelTextBox
            // 
            this.WeightInParcelTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightInParcelTextBox.ForeColor = System.Drawing.Color.Black;
            this.WeightInParcelTextBox.Location = new System.Drawing.Point(194, 279);
            this.WeightInParcelTextBox.Name = "WeightInParcelTextBox";
            this.WeightInParcelTextBox.Size = new System.Drawing.Size(121, 20);
            this.WeightInParcelTextBox.TabIndex = 3;
            // 
            // TrucksComboBox
            // 
            this.TrucksComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrucksComboBox.FormattingEnabled = true;
            this.TrucksComboBox.Location = new System.Drawing.Point(194, 240);
            this.TrucksComboBox.Name = "TrucksComboBox";
            this.TrucksComboBox.Size = new System.Drawing.Size(121, 21);
            this.TrucksComboBox.TabIndex = 2;
            this.TrucksComboBox.SelectedIndexChanged += new System.EventHandler(this.TrucksComboBox_SelectedIndexChanged);
            // 
            // trucksBindingSource
            // 
            this.trucksBindingSource.DataMember = "Trucks";
            // 
            // DNIComboBox
            // 
            this.DNIComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DNIComboBox.FormattingEnabled = true;
            this.DNIComboBox.Location = new System.Drawing.Point(193, 201);
            this.DNIComboBox.Name = "DNIComboBox";
            this.DNIComboBox.Size = new System.Drawing.Size(182, 21);
            this.DNIComboBox.TabIndex = 1;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            // 
            // VolverButton
            // 
            this.VolverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VolverButton.Location = new System.Drawing.Point(393, 425);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(79, 24);
            this.VolverButton.TabIndex = 5;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.volverClick);
            // 
            // AddCrateToTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.DNIComboBox);
            this.Controls.Add(this.TrucksComboBox);
            this.Controls.Add(this.WeightInParcelTextBox);
            this.Controls.Add(this.AñadirCajaButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ParcelsComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "AddCrateToTruck";
            this.Text = "AddCrateToTrip";
            this.Load += new System.EventHandler(this.AddCrateToTruck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parcelsBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.parcelsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trucksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ParcelsComboBox;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AñadirCajaButton;
        private System.Windows.Forms.TextBox WeightInParcelTextBox;
        private System.Windows.Forms.BindingSource parcelsDataSetBindingSource;
        private System.Windows.Forms.ComboBox TrucksComboBox;
        private System.Windows.Forms.ComboBox DNIComboBox;
        private System.Windows.Forms.BindingSource parcelsBindingSource;
        private System.Windows.Forms.BindingSource trucksBindingSource;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private System.Windows.Forms.Button VolverButton;
    }
}