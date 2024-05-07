using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GUI_V_2
{
    public partial class Descarga_de_horarios : Form
    {
        public Descarga_de_horarios()
        {
            InitializeComponent();
        }

        private void Descarga_de_horarios_Load(object sender, EventArgs e)
        {
            // Creamos un nuevo hilo para ejecutar el proceso en segundo plano
            Thread hiloProceso = new Thread(ProcesoLargo);
            hiloProceso.Start();
        }
        private void ProcesoLargo()
        {
            // Simulamos un proceso largo (en este caso, simplemente dormimos el hilo durante 5 segundos)
            for (int i = 0; i <= 100; i++)
            {
                // Actualizamos el progreso y el contador en cada iteración
                this.Invoke((MethodInvoker)delegate {
                    progressBar1.Value = i;
                    textContador.Text = i.ToString();
                });

                // Dormimos el hilo por un breve período para simular el proceso
                Thread.Sleep(50);
            }

            // Después de terminar el proceso, actualizamos el cuadro de texto en el hilo de la interfaz de usuario
            // para mostrar que el proceso ha finalizado
            this.Invoke((MethodInvoker)delegate {
                textResultados.Text = "Descarga finalizada ";
            });
        }
    }
}
