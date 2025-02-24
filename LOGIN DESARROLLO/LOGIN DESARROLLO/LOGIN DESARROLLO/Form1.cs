using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_DESARROLLO
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            // Validar que los campos no estén vacíos
            if (usuario == "" || contraseña == "")
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar usuarios y abrir el formulario correspondiente
            if (usuario == "0801200421974" && contraseña == "1234")
            {
                MessageBox.Show("Bienvenido Administrador.", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAdministrador adminForm = new frmAdministrador();
                adminForm.Show();
                this.Hide();
            }
            else if (usuario == "0805200521985" && contraseña == "5678")
            {
                MessageBox.Show("Bienvenido Supervisor.", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*frmSupervisor supervisorForm = new frmSupervisor();
                supervisorForm.Show();
                this.Hide(); */
            }
            else if (usuario == "0801200421996" && contraseña == "abcd")
            {
                MessageBox.Show("Bienvenido Docente.", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /* frmDocente docenteForm = new frmDocente();
                docenteForm.Show();
                this.Hide(); */
            }
            else if (usuario == "0801200422007" && contraseña == "efgh")
            {
                MessageBox.Show("Bienvenido Decano.", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
               /*  frmDecano decanoForm = new frmDecano();
                decanoForm.Show();
                this.Hide(); */
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperacionDeContraseña recuperarForm = new frmRecuperacionDeContraseña();
            recuperarForm.Show();
            this.Hide();
        }
    }
}
