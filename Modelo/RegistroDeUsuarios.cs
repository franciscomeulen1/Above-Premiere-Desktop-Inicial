using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbovePremiere.Modelo
{
    class RegistroDeUsuarios
    {
        Dictionary<string, string> usuarios;

        public RegistroDeUsuarios()
        {
            this.usuarios = new Dictionary<string, string>();
        }

        public void agregarUsuarios(string user, string pass)
        {
            usuarios.Add(user, pass);
        }
        public bool verificarUsaurio(string user, string pass)
        {
            bool verificado = false;
            string value;
            if (usuarios.TryGetValue(user, out value))
            {
                if (value == pass)
                {
                    verificado = true;
                }
            } else
            {
                verificado = false;
            }

            return verificado;
        }
    }
}
