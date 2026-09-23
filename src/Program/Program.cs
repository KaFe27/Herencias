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

            /*
            Mira a continuación cómo enviar mensajes y archivos a Discord;
            deberás hacer lo mismo en las clases y métodos adecuados de tu
            solución. Luego puedes comentar o eliminar este código.
            */

            Console.WriteLine("Conectando con Discord...");
            await discord.LoginAsync(botToken);
            await discord.SendMessageAsync(channelId, "¡Hola desde C#!");
            await discord.SendImageAsync(channelId, "bill.jpg", "Mira esta imagen");
            Console.WriteLine("Mensajes enviados.");

            /*
            En este método deberás mostrar un ejemplo de funcionamiento de tu
            solución. A continuación te planteamos un ejemplo de como hacerlo.
            Esto no significa que te limites a hacer solamente esto, ¡debes
            pensar en grande!

            User pasajero1 = ...
            User pasajero2 = ...
            User pasajero3 = ...
            User conductor1 = ...
            User conductorPool1 = ...
            UcuRideShare rideShare = new UcuRideShare()

            rideShare.Add(conductor1)
            Se publica en Discord un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Discord un nuevo conductor!

            rideShare.Add(pasajero1)
            Se publica en Discord nuevo registro de pasajero!

            rideShare.Add(pasajero2)
            Se publica en Discord nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Discord nuevo registro de pasajero!
            */
        }
    }
}
