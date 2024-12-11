//Fig. 4.2: PruebaLibroCalificaciones.cs
//Crea un objeto LibroCalificaciones y llama a su metodo MostrarMensaje


using Calificaciones;

public class PruebaLibroCalificaciones
{
    //El metodo Main comienza la ejecucion del programa
    public static void Main (string[] args)
    {
        //Crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones
        LibroCalificaciones miLibroCalificaciones1 = new LibroCalificaciones("CS101 Instruccion a la programacion en C#");

        LibroCalificaciones miLibroCalificaciones2 = new LibroCalificaciones("CS102 estructura de datos en C#");

        //muestra el valor inicial de NombreCurso
        Console.WriteLine("El nombre inicial del curso es: '{0}'\n", miLibroCalificaciones1.NombreCurso);

        Console.WriteLine("El nombre inicial del curso es: '{0}'\n", miLibroCalificaciones2.NombreCurso);

     
    }//fin de Main 
}//Fin de la clase PruebaLibroCalificaciones
