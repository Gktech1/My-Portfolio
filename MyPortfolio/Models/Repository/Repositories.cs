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

        public List<ProjectViewModel> GetProject()
        {
            var list = seedMe.ReadJson<ProjectViewModel>(project);
            return list;
        }

        public bool WriteContact(ContactViewModel contact)
        {
            var write = seedMe.WriteJson<ContactViewModel>(contact, cont);
            return write;
        }
    }
}
