using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AbovePremiere.forms
{
    public partial class FormInicio : Form
    {
        string archivo;
        string formatoInicial; // la extencion
        public FormInicio()
        {
            InitializeComponent();
        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog(); //openFile guarda el archivo a seleccionar
            if (openFile.ShowDialog() == DialogResult.OK) // ShowDialog() muestra el cuadro para seleccionar el archivo
            {
                archivo = openFile.FileName; //Obtengo el nombre del archivo que abri
                textArchivo.Text = archivo; //Cambio el valor text del componente textArchivo
                conocerFormatoInicial();
            }
        }
        private void conocerFormatoInicial()
        {
            FileInfo fi = new FileInfo(archivo);
            formatoInicial = fi.Extension;
        }
        private void cerrarForm(object sender, EventArgs e) // Para cerrar el form desde la X
        {
            Application.Exit();
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            if (corroborarArchivoSelec())
            {
                if (radioButtonMp4.Checked)
                {
                    string r = ruta();
                    if (!String.IsNullOrEmpty(r))
                    {
                        convertir(textArchivo.Text, radioButtonMp4.Text, r, textNombre.Text);
                    }
                }
                else if (radioButtonAvi.Checked)
                {
                    string r = ruta();
                    if (!String.IsNullOrEmpty(r))
                    {
                        convertir(textArchivo.Text, radioButtonAvi.Text, r, textNombre.Text);
                    }
                }
                else if (radioButtonMpeg.Checked)
                {
                    string r = ruta();
                    if (!String.IsNullOrEmpty(r))
                    {
                        convertir(textArchivo.Text, radioButtonMpeg.Text, r, textNombre.Text);
                    }
                }
                else if (radioButtonFlv.Checked)
                {
                    string r = ruta();
                    if (!String.IsNullOrEmpty(r))
                    {
                        convertir(textArchivo.Text, radioButtonFlv.Text, r, textNombre.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un formato para convertir.", "Error.");
                }
            }
            
        }
        public string ruta()
        {
            string rutas = "";
            FolderBrowserDialog folder = new FolderBrowserDialog(); //Pide al usuario que seleccione una carpeta
            if (folder.ShowDialog() == DialogResult.OK)
            {
                folder.Description = "Guardar en"; //Para que aparezca un msj de donde lo voy a guardar
                rutas = folder.SelectedPath; // Guardo la ruta de la carpeta que el usuario selecciono, donde se va a guardar el archivo
            }
            return rutas;
        }

        public void convertir(string archivo, string formato, string ruta, string nombre)
        {
            // En el comando indico cual es el archivo que voy a convertir, la ruta donde lo guardare, el nombre y el formato.
            string comando = $"/C ffmpeg -i \"{archivo}\" \"{ruta}\\{nombre}.{formato}\""; // -i significa que es entrada. Nos trae la ruta, el nombre y el formato
            iniciarProceso(comando);
        }

        private void buttonExtraerAudio_Click(object sender, EventArgs e)
        {
            if (corroborarArchivoSelec())
            {
                string r = ruta();
                if (!String.IsNullOrEmpty(r))
                {
                    convertir(textArchivo.Text, "mp3", r, textNombre.Text);
                }
                
            }
            
        }

        private void buttonRemoverAudio_Click(object sender, EventArgs e)
        {
            if (corroborarArchivoSelec())
            {
                string r = ruta();
                if (!String.IsNullOrEmpty(r))
                {
                    removerAudio(textArchivo.Text, r, textNombre.Text);
                }   
            } 
        }
        private void removerAudio(string archivo, string ruta, string nombre)
        {
            string comando = $"/C ffmpeg -i \"{archivo}\" -an \"{ruta}\\{nombre}{formatoInicial}\"";
            iniciarProceso(comando);
        }
        private void iniciarProceso(string comando)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo //Especifica un conjunto de valores q se usa cuando se inicia un proceso.
            {
                CreateNoWindow = false, //El proceso se inicia en una nueva ventana
                FileName = "cmd.exe", //cmd.exe es la consola de windows
                WindowStyle = ProcessWindowStyle.Minimized, // Si queremos ver o no ver la ventana del proceso, o minimizada.
                Arguments = comando
            };
            using (Process exeProcess = Process.Start(startInfo)) //Ejecuto el proceso startInfo
            {
                //Para que nada se pueda ejecutar, sin que se haya ejecutado este proceso.
                exeProcess.WaitForExit();
                //Una vez que termine de hacer la conversion de formato, se cierra la ventana, y se puede seguir utlizando el sistrema.
            }
            MessageBox.Show("Archivo convertido con exito", "Listo"); //Es el showMessageDialog() de C#
            textArchivo.Text = "";
            textNombre.Text = "";
        }
        private void cambiarReolucion(string archivo, string resolucion, string ruta, string nombre)
        {
            string comando = $"/C ffmpeg -i \"{archivo}\" -vf scale={resolucion}:-1 \"{ruta}\\{nombre}{formatoInicial}\"";
            iniciarProceso(comando);
        }

        private void buttonCambiarResol_Click(object sender, EventArgs e)
        {
            if (corroborarArchivoSelec())
            {
                if (radioButton1080.Checked)
                {
                    string r = ruta();
                    if (!String.IsNullOrEmpty(r))
                    {
                        cambiarReolucion(textArchivo.Text, radioButton1080.Text, r, textNombre.Text);
                    }
                }
                else if (radioButton720.Checked)
                {
                    string r = ruta();
                    if (!String.IsNullOrEmpty(r))
                    {
                        cambiarReolucion(textArchivo.Text, radioButton720.Text, r, textNombre.Text);
                    }  
                }
                else if (radioButton480.Checked)
                {
                    string r = ruta();
                    if (!String.IsNullOrEmpty(r))
                    {
                        cambiarReolucion(textArchivo.Text, radioButton480.Text, r, textNombre.Text);
                    }
                }
                else if (radioButton360.Checked)
                {
                    string r = ruta();
                    if (!String.IsNullOrEmpty(r))
                    {
                        cambiarReolucion(textArchivo.Text, radioButton360.Text, r, textNombre.Text);
                    }
                }
                else if (radioButton240.Checked)
                {
                    string r = ruta();
                    if (!String.IsNullOrEmpty(r))
                    {
                        cambiarReolucion(textArchivo.Text, radioButton240.Text, r, textNombre.Text);
                    }
                }
                else if (radioButton144.Checked)
                {
                    string r = ruta();
                    if (!String.IsNullOrEmpty(r))
                    {
                        cambiarReolucion(textArchivo.Text, radioButton144.Text, r, textNombre.Text);
                    }                   
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una resolución para cambiar.", "Error.");
                }
            }
            
        }

        private void extraerImagenes(string archivo, string segs, string ruta, string nombre)
        {
            string comando = $"/C ffmpeg -i \"{archivo}\" -vf fps=fps=1/{segs} \"{ruta}\\{nombre}-%d.jpg\"";
            iniciarProceso(comando);
        }

        private void buttonExtraerImagenes_Click(object sender, EventArgs e)
        {
            if (corroborarArchivoSelec())
            {
                string segs = textSegundos.Text;
                if (segs.All(char.IsDigit) && !String.IsNullOrEmpty(segs)) // Comprueba que todos los elementos de la cadena sean digitos/numeros.
                {
                    string r = ruta();
                    if (!String.IsNullOrEmpty(r))
                    {
                        extraerImagenes(textArchivo.Text, segs, r, textNombre.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Se debe ingresar un valor numérico para los segundos.", "Error.");
                }
            }
            
        }

    private bool corroborarArchivoSelec()
        {
            if (String.IsNullOrEmpty(archivo))
            {
                MessageBox.Show("Primero debes seleccionar un video.", "Error.");
                return false;
            } else
            {
                return true;
            }
        }
    }

}
