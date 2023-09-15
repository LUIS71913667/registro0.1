using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico
{
    public static class EstudianteDAO
    {
        public static int guardar(Estudiante estudiante)
        {
            string cadenaConexion = @"server=DESKTOP-7LDGQBD; database=TI2023; usuario id=sa; contraseña=Isabel100";
            //definimos un objeto conexión
            SqlConnection conectar = new SqlConnection(cadenaConexion);
            string sql = "insert into luis(matricula,apellido,nombres,genero," + "fechaNacimiento,email) valores(@matricula,@apellido,@nombre,@genero," + "@fechaNacimiento,@email)";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conectar);
            //configuramos los parámetros
            comando.CommandType= System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@matricula", estudiante.Matricula);
            comando.Parameters.AddWithValue("@apellidos", estudiante.Apellidos);
            comando.Parameters.AddWithValue("@nombres", estudiante.Nombres);
            comando.Parameters.AddWithValue("@genero", estudiante.Genero);
            comando.Parameters.AddWithValue("@fechaNacimiento", estudiante.Fecha_Nacimiento.Date);
            comando.Parameters.AddWithValue("@email", estudiante.Correo);
            conectar.Open();
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conectar.Close();

            return x;

        }
    }
}
