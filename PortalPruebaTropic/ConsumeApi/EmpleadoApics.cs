using BD.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PortalPruebaTropic.Interface;

namespace PortalPruebaTropic.ConsumeApi
{
    public class EmpleadoApics : IEmpleado
    {
        public async Task<List<Empleado>> listaEmpleado()
        {
            
            dynamic res;
            var lista = new List<Empleado>();
            var content = string.Empty;
            HttpClient client = new HttpClient();
            try
            {
                // Hacer una solicitud GET a una URL
                HttpResponseMessage response = await client.GetAsync("http://localhost:5000/Empleado/ListaEmpleado");

                // Verificar si la solicitud fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta como una cadena
                    content = await response.Content.ReadAsStringAsync();
                    lista = JsonConvert.DeserializeObject<List<Empleado>>(content);
                }
                else
                {
                    Console.WriteLine("La solicitud no fue exitosa. Código de estado: " + response.StatusCode);
                    res = content;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }
    }
}
