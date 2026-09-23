namespace Ucu.Poo.RideShare
//administra los conductores y pasajeros registrados en UcuRide
// publica en disord cada vez que se registra alguien nuevo
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Ucu.Poo.Discord;

    public class UcuRideShare
    {
        private readonly List<Driver> drivers;
        private readonly List<Passenger> passengers;
        private readonly DiscordClient discordClient;
        private readonly ulong channelId;

        public UcuRideShare(DiscordClient discordClient, ulong channelId)
        {
            this.drivers = new List<Driver>();
            this.passengers = new List<Passenger>();
            this.discordClient = discordClient;
            this.channelId = channelId;
        }

        public IReadOnlyList<Driver> Drivers => this.drivers;

        public IReadOnlyList<Passenger> Passengers => this.passengers;

        public async Task AddDriverAsync(Driver driver)
        {
            this.drivers.Add(driver);
            await this.PublishAsync(driver);
        }

        public async Task AddPassengerAsync(Passenger passenger)
        {
            this.passengers.Add(passenger);
            await this.PublishAsync(passenger);
        }
        //Publica en el canal de Discord la foto y el mensaje de bienvenida
        // de una persona recién registrada. Al recibir "Person"
        // como parámetro, se invoca la versión de"Person.Welcome"
        // específica del tipo real del objeto (Driver, PoolDriver o Passenger)
        private async Task PublishAsync(Person person)
        {
            await this.discordClient.SendImageAsync(this.channelId, person.FotoPath, person.Welcome());
        }
    }
}