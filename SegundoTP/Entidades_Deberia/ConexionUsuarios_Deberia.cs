using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelo;

namespace Entidades_Deberia
{
    [TestClass]
    public class ConexionUsuarios_Deberia
    {
        private void BorrarUsuario(string? mensaje, string? parametro)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = 192.168.0.163 ; Initial Catalog = truco ; User ID = more ; Password = segtp ;");
            SqlCommand command = connection.CreateCommand();

            connection.Open();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = mensaje;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Usuario", parametro);

            command.ExecuteNonQuery();
        }

        private Usuario ObtenerUsuarioPorNombreUsuario(string? nombre)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = 192.168.0.163 ; Initial Catalog = truco ; User ID = more ; Password = segtp ;");
            SqlCommand command = connection.CreateCommand();

            Usuario? usuario = null;

            connection.Open();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Usuarios where Usuario = @Usuario";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Usuario", nombre);

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                string nombreUsuario = dataReader.GetString(1);
                string contraseña = dataReader.GetString(2);
                int partidasGanadas = dataReader.GetInt32(3);
                int partidasPerdidas = dataReader.GetInt32(4);
                int cantAnchosDeEspada = dataReader.GetInt32(5);
                int cantSacoFaltaEnvido = dataReader.GetInt32(6);

                usuario = new Usuario(id, nombreUsuario, contraseña, partidasGanadas, partidasPerdidas, cantAnchosDeEspada, cantSacoFaltaEnvido);
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return usuario;
        }

        [TestMethod]
        public void ObtenerUsuarios_Deberia()
        {
            List<Usuario> usuarios;
            ConexionUsuarios conexion = new ConexionUsuarios();

            usuarios = conexion.ObtenerUsuarios();

            Assert.IsTrue(usuarios.Count > 0);
            Assert.IsNotNull(usuarios);
        }

        [TestMethod]
        public void ObtenerTop5Usuarios_Deberia()
        {
            List<Usuario> usuarios;
            ConexionUsuarios conexion = new ConexionUsuarios();

            usuarios = conexion.ObtenerTop5Usuarios();

            Assert.IsTrue(usuarios.Count == 5);
            Assert.IsNotNull(usuarios);
        }

        [TestMethod]
        public void AgregarUsuario_Deberia()
        {
            ConexionUsuarios conexion = new ConexionUsuarios();
            Usuario usuario = new Usuario(0, "prueba", "pruebaC");

            conexion.AgregarUsuario(usuario, "pruebaC");
            List<Usuario> usuarios = conexion.ObtenerUsuarios();
            Usuario usuarioDevuelto = ObtenerUsuarioPorNombreUsuario("prueba");

            Assert.AreEqual(usuario.NombreUsuario, usuarioDevuelto.NombreUsuario);

            BorrarUsuario(@"delete from Usuarios where Usuario = @Usuario", usuarioDevuelto.NombreUsuario);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void AgregarUsuario_Fallo()
        {
            ConexionUsuarios conexion = new ConexionUsuarios();
            Usuario usuario = new Usuario(0, "prueba", "1234");

            conexion.AgregarUsuario(usuario, null);

        }

        [TestMethod]
        public void ModificarUsuarios_Deberia()
        {
            ConexionUsuarios conexion = new ConexionUsuarios();
            List<Usuario> usuarios = conexion.ObtenerUsuarios();
            Usuario usuario = new Usuario(0, "prueba", "pruebaC");
            int partidasGanadas = usuario.PartidasGanadas;
            int partidasPerdidas = usuario.PartidasPerdidas;
            int cantAnchosEspada = usuario.CantAnchosDeEspada;
            int cantFaltaEnvido = usuario.CantSacoFaltaEnvido;
            conexion.AgregarUsuario(usuario, "pruebaC");
            usuario.PartidasGanadas = 3;
            usuario.PartidasPerdidas = 1;
            usuario.CantAnchosDeEspada = 5;
            usuario.CantSacoFaltaEnvido = 2;
            usuarios.Add(usuario);

            conexion.ModificarUsuarios(usuarios);
            Usuario usuarioDevuelto = ObtenerUsuarioPorNombreUsuario(usuario.NombreUsuario);

            Assert.IsTrue(partidasGanadas != usuarioDevuelto.PartidasGanadas);
            Assert.IsTrue(partidasPerdidas != usuarioDevuelto.PartidasPerdidas);
            Assert.IsTrue(cantAnchosEspada != usuarioDevuelto.CantAnchosDeEspada);
            Assert.IsTrue(cantFaltaEnvido != usuarioDevuelto.CantSacoFaltaEnvido);

            BorrarUsuario(@"delete from Usuarios where Usuario = @Usuario", usuarioDevuelto.NombreUsuario);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ModificarUsuarios_Fallo()
        {
            ConexionUsuarios conexion = new ConexionUsuarios();
            List<Usuario> usuarios = null;

            conexion.ModificarUsuarios(usuarios);
        }
    }
}
