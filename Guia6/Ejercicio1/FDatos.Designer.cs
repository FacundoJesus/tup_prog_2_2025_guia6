namespace Ejercicio1
{
    partial class FDatos
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            rbFisica = new RadioButton();
            rbJuridica = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            tbNombre = new TextBox();
            tbCUIT = new TextBox();
            lbNombreExcept = new Label();
            lbCuitExcept = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbCuitExcept);
            groupBox1.Controls.Add(lbNombreExcept);
            groupBox1.Controls.Add(tbCUIT);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Persona";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 89);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "CUIT:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbJuridica);
            groupBox2.Controls.Add(rbFisica);
            groupBox2.Location = new Point(68, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 66);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Persona";
            // 
            // rbFisica
            // 
            rbFisica.AutoSize = true;
            rbFisica.Location = new Point(35, 28);
            rbFisica.Name = "rbFisica";
            rbFisica.Size = new Size(54, 19);
            rbFisica.TabIndex = 0;
            rbFisica.TabStop = true;
            rbFisica.Text = "Física";
            rbFisica.UseVisualStyleBackColor = true;
            // 
            // rbJuridica
            // 
            rbJuridica.AutoSize = true;
            rbJuridica.Location = new Point(117, 28);
            rbJuridica.Name = "rbJuridica";
            rbJuridica.Size = new Size(65, 19);
            rbJuridica.TabIndex = 1;
            rbJuridica.TabStop = true;
            rbJuridica.Text = "Jurídica";
            rbJuridica.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(48, 234);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(205, 234);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(80, 27);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(174, 23);
            tbNombre.TabIndex = 3;
            // 
            // tbCUIT
            // 
            tbCUIT.Location = new Point(80, 81);
            tbCUIT.Name = "tbCUIT";
            tbCUIT.Size = new Size(174, 23);
            tbCUIT.TabIndex = 4;
            // 
            // lbNombreExcept
            // 
            lbNombreExcept.BackColor = SystemColors.ActiveCaption;
            lbNombreExcept.Location = new Point(80, 53);
            lbNombreExcept.Name = "lbNombreExcept";
            lbNombreExcept.Size = new Size(170, 20);
            lbNombreExcept.TabIndex = 5;
            // 
            // lbCuitExcept
            // 
            lbCuitExcept.BackColor = SystemColors.ActiveCaption;
            lbCuitExcept.Location = new Point(80, 107);
            lbCuitExcept.Name = "lbCuitExcept";
            lbCuitExcept.Size = new Size(170, 20);
            lbCuitExcept.TabIndex = 6;
            // 
            // FDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 267);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "FDatos";
            Text = "Datos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        public Label lbCuitExcept;
        public Label lbNombreExcept;
        public TextBox tbCUIT;
        public TextBox tbNombre;
        private GroupBox groupBox2;
        public RadioButton rbJuridica;
        public RadioButton rbFisica;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}