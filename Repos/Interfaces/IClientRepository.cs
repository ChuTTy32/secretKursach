using Model.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Interfaces
{
    public interface IClientRepository
    {
        IEnumerable<ClientModel> GetAllClients();
        ClientModel GetClientById(int id);
        void CreateClient(ClientModel client);
        void UpdateClient(ClientModel client);
        void DeleteClient(int id);
    }
}
