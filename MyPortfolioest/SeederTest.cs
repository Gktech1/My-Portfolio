using Moq;
using MyPortfolio.Data;
using MyPortfolio.Models;
using System;
using Xunit;

namespace MyPortfolioTest
{
    public class SeederTest
    {
        private readonly Mock<Seeder> _seeder;
        public SeederTest()
        {
            _seeder = new Mock<Seeder>();
        }

        [Theory]
        [InlineData("Kunle","favourblessing1@gmail.com","Good","Awesome good God" )]
        [InlineData("Favour", "favourblessing1@gmail.com", "Doing Good", "Awesome good God")]
        [InlineData("Bond", "Bond1@gmail.com", "Grateful God", "Feeling vibe just now")]
        public void WriteToJsonTest(string name, string email,  string subject, string message)
        {
            //Arrange
            var contact = new Contact(){ Name = name, Email = email, Message=message,  Subject= subject};
            //_seeder.Setup(x => x.WriteJson<Contact>(contact,"Contact.json")).Returns(true);
            //Actual
            var actual = _seeder.Object.WriteJson<Contact>(contact, "Contact.json");
            //Assert
            Assert.True(actual);
            Assert.IsType<bool>(actual);
        }
    }
}
