namespace Ucu.Poo.RideShare 
//Representa a una persona registrada en UcuRide.
//Clase base de : Driver y Passenger.
{
    public abstract class Person
    {
        protected Person(string nombre, string apellido, string ci, string fotoPath)
        //inicializa una nueva instancia de person. 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Ci = ci;
            this.FotoPath = fotoPath;
        }

        public string Nombre { get; private set; }

        public string Apellido { get; private set; }

        public string Ci { get; private set; }

        public string FotoPath { get; private set; }
         
        // Hace el mensaje de bienvenida que se publica en discord cuando alguien se registra.
        //Cada tipo de person tiene datos especificos en su mensaje por eso abstract.
        public abstract string Welcome();
    }
}