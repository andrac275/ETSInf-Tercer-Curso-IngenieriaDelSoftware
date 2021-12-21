
namespace TarongISW.GUI
{
    partial class TarongISWApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewGroupButton = new System.Windows.Forms.Button();
            this.InicializarBDButton = new System.Windows.Forms.Button();
            this.NewContractButton = new System.Windows.Forms.Button();
            this.AddTripToTruckButton = new System.Windows.Forms.Button();
            this.AddCrateToTripButton = new System.Windows.Forms.Button();
            this.TripsOfaTruckButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGroupButton
            // 
            this.NewGroupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewGroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NewGroupButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGroupButton.Location = new System.Drawing.Point(105, 339);
            this.NewGroupButton.Name = "NewGroupButton";
            this.NewGroupButton.Size = new System.Drawing.Size(134, 66);
            this.NewGroupButton.TabIndex = 5;
            this.NewGroupButton.Text = "Nuevo Grupo";
            this.NewGroupButton.UseVisualStyleBackColor = false;
            this.NewGroupButton.Click += new System.EventHandler(this.CreateNewGroupClick);
            // 
            // InicializarBDButton
            // 
            this.InicializarBDButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InicializarBDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.InicializarBDButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicializarBDButton.Location = new System.Drawing.Point(105, 194);
            this.InicializarBDButton.Name = "InicializarBDButton";
            this.InicializarBDButton.Size = new System.Drawing.Size(134, 66);
            this.InicializarBDButton.TabIndex = 1;
            this.InicializarBDButton.Text = "Inicializar BD";
            this.InicializarBDButton.UseVisualStyleBackColor = false;
            this.InicializarBDButton.Click += new System.EventHandler(this.InicializarBDClick);
            // 
            // NewContractButton
            // 
            this.NewContractButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewContractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NewContractButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewContractButton.Location = new System.Drawing.Point(105, 266);
            this.NewContractButton.Name = "NewContractButton";
            this.NewContractButton.Size = new System.Drawing.Size(134, 66);
            this.NewContractButton.TabIndex = 3;
            this.NewContractButton.Text = "Nuevo contrato";
            this.NewContractButton.UseVisualStyleBackColor = false;
            this.NewContractButton.Click += new System.EventHandler(this.CreateNewContractClick);
            // 
            // AddTripToTruckButton
            // 
            this.AddTripToTruckButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddTripToTruckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddTripToTruckButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTripToTruckButton.Location = new System.Drawing.Point(245, 193);
            this.AddTripToTruckButton.Name = "AddTripToTruckButton";
            this.AddTripToTruckButton.Size = new System.Drawing.Size(134, 66);
            this.AddTripToTruckButton.TabIndex = 2;
            this.AddTripToTruckButton.Text = "Añadir viaje a camión";
            this.AddTripToTruckButton.UseVisualStyleBackColor = false;
            this.AddTripToTruckButton.Click += new System.EventHandler(this.AddTripToTruckClick);
            // 
            // AddCrateToTripButton
            // 
            this.AddCrateToTripButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCrateToTripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddCrateToTripButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCrateToTripButton.Location = new System.Drawing.Point(245, 266);
            this.AddCrateToTripButton.Name = "AddCrateToTripButton";
            this.AddCrateToTripButton.Size = new System.Drawing.Size(134, 66);
            this.AddCrateToTripButton.TabIndex = 4;
            this.AddCrateToTripButton.Text = "Añadir caja a camión";
            this.AddCrateToTripButton.UseVisualStyleBackColor = false;
            this.AddCrateToTripButton.Click += new System.EventHandler(this.AddCrateToTripClick);
            // 
            // TripsOfaTruckButton
            // 
            this.TripsOfaTruckButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TripsOfaTruckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TripsOfaTruckButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TripsOfaTruckButton.Location = new System.Drawing.Point(245, 338);
            this.TripsOfaTruckButton.Name = "TripsOfaTruckButton";
            this.TripsOfaTruckButton.Size = new System.Drawing.Size(134, 66);
            this.TripsOfaTruckButton.TabIndex = 6;
            this.TripsOfaTruckButton.Text = "Viajes de camión";
            this.TripsOfaTruckButton.UseVisualStyleBackColor = false;
            this.TripsOfaTruckButton.Click += new System.EventHandler(this.TripsOfaTruckButtonClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::TarongISW.GUI.Properties.Resources.iconaISW;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(142, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 124);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "TarongISWApp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quatrebits";
            // 
            // TarongISWApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TripsOfaTruckButton);
            this.Controls.Add(this.AddCrateToTripButton);
            this.Controls.Add(this.AddTripToTruckButton);
            this.Controls.Add(this.NewContractButton);
            this.Controls.Add(this.InicializarBDButton);
            this.Controls.Add(this.NewGroupButton);
            this.Name = "TarongISWApp";
            this.Text = "TarongISWApp";
            this.Load += new System.EventHandler(this.TarongISWApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGroupButton;
        private System.Windows.Forms.Button InicializarBDButton;
        private System.Windows.Forms.Button NewContractButton;
        private System.Windows.Forms.Button AddTripToTruckButton;
        private System.Windows.Forms.Button AddCrateToTripButton;
        private System.Windows.Forms.Button TripsOfaTruckButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

