using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class usuarios
    {

        //solicitud
       public int idUsuario { get; set; }
        public string usuario { get; set; }

        public string contrasena { get; set; }
        public string rol { get; set; }



        public usuarios() { }


        public usuarios(int IdUsuario,
string Usuario, string Contrasena, string Rol
            )
        {           
            idUsuario = IdUsuario;
            usuario = Usuario;
            contrasena = Contrasena;
            rol = Rol;
        }

        public usuarios(
string Usuario, string Contrasena, string Rol   
            )
        {
           
           usuario = Usuario;
            contrasena = Contrasena;
            rol= Rol;
        }

    }
}



