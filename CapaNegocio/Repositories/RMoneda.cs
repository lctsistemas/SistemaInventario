﻿using CapaDatos.Contracts;
using CapaDatos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Repositories
{
    public class RMoneda : IMoneda
    {
        private SqlCommand cmd;
        private string result = "";
        public string Add(DMoneda Entity)
        {
            using (SqlConnection connect = Dconexion.Getconectar())
            {
                connect.Open();
                try
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = connect;
                        cmd.CommandText = "manto.SP_AddMoneda";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigo", Entity.Codigo);
                        cmd.Parameters.AddWithValue("@nom_moneda", Entity.Nom_moneda);
                        cmd.Parameters.AddWithValue("@abrev", Entity.Abrev);
                        cmd.Parameters.AddWithValue("@simbolo", Entity.Simbolo);
                        cmd.Parameters.AddWithValue("@descripcion", Entity.Descripcion);

                        result = cmd.ExecuteNonQuery() == 1 ? "Registrado Correctamente!" : "Error al Regsitrar";

                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    SqlException sqlex = ex as SqlException;
                    if (sqlex != null && sqlex.Number == 2627)
                    {
                        result = "EL CODIGO INGRESADO YA SE ENCUENTRA REGISTRADO";
                    }
                    else
                        result = ex.Message;


                }
            } //aqui esta cerrando la conexion.
            return result;
        }

        public string Delete(DMoneda Entity)
        {
            throw new NotImplementedException();
        }

        public string Edit(DMoneda Entity)
        {
            throw new NotImplementedException();
        }

        public List<DMoneda> Getdata(DMoneda Entity)
        {
            throw new NotImplementedException();
        }
    }
}
