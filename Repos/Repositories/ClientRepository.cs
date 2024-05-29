using Libs;
using Model.Client;
using Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext _context;

        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ClientModel> GetAllClients()
        {
            return _context.Clients.ToList();
        }

        public ClientModel GetClientById(int id)
        {
            return _context.Clients.Find(id);
        }

        public void CreateClient(ClientModel client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void UpdateClient(ClientModel client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }

        public void DeleteClient(int id)
        {
            var client = _context.Clients.Find(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }
    }
}
