namespace ClassLibrary1
{
    public class Carta
    {
        private string cara; // Cara de la carta
        private string palo; // Palo de la carta 

        //El constructor con dos parametros inicializa la cara y el palo de la carta 
        public Carta(string caraCarta, string paloCarta)
        {
            cara = caraCarta;
            palo = paloCarta;
        } // fin del constructor de Carta con dos parametros

        //devuelve representacion de cadena del objeto Carta
        public override string ToString()
        {
            return cara + "de" + palo;
        }
    }
}
