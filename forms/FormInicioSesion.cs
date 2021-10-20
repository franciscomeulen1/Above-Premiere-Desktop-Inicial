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

namespace AbovePremiere
{
    public partial class FormInicioSesion : Form
    {
        RegistroDeUsuarios rdu;
        public FormInicioSesion()
        {
            InitializeComponent();
            rdu = new RegistroDeUsuarios();
            rdu.agregarUsuarios("cami94", "12345");
            rdu.agregarUsuarios("fran94", "abc123");
            rdu.agregarUsuarios("mati94", "12345");
            rdu.agregarUsuarios("gasti94", "abc123");
            rdu.agregarUsuarios("malena94", "12345");
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string user = this.textBoxUsuario.Text;
            string pass = this.textBoxPassword.Text;
            if (rdu.verificarUsaurio(user, pass))
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
