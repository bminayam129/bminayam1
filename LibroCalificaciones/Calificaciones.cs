//Fig. 4.1 LibroCalificaciones.cs
//Declaracion de una clase con un metodo. 

namespace Calificaciones
{
    public class LibroCalificaciones
    {
        private string nombreCurso;//nombre del curso para este LibroCalificaciones

        //Propiedad para obtener (get) y establecer (Set) el nombre del curso

       

        //el constructor inicializa nombreCurso con el objeto string suministrado como argumento 
        public LibroCalificaciones(string nombre)
        {
            NombreCurso = nombre;

        }
        public string NombreCurso
        {
            get
            {
                return nombreCurso;
                //fin Get

            }
            set
            {
                nombreCurso = value;
            }//fin de set

        }//Fin de la propiedad NombreCurso

        //muestra un mensaje de bienvenida para el usuario de LibroCalificaciones
        public void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido al libro de calificaciones para\n{0}!", nombreCurso);
        }//fin del metodo MostrarMensaje

    }//fin de la clase LibroCalificaciones
}
