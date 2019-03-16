namespace DungeonsAndCodeWizards.Core
{
    using Models.Characters;
    using System.Collections.Generic;
    using Models;
    using System;
    using Models.Characters.Enums;
    using DungeonsAndCodeWizards.Validaros;
    using DungeonsAndCodeWizards.Factories;
    using System.Linq;
    using System.Text;

    public class DungeonMaster
    {
        private List<Character> party;
        private List<Item> pool;
        private int lastSurvivorsRounds;

        public DungeonMaster()
        {
            this.party = new List<Character>();
            this.pool = new List<Item>();
            this.lastSurvivorsRounds = 0;
        }

        public string JoinParty(string[] args)
        {
            var factionName = args[0];
            var characterType = args[1];
            var name = args.Skip(2).ToArray()[0];

            var faction = Validator.ValidateFaction(factionName);

            var character = CharacterFactory.CraetCharacter(characterType, name, faction);

            this.party.Add(character);

            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            var itemName = args[0];

            var item = ItemFactory.CreateItem(itemName);

            this.pool.Add(item);

            return $"{itemName} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            var characterName = args[0];

            var character = GetCharacterFromPoolByName(characterName);

            Validator.ValidateCharacterInParty(character, characterName);
            Validator.EmptyPool(this.pool.Count);

            var index = this.pool.Count - 1;
            var item = this.pool[index];
            this.pool.RemoveAt(index);

            character.ReceiveItem(item);

            return $"{character.Name} picked up {item.GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            var characterName = args[0];
            var character = GetCharacterFromPoolByName(characterName);
            Validator.ValidateCharacterInParty(character, characterName);

            var itemName = args[1];
            var item = GetItemFromCharacterBag(character, itemName);

            character.UseItem(item);
            this.pool.Remove(item);

            return $"{character.Name} used {item.GetType().Name}.";
        }

        public string UseItemOn(string[] args)
        {
            var giverName = args[0];
            var giver = GetCharacterFromPoolByName(giverName);
            Validator.ValidateCharacterInParty(giver, giverName);

            var receiverName = args[1];
            var receiver = GetCharacterFromPoolByName(receiverName);
            Validator.ValidateCharacterInParty(receiver, receiverName);

            var itemName = args[2];
            var item = GetItemFromCharacterBag(giver, itemName);
            Validator.DoesItemExist(itemName, item);

            giver.UseItemOn(item, receiver);
            this.pool.Remove(item);

            return $"{giverName} used {itemName} on {receiverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            var giverName = args[0];
            var giver = GetCharacterFromPoolByName(giverName);
            Validator.ValidateCharacterInParty(giver, giverName);

            var receiverName = args[1];
            var receiver = GetCharacterFromPoolByName(receiverName);
            Validator.ValidateCharacterInParty(receiver, receiverName);

            var itemName = args[2];
            var item = GetItemFromCharacterBag(giver, itemName);
            Validator.DoesItemExist(itemName, item);


            giver.GiveCharacterItem(item, receiver);

            return $"{giverName} gave {receiverName} {itemName}.";
        }

        public string GetStats()
        {
            var oredered = this.party.OrderByDescending(c => c.IsAlive)
                                     .ThenByDescending(c => c.Health);

            var result = new StringBuilder();

            foreach (var character in oredered)
            {
                var deadOrAlive = character.IsAlive ? "Alive" : "Dead";

                result.Append($"{character.Name} - ")
                      .Append($"HP: {character.Health}/{character.BaseHealth}")
                      .Append($", AP: {character.Armor}/{character.BaseArmor}, ")
                      .AppendLine($"Status: {deadOrAlive}");
            }

            return result.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            var attackerName = args[0];
            var attacker = GetCharacterFromPoolByName(attackerName);
            Validator.ValidateCharacterInParty(attacker, attackerName);

            var receiverName = args[1];
            var receiver = GetCharacterFromPoolByName(receiverName);
            Validator.ValidateCharacterInParty(receiver, receiverName);


            Validator.ValidateAttacker(attacker);
            var worrior = attacker as Warrior;
            worrior.Attack(receiver);

            var result = new StringBuilder();
            result.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

            if (!receiver.IsAlive)
            {
                result.AppendLine($"{receiver.Name} is dead!");
            }

            return result.ToString().TrimEnd();
        }

        public string Heal(string[] args)
        {
            var healerName = args[0];
            var healer = GetCharacterFromPoolByName(healerName);
            Validator.ValidateCharacterInParty(healer, healerName);

            var healingReceiverName = args[1];
            var receiver = GetCharacterFromPoolByName(healingReceiverName);
            Validator.ValidateCharacterInParty(receiver, healingReceiverName);


            Validator.ValidateHealer(healer);

            var cleric = healer as Cleric;
            cleric.Heal(receiver);

            return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
        }

        public string EndTurn(string[] args)
        {
            var aliveCharacters = this.party.Where(c => c.IsAlive == true);

            var result = new StringBuilder();

            foreach (var character in aliveCharacters)
            {
                var healthBeforeRest = character.Health;

                character.Rest();

                result.AppendLine($"{character.Name} rests ({healthBeforeRest} => {character.Health})");
            }

            if (aliveCharacters.Count() == 1 || aliveCharacters.Count() == 0)
            {
                this.lastSurvivorsRounds++;
            }

            return result.ToString().TrimEnd();
        }

        public bool IsGameOver()
        {
            if (lastSurvivorsRounds > 1)
            {
                return true;
            }

            return false;
        }

        private Character GetCharacterFromPoolByName(string characterName)
        {
            return this.party.FirstOrDefault(c => c.Name == characterName);
        }

        private Item GetItemFromCharacterBag(Character character, string itemName)
        {
            return character.Bag.GetItem(itemName);
        }
    }
}
