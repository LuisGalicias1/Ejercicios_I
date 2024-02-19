namespace Ejercicios_I
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblControl = new Label();
            lblCarrera = new Label();
            lblSemestre = new Label();
            lblPromedio = new Label();
            txtControl = new TextBox();
            txtNombre = new TextBox();
            txtCarrera = new TextBox();
            txtSemestre = new TextBox();
            txtPromedio = new TextBox();
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblControl
            // 
            lblControl.AutoSize = true;
            lblControl.Location = new Point(14, 78);
            lblControl.Name = "lblControl";
            lblControl.Size = new Size(69, 15);
            lblControl.TabIndex = 1;
            lblControl.Text = "No. Control";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(14, 148);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 2;
            lblCarrera.Text = "Carrera";
            // 
            // lblSemestre
            // 
            lblSemestre.AutoSize = true;
            lblSemestre.Location = new Point(14, 215);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(55, 15);
            lblSemestre.TabIndex = 3;
            lblSemestre.Text = "Semestre";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(14, 293);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(59, 15);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "Promedio";
            // 
            // txtControl
            // 
            txtControl.Location = new Point(12, 111);
            txtControl.Name = "txtControl";
            txtControl.Size = new Size(102, 23);
            txtControl.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(14, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(14, 175);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(252, 23);
            txtCarrera.TabIndex = 7;
            // 
            // txtSemestre
            // 
            txtSemestre.Location = new Point(12, 243);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.Size = new Size(100, 23);
            txtSemestre.TabIndex = 8;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(14, 325);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(100, 23);
            txtPromedio.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(301, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(465, 387);
            dataGridView1.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(37, 392);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(160, 392);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(txtPromedio);
            Controls.Add(txtSemestre);
            Controls.Add(txtCarrera);
            Controls.Add(txtNombre);
            Controls.Add(txtControl);
            Controls.Add(lblPromedio);
            Controls.Add(lblSemestre);
            Controls.Add(lblCarrera);
            Controls.Add(lblControl);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblControl;
        private Label lblCarrera;
        private Label lblSemestre;
        private Label lblPromedio;
        private TextBox txtControl;
        private TextBox txtNombre;
        private TextBox txtCarrera;
        private TextBox txtSemestre;
        private TextBox txtPromedio;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnEliminar;
    }
}
