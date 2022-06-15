using System;

namespace MyPortfolio.Models
{
    public class OfferDetails
    {

        
        public Guid Id { get; set; }
        public string Detail { get; set; }
        public Guid OfferId { get; set; }
        public Offer Offer { get; set; }
    }
}
