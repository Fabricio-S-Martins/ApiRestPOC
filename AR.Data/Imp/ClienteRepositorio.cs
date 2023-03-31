using AR.Data.Interfaces;
using AR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Data.Imp
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly ContextoPrincipal _db;

        public ClienteRepositorio(ContextoPrincipal db)
        {
            _db = db;
        }

        public async Task Add(Cliente entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Cliente> GetAll()
        {
            return _db.Cliente;
        }
    }
}
