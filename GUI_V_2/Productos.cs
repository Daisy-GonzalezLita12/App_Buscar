using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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

        static string conexion = "SERVER =  127.0.0.1; PORT=3306;DATABASE= buscando_dentro_del_tec;UID=root;PASSWORDS=;";
        MySqlConnection cn =new MySqlConnection(conexion);

        
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
            dataGridView1.DataSource = lleanar_grid();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public DataTable lleanar_grid() {
            cn.Open();
            DataTable dt=new DataTable();
            String llenar = "select* from persona";
            MySqlCommand cdm = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da= new MySqlDataAdapter(cdm); 
            da.Fill(dt);
            cn.Close();
            return dt;  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
