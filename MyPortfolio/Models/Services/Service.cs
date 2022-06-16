using MyPortfolio.Data;
using MyPortfolio.Models;
using MyPortfolio.Models.Repository;
using System.Collections.Generic;

namespace MyPortfolio.Models.Services
{
    public class Service : IService 
    {
        private readonly IRepositories _repositories;
        public Service(IRepositories repositories)
        {
            _repositories = repositories;
        }

        public bool CreateContact(Contact contact)
        {
            return _repositories.WriteContact(contact);
        }

        public List<Project> GetAllProjects()
        {
            return _repositories.GetProject();
        }
    }
}
