using Model.Client;
using Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Client
{
    public class ClientPresenter
    {
        private readonly IClientRepository _repository;

        public ClientPresenter(IClientRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ClientModel> GetAllClients()
        {
            return _repository.GetAllClients();
        }

        public ClientModel GetClientById(int id)
        {
            return _repository.GetClientById(id);
        }

        public void CreateClient(ClientModel client)
        {
            _repository.CreateClient(client);
        }

        public void UpdateClient(ClientModel client)
        {
            _repository.UpdateClient(client);
        }

        public void DeleteClient(int id)
        {
            _repository.DeleteClient(id);
        }
    }
}
