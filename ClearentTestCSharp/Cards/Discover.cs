namespace ClearentTestCSharp.Cards
{
    public class Discover :Card
    {
        public Discover(string cardID, double balance)
        {
            this.cardID = cardID;
            this.balance = balance;
            this.rate = 0.01;
        }
    }
}
