using RestSharp;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbovePremiere.Modelo
{
    static class ConsultaApiUsuarios
    {
        private static RestClient client = new RestClient("https://localhost:44396");
        private static RestRequest request = new RestRequest("/api/check", Method.POST);

        public static bool consultarApi(string user, string pwd)
        {
            request.AddJsonBody(new { user, pwd });
            var response = client.Execute(request);
            var obj = JObject.Parse(response.Content); //Esta linea no le gusta
            bool valido = (bool) obj["valid"];

            return valido;
        }
     
    }
}
