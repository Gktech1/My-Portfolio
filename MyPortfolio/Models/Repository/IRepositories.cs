using System.Collections.Generic;

namespace MyPortfolio.Models.Repository
{
    public interface IRepositories
    {
        bool WriteContact(ContactViewModel contact);
        List<ProjectViewModel> GetProject();
    }
}
