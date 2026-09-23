namespace Ucu.Poo.RideShare
//Conductor de UcuRide. 
//Por defecto de tipo comun: solo lleva un pasajero. 
//Clase base de la clase mas especifica PoolDriver que lleva mas pasajeros.
{
    public class Driver : Person
    //inicializa una nueva instancia de driver
    // usa los atributos de su clase base y usa el constructor para llamrlas y agregar las cosas especificas de driver.
    {
        public Driver(
            string nombre,
            string apellido,
            string ci,
            string fotoPath,
            double calificacionDriver,
            string vehiculo,
            string bio)
            : base(nombre, apellido, ci, fotoPath)
        {
            this.CalificacionDriver = calificacionDriver;
            this.Vehiculo = vehiculo;
            this.Bio = bio;
        }

        public double CalificacionDriver { get; private set; }

        public string Vehiculo { get; private set; }

        public string Bio { get; private set; }

        public override string Welcome()
        //mensaje de bienvenida welcome de driver 
        {
            return "¡Nuevo conductor en UcuRide! " + this.Nombre + " " + this.Apellido +
                " (" + this.Vehiculo + "). " + this.Bio;
        }
    }
}
