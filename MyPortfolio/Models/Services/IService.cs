using MyPortfolio.Data;
using MyPortfolio.Models;
using System.Collections.Generic;

namespace MyPortfolio.Models.Services
{
    public interface IService
    {
        bool CreateContact(ContactViewModel contact);
        List<ProjectViewModel> GetAllProjects();
    }
}