namespace Ejercicio_IV
{
    public partial class FormularioTienda : Form
    {
        int i = 1;
        int posicion;
        public FormularioTienda()
        {
            InitializeComponent();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            dgvProductos.Rows.RemoveAt(posicion);
            txtProducto.Focus();
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto, info, valor;

            producto = txtProducto.Text;
            info = txtInfo.Text;
            valor = txtValor.Text;
            dgvProductos.Rows.Add(i + "", producto, info, valor);
            i = i + 1;
            limpiar();
            txtProducto.Focus();
        }
        private void limpiar()
        {
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            txtProducto.Text = "";
            txtInfo.Text = "";
            txtValor.Text = "";
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            //posicion = dgvProductos.CurrentRow.Index;
            //txtProducto.Text = dgvProductos[1, posicion].Value.ToString();
            //txtInfo.Text = dgvProductos[2, posicion].Value.ToString();
            //txtValor.Text = dgvProductos[3, posicion].Value.ToString();
            //btnAgregar.Enabled = false;
            //btnActualizar.Enabled = true;
            //btnEliminar.Enabled = true;
            //txtProducto.Focus();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string producto, info, valor;

            producto = txtProducto.Text;
            info = txtInfo.Text;
            valor = txtValor.Text;
            dgvProductos[1, posicion].Value = txtProducto.Text;
            dgvProductos[2, posicion].Value = txtInfo.Text;
            dgvProductos[3, posicion].Value = txtValor.Text;


            txtProducto.Focus();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            btnAgregar.Enabled = true;
            txtProducto.Focus();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvProductos.CurrentRow.Index;
            txtProducto.Text = dgvProductos[1, posicion].Value.ToString();
            txtInfo.Text = dgvProductos[2, posicion].Value.ToString();
            txtValor.Text = dgvProductos[3, posicion].Value.ToString();
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            txtProducto.Focus();
        }
    }
}
