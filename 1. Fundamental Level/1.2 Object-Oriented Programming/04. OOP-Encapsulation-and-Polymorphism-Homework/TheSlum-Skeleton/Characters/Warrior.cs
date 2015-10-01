namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Items;

    public class Warrior : Character, IAttack
    {
        private int _attactPoints;

        public Warrior(string id, int x, int y, Team team)
            : base(id, x, y, 200, 100, team, 2)
        {
            
        }

        public int AttackPoints
        {
            get { return _attactPoints; }
            set { _attactPoints = 150; }
        }

        public override void AddToInventory(Item item)
        {
            if (!Inventory.Contains(item))
            {
                Inventory.Add(item);
                ApplyItemEffects(item);
            }
        }

        public override void RemoveFromInventory(Item item)
        {
            if (Inventory.Contains(item))
            {
                Inventory.Remove(item);
                RemoveItemEffects(item);
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.FirstOrDefault(x => x.Team != Team && x.IsAlive);
        }

        protected override void ApplyItemEffects(Item item)
        {
            AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            AttackPoints -= item.AttackEffect;
            base.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            var result = base.ToString() + string.Format(", Attact: {0}", AttackPoints);

            return result;
        }
    }
}
