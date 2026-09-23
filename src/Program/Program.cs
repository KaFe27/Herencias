//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Ucu.Poo.Discord;

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal. En este ejercicio no cambias
        /// este método, sino <see cref="Program.MainAsync"/> que está debajo.
        /// </summary>
        public static void Main()
        {
            MainAsync().GetAwaiter().GetResult();

        }

        private static async Task MainAsync()
        {
            var botToken = Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN");
            var channelText = Environment.GetEnvironmentVariable("CHANNEL_ID");
            if (string.IsNullOrWhiteSpace(botToken) || string.IsNullOrWhiteSpace(channelText))
            {
                Console.WriteLine("Faltan las variables de entorno.");
                return;
            }

            ulong channelId = ulong.Parse(channelText);

            DiscordClient discord = new DiscordClient();

            Console.WriteLine("Conectando con Discord...");
            await discord.LoginAsync(botToken);
            UcuRideShare rideShare = new UcuRideShare(discord, channelId);

            Driver conductor1 = new Driver(
                nombre: "Rick",
                apellido: "Rodriguez",
                ci: "1.234.567-8",
                fotoPath: "rick.jpg",
                calificacionDriver: 4.5,
                vehiculo: "Fiat gris",
                bio: "Amable y cordial. 35 años.");

            PoolDriver conductorPool1 = new PoolDriver(
                nombre: "Dan",
                apellido: "Perez",
                ci: "2.345.678-9",
                fotoPath: "dan.jpg",
                calificacionDriver: 4.8,
                vehiculo: "Toyota rojo",
                bio: "Puntual y educado. 50 años.",
                maxCapacity: 4);

            Passenger pasajero1 = new Passenger(
                nombre: "Bill",
                apellido: "Gomez",
                ci: "3.456.789-1",
                fotoPath: "bill.jpg",
                calificacionPassenger: 5.0);

            await rideShare.AddDriverAsync(conductor1);
            await rideShare.AddDriverAsync(conductorPool1);
            await rideShare.AddPassengerAsync(pasajero1);
            Console.WriteLine("Registros publicados en Discord.");

            
        }
    }
}

