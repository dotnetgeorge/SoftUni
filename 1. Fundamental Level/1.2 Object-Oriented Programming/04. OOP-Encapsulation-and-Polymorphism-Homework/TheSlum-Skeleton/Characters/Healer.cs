using System;

namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Items;

    public class Healer : Character, IHeal
    {
        private int _healingPoints;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, 75, 50, team, 6)
        {
            
        }

        public int HealingPoints
        {
            get { return _healingPoints; }
            set { _healingPoints = 60; }
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
            return targetsList.OrderBy(x => x.HealthPoints).FirstOrDefault(x => x.Team != Team);
        }

        public void Heal(Character character)
        {
            var checkCharacter = character.Team == Team && character.Id != Id && character.IsAlive;

            if (checkCharacter)
            {
                character.HealthPoints += HealingPoints;
            }
        }

        public override string ToString()
        {
            var result = base.ToString() + String.Format(", Healing: {0}", HealingPoints);

            return result;
        }
    }
}
