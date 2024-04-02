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
            Pokemon.Add(new Pokemon("Absol",
                new List<string> { "Night Slash", "Pursuit" },
                new List<string> { "Psycho Cut", "Sucker Punch" }));
            Pokemon.Add(new Pokemon("Aegislash",
                new List<string> { "Sacred Sword", "Shadow Claw" },
                new List<string> { "Wide Guard", "Iron Head" }));
            Pokemon.Add(new Pokemon("Azumarill",
                new List<string> { "Play Rough", "Water Pulse" },
                new List<string> { "Whirlpool", "Aqua Tail" }));
            Pokemon.Add(new Pokemon("Blastoise",
                new List<string> { "Hydro Pump", "Water Spout" },
                new List<string> { "Surf", "Rapid Spin" }));
            Pokemon.Add(new Pokemon("Blaziken",
                new List<string> { "Focus Blast", "Focus Blast" },
                new List<string> { "Fire Punch", "Fire Punch" }));
            Pokemon.Add(new Pokemon("Blaziken",
                new List<string> { "Blaze Kick", "Blaze Kick" },
                new List<string> { "Overheat", "Overheat" }));
            Pokemon.Add(new Pokemon("Blissey",
                new List<string> { "Soft-Boiled", "Safeguard" },
                new List<string> { "Egg Bomb", "Helping Hand" }));
            Pokemon.Add(new Pokemon("Buzzwole",
                new List<string> { "Lunge", "Smack Down" },
                new List<string> { "Leech Life", "Superpower" }));
            Pokemon.Add(new Pokemon("Chandelure",
                new List<string> { "Flamethrower", "Overheat" },
                new List<string> { "Poltergiest", "Imprison" }));
            Pokemon.Add(new Pokemon("Charizard",
                new List<string> { "Flamethrower", "Fire Punch" },
                new List<string> { "Fire Blast", "Flare Blitz" }));
            Pokemon.Add(new Pokemon("Cinderace",
                new List<string> { "Pyro Ball", "Blaze Kick" },
                new List<string> { "Flame Charge", "Feint" }));
            Pokemon.Add(new Pokemon("Clefable",
                new List<string> { "Moonlight", "Draining Kiss" },
                new List<string> { "Gravity", "Follow Me" }));
            Pokemon.Add(new Pokemon("Comfey",
                new List<string> { "Floral Healing", "Sweet Kiss" },
                new List<string> { "Magical Leaf", "Grass Knot" }));
            Pokemon.Add(new Pokemon("Cramorant",
                new List<string> { "Air Slash", "Hurricane" },
                new List<string> { "Dive", "Surf" }));
            Pokemon.Add(new Pokemon("Crustle",
                new List<string> { "Rock Tomb", "Shell Smash" },
                new List<string> { "Stealth Rock", "X-Scissor" }));
            Pokemon.Add(new Pokemon("Decidueye",
                new List<string> { "Razor Leaf", "Spirit Shackle" },
                new List<string> { "Leaf Storm", "Shadow Sneak" }));
            Pokemon.Add(new Pokemon("Delphox",
                new List<string> { "Fire Blast", "Mystical Fire" },
                new List<string> { "Fire Spin", "Flame Charge" }));
            Pokemon.Add(new Pokemon("Dodrio",
                new List<string> { "Tri Attack", "Drill Peck" },
                new List<string> { "Agility", "Jump Kick" }));
            Pokemon.Add(new Pokemon("Dragapult",
                new List<string> { "Dragon Breath", "Shadow Ball" },
                new List<string> { "Dragon Dance", "Phantom Force" }));
            Pokemon.Add(new Pokemon("Dragonite",
                new List<string> { "Dragon Dance", "Extreme Speed" },
                new List<string> { "Hyper Beam", "Outrage" }));
            Pokemon.Add(new Pokemon("Duraludon",
                new List<string> { "Flash Cannon", "Dragon Pulse" },
                new List<string> { "Stealth Rock", "Dragon Tail" }));
            Pokemon.Add(new Pokemon("Eldegoss",
                new List<string> { "Pollen Puff", "Leaf Tornado" },
                new List<string> { "Cotton Guard", "Cotton Spore" }));
            Pokemon.Add(new Pokemon("Espeon",
                new List<string> { "Psyshock", "Stored Power" },
                new List<string> { "Psybeam", "Future Sight" }));
            Pokemon.Add(new Pokemon("Garchomp",
                new List<string> { "Dig", "Dragon Rush" },
                new List<string> { "Earthquake", "Dragon Claw" }));
            Pokemon.Add(new Pokemon("Gardevoir",
                new List<string> { "Psychic", "Moonblast" },
                new List<string> { "Psyshock", "Future Sight" }));
            Pokemon.Add(new Pokemon("Gengar",
                new List<string> { "Shadow Ball", "Sludge Bomb" },
                new List<string> { "Dream Eater", "Hex" }));
            Pokemon.Add(new Pokemon("Glaceon",
                new List<string> { "Icicle Spear", "Icy Wind" },
                new List<string> { "Ice Shard", "Freeze Dry" }));
            Pokemon.Add(new Pokemon("Goodra",
                new List<string> { "Muddy Water", "Dragon Pulse" },
                new List<string> { "Power Whip", "Acid Spray" }));
            Pokemon.Add(new Pokemon("Greedent",
                new List<string> { "Bullet Seed", "Belch" },
                new List<string> { "Stuff Cheeks", "Covet" }));
            Pokemon.Add(new Pokemon("Greninja",
                new List<string> { "Water Shuriken", "Surf" },
                new List<string> { "Double Team", "Smokescreen" }));
            Pokemon.Add(new Pokemon("Gyrados",
                new List<string> { "Dragon Breath", "Aqua Tail" },
                new List<string> { "Waterfall", "Bounce" }));
            Pokemon.Add(new Pokemon("Hoopa",
                new List<string> { "Hyperspace Hole", "Trick" },
                new List<string> { "Phantom Force", "Shadow Ball" }));
            Pokemon.Add(new Pokemon("Inteleon",
                new List<string> { "Fell Stinger", "Acrobatics" },
                new List<string> { "Snipe Shot", "Liquidation" }));
            Pokemon.Add(new Pokemon("Lapras",
                new List<string> { "Water Pulse", "Perish Song" },
                new List<string> { "Bubble Beam", "Ice Beam" }));
            Pokemon.Add(new Pokemon("Leafeon",
                new List<string> { "Razor Leaf", "Solar Blade" },
                new List<string> { "Aerial Ace", "Leaf Blade" }));
            Pokemon.Add(new Pokemon("Lucario",
                new List<string> { "Power-Up Punch", "Extreme Speed" },
                new List<string> { "Bone Rush", "Close Combat" }));
            Pokemon.Add(new Pokemon("Machamp",
                new List<string> { "Close Combat", "Cross Chop" },
                new List<string> { "Dynamic Punch", "Submission" }));
            Pokemon.Add(new Pokemon("Mamoswine",
                new List<string> { "Icicle Crash", "Ice Fang" },
                new List<string> { "High Horsepower", "Earthquake" }));
            Pokemon.Add(new Pokemon("Meowscarada",
                new List<string> { "Flower Trick", "Night Slash" },
                new List<string> { "Double Team", "Trailblaze" }));
            Pokemon.Add(new Pokemon("Metagross",
                new List<string> { "Meteor Mash", "Gyro Ball" },
                new List<string> { "Zen Headbutt", "Magnet Rise" }));
            Pokemon.Add(new Pokemon("Mew",
                new List<string> { "Electro Ball", "Solar Beam", "Surf" },
                new List<string> { "Coaching", "Light Screen", "Agility" }));
            Pokemon.Add(new Pokemon("Mewtwo_X",
                new List<string> { "Future Sight", "Psystrike" },
                new List<string> { "Recover", "Teleport" }));
            Pokemon.Add(new Pokemon("Mewtwo_Y",
                new List<string> { "Future Sight", "Psystrike" },
                new List<string> { "Recover", "Teleport" }));
            Pokemon.Add(new Pokemon("Mimikyu",
                new List<string> { "Play Rough", "Shadow Claw" },
                new List<string> { "Shadow Sneak", "Trick Room" }));
            Pokemon.Add(new Pokemon("Miraidon",
                new List<string> { "Charge Beam", "Electro Drift" },
                new List<string> { "Thunder", "Parabolic Charge" }));
            Pokemon.Add(new Pokemon("Mr. Mime",
                new List<string> { "Confusion", "Psychic" },
                new List<string> { "Barrier", "Power Swap" }));
            Pokemon.Add(new Pokemon("Ninetails",
                new List<string> { "Avalanche", "Dazzling Gleam" },
                new List<string> { "Blizzard", "Aurora Veil" }));
            Pokemon.Add(new Pokemon("Pikachu",
                new List<string> { "Electro Ball", "Thunder" },
                new List<string> { "Volt Tackle", "Thunderbolt" }));
            Pokemon.Add(new Pokemon("Sableye",
                new List<string> { "Knock Off", "Shadow Sneak" },
                new List<string> { "Feint Attack", "Confuse Ray" }));
            Pokemon.Add(new Pokemon("Scizor",
                new List<string> { "Bullet Punch", "Bullet Punch" },
                new List<string> { "Double Hit", "Swords Dance" }));
            Pokemon.Add(new Pokemon("Scyther",
                new List<string> { "Dual Wingbeat", "Dual Wingbeat" },
                new List<string> { "Double Hit", "Swords Dance" }));
            Pokemon.Add(new Pokemon("Slowbro",
                new List<string> { "Scald", "Surf" },
                new List<string> { "Amnesia", "Telekinesis" }));
            Pokemon.Add(new Pokemon("Snorlax",
                new List<string> { "Heavy Slam", "Flail" },
                new List<string> { "Block", "Yawn" }));
            Pokemon.Add(new Pokemon("Sylveon",
                new List<string> { "Mystical Fire", "Hyper Voice" },
                new List<string> { "Draining Kiss", "Calm Mind" }));
            Pokemon.Add(new Pokemon("Talonflame",
                new List<string> { "Flame Charge", "Aerial Ace" },
                new List<string> { "Fly", "Brave Bird" }));
            Pokemon.Add(new Pokemon("Trevenant",
                new List<string> { "Wood Hammer", "Curse" },
                new List<string> { "Horn Leech", "Pain Split" }));
            Pokemon.Add(new Pokemon("Tsareena",
                new List<string> { "Triple Axel", "Stomp" },
                new List<string> { "Trop Kick", "Grassy Glide" }));
            Pokemon.Add(new Pokemon("Tyranitar",
                new List<string> { "Dark Pulse", "Stone Edge" },
                new List<string> { "Ancient Power", "Sand Tomb" }));
            Pokemon.Add(new Pokemon("Umbreon",
                new List<string> { "Mean Look", "Foul Play" },
                new List<string> { "Wish", "Snarl" }));
            Pokemon.Add(new Pokemon("Urshifu",
                new List<string> { "Wicked Blow", "Wicked Blow" },
                new List<string> { "Throat Chop", "Throat Chop" }));
            Pokemon.Add(new Pokemon("Urshifu",
                new List<string> { "Surging Strikes", "Surging Strikes" },
                new List<string> { "Liquidation", "Liquidation" }));
            Pokemon.Add(new Pokemon("Venusaur",
                new List<string> { "Sludge Bomb", "Giga Drain" },
                new List<string> { "Solar Beam", "Petal Dance" }));
            Pokemon.Add(new Pokemon("Wigglytuff",
                new List<string> { "Sing", "Rollout" },
                new List<string> { "Dazzling Gleam", "Double Slap" }));
            Pokemon.Add(new Pokemon("Zacian",
                new List<string> { "Metal Claw", "Sacred Sword" },
                new List<string> { "Agility", "Play Rough" }));
            Pokemon.Add(new Pokemon("Zeraora",
                new List<string> { "Volt Switch", "Spark" },
                new List<string> { "Discharge", "Wild Charge" }));
            Pokemon.Add(new Pokemon("Zoroark",
                new List<string> { "Shadow Claw", "Cut" },
                new List<string> { "Night Slash", "Feint Attack" }));
        }
    }
}
