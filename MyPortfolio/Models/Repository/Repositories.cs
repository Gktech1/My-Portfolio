using MyPortfolio.Data;
using System.Collections.Generic;

namespace MyPortfolio.Models.Repository
{
    public class Repositories:IRepositories
    {
        private string _project = "Project.json";
        private string _contact = "Contact.json";
        private readonly Seeder _seedMe;
        public Repositories()
        {
            _seedMe = new Seeder();
        }

        public List<Project> GetProject()
        {
            var list = _seedMe.ReadJson<Project>(_project);
            return list;
        }

        public void WriteContact<T>(T contact, string v)
        {
            throw new System.NotImplementedException();
        }

        public bool WriteContact(Contact contact)
        {
            var write = _seedMe.WriteJson<Contact>(contact, _contact);
            return write;
        }
    }
}
