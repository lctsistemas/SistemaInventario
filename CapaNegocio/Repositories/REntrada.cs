using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos.Entities;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaNegocio.Repositories
{
    public class REntrada : IDisposable
    {

       public List<DEntrada> list_entrada;

        public List<DEntrada> ImportarAchivoExcel(string url)
        {
            //double sumaEntradas = 0;
            //double sumaSalidas = 0;
            using (OleDbConnection conector = DconexionOffice.GetConectarOffice(url))
            {
                try
                {
                    conector.Open();
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        string sql = "select cod_catalogo, tipo_existencia, cod_existencia, fecha_emision, tipo_documento, serie, num_documento, tipo_operacion," +
                                     "existencia, unida_medida, entradas, salidas from [Inv_uni_fisica$]";
                        cmd.Connection = conector;                      
                        cmd.CommandText = sql;

                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            da.Dispose();

                            list_entrada = new List<DEntrada>();
                            foreach (DataRow item in dt.Rows)
                            {
                                list_entrada.Add(new DEntrada()
                                {
                                    //periodo = item[0].ToString(),
                                    //COU = item[1].ToString(),
                                    //numero_asiento = item[2].ToString(),
                                    //cod_anexo = item[3].ToString(),
                                    cod_catalogo = item["cod_catalogo"].ToString(),
                                    tipo_existencia = item["tipo_existencia"].ToString(),
                                    cod_existencia = item["cod_existencia"].ToString(),
                                    //cod_ctl = item[7].ToString(),
                                    //cod_ext_ctl = item[8].ToString(),
                                    fecha_emision = Convert.ToDateTime(item["fecha_emision"]),
                                    tipo_documento = item["tipo_documento"].ToString(),
                                    serie = item["serie"].ToString(),
                                    num_documento = item["num_documento"].ToString(),
                                    tipo_operacion = item["tipo_operacion"].ToString(),
                                    existencia = item["existencia"].ToString(),
                                    unida_medida = item["unida_medida"].ToString(),
                                    entradas = Convert.ToDouble(item["entradas"]),
                                    salidas = Convert.ToDouble(item["salidas"].ToString().Replace("-", "+"))

                                });
                               // sumaEntradas += (double)item["entradas"];
                               // sumaSalidas += Convert.ToDouble(item["salidas"].ToString().Replace("-", "+"));
                            }

                           /*list_entrada.Add(new DEntrada()
                            {
                                cod_catalogo = "TOTAL",
                                /*tipo_existencia = "-",
                                cod_existencia = "-",
                                /*fecha_emision = "",
                                tipo_documento = "-",
                                serie = "-",
                                num_documento = "-",
                                tipo_operacion = "-",
                                existencia = "-",
                                unida_medida = "-",*/
                                //entradas =Convert.ToDouble(sumaEntradas.ToString("N2")),
                                //salidas = Convert.ToDouble(sumaSalidas.ToString("N2")),
                            //});
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle de Error : " + ex.ToString(),"Error al Importar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conector.Close();
                }
            }
            return list_entrada;
        }

        public DataTable Get_mes()
        {
            DataTable dt = null;
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "manto.sp_showMes";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dtr = cmd.ExecuteReader();
                    using (dt = new DataTable())
                    {
                        dt.Load(dtr);
                        dtr.Dispose();                        
                    }
                } 
            }

            return dt;
        }

        public void Dispose()
        {
            //llamar metodo liberador
        }


    }
}
