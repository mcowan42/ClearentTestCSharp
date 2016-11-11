using System;

namespace ClearentTestCSharp.Cards
{
    public abstract class Card
    {
        public string cardID { get; set; }
        public double rate { get; set; }
        public double balance { get; set; }

        public double getInterest()
        {
            return Math.Round((this.balance * this.rate), 2, MidpointRounding.AwayFromZero);    //returns the interest for the card
        }

        public double newBalance()
        {
            this.balance += this.getInterest();                                                 //calculates the new balance based on the interest
            return this.balance;
        }

        public string toString()
        {
            return "CardID: " + this.cardID + " Interest rate: " + this.rate + " Balance: " + this.balance;
        }
    }
}
