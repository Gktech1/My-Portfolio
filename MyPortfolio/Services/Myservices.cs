using MyPortfolio.Models;
using System.Collections.Generic;

namespace MyPortfolio.Services
{
    public class Myservices : Base
    {
        virtual public ICollection<Offer> Offers { get; set; }
    }
}
