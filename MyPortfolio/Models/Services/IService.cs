using MyPortfolio.Data;
using MyPortfolio.Models;
using System.Collections.Generic;

namespace MyPortfolio.Models.Services
{
    public interface IService
    {
        bool CreateContact(Contact contact);
        List<Project> GetAllProjects();
    }
}