using AR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Data.Interfaces
{
    public interface IClienteRepositorio
    {
        IQueryable<Cliente> GetAll();
        Task Add(Cliente cliente);
    }
}
