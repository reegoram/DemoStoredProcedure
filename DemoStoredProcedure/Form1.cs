using System;
using System.Windows.Forms;

namespace DemoStoredProcedure
{
    public partial class Form1 : Form
    {
        Datos datos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!(new Datos().ExisteConexion()))
            {
                MessageBox.Show("No se ha podido establecer la conexión", "Error de Conexión", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LlenarCombos();
        }

        private void LlenarCombos()
        {
            datos = new Datos();

            cmbLibros.DataSource = null;
            cmbUsuarios.DataSource = null;

            cmbLibros.Items.Clear();
            cmbUsuarios.Items.Clear();

            cmbLibros.DataSource = datos.TraerRegistros("libros").Tables[0];
            cmbLibros.DisplayMember = "titulo";
            cmbUsuarios.DataSource = datos.TraerRegistros("usuarios").Tables[0];
            cmbUsuarios.DisplayMember = "nombre";
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedIndex > -1 && cmbLibros.SelectedIndex > -1)
                if (new Datos().RegistrarPrestamo(cmbUsuarios.Text, cmbLibros.Text))
                    MessageBox.Show("Préstamo realizado con éxito", "Préstamo Exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

            LlenarCombos();
        }
    }
}
