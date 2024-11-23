using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApellidoNombre
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void FormularioPrincipal_Load(object sender, EventArgs e) { }


        

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Crear una nueva instancia de FormUsuario
            Form formUsuario = new Form();

            // Mostrar el formulario de usuario
            formUsuario.Show();
        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formActividades = new Form();
            formActividades.Show();
        }

        private void reportesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form formReportes= new Form();  
            formReportes.Show();
        }
    }

}
    

