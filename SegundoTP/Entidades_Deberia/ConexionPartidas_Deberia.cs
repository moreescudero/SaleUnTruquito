using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelo;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace Entidades_Deberia
{
    [TestClass]
    public class ConexionPartidas_Deberia
    {
        private void BorrarPartida(string? mensaje, string? parametro)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = 192.168.0.163 ; Initial Catalog = truco ; User ID = more ; Password = segtp ;");
            SqlCommand command = connection.CreateCommand();

            connection.Open();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = mensaje;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Ganador", parametro);

            command.ExecuteNonQuery();
        }

        private Partida? ObtenerPartidaPorGanador(string? auxGanador)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = 192.168.0.163 ; Initial Catalog = truco ; User ID = more ; Password = segtp ;");
            SqlCommand command = connection.CreateCommand();

            Partida? partida = null;

            connection.Open();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Partidas where Ganador = @Ganador";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Ganador", auxGanador);

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                string ganador = dataReader.GetString(1);
                string perdedor = dataReader.GetString(2);
                DateTime fecha = dataReader.GetDateTime(3);

                partida = new Partida(id, ganador, fecha, perdedor);
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return partida;
        }

    
        [TestMethod]
        public void ObtenerPartidas_Deberia()
        {
            List<Partida> partidas;
            ConexionPartidas conexion = new ConexionPartidas();

            partidas = conexion.ObtenerPartidas();

            Assert.IsTrue(partidas.Count > 0);
            Assert.IsNotNull(partidas);
        }

        [TestMethod]
        public void ObtenerPartidas_DeberiaTraerPartidasDeUsuarioEspecifico()
        {
            Usuario usuario = new Usuario(0, "more", "more");
            List<Partida> partidasGanadas;
            ConexionPartidas conexion = new ConexionPartidas();

            partidasGanadas = conexion.ObtenerPartidas(usuario.NombreUsuario);

            Assert.IsNotNull(partidasGanadas);
            Assert.IsTrue(partidasGanadas.Count > 0);
            Assert.AreEqual(usuario.NombreUsuario, partidasGanadas[0].Ganador);
        }

        [TestMethod]
        public void ObtenerPartidas_NoEncuentraElGanador()
        {
            Usuario usuario = new Usuario(0, "ppp", "1234");
            List<Partida> partidasGanadas;
            ConexionPartidas conexion = new ConexionPartidas();

            partidasGanadas = conexion.ObtenerPartidas(usuario.NombreUsuario);

            Assert.IsTrue(partidasGanadas.Count == 0);
        }

        [TestMethod]
        public void AgregarPartida_Deberia()
        {
            ConexionPartidas conexion = new ConexionPartidas();
            List<Partida> partidas = conexion.ObtenerPartidas();
            int id = 0;
            foreach (Partida item in partidas)
            {
                if(item == partidas.Last())
                {
                    id = item.Id + 1;
                }
            }
            Partida partida = new Partida(id, "prueba", new DateTime(2022, 11, 20), "pruebaP");
            
            conexion.AgregarPartida(partida);
            Partida? partidaDevuelta = ObtenerPartidaPorGanador("prueba");

            Assert.IsNotNull(partidaDevuelta);
            Assert.AreEqual(partida.Ganador, partidaDevuelta.Ganador);
            Assert.AreEqual(partida.Perdedor, partidaDevuelta.Perdedor);

            BorrarPartida(@"delete from Partidas where Ganador = @Ganador", partidaDevuelta.Ganador);
        }
    }
}
