using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClearentTestCSharp.Owners;
using ClearentTestCSharp.Wallets;
using ClearentTestCSharp.Cards;

namespace ClearentTestCSharpTests
{
    [TestClass]
    public class TestCase2
    {
        [TestMethod]
        public void Test2()
        {
            Owner owner2 = new Owner("Mark Zuckerberg");
            Wallet wallet1 = new Wallet(owner2.name + "'s wallet1", owner2.name);
            Wallet wallet2 = new Wallet(owner2.name + "'s wallet2", owner2.name);
            Card Card11 = new Visa("Visa1", 100);
            Card Card12 = new Discover("Discover1", 100);
            Card Card21 = new Master("Master1", 100);
            wallet1.addCard(Card11);
            wallet1.addCard(Card12);
            wallet2.addCard(Card21);
            owner2.addWallet(wallet1);
            owner2.addWallet(wallet2);

            Assert.AreEqual(16.00, owner2.getInterest(), 0.01);                       //total interest for this person
            Assert.AreEqual(11.00, owner2.wallets[0].getInterest(), 0.01);            //total interest for wallet1
            Assert.AreEqual(5.00, owner2.wallets[1].getInterest(), 0.01);             //total interest for wallet2
        }
    }
}
