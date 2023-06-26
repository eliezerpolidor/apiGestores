/*Eliezer, practica 15/06/2023
Learn Web Api ASP.NET Core CRUD 

0) Antes que nada es importatisimo instalar las siguientes dependencias:
Microsoft.EntityFrameworkCore.Sq... {3.1.7}               
Swashbuckle.AspNetCore              {6.5.0}   
Microsoft.AspNetCore.Cors           {2.2.0}   
Swashbuckle.AspNetCore.Swagger      {6.5.0}   
MediatR                             {12.0.1}  
Microsoft.AspNet.WebApi.Cors        {5.3.0-preview1} 
Microsoft.AspNetCore.Mvc.Cors       {2.2.0}           
Microsoft.AspNet.Cors               {5.3.0-preview1}   
DocumentFormat.OpenXml              {2.17.1}         

1) crear una base de datos en SQL SERVER
2) crear una tabla 
3) abrir visual studio y seleccionar proyecto nuevo
referencia Link:
https://www.youtube.com/watch?v=Usj0J4rUumI
- el siguiente video me sirvio para aclarar el error de cors el video 
me ayudo a resolver el error:
https://www.youtube.com/watch?v=KK7fJTXxeeE
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
