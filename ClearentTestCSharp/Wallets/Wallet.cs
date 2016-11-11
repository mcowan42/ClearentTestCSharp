using System.Collections.Generic;
using ClearentTestCSharp.Cards;

namespace ClearentTestCSharp.Wallets
{
    public class Wallet
    {
        public string WalletID { get; set; }
        public string Owner { get; set; }
        public List<Card> cards { get; set; }

        public Wallet(string WalletID, string Owner)
        {
            this.WalletID = WalletID;
            this.Owner = Owner;
            this.cards = new List<Card>();
        }

        public void addCard(Card card)
        {
            this.cards.Add(card);
        }

        public double getInterest()
        {
            double walletInterest = 0;
            if (this.cards.Count != 0)
            {
                foreach (Card card in this.cards)
                {
                    walletInterest += card.getInterest();      //calculates and adds the interest of each card
                }
            }
            return walletInterest;
        }

        public double getBalance()
        {
            double walletBalance = 0;
            if (this.cards.Count != 0)
            {
                foreach (Card card in this.cards)
                {
                    walletBalance += card.balance;             //calculates and adds the balance of each card
                }
            }
            return walletBalance;
        }

        public double getNewBalance()
        {
            double walletNewBalance = 0;
            if (this.cards.Count != 0)
            {
                foreach (Card card in this.cards)
                {
                    walletNewBalance += card.newBalance();           //calculates and adds the new balance of each card
                }
            }
            return walletNewBalance;
        }

    }
}
