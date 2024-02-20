using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniteWheel
{
    class Dictionary
    {
        public static List<Pokemon> Pokemon = new List<Pokemon>();
        public static void LoadPokemon()
        {
            Pokemon.Add(new Pokemon("Absol", "Night Slash", "Pursuit", "Psycho Cut", "Sucker Punch"));
            Pokemon.Add(new Pokemon("Aegislash", "Sacred Sword", "Shadow Claw", "Wide Guard", "Iron Head"));
            Pokemon.Add(new Pokemon("Azumarill", "Play Rough", "Water Pulse", "Whirlpool", "Aqua Tail"));
            Pokemon.Add(new Pokemon("Blastoise", "Hydro Pump", "Water Spout", "Surf", "Rapid Spin"));
            Pokemon.Add(new Pokemon("Blaziken", "Blaze Kick", "Focus Blast", "Overheat", "Fire Punch"));
            Pokemon.Add(new Pokemon("Blissey", "Soft-Boiled", "Safeguard", "Egg Bomb", "Helping Hand"));
            Pokemon.Add(new Pokemon("Buzzwole", "Lunge", "Smack Down", "Leech Life", "Superpower"));
            Pokemon.Add(new Pokemon("Chandelure", "Flamethrower", "Overheat", "Poltergiest", "Imprison"));
            Pokemon.Add(new Pokemon("Charizard", "Flamethrower", "Fire Punch", "Fire Blast", "Flare Blitz"));
            Pokemon.Add(new Pokemon("Cinderace", "Pyro Ball", "Blaze Kick", "Flame Charge", "Feint"));
            Pokemon.Add(new Pokemon("Clefable", "Moonlight", "Draining Kiss", "Gravity", "Follow Me"));
            Pokemon.Add(new Pokemon("Comfey", "Floral Healing", "Sweet Kiss", "Magical Leaf", "Grass Knot"));
            Pokemon.Add(new Pokemon("Cramorant", "Air Slash", "Hurricane", "Dive", "Surf"));
            Pokemon.Add(new Pokemon("Crustle", "Rock Tomb", "Shell Smash", "Stealth Rock", "X-Scissor"));
            Pokemon.Add(new Pokemon("Decidueye", "Razor Leaf", "Spirit Shackle", "Leaf Storm", "Shadow Sneak"));
            Pokemon.Add(new Pokemon("Delphox", "Fire Blast", "Mystical Fire", "Fire Spin", "Flame Charge"));
            Pokemon.Add(new Pokemon("Dodrio", "Tri Attack", "Drill Peck", "Agility", "Jump Kick"));
            Pokemon.Add(new Pokemon("Dragapult", "Dragon Breath", "Shadow Ball", "Dragon Dance", "Phantom Force"));
            Pokemon.Add(new Pokemon("Dragonite", "Dragon Dance", "Extreme Speed", "Hyper Beam", "Outrage"));
            Pokemon.Add(new Pokemon("Duraludon", "Flash Cannon", "Dragon Pulse", "Stealth Rock", "Dragon Tail"));
            Pokemon.Add(new Pokemon("Eldegoss", "Pollen Puff", "Leaf Tornado", "Cotton Guard", "Cotton Spore"));
            Pokemon.Add(new Pokemon("Espeon", "Psyshock", "Stored Power", "Psybeam", "Future Sight"));
            Pokemon.Add(new Pokemon("Garchomp", "Dig", "Dragon Rush", "Earthquake", "Dragon Claw"));
            Pokemon.Add(new Pokemon("Gardevoir", "Psychic", "Moonblast", "Psyshock", "Future SIght"));
            Pokemon.Add(new Pokemon("Gengar", "Shadow Ball", "Sludge Bomb", "Dream Eater", "Hex"));
            Pokemon.Add(new Pokemon("Glaceon", "Icicle Spear", "Icy Wind", "Ice Shard", "Freeze Dry"));
            Pokemon.Add(new Pokemon("Goodra", "Muddy Water", "Dragon Pulse", "Power Whip", "Acid Spray"));
            Pokemon.Add(new Pokemon("Greedent", "Bullet Seed", "Belch", "Stuff Cheeks", "Covet"));
            Pokemon.Add(new Pokemon("Greninja", "Water Shuriken", "Surf", "Double Team", "Smokescreen"));
            Pokemon.Add(new Pokemon("Gyrados", "Dragon Breath", "Aqua Tail", "Waterfall", "Bounce"));
            Pokemon.Add(new Pokemon("Hoopa", "Hyperspace Hole", "Trick", "Phantom Force", "Shadow Ball"));
            Pokemon.Add(new Pokemon("Inteleon", "Fell Stinger", "Acrobatics", "Snipe Shot", "Liquidation"));
            Pokemon.Add(new Pokemon("Lapras", "Water Pulse", "Perish Song", "Bubble Beam", "Ice Beam"));
            Pokemon.Add(new Pokemon("Leafeon", "Razor Leaf", "Solar Blade", "Aerial Ace", "Leaf Blade"));
            Pokemon.Add(new Pokemon("Lucario", "Power-Up Punch", "Extreme Speed", "Bone Rush", "Close Combat"));
            Pokemon.Add(new Pokemon("Machamp", "Close Combat", "Cross Chop", "Dynamic Punch", "Submission"));
            Pokemon.Add(new Pokemon("Mamoswine", "Icicle Crash", "Ice Fang", "High Horsepower", "Earthquake"));
            Pokemon.Add(new Pokemon("Meowscarada", "Flower Trick", "Night Slash", "Double Team", "Trailblaze"));
            Pokemon.Add(new Pokemon("Metagross", "Meteor Mash", "Gyro Ball", "Zen Headbutt", "Magnet Rise"));
            Pokemon.Add(new Pokemon("Mew", new List<string> { "Electro Ball", "Solar Beam", "Surf" }, new List<string> { "Coaching", "Light Screen", "Agility" }));
            Pokemon.Add(new Pokemon("Mewtwo_X", "Future Sight", "Psystrike", "Recover", "Teleport"));
            Pokemon.Add(new Pokemon("Mewtwo_Y", "Future Sight", "Psystrike", "Recover", "Teleport"));
            Pokemon.Add(new Pokemon("Mimikyu", "Play Rough", "Shadow Claw", "Shadow Sneak", "Trick Room"));
            Pokemon.Add(new Pokemon("Mr. Mime", "Confusion", "Psychic", "Barrier", "Power Swap"));
            Pokemon.Add(new Pokemon("Ninetails", "Avalanche", "Dazzling Gleam", "Blizzard", "Aurora Veil"));
            Pokemon.Add(new Pokemon("Pikachu", "Electro Ball", "Thunder", "Volt Tackle", "Thunderbolt"));
            Pokemon.Add(new Pokemon("Sableye", "Knock Off", "Shadow Sneak", "Feint Attack", "Confuse Ray"));
            Pokemon.Add(new Pokemon("Scizor", "Bullet Punch", "Bullet Punch", "Double Hit", "Swords Dance"));
            Pokemon.Add(new Pokemon("Scyther", "Dual Wingbeat", "Dual Wingbeat", "Double Hit", "Swords Dance"));
            Pokemon.Add(new Pokemon("Slowbro", "Scald", "Surf", "Amnesia", "Telekinesis"));
            Pokemon.Add(new Pokemon("Snorlax", "Heavy Slam", "Flail", "Block", "Yawn"));
            Pokemon.Add(new Pokemon("Sylveon", "Mystical Fire", "Hyper Voice", "Draining Kiss", "Calm Mind"));
            Pokemon.Add(new Pokemon("Talonflame", "Flame Charge", "Aerial Ace", "Fly", "Brave Bird"));
            Pokemon.Add(new Pokemon("Trevenant", "Wood Hammer", "Curse", "Horn Leech", "Pain Split"));
            Pokemon.Add(new Pokemon("Tsareena", "Triple Axel", "Stomp", "Trop Kick", "Grassy Glide"));
            Pokemon.Add(new Pokemon("Tyranitar", "Dark Pulse", "Stone Edge", "Ancient Power", "Sand Tomb"));
            Pokemon.Add(new Pokemon("Umbreon", "Mean Look", "Foul Play", "Wish", "Snarl"));
            Pokemon.Add(new Pokemon("Urshifu", "Wicked Blow", "Wicked Blow", "Throat Chop", "Throat Chop"));
            Pokemon.Add(new Pokemon("Urshifu", "Surging Strikes", "Surging Strikes", "Liquidation", "Liquidation"));
            Pokemon.Add(new Pokemon("Venusaur", "Sludge Bomb", "Giga Drain", "Solar Beam", "Petal Dance"));
            Pokemon.Add(new Pokemon("Wigglytuff", "Sing", "Rollout", "Dazzling Gleam", "Double Slap"));
            Pokemon.Add(new Pokemon("Zacian", "Metal Claw", "Sacred Sword", "Agility", "Play Rough"));
            Pokemon.Add(new Pokemon("Zeraora", "Volt Switch", "Spark", "Discharge", "Wild Charge"));
            Pokemon.Add(new Pokemon("Zoroark", "Shadow Claw", "Cut", "Night Slash", "Feint Attack"));
        }
    }
}
