using AWSSecretsManagerClient.Helpers;
using AWSSecretsManagerClient.Models;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

Console.WriteLine("Ejemplo Secrets Manager");

string miSecreto = await HelperSecretManager.GetSecretAsync();
Console.WriteLine(miSecreto);
//PODEMOS DAR FORMATO A NUESTRO SECRETO
KeysModel model = JsonConvert.DeserializeObject<KeysModel>(miSecreto);
Console.WriteLine("Ganador de la Champions: " + model.Champions);
//SI ESTAMOS EN UNA APP MAS COMPLEJA DONDE NECESITAMOS RECUPERAR MAS 
//DATOS Y UTILIZARLOS EN DISTINTAS CLASES, AL ESTILO DE IConfiguration
var provider =
    new ServiceCollection()
    .AddSingleton<KeysModel>()
    .BuildServiceProvider();

//RECUPERAMOS NUESTRO KEYMODEL DE LA INYECCION PARA COMPROBAR 
//QUE FUNCIONA BIEN
var service = provider.GetService<KeysModel>();
Console.WriteLine("Inyectado el Servicio=??? " + service.MySql);

Console.WriteLine("Fin de programa");