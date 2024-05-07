using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class Productos : Form
    {
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panel2.Controls.Count > 0)

                this.panel2.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }
        public Productos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Horario());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Horario());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Horario());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Horario());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Horario());
        }

        private void Descargar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Descarga_de_horarios());
        }
        private void CROQUIS_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CROQUIS());
        }

        private void Croquis_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CROQUIS());
        }
    }
}
