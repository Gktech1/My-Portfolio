using MyPortfolio.Data;
using System.Collections.Generic;

namespace MyPortfolio.Models.Repository
{
    public class Repositories:IRepositories
    {
        private string project = "Project.json";
        private string cont = "Contact.json";
        private readonly Seeder seedMe;
        public Repositories()
        {
            seedMe = new Seeder();
        }

        public List<Project> GetProject()
        {
            var list = seedMe.ReadJson<Project>(project);
            return list;
        }

        public bool WriteContact(Contact contact)
        {
            var write = seedMe.WriteJson<Contact>(contact, cont);
            return write;
        }
    }
}
