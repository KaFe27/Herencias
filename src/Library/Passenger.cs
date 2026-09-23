namespace Ucu.Poo.RideShare
{
    //representa a un pasajero de UcuRide.
    public class Passenger : Person
    //inicializa una nueva instancia de passenger.
    // usa al constructor, llama los dagtos de person y agrega los especificos de passenger.
    {
        public Passenger(
            string nombre,
            string apellido,
            string ci,
            string fotoPath,
            double calificacionPassenger)
            : base(nombre, apellido, ci, fotoPath)
        {
            this.CalificacionPassenger = calificacionPassenger;
        }

        public double CalificacionPassenger { get; private set; }

        public override string Welcome()
        //construye mensaje de bienvenida para el nuevo pasajero que se registra
        {
            return "¡Nuevo pasajero en UcuRide! " + this.Nombre + " " + this.Apellido;
        }
    }
}
