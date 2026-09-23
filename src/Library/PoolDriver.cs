namespace Ucu.Poo.RideShare
{
    //conductor tipo pool: lleva multiples pasajeros, cada uno establece capacidad maxima. 
    public class PoolDriver : Driver
    {
        //inicializa nueva instancia de PoolDriver 
        public PoolDriver(
            string nombre,
            string apellido,
            string ci,
            string fotoPath,
            double calificacionDriver,
            string vehiculo,
            string bio,
            int maxCapacity)
            : base(nombre, apellido, ci, fotoPath, calificacionDriver, vehiculo, bio)
        {
            this.MaxCapacity = maxCapacity;
        }

        public int MaxCapacity { get; private set; }

        public override string Welcome()
        //Hace mensaje de bienvenida para nuevo conductor  y al ser pool especifica la capacidad maxima.
        {
            return base.Welcome() + " Viaja en modalidad Pool, hasta " +
                this.MaxCapacity + " pasajeros por viaje.";
        }
    }
}
