using Moq;
using MyPortfolio.Data;
using MyPortfolio.Models;
using MyPortfolio.Models.Repository;
using System;
using System.Collections.Generic;
using Xunit;

namespace MyPortfolioTest
{
    public class SeederTest
    {
        private readonly Mock<ISeeder> _seeder;
        public SeederTest()
        {
            _seeder = new Mock<ISeeder>();
        }

        [Theory]
        [InlineData("Kunle","favourblessing1@gmail.com","Good","Awesome good God" )]
        [InlineData("Favour", "favourblessing1@gmail.com", "Doing Good", "Awesome good God")]
        [InlineData("Bond", "Bond1@gmail.com", "Grateful God", "Feeling vibe just now")]
        public void WriteToJsonTest(string name, string email,  string subject, string message)
        {
            //Arrange
            var contact = new Contact(){ Name = name, Email = email, Message = message,  Subject= subject};
            _seeder.Setup(x => x.WriteJson<Contact>(contact,"Contact.json")).Returns(true);
            //Actual
            var actual = _seeder.Object.WriteJson<Contact>(contact, "Contact.json");
            //Assert
            Assert.True(actual);
            Assert.IsType<bool>(actual);
        }


        [Theory]
        [InlineData(1, "../img / portfolio / GPACalculator.png", "github.com/week1")]
        [InlineData(2, "../img / portfolio / GPACalculator.png", "github.com/week2")]
        [InlineData(3, "../img / portfolio / GPACalculator.png", "github.com/week3")]
        public void ReadToJsonTest(int id, string imageUrl,  string projectLink)
        {
            //Arrange
            var project = new List<Project>()
            {
                new Project{ Id = id, ImageUrl = imageUrl, ProjectLink = projectLink },
            };
            _seeder.Setup(x => x.ReadJson<Project>("Project.json")).Returns(project);
            //Actual
            var actual = _seeder.Object.ReadJson<Project>("Project.json");
            //Assert
            Assert.NotEmpty(actual);
            Assert.Equal(project,actual);
        }

    }
}
