using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class ClienteService
    {
        private ClienteDao clienteDao;
        public ClienteService()
        {
            this.clienteDao = new ClienteDao();
        }

        internal IList<Cliente> GetAll()
        {
            return clienteDao.GetAll();
        }

        internal IList<Cliente> GetByFilters(Dictionary<string,object> dicc)
        {
            return clienteDao.GetByFilters(dicc);
        }

        internal Cliente GetByDni(int dniClienteSeleccionado)
        {
            return clienteDao.GetByDni(dniClienteSeleccionado);
        }

        internal void Create(Cliente cliente)
        {
            clienteDao.Create(cliente);
        }

        internal void Update(Cliente cliente)
        {
            clienteDao.Update(cliente);
        }

        internal void Delete(int clienteSeleccionado)
        {
            clienteDao.Delete(clienteSeleccionado);
        }
    }
}
