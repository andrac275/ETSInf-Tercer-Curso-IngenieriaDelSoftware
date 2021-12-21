
namespace TarongISW.GUI.Forms
{
    partial class AddTripToTruck
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
            this.label6 = new System.Windows.Forms.Label();
            this.ParcelExitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CoopArrivalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HHUnloadTime = new System.Windows.Forms.TextBox();
            this.MMUnloadTime = new System.Windows.Forms.TextBox();
            this.AñadirViaje1Button = new System.Windows.Forms.Button();
            this.TrucksComboBox = new System.Windows.Forms.ComboBox();
            this.trucksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trucksDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.VolverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trucksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trucksDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Añadir viaje a camión";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matrícula del camión:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de salida de la parcela:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de llegada a la cooperativa:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hora de descarga (HH:MM):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ParcelExitDateTimePicker
            // 
            this.ParcelExitDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParcelExitDateTimePicker.Location = new System.Drawing.Point(304, 196);
            this.ParcelExitDateTimePicker.Name = "ParcelExitDateTimePicker";
            this.ParcelExitDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ParcelExitDateTimePicker.TabIndex = 10;
            // 
            // CoopArrivalDateTimePicker
            // 
            this.CoopArrivalDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CoopArrivalDateTimePicker.Location = new System.Drawing.Point(304, 238);
            this.CoopArrivalDateTimePicker.Name = "CoopArrivalDateTimePicker";
            this.CoopArrivalDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.CoopArrivalDateTimePicker.TabIndex = 11;
            // 
            // HHUnloadTime
            // 
            this.HHUnloadTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HHUnloadTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HHUnloadTime.Location = new System.Drawing.Point(304, 276);
            this.HHUnloadTime.Name = "HHUnloadTime";
            this.HHUnloadTime.Size = new System.Drawing.Size(37, 20);
            this.HHUnloadTime.TabIndex = 12;
            this.HHUnloadTime.Text = "00";
            this.HHUnloadTime.TextChanged += new System.EventHandler(this.HHUnloadTime_TextChanged);
            // 
            // MMUnloadTime
            // 
            this.MMUnloadTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MMUnloadTime.Location = new System.Drawing.Point(366, 276);
            this.MMUnloadTime.Name = "MMUnloadTime";
            this.MMUnloadTime.Size = new System.Drawing.Size(37, 20);
            this.MMUnloadTime.TabIndex = 13;
            this.MMUnloadTime.Text = "00";
            // 
            // AñadirViaje1Button
            // 
            this.AñadirViaje1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AñadirViaje1Button.Location = new System.Drawing.Point(416, 426);
            this.AñadirViaje1Button.Name = "AñadirViaje1Button";
            this.AñadirViaje1Button.Size = new System.Drawing.Size(75, 23);
            this.AñadirViaje1Button.TabIndex = 14;
            this.AñadirViaje1Button.Text = "Añadir";
            this.AñadirViaje1Button.UseVisualStyleBackColor = true;
            this.AñadirViaje1Button.Click += new System.EventHandler(this.AñadirViaje1Click);
            // 
            // TrucksComboBox
            // 
            this.TrucksComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrucksComboBox.FormattingEnabled = true;
            this.TrucksComboBox.Location = new System.Drawing.Point(304, 164);
            this.TrucksComboBox.Name = "TrucksComboBox";
            this.TrucksComboBox.Size = new System.Drawing.Size(121, 21);
            this.TrucksComboBox.TabIndex = 19;
            // 
            // trucksBindingSource
            // 
            this.trucksBindingSource.DataMember = "Trucks";
            this.trucksBindingSource.DataSource = this.trucksDataSetBindingSource;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(347, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = ":";
            // 
            // VolverButton
            // 
            this.VolverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolverButton.Location = new System.Drawing.Point(497, 426);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(75, 23);
            this.VolverButton.TabIndex = 21;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverClick);
            // 
            // AddTripToTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrucksComboBox);
            this.Controls.Add(this.AñadirViaje1Button);
            this.Controls.Add(this.MMUnloadTime);
            this.Controls.Add(this.HHUnloadTime);
            this.Controls.Add(this.CoopArrivalDateTimePicker);
            this.Controls.Add(this.ParcelExitDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "AddTripToTruck";
            this.Text = "AddTripToTruck";
            this.Load += new System.EventHandler(this.AddTripToTruck_Load);
            //((System.ComponentModel.ISupportInitialize)(this.trucksBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.trucksDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ParcelExitDateTimePicker;
        private System.Windows.Forms.DateTimePicker CoopArrivalDateTimePicker;
        private System.Windows.Forms.TextBox HHUnloadTime;
        private System.Windows.Forms.TextBox MMUnloadTime;
        private System.Windows.Forms.Button AñadirViaje1Button;
        private System.Windows.Forms.ComboBox TrucksComboBox;
        private System.Windows.Forms.BindingSource trucksDataSetBindingSource;
        private System.Windows.Forms.BindingSource trucksBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button VolverButton;
    }
}