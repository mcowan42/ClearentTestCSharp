namespace ClearentTestCSharp.Cards
{
    public class Master:Card
    {
        public Master(string cardID, double balance)
        {
            this.cardID = cardID;
            this.balance = balance;
            this.rate = 0.05;
        }
    }
}
