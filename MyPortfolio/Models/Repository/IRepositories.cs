using System.Collections.Generic;

namespace MyPortfolio.Models.Repository
{
    public interface IRepositories
    {
        bool WriteContact(Contact contact);
        List<Project> GetProject();
        void WriteContact<T>(T contact, string v);
    }
}
