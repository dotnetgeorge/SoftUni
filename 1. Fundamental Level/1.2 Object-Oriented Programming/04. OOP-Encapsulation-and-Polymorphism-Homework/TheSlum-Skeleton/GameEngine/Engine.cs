namespace TheSlum.GameEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Characters;
    using Interfaces;
    using Items;

    public class Engine
    {
        protected List<Character> characterList = new List<Character>();
        protected List<Bonus> timeoutItems;

        private const int GameTurns = 4;

        public virtual void Run()
        {
            ReadUserInput();
            InitializeTimeoutItems();

            for (int i = 0; i < GameTurns; i++)
            {
                foreach (var character in characterList)
                {
                    if (character.IsAlive)
                    {
                        ProcessTargetSearch(character);
                    }
                }

                ProcessItemTimeout(timeoutItems);
            }

            PrintGameOutcome();
        }

        public void ProcessItemTimeout(List<Bonus> timeoutItems)
        {
            for (int i = 0; i < timeoutItems.Count; i++)
            {
                timeoutItems[i].Countdown--;
                if (timeoutItems[i].Countdown == 0)
                {
                    var item = timeoutItems[i];
                    item.HasTimedOut = true;
                    var itemHolder = GetCharacterByItem(item);
                    itemHolder.RemoveFromInventory(item);
                    i--;
                }
            }
        }

        public void InitializeTimeoutItems()
        {
            timeoutItems = characterList
                .SelectMany(c => c.Inventory)
                .Where(i => i is Bonus)
                .Cast<Bonus>()
                .ToList();
        }

        protected virtual void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0].ToLower())
            {
                case "status":
                    PrintCharactersStatus(characterList);
                    break;
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItem(inputParams);
                    break;;
                default:
                    ExecuteCommand(inputParams);
                    break;
            }
        }

        protected virtual void CreateCharacter(string[] inputParams)
        {
            var id = inputParams[2];
            var x = Convert.ToInt32(inputParams[3]);
            var y = Convert.ToInt32(inputParams[4]);
            var team = (Team) Enum.Parse(typeof(Team), inputParams[5], true);

            switch (inputParams[1].ToLower())
            {
                case "warrior":
                    characterList.Add(new Warrior(id, x, y, team));
                    break;
                case "mage":
                    characterList.Add(new Mage(id, x, y, team));
                    break;
                case "healer":
                    characterList.Add(new Healer(id, x, y, team));
                    break;
            }
        }

        protected void AddItem(string[] inputParams)
        {
            var character = GetCharacterById(inputParams[1]);

            switch (inputParams[2])
            {
                case "axe":
                    character.AddToInventory(new Axe(inputParams[3]));
                    break;
                case "shield":
                    character.AddToInventory(new Shield(inputParams[3]));
                    break;
                case "injection":
                    character.AddToInventory(new Injection(inputParams[3]));
                    break;
                case "pill":
                    character.AddToInventory(new Pill(inputParams[3]));
                    break;
            }
        }

        protected void ProcessTargetSearch(Character currentCharacter)
        {
            var availableTargets = characterList
                .Where(t => IsWithinRange(currentCharacter.X, currentCharacter.Y, t.X, t.Y, currentCharacter.Range))
                .ToList();

            if (availableTargets.Count == 0)
            {
                return;
            }

            var target = currentCharacter.GetTarget(availableTargets);
            if (target == null)
            {
                return;
            }

            ProcessInteraction(currentCharacter, target);
        }

        protected void ProcessInteraction(Character currentCharacter, Character target)
        {
            if (currentCharacter is IHeal)
            {
                target.HealthPoints += (currentCharacter as IHeal).HealingPoints;
            }
            else if (currentCharacter is IAttack)
            {
                target.HealthPoints -= (currentCharacter as IAttack).AttackPoints - target.DefensePoints;
                if (target.HealthPoints <= 0)
                {
                    target.IsAlive = false;
                }
            }
        }

        protected bool IsWithinRange(int attackerX, int attackerY, int targetX, int targetY, int range)
        {
            double distance = Math.Sqrt(
                (attackerX - targetX) * (attackerX - targetX) +
                (attackerY - targetY) * (attackerY - targetY));

            return distance <= range;
        }

        protected Character GetCharacterById(string characterId)
        {
            return characterList.FirstOrDefault(x => x.Id == characterId);
        }

        protected Character GetCharacterByItem(Item item)
        {
            return characterList.FirstOrDefault(x => x.Inventory.Contains(item));
        }

        protected void PrintCharactersStatus(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
                Console.WriteLine(character.ToString());
            }
        }

        protected void PrintGameOutcome()
        {
            var charactersAlive = characterList.Where(c => c.IsAlive);
            var redTeamCount = charactersAlive.Count(x => x.Team == Team.Red);
            var blueTeamCount = charactersAlive.Count(x => x.Team == Team.Blue);

            if (redTeamCount == blueTeamCount)
            {
                Console.WriteLine("Tie game!");
            }
            else
            {
                string winningTeam = redTeamCount > blueTeamCount ? "Red" : "Blue";
                Console.WriteLine(winningTeam + " team wins the game!");
            }

            var aliveCharacters = characterList.Where(c => c.IsAlive);
            PrintCharactersStatus(aliveCharacters);
        }

        private void ReadUserInput()
        {
            string inputLine = Console.ReadLine();
            while (inputLine != string.Empty)
            {
                string[] parameters = inputLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                ExecuteCommand(parameters);
                inputLine = Console.ReadLine();
            }
        }
    }
}
