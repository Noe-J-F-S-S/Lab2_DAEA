using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void manUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;   
            string fechaNacimiento = dtpFechaNacimiento.Text;
            string apellido = txtApellido.Text; 
            string email = txtEmail.Text;

            dgvUsuarios.Rows.Add(dni, nombre, telefono, direccion, fechaNacimiento, apellido, email);
        }
    }
}
