
namespace TarongISW.GUI.Forms
{
    partial class ListTripsOfaTruck
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InitialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.TripsListBox = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trucksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TrucksComboBox = new System.Windows.Forms.ComboBox();
            this.VolverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trucksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comprobar viajes de un camión";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(84, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matrícula del camión:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(84, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha inicial:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(84, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha final:";
            // 
            // InitialDateTimePicker
            // 
            this.InitialDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InitialDateTimePicker.Location = new System.Drawing.Point(231, 143);
            this.InitialDateTimePicker.Name = "InitialDateTimePicker";
            this.InitialDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.InitialDateTimePicker.TabIndex = 1;
            // 
            // FinalDateTimePicker
            // 
            this.FinalDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinalDateTimePicker.Location = new System.Drawing.Point(231, 182);
            this.FinalDateTimePicker.Name = "FinalDateTimePicker";
            this.FinalDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FinalDateTimePicker.TabIndex = 2;
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultarButton.Location = new System.Drawing.Point(566, 426);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(75, 23);
            this.ConsultarButton.TabIndex = 4;
            this.ConsultarButton.Text = "Consultar";
            this.ConsultarButton.UseVisualStyleBackColor = true;
            this.ConsultarButton.Click += new System.EventHandler(this.ConsultarClick);
            // 
            // TripsListBox
            // 
            this.TripsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TripsListBox.FormattingEnabled = true;
            this.TripsListBox.Location = new System.Drawing.Point(87, 218);
            this.TripsListBox.Name = "TripsListBox";
            this.TripsListBox.Size = new System.Drawing.Size(563, 134);
            this.TripsListBox.TabIndex = 3;
            this.TripsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // trucksBindingSource
            // 
            this.trucksBindingSource.DataMember = "Trucks";
            // 
            // TrucksComboBox
            // 
            this.TrucksComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrucksComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TrucksComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TrucksComboBox.FormattingEnabled = true;
            this.TrucksComboBox.Location = new System.Drawing.Point(231, 108);
            this.TrucksComboBox.Name = "TrucksComboBox";
            this.TrucksComboBox.Size = new System.Drawing.Size(133, 21);
            this.TrucksComboBox.TabIndex = 0;
            this.TrucksComboBox.SelectedIndexChanged += new System.EventHandler(this.TrucksComboBox_SelectedIndexChanged);
            // 
            // VolverButton
            // 
            this.VolverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolverButton.Location = new System.Drawing.Point(647, 426);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(75, 23);
            this.VolverButton.TabIndex = 5;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverClick);
            // 
            // ListTripsOfaTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.TrucksComboBox);
            this.Controls.Add(this.TripsListBox);
            this.Controls.Add(this.ConsultarButton);
            this.Controls.Add(this.FinalDateTimePicker);
            this.Controls.Add(this.InitialDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "ListTripsOfaTruck";
            this.Text = "ListTripsOfaTruck";
            this.Load += new System.EventHandler(this.ListTripsOfaTruck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trucksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker InitialDateTimePicker;
        private System.Windows.Forms.DateTimePicker FinalDateTimePicker;
        private System.Windows.Forms.Button ConsultarButton;
        private System.Windows.Forms.ListBox TripsListBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource trucksBindingSource;
        private System.Windows.Forms.ComboBox TrucksComboBox;
        private System.Windows.Forms.Button VolverButton;
    }
}