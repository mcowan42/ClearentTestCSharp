using System.Collections.Generic;
using ClearentTestCSharp.Wallets;

namespace ClearentTestCSharp.Owners
{
    public class Owner
    {
        public string name { get; set; }
        public List<Wallet> wallets { get; set; }

        public Owner(string name)
        {
            this.name = name;
            this.wallets = new List<Wallet>();
        }

        public void addWallet(Wallet wallet)
        {
            this.wallets.Add(wallet);
        }

        public double getBalance()
        {
            double ownerBalance = 0;
            if (wallets.Count != 0)
            {
                foreach (Wallet wallet in this.wallets)
                {
                    ownerBalance += wallet.getBalance();                            //calculates and adds the balance of each wallet
                }
            }
            return ownerBalance;
        }

        public double getInterest()
        {
            double ownerInterest = 0;
            if (wallets.Count != 0)
            {
                foreach (Wallet wallet in this.wallets)
                {
                    ownerInterest += wallet.getInterest();                      //adds up the total interest for the wallet
                }
            }
            return ownerInterest;
        }

    }
}
