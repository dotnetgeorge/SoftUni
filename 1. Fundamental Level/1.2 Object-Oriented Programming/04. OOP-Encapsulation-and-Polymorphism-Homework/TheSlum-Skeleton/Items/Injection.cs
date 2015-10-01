namespace TheSlum.Items
{
    public class Injection : Bonus
    {
        public Injection(string id)
            : base(id, 200, 0, 0)
        {
            Countdown = 3;
            Timeout = 3;
            HasTimedOut = false;
        }
    }
}
