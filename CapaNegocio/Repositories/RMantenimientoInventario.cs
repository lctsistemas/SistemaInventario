using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaDatos.Entities;

namespace CapaNegocio.Repositories
{
    public class RMantenimientoInventario:IDisposable
    {
        List<DMantenimientoInventario> List_invent;
        
       
        public List<DMantenimientoInventario> Get_showGrupo(DEntrada entity)
        {
            //double sumaEntradas = 0;
            //double sumaSalidas = 0;

            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "invent.SP_GrupoInventario";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idempresa", entity.Id_empresa);
                    cmd.Parameters.AddWithValue("@idmes", entity.Id_mes);
                    cmd.Parameters.AddWithValue("@idperiodo", entity.Id_periodo);

                    SqlDataReader dtr = cmd.ExecuteReader();
                    using (DataTable dt = new DataTable())
                    {
                        dt.Load(dtr);
                        dtr.Dispose();

                        List_invent = new List<DMantenimientoInventario>();
                        foreach (DataRow item in dt.Rows)
                        {
                            List_invent.Add(new DMantenimientoInventario()
                            {
                                Inv_cantidad = Convert.ToInt32(item[0].ToString()),
                                Inv_cod_exis = item[1].ToString(),
                                Inv_existencia = item[2].ToString(),
                                Inv_entrada = Convert.ToDouble(item[3]),
                                Inv_salida = Convert.ToDouble(item[4]),
                                Inv_final = Convert.ToDouble(item[5]),
                                

                            });
                            //sumaEntradas += Convert.ToDouble(item[3]);
                            //sumaSalidas += Convert.ToDouble(item[4]);
                        }
                        //List_invent.Add(new DMantenimientoInventario()
                        //{
                        //    Inv_cod_exis = "Total",
                        //    Inv_entrada = Convert.ToDouble(sumaEntradas.ToString("N2")),
                        //    Inv_salida = Convert.ToDouble(sumaSalidas.ToString("N2"))

                        //});
                    }
                }

            }

            return List_invent;
        }


        public int GetCantidadEntrada(DEntrada entity) {
            int c_entrada = 0;
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "invent.SP_totalEntrada";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idempresa", entity.Id_empresa);
                    cmd.Parameters.AddWithValue("@idmes", entity.Id_mes);
                    cmd.Parameters.AddWithValue("@idperiodo", entity.Id_periodo);
                    cmd.Parameters.Add("@outEntrada", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteScalar();
                    c_entrada = Convert.ToInt32(cmd.Parameters["@outEntrada"].Value);                    
                                        
                }
            }
            return c_entrada;
        }

        public int GetCantidadSalida(DEntrada entity)
        {
            int c_salida = 0;
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "invent.SP_totalSalida";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idempresa", entity.Id_empresa);
                    cmd.Parameters.AddWithValue("@idmes", entity.Id_mes);
                    cmd.Parameters.AddWithValue("@idperiodo", entity.Id_periodo);
                    cmd.Parameters.Add("@outSalida", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteScalar();
                    c_salida = Convert.ToInt32(cmd.Parameters["@outSalida"].Value);

                }
            }
            return c_salida;
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }


    }
}
