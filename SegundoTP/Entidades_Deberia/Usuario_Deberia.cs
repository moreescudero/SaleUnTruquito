using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelo;

namespace Entidades_Deberia
{
    [TestClass]
    public class Usuario_Deberia
    {
        private Usuario CrearUsuario(Carta carta1, Carta carta2, Carta carta3)
        {
            Usuario usuario = new Usuario(0, "test", "test");
            usuario.Cartas.Add(carta1);
            usuario.Cartas.Add(carta2);
            usuario.Cartas.Add(carta3);

            return usuario;
        }

        [TestMethod]
        public void ComprobarContraseña_Deberia()
        {
            //Arrange       Given
            string? nombreUsuario = "usuario123";
            string? contraseña = "contraseña";
            Usuario usuario = new Usuario(0, nombreUsuario, contraseña);

            //Act           When        
            bool contraseñaCorreta = usuario.ComprobarContraseña(contraseña);

            //Assert        Then
            Assert.IsTrue(contraseñaCorreta);
        }

        [TestMethod]
        public void ComprobarContraseña_Error()
        {
            string? nombreUsuario = "usuario123";
            string? contraseña = "contraseña";
            string? contraseñaIncorrecta = "incorrecta";
            Usuario usuario = new Usuario(0, nombreUsuario, contraseña);

            bool contraseñaCorrecta = usuario.ComprobarContraseña(contraseñaIncorrecta);

            Assert.IsFalse(contraseñaCorrecta);
        }

        [TestMethod]
        public void BuscarFlor_DeberiaSerVerdadero()
        {
            Usuario usuario = CrearUsuario(new Carta(2, "oro", EValores.Dos), 
                                           new Carta(7, "oro", EValores.SieteOro), 
                                           new Carta(1, "oro", EValores.Uno));

            usuario.BuscarFlor();

            Assert.IsTrue(usuario.SacoFlor);
        }

        [TestMethod]
        public void BuscarFlor_DeveriaSerFalse()
        {
            Usuario usuario = CrearUsuario(new Carta(2, "basto", EValores.Dos),
                                           new Carta(7, "oro", EValores.SieteOro),
                                           new Carta(1, "copa", EValores.Uno));

            usuario.BuscarFlor();

            Assert.IsFalse(usuario.SacoFlor);
        }

        [TestMethod]
        public void DecirEnvido_Deberia()
        {
            Usuario usuario = CrearUsuario(new Carta(2, "oro", EValores.Dos),
                                           new Carta(7, "oro", EValores.SieteOro),
                                           new Carta(1, "copa", EValores.Uno));
            
            int esperado = usuario.Cartas[0].Numero + usuario.Cartas[1].Numero + 20;

            int resultado = usuario.DecirEnvido();

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void DecirEnvido_DeberiaRetornar20()
        {
            Usuario usuario = CrearUsuario(new Carta(11, "oro", EValores.Once),
                                           new Carta(10, "oro", EValores.Diez),
                                           new Carta(1, "copa", EValores.Uno));

            int esperado = 20;

            int resultado = usuario.DecirEnvido();

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void DecirEnvido_DeberiaRetornar()
        {
            Usuario usuario = CrearUsuario(new Carta(7, "oro", EValores.SieteEspada),
                                           new Carta(10, "oro", EValores.Diez),
                                           new Carta(1, "copa", EValores.Uno));
      
            int esperado = 20 + usuario.Cartas[0].Numero;

            int resultado = usuario.DecirEnvido();

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void DecirEnvido_Fallo()
        {
            Usuario usuario = CrearUsuario(new Carta(7, "espada", EValores.SieteEspada),
                                           new Carta(10, "oro", EValores.Diez),
                                           new Carta(1, "copa", EValores.Uno));

            int esperado = 0;

            int resultado = usuario.DecirEnvido();

            Assert.AreEqual(esperado, resultado);
        }


        [TestMethod]
        public void ContestarTruco_DeberiaQuerer()
        {
            Usuario usuario = CrearUsuario(new Carta(7, "espada", EValores.SieteEspada),
                                           new Carta(10, "oro", EValores.Diez),
                                           new Carta(1, "copa", EValores.Uno));

            string respuesta = usuario.ContestarTruco();

            Assert.IsTrue(respuesta == "Quiero");
            Assert.IsTrue(usuario.CantoTruco);
        }

        [TestMethod]
        public void ContestarTruco_DeberiaNoQuerer()
        {
            Usuario usuario = CrearUsuario(new Carta(6, "espada", EValores.Seis),
                                           new Carta(10, "oro", EValores.Diez),
                                           new Carta(1, "copa", EValores.Uno));

            string respuesta = usuario.ContestarTruco();

            Assert.IsTrue(respuesta == "No quiero");
            Assert.IsFalse(usuario.CantoTruco);
        }


    }
}
