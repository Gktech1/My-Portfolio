using System;
using System.Collections.Generic;


namespace MyPortfolio.Models
{
    public class Offer
    {

        public decimal Rate { get; set; }
        public string Duration { get; set; }
        public bool IsAvaiable { get; set; }

        public Guid MyServiceId { get; set; }
       // public MyServices MyService { get; set; }

        virtual public ICollection<OfferDetails> OfferDetails { get; set; }
    }
}
