/*Eliezer, practica 15/06/2023
Learn Web Api ASP.NET Core CRUD 
1) crear una base de datos en SQL SERVER
2) crear una tabla 
3) abrir visual studio y seleccionar proyecto nuevo
referencia Link:
https://www.youtube.com/watch?v=Usj0J4rUumI
Learn Swagger link:
https://www.youtube.com/watch?v=HIfMZbzJMO8&t=380s
para llamar a Swagger directamente al ejecutar el programa
hago lo siguiente: 1)entre al archivo "launchSettings.json, 2) En el 
apartado "profiles especificamente en "IIS Express": " donde 
vea launchUrl agregue esto como parte de sus elementos
"launchUrl": "swagger ","/ <--- con esto llama directamente a 
swagger desde el browser

*/
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiGestores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
