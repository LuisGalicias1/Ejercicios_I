
namespace Ejercicio_IV
{
    partial class FormularioTienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioTienda));
            lblProducto = new Label();
            lblValor = new Label();
            lblInfo = new Label();
            txtProducto = new TextBox();
            txtValor = new TextBox();
            txtInfo = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            pnlOpciones = new Panel();
            btnSalir = new Button();
            pnlIngresarTexto = new Panel();
            pnlImagen = new Panel();
            pbLogo = new PictureBox();
            dgvProductos = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Info = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            pnlOpciones.SuspendLayout();
            pnlIngresarTexto.SuspendLayout();
            pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BackColor = SystemColors.Info;
            lblProducto.BorderStyle = BorderStyle.Fixed3D;
            lblProducto.Location = new Point(13, 9);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(58, 17);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            lblProducto.Click += lblProducto_Click;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.BackColor = SystemColors.Info;
            lblValor.BorderStyle = BorderStyle.Fixed3D;
            lblValor.Location = new Point(13, 73);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(35, 17);
            lblValor.TabIndex = 1;
            lblValor.Text = "Valor";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = SystemColors.Info;
            lblInfo.BorderStyle = BorderStyle.Fixed3D;
            lblInfo.Location = new Point(228, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(74, 17);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "Informacion";
            lblInfo.Click += lblInfo_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(13, 104);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(183, 23);
            txtProducto.TabIndex = 3;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(13, 38);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(183, 23);
            txtValor.TabIndex = 4;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(228, 36);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(264, 91);
            txtInfo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Info;
            btnAgregar.Location = new Point(3, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 36);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Info;
            btnActualizar.Location = new Point(143, 13);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(136, 38);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Info;
            btnEliminar.Location = new Point(3, 82);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 44);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.Info;
            btnNuevo.Location = new Point(143, 82);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(136, 44);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // pnlOpciones
            // 
            pnlOpciones.Controls.Add(btnSalir);
            pnlOpciones.Controls.Add(btnAgregar);
            pnlOpciones.Controls.Add(btnActualizar);
            pnlOpciones.Controls.Add(btnNuevo);
            pnlOpciones.Controls.Add(btnEliminar);
            pnlOpciones.Location = new Point(12, 234);
            pnlOpciones.Name = "pnlOpciones";
            pnlOpciones.Size = new Size(282, 204);
            pnlOpciones.TabIndex = 11;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ScrollBar;
            btnSalir.BackgroundImageLayout = ImageLayout.Center;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = SystemColors.Highlight;
            btnSalir.Location = new Point(76, 144);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 44);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnlIngresarTexto
            // 
            pnlIngresarTexto.Controls.Add(lblProducto);
            pnlIngresarTexto.Controls.Add(txtValor);
            pnlIngresarTexto.Controls.Add(txtInfo);
            pnlIngresarTexto.Controls.Add(lblValor);
            pnlIngresarTexto.Controls.Add(lblInfo);
            pnlIngresarTexto.Controls.Add(txtProducto);
            pnlIngresarTexto.Location = new Point(290, 12);
            pnlIngresarTexto.Name = "pnlIngresarTexto";
            pnlIngresarTexto.Size = new Size(498, 140);
            pnlIngresarTexto.TabIndex = 10;
            // 
            // pnlImagen
            // 
            pnlImagen.Controls.Add(pbLogo);
            pnlImagen.Location = new Point(12, 12);
            pnlImagen.Name = "pnlImagen";
            pnlImagen.Size = new Size(241, 174);
            pnlImagen.TabIndex = 12;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(0, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(241, 174);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // dgvProductos
            // 
            dgvProductos.BorderStyle = BorderStyle.Fixed3D;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Producto, Info, Valor });
            dgvProductos.Location = new Point(414, 190);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(344, 260);
            dgvProductos.TabIndex = 13;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Info
            // 
            Info.HeaderText = "Informacion";
            Info.Name = "Info";
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductos);
            Controls.Add(pnlImagen);
            Controls.Add(pnlIngresarTexto);
            Controls.Add(pnlOpciones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Form1";
            pnlOpciones.ResumeLayout(false);
            pnlIngresarTexto.ResumeLayout(false);
            pnlIngresarTexto.PerformLayout();
            pnlImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblProducto;
        private Label lblValor;
        private Label lblInfo;
        private TextBox txtProducto;
        private TextBox txtValor;
        private TextBox txtInfo;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnNuevo;
        private Panel pnlOpciones;
        private Panel pnlIngresarTexto;
        private Panel pnlImagen;
        private PictureBox pbLogo;
        private Button btnSalir;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Info;
        private DataGridViewTextBoxColumn Valor;
    }
}
