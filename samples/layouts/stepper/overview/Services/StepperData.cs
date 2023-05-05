using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class CardModel
    {
        public int ID { get; set; }
        public string Img { get; set; }
        public int Price { get; set; }
        public string Offer { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public static CardModel[] getCards()
        {
            return new CardModel[] {
                        new CardModel() {
                            ID = 1,
                            Img = "https://www.infragistics.com/angular-demos/assets/images/stepper/card-blue.png",
                            Price = 400,
                            Offer = "STATEMENT CREDIT OFFER",
                            Type = "Business Customized Advanced",
                            Description = "Cash Mastercard"
                        },
                        new CardModel() {
                            ID = 2,
                            Img = "https://www.infragistics.com/angular-demos/assets/images/stepper/card-red.png",
                            Price = 600,
                            Offer = "STATEMENT CREDIT OFFER",
                            Type = "Business Travel Advanced",
                            Description = "World Mastercard"
                        },
                        new CardModel() {
                            ID = 3,
                            Img = "https://www.infragistics.com/angular-demos/assets/images/stepper/card-gold.png",
                            Price = 500,
                            Offer = "STATEMENT CREDIT OFFER",
                            Type = "Business Golden",
                            Description = "World Mastercard"
                        }
                    };
        }
    }

    public class BusinessInformationModel
    {
        public string Name { get; set; }
        public string PhysicalAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool DifferentAddress { get; set; }
        public string TaxIDNumber { get; set; }
        public int NonUSBusinessActivity { get; set; }
    }

    public class PersonalInformationModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Authorization { get; set; }
        public bool AgreementAccepted { get; set; }
    }

    public class ShippingDetailsModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailingAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
