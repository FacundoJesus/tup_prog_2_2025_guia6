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
            lbCuitExcept = new Label();
            lbNombreExcept = new Label();
            tbCUIT = new TextBox();
            tbNombre = new TextBox();
            groupBox2 = new GroupBox();
            rbJuridica = new RadioButton();
            rbFisica = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
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
            groupBox1.Size = new Size(280, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Persona";
            // 
            // lbCuitExcept
            // 
            lbCuitExcept.BackColor = SystemColors.ActiveCaption;
            lbCuitExcept.Location = new Point(81, 157);
            lbCuitExcept.Name = "lbCuitExcept";
            lbCuitExcept.Size = new Size(173, 55);
            lbCuitExcept.TabIndex = 6;
            // 
            // lbNombreExcept
            // 
            lbNombreExcept.BackColor = SystemColors.ActiveCaption;
            lbNombreExcept.Location = new Point(80, 53);
            lbNombreExcept.Name = "lbNombreExcept";
            lbNombreExcept.Size = new Size(174, 55);
            lbNombreExcept.TabIndex = 5;
            // 
            // tbCUIT
            // 
            tbCUIT.Location = new Point(80, 131);
            tbCUIT.Name = "tbCUIT";
            tbCUIT.Size = new Size(174, 23);
            tbCUIT.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(80, 27);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(174, 23);
            tbNombre.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbJuridica);
            groupBox2.Controls.Add(rbFisica);
            groupBox2.Location = new Point(6, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 66);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Persona";
            // 
            // rbJuridica
            // 
            rbJuridica.AutoSize = true;
            rbJuridica.Location = new Point(117, 28);
            rbJuridica.Name = "rbJuridica";
            rbJuridica.Size = new Size(65, 19);
            rbJuridica.TabIndex = 1;
            rbJuridica.Text = "Jurídica";
            rbJuridica.UseVisualStyleBackColor = true;
            // 
            // rbFisica
            // 
            rbFisica.AutoSize = true;
            rbFisica.Location = new Point(35, 28);
            rbFisica.Name = "rbFisica";
            rbFisica.Size = new Size(54, 19);
            rbFisica.TabIndex = 0;
            rbFisica.Text = "Física";
            rbFisica.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 139);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "CUIT:";
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
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(31, 305);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(188, 305);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 340);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "FDatos";
            StartPosition = FormStartPosition.CenterScreen;
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