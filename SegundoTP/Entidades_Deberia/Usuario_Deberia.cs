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


    }
}
