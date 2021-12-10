using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbovePremiere.forms;
using AbovePremiere.Modelo;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace AbovePremiere
{
    public partial class FormInicioSesion : Form
    {
        private bool consultarApi(string user, string pwd)
        {
            RestClient client = new RestClient("https://localhost:44358");
            RestRequest request = new RestRequest("/api/check", Method.POST);
            request.AddJsonBody(new { user, pwd });
            var response = client.Execute(request);
            var obj = JObject.Parse(response.Content);
            bool valido = (bool)obj["valid"];

            return valido;
        }
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string user = this.textBoxUsuario.Text;
            string pass = this.textBoxPassword.Text;
            if (consultarApi(user, pass))
            {
                FormInicio formInicio = new FormInicio();
                formInicio.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error");
            }
            
            
        }
    }
}
