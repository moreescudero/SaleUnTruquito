using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelo;

namespace Entidades_Deberia
{
    [TestClass]
    public class Usuario_Deberia
    {

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
            Usuario usuario = new Usuario(0, "test", "test");
            usuario.Cartas.Add(new Carta(2, "oro", EValores.Dos));
            usuario.Cartas.Add(new Carta(7, "oro", EValores.SieteOro));
            usuario.Cartas.Add(new Carta(1, "oro", EValores.Uno));

            usuario.BuscarFlor();

            Assert.IsTrue(usuario.SacoFlor);
        }

        [TestMethod]
        public void BuscarFlor_DeveriaSerFalse()
        {
            Usuario usuario = new Usuario(0, "test", "test");
            usuario.Cartas.Add(new Carta(2, "basto", EValores.Dos));
            usuario.Cartas.Add(new Carta(7, "oro", EValores.SieteOro));
            usuario.Cartas.Add(new Carta(1, "copa", EValores.Uno));

            usuario.BuscarFlor();

            Assert.IsFalse(usuario.SacoFlor);
        }

        [TestMethod]
        public void DecirEnvido_Deberia()
        {

        }
    }
}
