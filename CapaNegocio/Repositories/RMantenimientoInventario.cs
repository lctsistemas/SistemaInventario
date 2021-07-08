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
                                Inv_final = Convert.ToDouble(item[5])                                                        

                            });
                        }
                    }
                }

            }

            return List_invent;
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }


    }
}
