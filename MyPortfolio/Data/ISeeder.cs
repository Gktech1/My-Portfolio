using System.Collections.Generic;

namespace MyPortfolio.Data
{
    public interface ISeeder
    {
        public bool WriteJson<T>(T model, string jsonFile);
        public List<T> ReadJson<T>(string jsonFile);
    }
}
