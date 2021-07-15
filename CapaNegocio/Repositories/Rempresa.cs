using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos.Contracts;
using CapaDatos.Entities;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio.Repositories
{
    public class Rempresa : IEmpresa,IDisposable
    {
        string result;
        private SqlCommand cmd;
        private List<Dempresa> listemp;
        public string Add(Dempresa Entity)
        {
            result = "";
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.CommandText = "manto.SP_AddEmpresa";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ruc", Entity.Ruc);
                        cmd.Parameters.AddWithValue("@razon_social", Entity.Razon_social);
                        cmd.Parameters.AddWithValue("@nombre_comercial", Entity.Nombre_comercial);
                        cmd.Parameters.AddWithValue("@direccion", Entity.Direccion);
                        cmd.Parameters.AddWithValue("@domicilio_fiscal", Entity.Domicilio_fiscal);
                        cmd.Parameters.AddWithValue("@regimen", Entity.Regimen);
                        cmd.Parameters.AddWithValue("@estado", Entity.Estado);

                        result = cmd.ExecuteNonQuery() == 1 ? "¡Se Registro Correctamente!" : "Error al Registrar";

                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    SqlException sqlex = ex as SqlException;
                    if (sqlex != null && sqlex.Number == 2627)
                        result = "El Número de RUC ya se encuentra Registrado. \n Por favor Ingrese Nuevo Número";
                    else
                        result = ex.Message;                    
                }
            }
            return result;
        }


        //ELIMINAR ANULAR
        public string Delete(Dempresa Entity)
        {
            result = "";
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.CommandText = "manto.SP_DelteEmpresa";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_empresa", Entity.Id_empresa);
                        cmd.Parameters.AddWithValue("@estado", Entity.Estado);
                    
                        result = cmd.ExecuteNonQuery() == 1 ? "¡Se Anulo Correctamente!" : "Error al Anular Empresa";

                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                }
            }
            return result;
        }
      
        public string Edit(Dempresa Entity)
        {
            result = "";
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.CommandText = "manto.SP_EditEmpresa";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_empresa", Entity.Id_empresa);
                        cmd.Parameters.AddWithValue("@ruc", Entity.Ruc);
                        cmd.Parameters.AddWithValue("@razon_social", Entity.Razon_social);
                        cmd.Parameters.AddWithValue("@nombre_comercial", Entity.Nombre_comercial);
                        cmd.Parameters.AddWithValue("@direccion", Entity.Direccion);
                        cmd.Parameters.AddWithValue("@domicilio_fiscal", Entity.Domicilio_fiscal);
                        cmd.Parameters.AddWithValue("@regimen", Entity.Regimen);
                        cmd.Parameters.AddWithValue("@estado", Entity.Estado);


                        result = cmd.ExecuteNonQuery() == 1 ? "Se Modifico Correctamente!" : "Error al Modificar";

                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                }
            }
            return result;

        }

        public List<Dempresa> Getdata(Dempresa Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "manto.SP_ShowEmpresa";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@estado", Entity.Estado);

                    SqlDataReader dtr = cmd.ExecuteReader();
                    using (DataTable dt = new DataTable())
                    {
                        dt.Load(dtr);
                        dtr.Dispose();

                        listemp = new List<Dempresa>();
                        foreach (DataRow item in dt.Rows)
                        {
                            listemp.Add(new Dempresa()
                            {
                                Id_empresa= Convert.ToInt32(item[0]),
                                Ruc = item[1].ToString(),
                                Razon_social = item[2].ToString(),
                                Nombre_comercial = item[3].ToString(),
                                Direccion = item[4].ToString(),
                                Domicilio_fiscal = item[5].ToString(),
                                Regimen = item[6].ToString()
                            });
                        }
                    }
                }                
            }

            return listemp;

        }

        //BUSCAR EMPRESA
        public IEnumerable<Dempresa> Search(string filter)
        {
            return listemp.FindAll(e => e.Razon_social.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }


    }
}
