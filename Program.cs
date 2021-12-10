using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbovePremiere
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicioSesion());
            /*
            var client = new RestClient("https://localhost:44373");
            var request = new RestRequest("/api/check", Method.POST);
            request.AddJsonBody(new { user = "admin", pwd = "admin" });

            var response = client.Execute(request);

            var obj = JObject.Parse(response.Content); // Esto no le gusta

            Console.WriteLine(obj["valid"]);
            */
        }
    }
}
