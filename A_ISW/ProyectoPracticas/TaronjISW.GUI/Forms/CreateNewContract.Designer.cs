
namespace TarongISW.GUI.Forms
{
    partial class CreateNewContract
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkNewPerson = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.ssnText = new System.Windows.Forms.TextBox();
            this.cuentaText = new System.Windows.Forms.TextBox();
            this.dniText = new System.Windows.Forms.TextBox();
            this.salarioText = new System.Windows.Forms.TextBox();
            this.inicioDatePicker = new System.Windows.Forms.DateTimePicker();
            this.finDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.permanenteRButton = new System.Windows.Forms.RadioButton();
            this.temporalRButton = new System.Windows.Forms.RadioButton();
            this.finCheckBox = new System.Windows.Forms.CheckBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(178, 20);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "Crear nuevo contrato";
            // 
            // dniLabel
            // 
            this.dniLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dniLabel.AutoSize = true;
            this.dniLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniLabel.Location = new System.Drawing.Point(109, 245);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(34, 16);
            this.dniLabel.TabIndex = 20;
            this.dniLabel.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cuenta de banco:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "SSN:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha de finalización:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha de inicio:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Salario:";
            // 
            // linkNewPerson
            // 
            this.linkNewPerson.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkNewPerson.AutoSize = true;
            this.linkNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNewPerson.LinkColor = System.Drawing.Color.DarkOrange;
            this.linkNewPerson.Location = new System.Drawing.Point(109, 141);
            this.linkNewPerson.Name = "linkNewPerson";
            this.linkNewPerson.Size = new System.Drawing.Size(109, 16);
            this.linkNewPerson.TabIndex = 0;
            this.linkNewPerson.TabStop = true;
            this.linkNewPerson.Text = "Añadir persona...";
            this.linkNewPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newPersonLinkClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(109, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(385, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Antes de crear un contrato la persona debe haber sido añadida";
            // 
            // ssnText
            // 
            this.ssnText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ssnText.Location = new System.Drawing.Point(251, 309);
            this.ssnText.Name = "ssnText";
            this.ssnText.Size = new System.Drawing.Size(100, 20);
            this.ssnText.TabIndex = 5;
            this.ssnText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cuentaText
            // 
            this.cuentaText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cuentaText.Location = new System.Drawing.Point(251, 275);
            this.cuentaText.Name = "cuentaText";
            this.cuentaText.Size = new System.Drawing.Size(124, 20);
            this.cuentaText.TabIndex = 4;
            // 
            // dniText
            // 
            this.dniText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dniText.Location = new System.Drawing.Point(251, 245);
            this.dniText.Name = "dniText";
            this.dniText.Size = new System.Drawing.Size(100, 20);
            this.dniText.TabIndex = 3;
            // 
            // salarioText
            // 
            this.salarioText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salarioText.Location = new System.Drawing.Point(251, 411);
            this.salarioText.Name = "salarioText";
            this.salarioText.Size = new System.Drawing.Size(100, 20);
            this.salarioText.TabIndex = 9;
            // 
            // inicioDatePicker
            // 
            this.inicioDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inicioDatePicker.Location = new System.Drawing.Point(251, 340);
            this.inicioDatePicker.Name = "inicioDatePicker";
            this.inicioDatePicker.Size = new System.Drawing.Size(200, 20);
            this.inicioDatePicker.TabIndex = 6;
            this.inicioDatePicker.ValueChanged += new System.EventHandler(this.inicioDatePicker_ValueChanged);
            // 
            // finDatePicker
            // 
            this.finDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.finDatePicker.Location = new System.Drawing.Point(251, 374);
            this.finDatePicker.Name = "finDatePicker";
            this.finDatePicker.Size = new System.Drawing.Size(200, 20);
            this.finDatePicker.TabIndex = 7;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.Location = new System.Drawing.Point(497, 526);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 11;
            this.cancelarButton.Text = "Volver";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarClick);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aceptarButton.Location = new System.Drawing.Point(416, 526);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 23);
            this.aceptarButton.TabIndex = 10;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarClick);
            // 
            // permanenteRButton
            // 
            this.permanenteRButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.permanenteRButton.AutoSize = true;
            this.permanenteRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permanenteRButton.Location = new System.Drawing.Point(112, 172);
            this.permanenteRButton.Name = "permanenteRButton";
            this.permanenteRButton.Size = new System.Drawing.Size(185, 20);
            this.permanenteRButton.TabIndex = 1;
            this.permanenteRButton.TabStop = true;
            this.permanenteRButton.Text = "Crear contrato permanente";
            this.permanenteRButton.UseVisualStyleBackColor = true;
            this.permanenteRButton.CheckedChanged += new System.EventHandler(this.permanenteChange);
            // 
            // temporalRButton
            // 
            this.temporalRButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temporalRButton.AutoSize = true;
            this.temporalRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temporalRButton.Location = new System.Drawing.Point(112, 196);
            this.temporalRButton.Name = "temporalRButton";
            this.temporalRButton.Size = new System.Drawing.Size(166, 20);
            this.temporalRButton.TabIndex = 2;
            this.temporalRButton.TabStop = true;
            this.temporalRButton.Text = "Crear contrato temporal";
            this.temporalRButton.UseVisualStyleBackColor = true;
            this.temporalRButton.CheckedChanged += new System.EventHandler(this.temporalChange);
            // 
            // finCheckBox
            // 
            this.finCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.finCheckBox.AutoSize = true;
            this.finCheckBox.Checked = true;
            this.finCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.finCheckBox.Location = new System.Drawing.Point(457, 381);
            this.finCheckBox.Name = "finCheckBox";
            this.finCheckBox.Size = new System.Drawing.Size(15, 14);
            this.finCheckBox.TabIndex = 8;
            this.finCheckBox.UseVisualStyleBackColor = true;
            this.finCheckBox.CheckedChanged += new System.EventHandler(this.finCheckBox_CheckedChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(13, 446);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            this.statusLabel.TabIndex = 39;
            // 
            // CreateNewContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.finCheckBox);
            this.Controls.Add(this.temporalRButton);
            this.Controls.Add(this.permanenteRButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.finDatePicker);
            this.Controls.Add(this.inicioDatePicker);
            this.Controls.Add(this.salarioText);
            this.Controls.Add(this.dniText);
            this.Controls.Add(this.cuentaText);
            this.Controls.Add(this.ssnText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkNewPerson);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.titleLabel);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "CreateNewContract";
            this.Text = "CreateNewContract";
            this.Load += new System.EventHandler(this.CreateNewContract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkNewPerson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ssnText;
        private System.Windows.Forms.TextBox cuentaText;
        private System.Windows.Forms.TextBox dniText;
        private System.Windows.Forms.TextBox salarioText;
        private System.Windows.Forms.DateTimePicker inicioDatePicker;
        private System.Windows.Forms.DateTimePicker finDatePicker;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.RadioButton permanenteRButton;
        private System.Windows.Forms.RadioButton temporalRButton;
        private System.Windows.Forms.CheckBox finCheckBox;
        private System.Windows.Forms.Label statusLabel;
    }
}