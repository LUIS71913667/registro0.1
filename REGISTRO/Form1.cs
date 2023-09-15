using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REGISTRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int x = 0;
            Academico.Estudiante estudiante = new Academico.Estudiante();
            estudiante.Matricula = this.txtMatricula.Text;
            estudiante.Apellidos = this.txtApellido.Text;
            estudiante.Nombres = this.txtNombre.Text;
            estudiante.Fecha_Nacimiento = this.dtFecha_Nacimiento.Value;
            estudiante.Correo = this.txtCorreo.Text;
            string genero = "F";
            if(this.cmdGenero.Text.ToString().Equals("Masculino"))
            {
                genero = "M";
            }
            estudiante.Genero = genero;
            Academico.EstudianteDAO.guardar(estudiante);
            MessageBox.Show("Filas agregadas: " + x.ToString());
        }
    }
}
