
namespace Ejercicios_I
{
    internal class Contenedor
    {
        List<Alumno> alumnos;
        public Contenedor()
        {
         alumnos = new List<Alumno>();           
        }

        public void Agregar (Alumno a)
        {
            alumnos.Add(a);
        }

    }
}
