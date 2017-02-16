using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDominio;


namespace CapaPersistencia
{
    public class daoUsuario
    {
        #region singleton
        private static readonly daoUsuario _instancia = new daoUsuario();
        public static daoUsuario Instancia
        {
            get { return daoUsuario._instancia; }
        }
        #endregion singleton
        #region metodos
        public entUsuario VerificarAcceso(String Usuario, String Password)
        {
            SqlCommand cmd = null;
            entUsuario u = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spVerificarAcceso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmstrUsuario", Usuario);
                cmd.Parameters.AddWithValue("@prmstrPassword", Password);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    u = new entUsuario();
                    u.idUsuario = Convert.ToInt16(dr["idUsuario"]);
                    u.Nombres = dr["Nombres"].ToString();
                    u.Apellidos = dr["Apellidos"].ToString();
                    u.NombreUsuario = dr["NombreUsuario"].ToString();
                    u.ValidoHasta = Convert.ToDateTime(dr["ValidoHasta"]);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {cmd.Connection.Close();} 
            return u;
        }

        #endregion metodos

                }
            }
     