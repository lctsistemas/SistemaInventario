using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos.Entities;

namespace CapaDatos.Contracts
{
    public interface IGeneral<Entidades> where Entidades : class
    {
        string Add(Entidades Entity);
        string Edit(Entidades Entity);
        string Delete(Entidades Entity);
        List<Entidades> Getdata(Entidades Entity);
    }

    public interface IEmpresa : IGeneral<Dempresa>
    {
    }


}
