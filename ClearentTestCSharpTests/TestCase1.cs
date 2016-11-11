using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClearentTestCSharp.Owners;
using ClearentTestCSharp.Wallets;
using ClearentTestCSharp.Cards;

namespace ClearentTestCSharpTests.TestCase1
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void Test1()
        {
            Owner owner1 = new Owner("Steve Jobs");
            Wallet wallet1 = new Wallet(owner1.name + "'s wallet1", owner1.name);
            Card Card1 = new Visa("Visa1", 100);
            Card Card2 = new Master("Master1", 100);
            Card Card3 = new Discover("Discover1", 100);
            wallet1.addCard(Card1);
            wallet1.addCard(Card2);
            wallet1.addCard(Card3);
            owner1.addWallet(wallet1);

            Assert.AreEqual(10.00, owner1.wallets[0].cards[0].getInterest(), 0.01);             //interest on card1
            Assert.AreEqual(5.00, owner1.wallets[0].cards[1].getInterest(), 0.01);              //interest on card2
            Assert.AreEqual(1.00, owner1.wallets[0].cards[2].getInterest(), 0.01);              //interest on card1
            Assert.AreEqual(16.00, owner1.getInterest());                                       //total interest for this person
        }
    }
}
 