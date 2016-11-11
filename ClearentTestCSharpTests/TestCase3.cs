using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClearentTestCSharp.Owners;
using ClearentTestCSharp.Wallets;
using ClearentTestCSharp.Cards;

namespace ClearentTestCSharpTests
{
    [TestClass]
    public class TestCase3
    {
        [TestMethod]
        public void Test3()
        {
            Owner owner3 = new Owner("Dr. Jekyll");
            Wallet wallet31 = new Wallet(owner3.name + "'s wallet1", owner3.name);
            Card Card31 = new Master("Master31", 100);
            Card Card32 = new Master("Master32", 100);
            owner3.addWallet(wallet31);
            owner3.wallets[0].addCard(Card31);
            owner3.wallets[0].addCard(Card32);

            Owner owner4 = new Owner("Mr. Hyde");
            Wallet wallet41 = new Wallet(owner4.name + "'s wallet1", owner4.name);
            Card Card41 = new Visa("Visa41", 100);
            Card Card42 = new Master("Master42", 100);
            owner4.addWallet(wallet41);
            owner4.wallets[0].addCard(Card41);
            owner4.wallets[0].addCard(Card42);

            Assert.AreEqual(10.00, owner3.getInterest(), 0.01);                           //total interest for this person
            Assert.AreEqual(10.00, owner3.wallets[0].getInterest(), 0.01);                //total interest for this wallet

            Assert.AreEqual(15.00, owner4.getInterest(), 0.01);                           //total interest for this person
            Assert.AreEqual(15.00, owner4.wallets[0].getInterest(), 0.01);                //total interest for this wallet
        }
    }
}
