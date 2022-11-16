using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelo;

namespace Entidades.Presentador
{
    public class PresentadorLogin
    {
        ILogin login;
        public static List<Usuario> usuarios = new List<Usuario>();
        public static Usuario usuarioActivo;

        public PresentadorLogin (ILogin login)
        {
            this.login = login;
            ObtenerUsuarios();
        }

        /// <summary>
        /// obtiene los usuarios de la base de datos
        /// </summary>
        private void ObtenerUsuarios()
        {
            try
            {
                ConexionUsuarios conexionUsuarios = new ConexionUsuarios();
                usuarios = conexionUsuarios.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                login.ContraseñaIncorrecta = ex.Message;
            }
        }

        /// <summary>
        /// intenta ingresar al menu principal si el usuario y la contraseña son correctas
        /// </summary>
        public void IntentarIngresar()
        {
            int contador = 0;
            try
            {
                foreach (Usuario usuario in usuarios)
                {
                    if (usuario.ComprobarContraseña(login.Contraseña) && usuario.NombreUsuario == login.NombreUsuario)
                    {
                        usuarioActivo = usuario;
                        login.IngresarAlMenuPrincipal();
                        break;
                    }
                    else if(usuario.NombreUsuario != login.NombreUsuario)
                    {
                        contador++;
                    }
                }
                if(contador == usuarios.Count)
                {
                    throw new Exception("nombre de usuario incorrecto");
                }
                else if(contador == (usuarios.Count - 1))
                {
                    throw new Exception("contraseña incorrecta");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "contraseña incorrecta")
                {
                    login.ContraseñaIncorrecta = ex.Message;
                }
                if (ex.Message == "nombre de usuario incorrecto")
                {
                    login.UsuarioIncorrecto = ex.Message;
                }
            }
        }

        /// <summary>
        /// comprueba que el nombre de usuario no exista en la base de datos
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <returns></returns>
        public bool ComprobarNombreUsuarioUnico(string nombreUsuario)
        {
            foreach (Usuario usuario in usuarios)
            {
                if(usuario.NombreUsuario == nombreUsuario)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Obtiene el ultimo ID de los usuarios
        /// </summary>
        /// <returns></returns>
        private int ObtenerUltimoID()
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuarios.Last() == usuario)
                {
                    return usuario.Id;
                }
            }
            return -1;
        }

        /// <summary>
        /// Agrega un usuario a la base de datos 
        /// </summary>
        /// <returns></returns>
        public bool AgregarUsuario()
        {
            bool agregoUsuario = false;
            int id = ObtenerUltimoID() + 1;
            if (id > 0)
            {
                Usuario usuario = new Usuario(id, login.NombreUsuario, login.Contraseña);
                if (!usuarios.Contains(usuario))
                {
                    try
                    {
                        ConexionUsuarios conexionUsuarios = new ConexionUsuarios();
                        conexionUsuarios.AgregarUsuario(usuario, login.Contraseña);
                        usuarios.Add(usuario);
                        agregoUsuario = true;
                    }
                    catch (Exception ex)
                    {
                        login.ContraseñaIncorrecta = ex.Message;
                    }
                }
            }

            return agregoUsuario;
        }
    }
}
