using MyPortfolio.Models;
using MyPortfolio.Models.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MyPortfolio.Data
{
    public class Seeder : IRepositories
    {
        private string db = Path.Combine(Directory.GetCurrentDirectory(), "Data/");

        public bool WriteJson<T>(T model, string jsonFile)
        {
            try
            {
                string json = JsonConvert.SerializeObject(model) + Environment.NewLine;
                File.AppendAllTextAsync(db + jsonFile, json);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<T> ReadJson<T>(string jsonFile)
        {
            var readText = File.ReadAllText (db + jsonFile);
            var objects = new List<T>();
            var serializer = new JsonSerializer();
            var stringReader = new StringReader(readText);
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                jsonReader.SupportMultipleContent = true;
                while (jsonReader.Read())
                {
                    T json = serializer.Deserialize<T>(jsonReader);
                    objects.Add(json);
                }
            }
            return objects;
        }

        public bool WriteContact(ContactViewModel contact)
        {
            throw new NotImplementedException();
        }

        public List<ProjectViewModel> GetProject()
        {
            throw new NotImplementedException();
        }
    }
}
