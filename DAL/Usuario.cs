﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL
{
    public class Usuario
    {
        /// <summary>
        /// Invocamos al store procedure que devuelve un DataTable, instanciamos un objeto de negocio y lo poblamos
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contraseña"></param>
        /// <returns>Si el Datatable es null o la cantidad de filas es 0, retornamos nulo, sino retornamos el objeto de negocio</returns>
        public BUE.Usuario ValidarUsuario(string nombreUsuario, string contraseña)
        {
            string usuarioStoreProcedure = "sp_validar_usuario";
            SqlParameter[] parametros = new SqlParameter[2];
            Conexion objConexion = new Conexion();
            parametros[0] = objConexion.crearParametro("@username", nombreUsuario);
            parametros[1] = objConexion.crearParametro("@password", contraseña);

            DataTable dt = objConexion.LeerPorStoreProcedure(usuarioStoreProcedure, parametros);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            BUE.Usuario usuarioDeRetorno = new BUE.Usuario();
            usuarioDeRetorno.ID = int.Parse(dt.Rows[0][0].ToString());
            usuarioDeRetorno.UserName = dt.Rows[0]["nombreDeUsuario"].ToString();
            usuarioDeRetorno.Password = contraseña;
            usuarioDeRetorno.Perfil = new BUE.Perfil();
            usuarioDeRetorno.Perfil.ID = int.Parse(dt.Rows[0]["IdPerfil"].ToString());
            usuarioDeRetorno.Perfil.Descripcion = dt.Rows[0]["Descripcion"].ToString();


            return usuarioDeRetorno;
        }

    }
}
