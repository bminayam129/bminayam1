namespace Punto_en_el_plano
{
    public class Punto
    {

        private double x;
        private double y;

        //Metodo para cargar los valores de x e y 

        public void CargarValores(double valorX, double valorY)
        {
            x = valorX;
            y = valorY;
        }

        public string DeterminarCuadrante()
        {
            if (x > 0 && y > 0)
            {
                return "El punto se encuentra en el primer cuadrante.";
            }
            else if (x < 0 && y > 0)
            {
                return "El punto se encuentra en el segundo cuadrante";
            }
            else if (x < 0 && y < 0)
            {
                return "El punto se encuentra en el tercenr cuadrante";

            }
            else if (x > 0 && y < 0)
            {
                return "El punto se encuentra en el cuarto cuadranet";

            }
            else if (x == 0 && y == 0)
            {
                return "El punto se encuentra en el origen";
            }
            else if (x == 0)
            {
                return "El punto se encuentra sobre el eje Y.";
            }
            else // y == 0
            {
                return "El punto se encuentra sobre el eje x.";
            }


        }
        public void ImprimirCuadrante()
        {
            Console.WriteLine(DeterminarCuadrante());
        }

    }

    class Programa
    {
        static void Main (string[] args)
        {
            Punto punto = new Punto();

            punto.CargarValores(3, -4);

            punto.ImprimirCuadrante();
        }
    }
}
