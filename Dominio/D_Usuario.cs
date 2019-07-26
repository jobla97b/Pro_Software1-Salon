using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Acceso_Datos;
using Entidades;

namespace Dominio
{
    public class D_Usuario //Aqui van Todos los metodos y validaciones propias de la capa negocio para el Usuario
    {
        #region Metodo Login - Capa Dominio

        public static DataTable Login(string User, string contraseña)
        {
            AD_Usuario AU = new AD_Usuario();//instancio La clase de AD_Usuario para acceder al metodo login de la capa acceso a datos
            Users U = new Users();//Intnacio la clase usuario de la capa entidades para acceder a los atributos
            U.Usuario = User;//Le paso el valor de entrada "User" y le asigno el atributo a usuario de la clase Users
            U.Contraseña = contraseña;// Lo mismo que lo anterior pero "contraseña" al atributo Contraseña
            return AU.Login(U);//Accedo al metodo Login de la Capa ACCESO_DATOS
                               //seguido le paso Un parametro "U" de Tipo Usuario ya que es lo que espera el Metodo Login de la capa ACESSO_DATOS
        }
        #endregion
    }
}
