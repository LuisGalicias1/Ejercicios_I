namespace Ejercicios_I
{
    public partial class Form1 : Alumno
    {
        List<Alumno> alumnos = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
        }
 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            {
                Nombre = txtNombre.Text;
                Control = txtControl.Text;
                Carrera = txtCarrera.Text;
                Semestre = Convert.ToInt32(txtSemestre.Text);
                Promedio = Convert.ToInt32(txtPromedio.Text);
            }
            alumnos.Add(alumno);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
}
