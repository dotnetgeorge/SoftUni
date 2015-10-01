﻿namespace TheSlum.Items
{
    public class Pill : Bonus
    {
        public Pill(string id)
            : base(id, 0, 0, 100)
        {
            Countdown = 1;
            Timeout = 1;
            HasTimedOut = false;
        }
    }
}
