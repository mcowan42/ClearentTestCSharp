namespace ClearentTestCSharp.Cards
{
    public class Visa:Card
    {
        public Visa(string cardID, double balance)
        {
            this.cardID = cardID;
            this.balance = balance;
            this.rate = 0.1;
        }
    }
}
