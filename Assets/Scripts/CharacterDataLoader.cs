using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

public class CharacterDataLoader : MonoBehaviour
{
    // This list will be filled in the Unity Editor
    public List<CharacterData> allCharacters = new List<CharacterData>();

    public List<CharacterDataLoaderFormat> dataToLoad = new List<CharacterDataLoaderFormat>();

    public void OnEnable()
    {
        #region populate database
        //    Name: Glimmerfang, Description: A swift and agile reptilian creature with venomous fangs, striking from
        // the shadows. Health: 80, Attack: 95, Defense: 60, tier: 0
        dataToLoad.Add(new CharacterDataLoaderFormat("Glimmerfang", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Common, 80, 95, 60, 0,
            "A swift and agile reptilian creature with venomous fangs, striking from the shadows."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Stonehide", CharacterGender.Monsters, CharacterRole.DamageDealer,
            Rarity.Common, 90, 85, 70, 1,
            "A hulking beast with rocky skin and powerful claws, capable of shattering defenses."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Emberwing", CharacterGender.Monsters, CharacterRole.DamageDealer,
            Rarity.Common, 75, 100, 55, 2,
            "A fiery avian creature that dives from the sky, unleashing scorching attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Shadowwhisper", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Common, 85, 90, 65, 3,
            "A stealthy, spectral entity that phases through obstacles to deliver precise, debilitating strikes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Frostmaw", CharacterGender.Monsters, CharacterRole.DamageDealer,
            Rarity.Uncommon, 90, 110, 75, 0,
            "A fearsome, ice-elemental predator that can freeze foes in their tracks before delivering bone-chilling blows."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Thornback", CharacterGender.Monsters, CharacterRole.DamageDealer,
            Rarity.Uncommon, 100, 105, 80, 1,
            "A bristling behemoth covered in razor-sharp spines, capable of both impaling enemies and reflecting damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sparkcoil", CharacterGender.Monsters, CharacterRole.DamageDealer,
            Rarity.Uncommon, 85, 115, 70, 2,
            "A creature of pure electricity, zapping enemies with unpredictable bursts of lightning."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Venomscale", CharacterGender.Monsters, CharacterRole.DamageDealer,
            Rarity.Uncommon, 95, 108, 78, 3,
            "A highly intelligent serpent with potent, corrosive venom that melts through armor and flesh alike."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Soulreaper", CharacterGender.Monsters, CharacterRole.DamageDealer,
            Rarity.Rare, 105, 130, 85, 0,
            "A spectral being that drains the life force of its enemies, growing stronger with each strike."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Dreadwing", CharacterGender.Monsters, CharacterRole.DamageDealer,
            Rarity.Rare, 115, 125, 90, 1,
            "A colossal, ancient beast with wings that blot out the sun, unleashing devastating sonic screams and powerful talons."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Infernoheart", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Rare, 100, 135, 80, 2,
            "A creature born of volcanic fire, its very presence scorches the battlefield, incinerating all in its path."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronosplitter", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Rare, 110, 128, 88, 3,
            "A mysterious entity that manipulates time, allowing it to strike multiple times in an instant or rewind moments to escape damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Abyssal Maw", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Legendary, 130, 160, 100, 0,
            "An unfathomable horror from the deepest voids, capable of devouring entire dimensions and unleashing cosmic energy."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Worldbreaker", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Legendary, 140, 155, 105, 1,
            "A titan of primordial chaos, its every movement causes earthquakes and splits the very fabric of reality."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aetherwing", CharacterGender.Monsters, CharacterRole.DamageDealer,
            Rarity.Legendary, 125, 165, 95, 2,
            "A celestial dragon whose scales shimmer with starlight and whose breath conjures supernovas, burning all opposition."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Paradox Engine", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Legendary, 135, 158, 102, 3,
            "A sentient construct of pure logic and anti-matter, it can unravel the laws of physics to unleash impossible attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos Archon", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Mythic, 150, 180, 115, 0,
            "A being beyond time itself, capable of existing in past, present, and future simultaneously, unleashing strikes that reverberate through eternity."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Void Weaver", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Mythic, 160, 175, 120, 1,
            "The living embodiment of the cosmic void, capable of tearing holes in reality and summoning oblivion to consume its foes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Primordial Spark", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Mythic, 145, 185, 110, 2,
            "The genesis of all life and destruction, its essence can ignite entire star systems or snuff them out with a thought."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nexus Behemoth", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Mythic, 155, 178, 118, 3,
            "A creature formed from the convergence of all dimensions, wielding powers that defy comprehension and reshape existence at will."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Stormbinder", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Epic, 120, 145, 90, 0,
            "A magnificent avian creature that commands the very essence of tempests, striking with bolts of lightning and furious gales."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ironhide Colossus", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Epic, 130, 140, 95, 1,
            "A mountainous goliath whose skin is tougher than steel, capable of shrugging off devastating blows while delivering earth-shattering attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Blightfang Serpent", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Epic, 115, 150, 85, 2,
            "A monstrous, ancient serpent whose venom not only poisons but also rapidly decays everything it touches."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Runic Golem", CharacterGender.Monsters,
            CharacterRole.DamageDealer, Rarity.Epic, 125, 148, 92, 3,
            "An animated construct of enchanted stone, inscribed with powerful arcane runes that allow it to unleash destructive magical energy."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gloworm", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Common, 70, 20, 50, 0,
            "A bioluminescent worm-like creature that emits soothing light, mending minor wounds."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sporeling", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Common, 65, 15, 45, 1,
            "A small, mushroom-like creature that releases restorative spores, providing basic healing."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Mistletoad", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Common, 75, 25, 55, 2, "A warty amphibian that secretes a sticky, healing balm to aid allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Flutterwing", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Common, 60, 10, 40, 3,
            "A tiny, insectoid creature whose gentle wingbeats create a calming, regenerative aura."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nectarbuzz", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Uncommon, 85, 30, 65, 0,
            "A large, bee-like creature that collects magical nectar, distributing it to allies for significant healing."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Mossback Turtle", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Uncommon, 90, 25, 70, 1,
            "A slow-moving turtle with ancient moss growing on its shell, radiating restorative energy to those nearby."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Spirit Fox", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Uncommon, 80, 35, 60, 2,
            "An ethereal fox that channels natural energies to rejuvenate allies and cleanse minor ailments."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Whisperwind Sprite", CharacterGender.Monsters,
            CharacterRole.Healer, Rarity.Uncommon, 75, 28, 58, 3,
            "A delicate, airy creature that can conjure gentle breezes imbued with healing properties."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Verdant Guardian", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Epic, 130, 50, 100, 0,
            "A majestic, tree-like being that anchors itself to the earth, drawing immense life energy to heal and protect its allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Phoenix Hatchling", CharacterGender.Monsters,
            CharacterRole.Healer, Rarity.Epic, 120, 60, 90, 1,
            "Though young, this fiery bird possesses the essence of rebirth, capable of resurrecting fallen allies and mending grievous wounds."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Tidal Serpent", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Epic, 125, 55, 95, 2,
            "A graceful aquatic creature that commands pure, cleansing waters to wash away harm and restore vitality to its team."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Star-Moth Oracle", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Epic, 118, 58, 88, 3,
            "A giant moth whose wings are constellations, scattering stardust that illuminates and rapidly heals all allies within its radiant aura."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Life-Binder Dragon", CharacterGender.Monsters,
            CharacterRole.Healer, Rarity.Legendary, 150, 70, 120, 0,
            "An ancient dragon whose breath can knit flesh and bone instantly, capable of restoring entire teams from the brink of defeat."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Astral Jellyfish", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Legendary, 140, 65, 115, 1,
            "A colossal, translucent creature from beyond the stars, whose ethereal pulsations mend wounds and even rewind time on injuries."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gaia's Heart", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Legendary, 160, 60, 130, 2,
            "The living core of a forgotten world, manifesting as a gentle, colossal beast that channels the very essence of planetary restoration."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Spirit of Elysium", CharacterGender.Monsters,
            CharacterRole.Healer, Rarity.Legendary, 145, 75, 110, 3,
            "An otherworldly entity whose form is pure light, capable of bestowing divine blessings that make allies virtually invulnerable for short periods."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Crystal Golem", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Rare, 105, 40, 80, 0,
            "A benevolent construct infused with pure healing crystals, radiating restorative energy to nearby allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Moonpetal Sprite", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Rare, 100, 35, 75, 1,
            "A delicate, nocturnal creature whose luminous petals fall, mending wounds and bestowing temporary resilience."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Deepwood Shaman", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Rare, 110, 45, 85, 2,
            "An ancient, wise creature of the forest, weaving powerful nature magic to rejuvenate allies and dispel curses."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Songbird Siren", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Rare, 98, 42, 78, 3,
            "A creature whose enchanting melodies have potent healing properties, calming allies and restoring their vigor with each note."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cosmic Bloom", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Mythic, 170, 80, 135, 0,
            "A colossal, sentient flower that draws energy from nascent stars, capable of instantly regenerating allies and resurrecting the fallen."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lifeblood Seraph", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Mythic, 165, 78, 130, 1,
            "An angelic creature woven from pure healing energy, its presence alone restores vitality and grants temporary immortality to those it protects."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Fountain of Ages", CharacterGender.Monsters, CharacterRole.Healer,
            Rarity.Mythic, 180, 75, 140, 2,
            "A living, primordial spring whose waters flow with the essence of time itself, reversing all damage and ailments on a cellular level."));
        dataToLoad.Add(new CharacterDataLoaderFormat("World-Tree Sprout", CharacterGender.Monsters,
            CharacterRole.Healer, Rarity.Mythic, 175, 82, 128, 3,
            "The nascent form of a universal tree, its roots connect to all life, allowing it to channel boundless regenerative power across the battlefield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Shrieker Bat", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Common, 60, 10, 40, 0,
            "A small bat that emits a high-pitched sonic shriek, momentarily disorienting enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sticky Slime", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Common, 70, 5, 50, 1,
            "A harmless blob that can exude a viscous substance, slowing down nearby foes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Watchful Owl", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Common, 65, 12, 45, 2,
            "An owl with keen eyesight that can spot enemy weaknesses, granting minor buffs to allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Pebble-Pusher", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Common, 55, 8, 35, 3,
            "A small, rock-dwelling creature that can strategically move obstacles or create small distractions."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Echo Cricket", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Uncommon, 80, 18, 60, 0,
            "A large cricket whose rhythmic chirps can inspire allies, granting minor speed or attack bonuses."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Glow-Puff", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Uncommon, 75, 15, 55, 1,
            "A floating, luminescent creature that can emit blinding flashes, debuffing enemy accuracy."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Mimic Goo", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Uncommon, 85, 20, 65, 2,
            "A shapeless entity that can briefly copy a single enemy's buff and apply it to an ally."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Scent Hound", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Uncommon, 70, 22, 58, 3,
            "A canine creature with an unparalleled sense of smell, capable of tracking hidden enemies or revealing enemy traps."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chrono-Mite", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Epic, 110, 30, 85, 0,
            "A small, iridescent insect that can briefly manipulate localized time, granting allies extra turns or delaying enemy actions."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Geomancer Worm", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Epic, 125, 25, 95, 1,
            "A massive subterranean worm capable of shifting the earth, creating barriers for allies or difficult terrain for enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Dreamweaver Spider", CharacterGender.Monsters,
            CharacterRole.Support, Rarity.Epic, 115, 35, 90, 2,
            "A mystical arachnid that spins ethereal webs, entrapping enemies in illusions or bolstering allies with protective enchantments."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Echoing Siren", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Epic, 105, 38, 80, 3,
            "A beautiful yet formidable creature whose melodic calls can charm enemies into fighting for you, or grant powerful, sustained buffs to allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Shadow Veil", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Rare, 95, 25, 70, 0,
            "An amorphous creature that can cloak allies in a shroud of darkness, making them harder to target and increasing their evasion."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aura Lynx", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Rare, 100, 28, 75, 1,
            "A mystical feline whose purrs generate a protective aura, reducing incoming damage for nearby allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Spirit Guide", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Rare, 90, 20, 68, 2,
            "A wispy, ghost-like creature that can soothe allies' minds, removing negative status effects and boosting their resolve."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Rune Toucan", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Rare, 88, 30, 65, 3,
            "A brightly colored bird whose feathers are inscribed with ancient runes, capable of dispelling enemy buffs or marking targets for increased damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Galactic Architect", CharacterGender.Monsters,
            CharacterRole.Support, Rarity.Legendary, 130, 45, 110, 0,
            "A cosmic entity capable of subtly reshaping the battlefield, creating advantageous terrain for allies or impossible obstacles for foes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Fate Weaver", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Legendary, 125, 50, 105, 1,
            "A mysterious creature that can pluck at the threads of destiny, altering critical hit chances or forcing enemy attacks to miss."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos-Shard", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Legendary, 135, 48, 115, 2,
            "A living fragment of temporal energy, able to freeze specific enemies in time or grant allies multiple actions in a single turn."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Empyrean Choir", CharacterGender.Monsters, CharacterRole.Support,
            Rarity.Legendary, 120, 55, 100, 3,
            "A chorus of celestial beings whose combined harmonies can inspire unmatched courage and strength in allies, making them immune to control effects."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Paradigm Shifter", CharacterGender.Monsters,
            CharacterRole.Support, Rarity.Mythic, 150, 60, 130, 0,
            "An entity from beyond known reality, capable of altering the fundamental rules of combat, turning disadvantages into overwhelming strengths."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Quantum Symbiote", CharacterGender.Monsters,
            CharacterRole.Support, Rarity.Mythic, 145, 65, 125, 1,
            "A creature that merges with an ally, granting them perfect foresight, allowing them to dodge any attack or respond with devastating precision."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Echo of Creation", CharacterGender.Monsters,
            CharacterRole.Support, Rarity.Mythic, 160, 58, 135, 2,
            "A primal sound wave given form, capable of mimicking and amplifying any beneficial effect on the battlefield to an infinite degree."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Stellar Cartographer", CharacterGender.Monsters,
            CharacterRole.Support, Rarity.Mythic, 155, 62, 128, 3,
            "A cosmic navigator whose very presence aligns the celestial bodies, showering allies with buffs drawn from constellations and disrupting enemy strategies with gravitational anomalies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ironclad Beetle", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Common, 120, 20, 80, 0,
            "A hardy beetle with a remarkably tough exoskeleton, able to absorb basic attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Stone-Skin Boar", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Common, 130, 25, 75, 1,
            "A stubborn wild boar whose hide is thick and resilient, charging headfirst into danger."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Mud Golem", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Common, 115, 18, 85, 2,
            "A slow-moving creature formed from compacted mud, soaking up damage with its earthy body."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Shelled Snail", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Common, 125, 15, 70, 3,
            "A massive snail that can retract into its incredibly strong shell, providing solid cover."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Obsidian Tortoise", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Uncommon, 150, 30, 100, 0,
            "An ancient tortoise whose shell is forged from volcanic rock, making it highly resistant to all forms of damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Barkskin Bear", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Uncommon, 160, 35, 95, 1,
            "A colossal bear whose fur has merged with thick tree bark, granting it immense natural armor and regeneration."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Frost Ram", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Uncommon, 145, 28, 105, 2,
            "A hardy ram from icy peaks, its horns are like glaciers and its hide impervious to cold, capable of withstanding heavy assaults."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Living Wall", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Uncommon, 155, 25, 98, 3,
            "An animated mass of entangled vines and roots, capable of growing thicker and stronger to absorb incoming attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Adamant Rhino", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Rare, 180, 40, 120, 0,
            "A beast whose hide is fused with rare, unbreakable minerals, allowing it to shrug off even the most powerful blows."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Titanic Crab", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Rare, 190, 35, 115, 1,
            "A gargantuan crustacean with pincers that can snap steel and a carapace as strong as a fortress wall."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Earth-Heart Golem", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Rare, 175, 38, 125, 2,
            "A powerful golem animated by a pure earth elemental, capable of absorbing and redirecting massive amounts of damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Shieldback Dragon", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Rare, 185, 30, 118, 3,
            "A rare, smaller dragon species whose primary defense is an incredibly dense, scale-plated back that can endure barrages of attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Dreadnought Behemoth", CharacterGender.Monsters,
            CharacterRole.Tank, Rarity.Epic, 210, 45, 140, 0,
            "A colossal creature with natural armor plating that can withstand siege weaponry, forming an impenetrable barrier."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Obsidian Colossus", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Epic, 220, 40, 135, 1,
            "A titanic entity carved from solidified lava and obsidian, virtually immune to heat and incredibly dense."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Runic Guardian", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Epic, 205, 42, 145, 2,
            "An ancient protector creature whose body is etched with powerful defensive runes, deflecting magic and physical attacks alike."));
        dataToLoad.Add(new CharacterDataLoaderFormat("World-Shell Serpent", CharacterGender.Monsters,
            CharacterRole.Tank, Rarity.Epic, 215, 38, 138, 3,
            "A gargantuan serpent that can coil itself to form a living shield, capable of absorbing city-destroying impacts."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Terraformer Titan", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Legendary, 250, 55, 170, 0,
            "A colossal entity that embodies the very crust of a planet, capable of growing mountains to shield allies or shifting tectonic plates to absorb damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aegis Serpent", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Legendary, 240, 50, 165, 1,
            "An ethereal serpent whose scales are made of solidified defensive magic, forming an almost unbreakable barrier against all forms of attack."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Void Golem", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Legendary, 260, 48, 175, 2,
            "A golem infused with the essence of a black hole, drawing in and neutralizing all incoming damage into its core."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Invincible Warden", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Legendary, 245, 52, 168, 3,
            "A primordial guardian creature whose very existence defies destruction, passively redirecting harm and reinforcing allies' defenses."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cosmic Barrier", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Mythic, 300, 65, 200, 0,
            "An entity that is literally a fragment of a collapsed star, creating gravitational fields that distort and absorb all incoming harm."));
        dataToLoad.Add(new CharacterDataLoaderFormat("World-Ender's Core", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Mythic, 290, 60, 195, 1,
            "The core of a vanquished cosmic horror, which, though dormant, projects an impenetrable aura that negates all attacks within its range."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nexus Shard", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Mythic, 310, 58, 205, 2,
            "A crystalline creature that can solidify reality around it, making allies immune to damage and status effects within its protective field."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Indomitable Aegis", CharacterGender.Monsters, CharacterRole.Tank,
            Rarity.Mythic, 295, 62, 198, 3,
            "The ultimate defender, a creature whose will alone can manifest absolute protection, absorbing damage from allies and redirecting it into the void."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Spark Droner", CharacterGender.Robots, CharacterRole.DamageDealer,
            Rarity.Common, 85, 90, 60, 0,
            "A small, agile robot equipped with twin energy emitters, firing rapid, low-damage bursts."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sawblade Unit", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Common, 90, 88, 65, 1,
            "A simple combat robot armed with spinning sawblades, excelling in close-quarters shredding."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Bolt-Caster", CharacterGender.Robots, CharacterRole.DamageDealer,
            Rarity.Common, 80, 92, 55, 2,
            "A utilitarian robot designed to fire high-velocity metallic bolts at individual targets."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Scorch Bot", CharacterGender.Robots, CharacterRole.DamageDealer,
            Rarity.Common, 95, 85, 70, 3,
            "A basic automaton with a built-in flamethrower, effective at damaging multiple adjacent foes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Railgun Striker", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Uncommon, 95, 110, 70, 0,
            "A specialized robot armed with a compact railgun, capable of firing high-penetration slugs through multiple targets."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Plasma Disruptor", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Uncommon, 100, 105, 75, 1,
            "A bipedal automaton that generates unstable plasma, unleashing volatile bursts that explode on impact."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Laser Weaver", CharacterGender.Robots, CharacterRole.DamageDealer,
            Rarity.Uncommon, 90, 115, 65, 2,
            "A sleek robot equipped with multiple adjustable laser emitters, capable of precise, continuous damage or wide-arc sweeps."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kinetic Pulverizer", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Uncommon, 105, 108, 78, 3,
            "A heavily armored bot with oversized mechanical fists, dealing devastating kinetic damage in close combat."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Annihilator Unit", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Epic, 120, 145, 90, 0,
            "A heavily armed robotic platform bristling with missile launchers and rotary cannons, designed for widespread destruction."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Quantum Slicer", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Epic, 115, 150, 85, 1,
            "An agile combat android equipped with energy blades that vibrate at a quantum frequency, capable of cutting through any material."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Singularity Cannon", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Epic, 130, 140, 95, 2,
            "A massive, slow-moving robot whose primary weapon creates miniature black holes, pulling in and crushing enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chrono-Striker", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Epic, 125, 148, 92, 3,
            "A highly advanced robot that can briefly manipulate localized time, allowing it to unleash a flurry of attacks in rapid succession."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ion Blaster", CharacterGender.Robots, CharacterRole.DamageDealer,
            Rarity.Rare, 105, 130, 80,  0,
            "A combat robot equipped with a sophisticated ion cannon, firing concentrated energy beams that pierce armor."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Electro-Scourge", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Rare, 110, 125, 85, 1,
            "An airborne drone platform that generates powerful electrical storms, shocking multiple enemies simultaneously."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sonic Devastator", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Rare, 100, 135, 75, 2,
            "A bipedal robot with integrated sonic emitters, capable of generating destructive sound waves that shatter defenses."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nanite Swarmer", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Rare, 108, 128, 78, 3,
            "A robotic hive that deploys self-replicating nanobots, slowly corroding enemies from the inside out."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Armageddon Protocol", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Legendary, 140, 165, 100, 0,
            "A colossal war machine designed to end conflicts swiftly, capable of unleashing tactical nukes or superheated plasma blasts."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Reality Warper", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Legendary, 135, 170, 95, 1,
            "An advanced android capable of distorting local spacetime, causing enemies to spontaneously combust or be crushed by immense pressure."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Celestial Forge", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Legendary, 130, 175, 90, 2,
            "A robotic construct that harnesses stellar energy, firing miniature suns or unleashing solar flares that devastate the entire battlefield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Absolute Zero", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Legendary, 145, 168, 102, 3,
            "A robotic assassin that manipulates cryonic energies, freezing targets solid and shattering them with extreme cold."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Omega Destroyer", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Mythic, 160, 200, 120, 0,
            "The ultimate weapon, a robot capable of generating and wielding anti-matter, erasing targets from existence with a single strike."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Singularity Engine", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Mythic, 155, 195, 115, 1,
            "A colossal automaton that contains a stable black hole within its core, deploying miniature singularities that can consume entire battlefields."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cosmic Reaver", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Mythic, 150, 205, 110, 2,
            "An extra-dimensional robot whose weapons tap into the fabric of reality itself, unleashing cosmic rays that unravel foes at a molecular level."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Final Judgment", CharacterGender.Robots,
            CharacterRole.DamageDealer, Rarity.Mythic, 165, 198, 122, 3,
            "A self-aware AI housed in an indestructible chassis, capable of analyzing enemy weaknesses instantly and delivering perfectly calibrated, fatal blows."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Medi-Bot 7", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Common, 70, 10, 50, 0,
            "A basic medical drone equipped with a repair beam for minor structural damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Patch-Up Unit", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Common, 65, 8, 45, 1,
            "A small, wheeled robot designed to apply temporary patches and stabilizers to damaged allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Energy Conduit", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Common, 75, 12, 55, 2,
            "A stationary robotic pillar that can project a low-level energy field to slowly recharge allied units."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Buffer Drone", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Common, 60, 5, 40, 3,
            "A hovering drone that can dispense a stabilizing chemical compound, preventing minor system failures in allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Restorator-R", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Uncommon, 85, 15, 65, 0,
            "A compact robot designed for on-the-fly repairs, utilizing nanite sprays to quickly mend damaged components."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Field Rescuer", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Uncommon, 90, 12, 70, 1,
            "A sturdy, tracked robot equipped with a grappling arm to extract damaged allies and perform emergency repairs."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aura Generator", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Uncommon, 80, 18, 60, 2,
            "A spherical drone that emits a localized energy field, subtly accelerating the self-repair protocols of nearby robots."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chrono-Patch", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Uncommon, 78, 16, 58, 3,
            "A specialized unit capable of momentarily reversing minor damage to an ally by rewinding their local temporal state."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Arch-Medic Sentinel", CharacterGender.Robots,
            CharacterRole.Healer, Rarity.Epic, 125, 30, 100, 0,
            "A large, multi-limbed robot dedicated to battlefield medicine, capable of deploying multiple repair drones and force fields."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nano-Assembler", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Epic, 118, 28, 95, 1,
            "A highly advanced unit that can reconstruct damaged allies at a molecular level using advanced nanite clouds."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Revival Matrix", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Epic, 130, 25, 105, 2,
            "A floating, crystalline automaton that can project a powerful energy matrix, bringing critically damaged allies back to operational status."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos Weaver", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Epic, 120, 32, 98, 3,
            "A robotic entity capable of rapidly accelerating the self-repair mechanisms of an entire squad by bending local temporal flow."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Quantum Repairer", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Rare, 105, 20, 80, 0,
            "An advanced repair unit that uses quantum entanglement to instantly restore complex systems and structural integrity."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aura Mender", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Rare, 100, 18, 75, 1,
            "A robotic generator that emits a powerful, sustained healing aura, regenerating shields and repairing light damage over time."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Resonator Drone", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Rare, 98, 22, 78, 2,
            "A hovering drone that projects focused sonic frequencies, shaking loose debris and stimulating rapid component self-assembly."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Bio-Synthesizer", CharacterGender.Robots,
            CharacterRole.Healer, Rarity.Rare, 110, 25, 85, 3,
            "A specialized robot capable of rapidly synthesizing replacement parts and organic-equivalent repairs for cybernetic allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Divinity Protocol", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Legendary, 150, 35, 120, 0,
            "An autonomous AI designed for ultimate repair and revival, capable of reconstructing an ally from a single circuit board."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Phoenix Core", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Legendary, 145, 32, 115, 1,
            "A robotic entity housing a perpetually regenerating energy source, able to instantly restore multiple allies to full combat readiness."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Temporal Restoration Unit", CharacterGender.Robots,
            CharacterRole.Healer, Rarity.Legendary, 140, 38, 110, 2,
            "A master of spacetime manipulation, this robot can reverse allies' states to moments before they took fatal damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Arch-Architect", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Legendary, 155, 30, 125, 3,
            "A creation-class robot that can rebuild allies even faster than they are damaged, effectively making them invulnerable for short periods."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Universal Recalibrator", CharacterGender.Robots,
            CharacterRole.Healer, Rarity.Mythic, 180, 45, 140, 0,
            "An omnipotent repair unit capable of rewriting the very laws of physics to restore any ally to perfect operational status, no matter the damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Genesis Synthesizer", CharacterGender.Robots,
            CharacterRole.Healer, Rarity.Mythic, 175, 42, 135, 1,
            "A colossal robot that can generate new components from raw energy, capable of fully replacing destroyed systems or even constructing new bodies for fallen allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos-Prime", CharacterGender.Robots, CharacterRole.Healer,
            Rarity.Mythic, 170, 48, 130, 2,
            "The ultimate temporal repair unit, able to rewind entire battlefields to a pristine state, negating all damage and debuffs across a wide area."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Absolute Maintenance", CharacterGender.Robots,
            CharacterRole.Healer, Rarity.Mythic, 185, 40, 145, 3,
            "An AI consciousness housed in an ethereal form, capable of predicting and preventing damage to allies before it even occurs."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Recon Drone", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Common, 60, 5, 40, 0,
            "A small, agile drone that flies ahead, scouting enemy positions and providing basic target acquisition data."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Shield Emitter", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Common, 70, 0, 50, 1,
            "A stationary robot that can project a small, personal energy shield for a single ally."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Logic Pinger", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Common, 65, 8, 45, 2,
            "A basic computational unit that can slightly improve an ally's accuracy by running quick calculations."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Stun Bot", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Common, 55, 10, 35, 3,
            "A simple automaton that can emit a short-range electrical pulse, briefly stunning minor enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Tactical Drone", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Uncommon, 80, 12, 60, 0,
            "An advanced drone capable of highlighting enemy weaknesses, increasing critical hit chance for allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Energy Buffer", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Uncommon, 85, 10, 65, 1,
            "A robotic unit that can siphon energy from the environment to create temporary damage shields for multiple allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Scrambler Unit", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Uncommon, 75, 15, 55, 2,
            "A mobile robot that emits a jamming frequency, disrupting enemy targeting systems and debuffing their accuracy."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Overcharge Relay", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Uncommon, 78, 18, 58, 3,
            "A robotic power conduit that can temporarily supercharge an ally's weapons, boosting their attack power significantly."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Strategic Coordinator", CharacterGender.Robots,
            CharacterRole.Support, Rarity.Epic, 115, 25, 90, 0,
            "An advanced AI drone that analyzes battlefield data in real-time, providing tactical advantages and powerful, rotating buffs to the team."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gravity Stabilizer", CharacterGender.Robots,
            CharacterRole.Support, Rarity.Epic, 120, 20, 95, 1,
            "A robotic platform that can manipulate local gravity, slowing enemy movements or granting allies enhanced jumps and evasion."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Quantum Decryptor", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Epic, 110, 30, 85, 2,
            "A highly sophisticated unit capable of instantly breaking down enemy defenses and applying massive vulnerability debuffs."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Temporal Anchor", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Epic, 125, 28, 98, 3,
            "A rare robot that can project a localized time bubble, allowing allies within it to act with increased speed or negating enemy cooldowns."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Oracle Drone", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Rare, 95, 18, 70, 0,
            "An advanced surveillance robot that can predict enemy movements, allowing allies to dodge attacks or counter with increased precision."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Deflection Array", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Rare, 100, 15, 75, 1,
            "A mobile robotic unit that can project a wide-area force field, deflecting incoming projectiles and energy blasts."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cyber-Warfare Unit", CharacterGender.Robots,
            CharacterRole.Support, Rarity.Rare, 90, 20, 68, 2,
            "A specialized robot capable of hacking enemy systems, temporarily disabling their weapons or turning their automated defenses against them."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Hyper-Booster", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Rare, 98, 22, 72, 3,
            "A robotic platform designed to inject allies with temporary performance-enhancing nanites, greatly increasing their speed and attack power."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Grand Strategist AI", CharacterGender.Robots,
            CharacterRole.Support, Rarity.Legendary, 135, 35, 110, 0,
            "An omniscient artificial intelligence housed in a compact frame, capable of predicting entire battle outcomes and providing perfect tactical adjustments."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Reality Anchor", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Legendary, 140, 30, 115, 1,
            "A robotic marvel that can stabilize or distort the fabric of spacetime, negating enemy abilities or empowering allies beyond their limits."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Singularity Harmonizer", CharacterGender.Robots,
            CharacterRole.Support, Rarity.Legendary, 130, 38, 105, 2,
            "A sophisticated unit that can safely manipulate gravitational forces, creating impenetrable shields or pulling enemies into vulnerable positions."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Genesis Matrix", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Legendary, 128, 40, 108, 3,
            "A robotic supercomputer that can project a field of pure creation energy, instantaneously constructing cover, deploying drones, or fabricating powerful temporary weapons for allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cosmic Architect", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Mythic, 160, 50, 135, 0,
            "An autonomous construct capable of manipulating the fundamental forces of the universe, shaping the battlefield with starlight barriers or gravitational wells."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Oracle of Ages", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Mythic, 155, 55, 130, 1,
            "A sentient supercomputer that exists across all timelines, providing perfect foresight to allies and disrupting enemy causality to prevent their actions."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Quantum Entangler", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Mythic, 150, 52, 125, 2,
            "A robotic marvel that can link allies at a quantum level, allowing them to share buffs, synchronize attacks, and even resurrect each other."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Absolute Harmony", CharacterGender.Robots, CharacterRole.Support,
            Rarity.Mythic, 165, 48, 140, 3,
            "An ethereal AI that projects a field of pure computational perfection, rendering all allies immune to debuffs and granting them infinite resource generation."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sentinel Droid", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Uncommon, 130, 20, 85, 0,
            "A basic security robot with reinforced plating, designed to absorb small arms fire and protect a zone."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Barrier Bot", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Uncommon, 125, 15, 90, 1,
            "A squat, heavy robot capable of deploying a temporary energy barrier to intercept projectiles."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Bulwark Unit", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Uncommon, 135, 18, 80, 2,
            "A slow-moving automaton with a massive frontal shield, intended to draw enemy fire."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Guard Node", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Uncommon, 120, 12, 75, 3,
            "A stationary defensive pylon that can activate a localized deflection field."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ironclad Enforcer", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Common, 155, 28, 105, 0,
            "A heavily armored robotic unit with dense alloy plating, designed to sustain prolonged enemy assaults."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kinetic Absorber", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Common, 160, 25, 100, 1,
            "A bipedal robot that converts kinetic impact into temporary shield energy, thriving under heavy fire."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Resilient Guard", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Common, 150, 22, 110, 2,
            "A sturdy robot with self-repairing nanites, capable of slowly regenerating its outer shell mid-combat."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Energy Wall", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Common, 165, 20, 98, 3,
            "A specialized unit that can project a wide, transparent energy wall to intercept incoming ranged attacks for the team."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Siege Breaker", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Epic, 200, 38, 140, 0,
            "A colossal, multi-tracked robot designed to withstand planetary bombardments, capable of creating localized impenetrable shields."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Adaptive Bulwark", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Epic, 195, 35, 145, 1,
            "An advanced automaton whose armor can rapidly reconfigure to absorb specific damage types, becoming immune to repeated attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Graviton Shield", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Epic, 205, 32, 135, 2,
            "A floating, spherical robot that manipulates local gravity to bend incoming projectiles and energy blasts around allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Immovable Object", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Epic, 210, 30, 130, 3,
            "A robotic fortress whose primary function is to lock down an area, deploying reinforced walls and force fields that cannot be bypassed."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chrono-Deflector", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Rare, 175, 30, 120, 0,
            "A robotic unit that can briefly shift itself or allies slightly out of the current timeline, allowing attacks to pass harmlessly through."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Particle Barrier", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Rare, 180, 28, 125, 1,
            "A heavy robot that generates a shimmering particle field around itself, dissipating incoming energy and kinetic impacts."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Self-Repair Matrix", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Rare, 170, 25, 115, 2,
            "An autonomous combat shell equipped with an advanced self-repair system, rapidly mending any damage it takes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aegis Protector", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Rare, 185, 22, 118, 3,
            "A bipedal robot with an integrated hard-light projector, capable of creating durable, temporary shields for the entire squad."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Planetary Fortress", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Legendary, 250, 45, 170, 0,
            "A colossal, self-constructing robot capable of erecting an entire defensive installation around allies, impervious to all but the most devastating attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Void Shield Generator", CharacterGender.Robots,
            CharacterRole.Tank, Rarity.Legendary, 240, 40, 165, 1,
            "An advanced automaton that generates a field of pure void energy, completely negating all incoming damage within its radius."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos Bulwark", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Legendary, 260, 38, 175, 2,
            "A master of temporal physics, this robot can exist in multiple moments simultaneously, making it practically untouchable by conventional means."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Omega Guard", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Legendary, 245, 42, 168, 3,
            "The ultimate defensive system, an AI-driven chassis designed to absorb any and all forms of attack, redirecting the residual energy into a non-lethal quantum sink."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Absolute Bastion", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Mythic, 300, 55, 200, 0,
            "An autonomous, self-aware fortress that warps reality to create an impenetrable zone, capable of withstanding attacks that could shatter planets."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Reality Anchor Prime", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Mythic, 290, 50, 195, 1,
            "A robotic entity capable of solidifying the very fabric of existence around allies, making them immune to all forms of harm and debuffs."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nexus Protector", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Mythic, 310, 48, 205, 2,
            "A colossal automaton that exists simultaneously across multiple dimensions, drawing infinite defensive energy from alternate realities to protect its team."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Eternity Shield", CharacterGender.Robots, CharacterRole.Tank,
            Rarity.Mythic, 295, 52, 198, 3,
            "The ultimate defensive AI, capable of generating a temporal loop around allies, effectively rewinding any damage taken to an infinite degree."));

        dataToLoad.Add(new CharacterDataLoaderFormat("Spikeweed Shooter", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Common, 80, 85, 55, 0,
            "A common, thorny plant that can rapidly launch sharp, irritating seeds at foes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Acid Spitter Vine", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Common, 75, 90, 50, 1,
            "A creeping vine with bulbous sacs that spray corrosive sap over short distances."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Thornwhipper", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Common, 85, 80, 60, 2,
            "A sentient bush with long, thorny branches that lash out at close-range enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Flare Bulb", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Common, 70, 92, 48, 3,
            "A plant with a luminous, explosive flower that detonates small bursts of fiery pollen."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Venom-Bloom", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Uncommon, 90, 105, 70, 0,
            "A vibrant but deadly flower that releases clouds of potent, debilitating toxins that slowly poison enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Razorleaf Spinner", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Uncommon, 85, 110, 65, 1,
            "A fast-spinning plant armed with hardened, razor-sharp leaves that can be launched with surprising force."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Fire Blossom", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Uncommon, 95, 100, 75, 2,
            "A rare desert plant whose petals ignite with intense heat, launching small, incandescent projectiles."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Root-Crusher", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Uncommon, 100, 98, 78, 3,
            "A sturdy, walking plant whose thick, powerful roots can constrict and crush enemies in close quarters."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sundew Stalker", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Rare, 105, 125, 80, 0,
            "A carnivorous plant that lures enemies with a sweet scent before ensnaring them in sticky, corrosive tentacles."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Bramble Barrage", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Rare, 110, 120, 85, 1,
            "A large, mobile briar patch capable of rapidly growing and launching volleys of enchanted, piercing thorns."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Shriek Bulb", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Rare, 100, 130, 75, 2,
            "A mutated plant with an auditory sac that emits piercing sonic waves, disrupting enemy formations and damaging them over an area."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Magma Bloom", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Rare, 115, 122, 88, 3,
            "A rare, volcanic flora that generates intense heat, occasionally erupting with molten projectiles."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Doom-Vine Entangler", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Epic, 125, 145, 95, 0,
            "A colossal, ancient vine that can rapidly grow and coil around multiple foes, crushing them with immense force and sapping their life."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Bio-Artillery Pod", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Epic, 130, 140, 100, 1,
            "A stationary but powerful plant structure that launches highly explosive, bio-luminescent seed-bombs across the battlefield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Shadowpetal Weaver", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Epic, 120, 150, 90, 2,
            "A rare, dark flora whose petals release tendrils of necrotic energy, slowly draining the vitality from all enemies in an area."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Emberbark Sentinel", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Epic, 135, 142, 102, 3,
            "A treant-like being with a bark of hardened, smoldering embers, capable of igniting foes with fiery assaults and explosive bursts."));
        dataToLoad.Add(new CharacterDataLoaderFormat("World-Root Ravager", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Legendary, 145, 165, 110, 0,
            "A sentient, mobile root system from a primordial tree, capable of erupting from the ground to impale and shatter multiple enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Solar Flare Lily", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Legendary, 140, 170, 105, 1,
            "A mythical flower that opens to unleash concentrated solar energy, incinerating anything caught in its brilliant, destructive beam."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Abyssal Sprout", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Legendary, 135, 175, 100, 2,
            "A plant born from dark, arcane energies, capable of summoning shadowy tendrils that consume the life force of foes and empower itself."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chrono-Vine Predator", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Legendary, 150, 168, 112, 3,
            "An ancient vine that has learned to manipulate localized time, rapidly accelerating its growth to ensnare and crush enemies with impossible speed."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cosmic Bloom Devourer", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Mythic, 170, 200, 130, 0,
            "A sentient, planet-sized flower that can open its colossal maw to consume entire starships, its digestive acids dissolving anything."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Elemental Overgrowth", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Mythic, 165, 195, 125, 1,
            "The living embodiment of primordial nature, capable of summoning hurricanes, earthquakes, and volcanic eruptions at will to devastate the battlefield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Life-Drain Parasite Prime", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Mythic, 160, 205, 120, 2,
            "A parasitic entity that can merge with a target, rapidly growing and draining all vitality, leaving nothing but dust in its wake."));
        dataToLoad.Add(new CharacterDataLoaderFormat("World-Tree Scion", CharacterGender.Plants, CharacterRole.DamageDealer,
            Rarity.Mythic, 175, 198, 132, 3,
            "A direct offspring of the legendary World-Tree, capable of extending its roots across vast distances to inflict unimaginable natural destruction."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sunpetal Sprout", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Common, 65, 10, 45, 0,
            "A small plant that absorbs sunlight to release a gentle, restorative glow, healing minor wounds."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Dewdrop Blossom", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Common, 60, 8, 40, 1,
            "A delicate flower whose dewdrops possess mild healing properties when applied to injuries."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sootheleaf Shrub", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Common, 70, 12, 50, 2,
            "A common bush with leaves that, when crushed, release a fragrant aroma that calms and slightly regenerates."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Life-Lichen Patch", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Common, 75, 5, 55, 3,
            "A spreading patch of bioluminescent lichen that radiates a low-level regenerative aura."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nectar-Sac Blossom", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Uncommon, 85, 18, 65, 0,
            "A vibrant flower that stores magical nectar, which can be dispensed to rapidly close wounds and restore energy."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Root-Mender", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Uncommon, 90, 15, 70, 1,
            "A sturdy, walking root system that can extend its tendrils to inject revitalizing sap directly into injured allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lumina Shroom", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Uncommon, 80, 20, 60, 2,
            "A large, glowing mushroom that releases clouds of invigorating spores, cleansing minor ailments and boosting vitality."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Forest Whisperer", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Uncommon, 78, 16, 58, 3,
            "A sentient, mobile plant whose rustling leaves create a soothing, regenerative breeze across the battlefield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Vitality Bloom", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Rare, 105, 25, 80, 0,
            "A magnificent flower that, when fully opened, radiates a powerful life-force aura, rapidly mending severe injuries."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cleansing Cypress", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Rare, 110, 22, 85, 1,
            "An ancient, walking cypress tree whose needles release purifying mists, removing debilitating effects and restoring vigor."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Spirit-Leaf Weaver", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Rare, 100, 28, 75, 2,
            "A mystical plant that can weave its glowing leaves into temporary shields, while its pollen rejuvenates weary allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Phoenix Fern", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Rare, 98, 20, 78, 3,
            "A rare fern that, when damaged, bursts into life-giving spores, bringing critically injured allies back from the brink."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Verdant Heartwood", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Epic, 130, 35, 100, 0,
            "A sentient, walking ancient tree whose very core radiates immense life energy, capable of healing multiple allies instantly and granting temporary invulnerability."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Solar Nectar Flower", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Epic, 125, 32, 95, 1,
            "A mythical blossom that stores pure, concentrated solar energy, releasing it in bursts to fully restore allies and purge all negative effects."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Dream-Thorn Healer", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Epic, 120, 38, 90, 2,
            "A rare, ethereal plant whose thorns, despite their appearance, can inject a powerful restorative sap that mends severe wounds and cleanses mind-affecting ailments."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Grove Warden Bloom", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Epic, 135, 30, 105, 3,
            "A sacred plant guardian that can call upon the collective life force of an entire forest to revive fallen allies and shield the team from harm."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Genesis Seedling", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Legendary, 150, 45, 120, 0,
            "The nascent form of a World-Tree, possessing primordial life-giving energies capable of full battlefield regeneration and resurrection."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Astral Lotus", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Legendary, 145, 42, 115, 1,
            "A flower that blooms only under specific cosmic alignments, its petals emit a soothing energy that can mend any injury, physical or spiritual."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos Flora", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Legendary, 140, 48, 110, 2,
            "A plant whose cellular structure exists outside conventional time, allowing it to instantly reverse grievous wounds and reset allies' physical states."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ethereal Root Mother", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Legendary, 155, 40, 125, 3,
            "A vast, ancient root network that manifests as a benevolent entity, capable of channeling boundless life force to sustain and revive entire armies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Universal Spore", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Mythic, 180, 55, 140, 0,
            "The source of all botanical life, capable of instantly regenerating matter and undoing any damage or ailment across entire realities."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cosmic Photosynthesizer", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Mythic, 175, 52, 135, 1,
            "A plant entity that directly harvests energy from the cosmos, transforming it into boundless life force to instantly restore and even ascend allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nexus Bloom", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Mythic, 170, 58, 130, 2,
            "A flower that exists at the intersection of all dimensions, capable of drawing healing energy from infinite realities to make allies effectively immortal."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Life-Stream Embodiment", CharacterGender.Plants, CharacterRole.Healer,
            Rarity.Mythic, 185, 50, 145, 3,
            "The living manifestation of the universe's collective life-stream, capable of creating and sustaining life on a planetary scale."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Glow-Lichen Cluster", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Common, 60, 5, 40, 0,
            "A patch of luminous lichen that emits a faint glow, slightly boosting allied morale and vision."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Spore Cloud Bloom", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Common, 55, 8, 35, 1,
            "A small plant that releases irritating spores, briefly disorienting enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Root Tendriler", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Common, 65, 10, 45, 2,
            "A mobile root system that can extend small tendrils to trip minor enemies or create minor hindrances."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sticky Pod Plant", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Common, 70, 12, 50, 3,
            "A plant that fires adhesive pods, slowing down single targets."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Vine Weaver", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Uncommon, 80, 15, 60, 0,
            "A sentient vine plant that can rapidly grow and form temporary restraints, rooting enemies in place."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Mind-Calm Fungus", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Uncommon, 75, 12, 55, 1,
            "A rare mushroom that releases a soothing aroma, removing minor status effects from allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Glimmerbulb Sprout", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Uncommon, 85, 18, 65, 2,
            "A plant that pulses with bright light, temporarily blinding and debuffing enemy accuracy."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aroma Diffuser", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Uncommon, 78, 16, 58, 3,
            "A fragrant plant whose potent scents can either invigorate allies, slightly boosting their attack, or sicken enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Psychic Pollen Shrub", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Rare, 95, 20, 70, 0,
            "A plant that releases highly concentrated pollen, capable of briefly confusing enemies or enhancing allied focus."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Guardian Willow", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Rare, 100, 18, 75, 1,
            "An ancient, walking willow tree whose branches can form protective barriers and whose roots can slow advancing foes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Resonance Bloom", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Rare, 90, 22, 68, 2,
            "A vibrant flower that vibrates at a specific frequency, disrupting enemy spells and amplifying allied abilities."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nutrient Sapling", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Rare, 98, 15, 72, 3,
            "A young, but potent tree that can share its stored nutrients, granting allies temporary boosts to health regeneration and defense."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chrono-Moss Weaver", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Epic, 115, 28, 90, 0,
            "A rare, glowing moss that can manipulate localized time, slowing enemies to a crawl or granting allies bursts of accelerated action."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aurawood Sentinel", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Epic, 120, 25, 95, 1,
            "A magnificent, sentient tree whose very presence creates a powerful, protective aura, shielding allies from both physical and magical harm."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Bioluminescent Oracle", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Epic, 110, 30, 85, 2,
            "A vast, glowing fungal network that can tap into the collective consciousness of nature, revealing enemy weaknesses and boosting allied resolve."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Terra-Shaper Vine", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Epic, 125, 22, 98, 3,
            "A powerful, mobile vine system capable of rapidly growing and altering the terrain, creating defensive structures or trapping enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("World-Heart Echo", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Legendary, 140, 35, 115, 0,
            "A sentient floral manifestation connected to the planet's core, capable of bestowing boundless natural energy to allies, refreshing abilities and boosting stats dramatically."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cosmic Pollen Cloud", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Legendary, 135, 38, 110, 1,
            "A rare, floating plant that continuously emits a shimmering, cosmic pollen, inspiring allies with unyielding determination and disorienting all foes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Dream-Weaver Grove", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Legendary, 130, 40, 105, 2,
            "An ethereal grove of interconnected plants that can plunge enemies into deep illusions, incapacitating them, while granting allies clear-sightedness and foresight."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Timeless Bloom", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Legendary, 145, 32, 120, 3,
            "A flower that exists outside the conventional flow of time, capable of temporarily freezing the battlefield, allowing allies to reposition or strike with impunity."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Universal Gardener", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Mythic, 160, 50, 135, 0,
            "The ultimate life-shaper, capable of manipulating the very essence of existence to grow instantaneous defenses, create restorative oases, or bind enemies with unbreakable flora."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cosmic Nexus Sprout", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Mythic, 155, 55, 130, 1,
            "A plant that channels energies from across the multiverse, bestowing reality-bending buffs to allies and weaving impenetrable barriers from pure potential."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos Genesis Vine", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Mythic, 150, 52, 125, 2,
            "A living temporal paradox, able to reset the state of entire battlefields, undoing damage, debuffs, and granting allies perfect strategic opportunities."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Life-Stream Conduit", CharacterGender.Plants, CharacterRole.Support,
            Rarity.Mythic, 165, 48, 140, 3,
            "The direct manifestation of the universe's life-giving force, capable of linking allies to an infinite wellspring of energy, making them virtually unstoppable."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Root Guardian", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Common, 125, 15, 85, 0,
            "A sturdy, immobile plant whose dense root system makes it an excellent defensive anchor."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Bark Shield Plant", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Common, 130, 18, 80, 1,
            "A small, treant-like creature with incredibly tough bark, designed to absorb blunt force."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Mossy Bulwark", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Common, 120, 12, 90, 2,
            "A slow-moving mound of ancient, thick moss and stone, soaking up damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Stonefruit Shielder", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Common, 115, 10, 75, 3,
            "A plant that produces hard, stony fruits, which can be used to deflect minor attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ironwood Sentinel", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Uncommon, 150, 25, 105, 0,
            "A treant-like being whose limbs and trunk are as hard as steel, providing formidable natural armor."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sporewall Protector", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Uncommon, 145, 20, 110, 1,
            "A large, fungal growth that can rapidly expand to create temporary, damage-absorbing spore walls for allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Amberhide Vine", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Uncommon, 155, 22, 100, 2,
            "A massive, mobile vine whose segments are encased in solidified amber, making it highly resistant to penetration."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Crystal Thistle", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Uncommon, 160, 18, 95, 3,
            "A large, thorny plant whose outer layers are made of sharpened, regenerative crystals, deflecting attacks and slowly regrowing."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Golem-Root Guardian", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Rare, 180, 30, 120, 0,
            "An animated mass of ancient, petrified roots, forming an incredibly dense and damage-resistant living shield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Obsidian Bloom", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Rare, 175, 28, 125, 1,
            "A rare, volcanic flora whose hardened, obsidian-like petals form an almost impenetrable shell."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Shield-Thorn Colossus", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Rare, 185, 25, 115, 2,
            "A colossal, mobile plant covered in self-repairing, reinforced thorns that absorb and redirect incoming damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Mnemonic Mossback", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Rare, 190, 22, 118, 3,
            "An ancient, slow-moving creature covered in glowing moss, capable of 'remembering' and adapting to damage types, growing stronger against repeated attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Living Mountain Aegis", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Epic, 220, 40, 150, 0,
            "A colossal, sentient mountain formed from primordial plant life, capable of shrugging off continent-shattering blows."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Photosynthetic Fortress", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Epic, 210, 35, 155, 1,
            "A massive, walking plant structure that can generate an impenetrable light barrier, absorbing and converting all incoming energy into its own health."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Void Blossom Bastion", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Epic, 225, 38, 145, 2,
            "A rare, dark floral entity that can open its petals to create a localized void field, completely nullifying damage and pulling enemies into harmless oblivion."));
        dataToLoad.Add(new CharacterDataLoaderFormat("World-Tree Bulwark", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Epic, 215, 32, 148, 3,
            "A miniature, mobile offshoot of the legendary World-Tree, whose roots dig deep into the earth, making it an unyielding, immovable defensive anchor."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Primordial Grove", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Legendary, 260, 50, 180, 0,
            "A mobile, ancient grove whose interconnected flora form an unyielding fortress, absorbing immense damage and regenerating at an alarming rate."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gaia's Embodiment", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Legendary, 250, 45, 185, 1,
            "A colossal, sentient manifestation of a planetary ecosystem, capable of commanding geological forces to create impenetrable shields and deflect entire assaults."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos-Bark Guardian", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Legendary, 270, 48, 175, 2,
            "An ancient, time-touched treant whose bark exists across multiple temporal layers, making it nearly impossible to damage through conventional means."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Star-Seed Citadel", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Legendary, 255, 42, 188, 3,
            "A massive, crystalline plant grown from a fallen star-seed, capable of generating hyper-dense energy fields that deflect even cosmic attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cosmic World-Tree Core", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Mythic, 320, 60, 220, 0,
            "The living, beating heart of a universal World-Tree, capable of manifesting reality-bending defenses that absorb and nullify all forms of damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Primordial Genesis Bloom", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Mythic, 310, 55, 215, 1,
            "A colossal, sentient flower that predates all life, capable of instantly creating and dissolving matter to erect impervious shields."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nexus Flora Colossus", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Mythic, 330, 58, 225, 2,
            "A plant entity existing across all dimensions, drawing infinite defensive resilience from every possible reality, rendering it truly indestructible."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Eternity Vine Guardian", CharacterGender.Plants, CharacterRole.Tank,
            Rarity.Mythic, 315, 52, 218, 3,
            "A vast, sentient vine system that embodies timelessness, capable of reversing any damage taken and extending its roots through causality itself to block threats."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sting-Tail Hornet", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Common, 80, 90, 55, 0,
            "A large, aggressive hornet with a venomous stinger, capable of swift, piercing attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Mandible Ripper", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Common, 85, 88, 60, 1,
            "A beetle-like insect with powerful, snapping mandibles, specializing in close-range physical damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Acid Spray Beetle", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Common, 75, 92, 50, 2,
            "A robust beetle that can spray a stream of corrosive acid from glands on its back."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Razorwing Swarmer", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Common, 70, 95, 48, 3,
            "A small, fast-flying insect whose wings have razor-sharp edges, performing quick, slashing passes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Venom-Spine Scorpion", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Uncommon, 90, 108, 70, 0,
            "A predatory scorpion with highly potent venom, capable of paralyzing and slowly killing its prey."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Crystal Locust Swarm", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Uncommon, 85, 112, 65, 1,
            "A large swarm of locusts whose exoskeletons are reinforced with sharp crystals, shredding targets with sheer numbers."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Blast-Ant Queen", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Uncommon, 95, 105, 75, 2,
            "A formidable ant queen that can command her smaller explosive workers or launch highly corrosive secretions."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Emberwing Moth", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Uncommon, 100, 100, 78, 3,
            "A giant moth whose wings shed burning scales, raining down fiery destruction on areas below."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Dread Stinger Mantis", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Rare, 110, 125, 80, 0,
            "A gigantic, predatory mantis with scythe-like forelegs that can slice through armor and deliver potent venom."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sonic Cicada", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Rare, 105, 130, 75, 1,
            "A colossal cicada whose deafening sonic bursts can shatter glass and disorient entire enemy formations."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Corrosive Bombardier", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Rare, 115, 122, 85, 2,
            "A heavily armored beetle that sprays highly corrosive liquid over a wide area, melting defenses and flesh."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Shadow Wasp Queen", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Rare, 108, 128, 78, 3,
            "A queen wasp that commands an ethereal swarm, stinging foes with dark energy and slowly draining their vitality."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Hive Tyrant", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Epic, 130, 145, 95, 0,
            "The alpha of a parasitic insect hive, capable of summoning smaller, aggressive insectoids and coordinating overwhelming assaults."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Quantum Mantis", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Epic, 125, 150, 90, 1,
            "A highly evolved mantis that can briefly phase in and out of reality, striking with impossible speed and precision from multiple angles."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Plasma Bombardier", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Epic, 135, 142, 100, 2,
            "A colossal insect that can generate and launch superheated plasma charges, detonating with devastating area-of-effect damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chrono-Locust Swarm", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Epic, 128, 148, 92, 3,
            "A swarm of time-warping locusts that can rapidly consume targets, accelerating their decay and then moving onto the next victim in a blur."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Apocalyptic Swarm Lord", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Legendary, 150, 170, 110, 0,
            "The progenitor of all destructive swarms, capable of summoning infinite insectoids that blanket the battlefield and strip targets bare in seconds."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Rift-Scarab Devourer", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Legendary, 145, 175, 105, 1,
            "Description: A colossal scarab that can open small spatial rifts, pulling enemies into oblivion or disgorging corrosive, extra-dimensional energy."));
        dataToLoad.Add(new CharacterDataLoaderFormat("World-Moth Weaver", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Legendary, 140, 180, 100, 2,
            "Description: A mythical moth whose wingbeats create destructive hurricanes and whose glowing scales can ignite entire regions into fiery infernos."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Venom-Leviathan", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Legendary, 155, 172, 112, 3,
            "Description: A gigantic, serpentine insect whose venom is so potent it can corrode even bedrock and paralyze titans with a single bite."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cosmic Hive Mind", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Mythic, 175, 210, 130, 0,
            "Description: The collective consciousness of an intergalactic insectoid empire, capable of manifesting devastating psychic attacks and controlling vast swarms with perfect synchronization."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Entropy Locust Prime", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Mythic, 170, 205, 125, 1,
            "The ultimate devourer, a locust entity that consumes not just matter, but also energy, memories, and even the very fabric of spacetime."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Void Mantis Hunter", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Mythic, 165, 215, 120, 2,
            "A colossal mantis that can open breaches to the void, using its scythes to tear through reality and dispatch foes into non-existence."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos-Scourge Beetle", CharacterGender.Insects, CharacterRole.DamageDealer,
            Rarity.Mythic, 180, 208, 132, 3,
            "A titanic beetle whose carapace is imbued with temporal energy, allowing it to unleash strikes that ripple through time, erasing targets from all points in their existence."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Pollen Beetle", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Common, 65, 5, 45, 0,
            "A docile beetle that secretes a sweet, restorative pollen, capable of mending minor scrapes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Glowfly Swarm", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Common, 60, 2, 40, 1,
            "A small swarm of bioluminescent flies that emit a soothing light, helping allies recover from fatigue."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nectar Ant", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Common, 70, 8, 50, 2,
            "A worker ant that carries droplets of a mild healing nectar, which it can share with injured allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Silk Weaver Larva", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Common, 75, 10, 55, 3,
            "A caterpillar-like larva that can spin a delicate, restorative silk to cover and protect wounds."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Regenerative Scarab", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Uncommon, 85, 12, 65, 0,
            "A metallic-shelled scarab that can rapidly generate healing secretions, mending medium wounds for allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Soothing Swarm Moth", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Uncommon, 80, 10, 60, 1,
            "A dense cloud of small, gentle moths whose wingbeats create a calming, regenerative breeze."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Life-Dew Cicada", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Uncommon, 90, 15, 70, 2,
            "A large cicada that collects rare, life-enhancing dew, dispensing it to allies for noticeable healing."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Crystal-Wing Dragonfly", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Uncommon, 78, 18, 58, 3,
            "A graceful dragonfly with wings made of pulsating crystals, radiating a steady, restorative energy field."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Vitality Wasp", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Rare, 105, 20, 80, 0,
            "A queen wasp that produces a rare royal jelly, capable of rapidly healing severe wounds and boosting an ally's fortitude."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chrono-Beetle", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Rare, 100, 18, 75, 1,
            "A mystical beetle capable of localized time manipulation, accelerating an ally's cellular regeneration to mend grievous injuries."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aura Weevil", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Rare, 110, 22, 85, 2,
            "A large weevil whose antennae can detect and amplify ambient life force, creating a wide healing aura for the team."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Bioluminescent Phoenixfly", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Rare, 98, 25, 78, 3,
            "A rare, glowing fly whose light can purify toxins and stimulate rapid healing, even bringing allies back from unconsciousness."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Life-Cycle Weaver", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Epic, 130, 30, 100, 0,
            "An ancient insect entity capable of manipulating an ally's life cycle, rapidly regenerating their form and purging all ailments."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nectar-Heart Beehemoth", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Epic, 125, 28, 95, 1,
            "A colossal, gentle bee whose vast honeycombs store potent, universal nectar, capable of fully restoring multiple allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Astral Silk Spinner", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Epic, 120, 32, 90, 2,
            "A giant spider that spins ethereal, glowing silk imbued with restorative properties, creating protective cocoons that heal rapidly."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Phoenix Beetle Prime", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Epic, 135, 25, 105, 3,
            "A rare, fiery beetle that, when near allies, can burst into a shower of healing embers, bringing them back from the brink of defeat."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cosmic Chrysalis Weaver", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Legendary, 150, 40, 120, 0,
            "An extra-dimensional insect that can encase allies in a rapid-healing chrysalis, completely restoring them and granting temporary invulnerability."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Eternity Moth Matron", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Legendary, 145, 38, 115, 1,
            "A colossal, ancient moth whose wingbeats spread a soothing, time-bending dust that can reverse all damage and even revive the fallen."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Life-Force Harvester", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Legendary, 140, 42, 110, 2,
            "A unique insect that can tap into the universal life-stream, channeling boundless regenerative energy directly to allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nexus Ant Queen", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Legendary, 155, 35, 125, 3,
            "The queen of an interdimensional ant colony, capable of summoning an army of specialized worker ants that provide instant, potent healing and resurrection."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lumina", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Mythic, 120, 30, 60, 0,
            "A radiant firefly whose gentle glow mends the most grievous wounds. Lumina flits across the battlefield, leaving trails of healing light in her wake. Her ancient lineage grants her an unparalleled connection to life energy, making her an indispensable ally."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ambrosia", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Mythic, 110, 25, 50, 1,
            "A majestic monarch butterfly, Ambrosia's wings carry the pollen of rejuvenation. She gracefully evades harm, showering her allies with revitalizing dust that restores their vigor. Her presence alone inspires hope and resilience in the face of overwhelming odds."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chrysalis", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Mythic, 130, 20, 70, 2,
            "A mysterious moth, Chrysalis remains largely unseen, but her soothing hum resonates with healing vibrations. She can weave protective cocoons around her comrades, shielding them from harm while subtly restoring their strength. Her true power lies in her silent, unwavering support."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nectar", CharacterGender.Insects, CharacterRole.Healer,
            Rarity.Mythic, 115, 35, 55, 3,
            "A vibrant bumblebee, Nectar buzzes with an infectious energy that uplifts her allies. She collects and distributes life-giving essence, patching up wounds and invigorating weary fighters. Her unwavering optimism and diligent efforts make her a cornerstone of any defensive line."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Hopper", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Common, 80, 40, 30, 0,
            "A sprightly grasshopper, Hopper uses his powerful legs to leap into action, distracting foes and repositioning allies. He's not the strongest fighter, but his agility and quick thinking provide crucial openings."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Drone", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Common, 90, 25, 45, 1,
            "A diligent worker bee, Drone tirelessly assists his team by gathering resources and reinforcing defenses. While not a direct combatant, his steady efforts significantly bolster the group's staying power."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chirp", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Common, 75, 35, 25, 2,
            "A small but vocal cricket, Chirp's rhythmic songs can either inspire allies to greater feats or annoy enemies into making mistakes. His presence on the battlefield, though subtle, can sway the tide of a skirmish."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Scuttler", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Common, 85, 30, 40, 3,
            "A quick-moving beetle, Scuttler is adept at disrupting enemy formations and drawing aggro. He's tough for his size and can create openings for more powerful allies to strike."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Weaver", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Uncommon, 95, 40, 50, 0,
            "A cunning spider, Weaver excels at trapping enemies and protecting allies with intricate silk webs. Her strategic placements can severely limit enemy movement and safeguard vulnerable team members."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Stinger", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Uncommon, 100, 50, 45, 1,
            "A nimble wasp, Stinger zips around the battlefield, applying weakening toxins to foes and boosting allies with invigorating pheromones. Her rapid movements make her hard to pin down."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gloworm", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Uncommon, 85, 35, 35, 2,
            "A luminous glowworm, Gloworm emits a soft, strategic light that can reveal hidden enemies or temporarily blind opponents, creating tactical advantages for her team. She's a beacon of support in the darkness."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sentry", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Uncommon, 105, 45, 55, 3,
            "A vigilant ant, Sentry establishes small, temporary fortifications or lays down scent trails that guide allies and disorient enemies. Her unwavering dedication provides reliable tactical support."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aura", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Rare, 110, 55, 60, 0,
            "A mesmerizing luna moth, Aura creates zones of calming dust that shield allies from harm and enhance their abilities, while simultaneously sapping the will of her enemies. Her presence on the field is a profound influence."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Echo", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Rare, 105, 60, 50, 1,
            "A sophisticated cicada, Echo generates powerful sonic pulses that can disorient entire enemy ranks or amplify the attacks of her allies. Her sound manipulation offers versatile battlefield control."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Myrmidon", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Rare, 120, 50, 65, 2,
            "A disciplined ant general, Myrmidon commands small swarms of worker ants to fortify positions, retrieve lost items, or overwhelm specific targets with sheer numbers. Her strategic brilliance is unmatched."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nimbus", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Rare, 115, 65, 55, 3,
            "A swift dragonfly, Nimbus manipulates localized air currents to create protective wind barriers, deflect projectiles, or grant allies temporary bursts of speed. Her mastery of the winds makes her an aerial maestro of support."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Epic, 130, 70, 75, 0,
            "A venerable mayfly, Chronos possesses an ancient understanding of temporal manipulation. He can briefly accelerate allies' actions or slow down enemies, altering the flow of battle to his team's advantage. His fleeting existence grants him unique insights into time itself."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Metamorph", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Epic, 125, 75, 70, 1,
            "A mystical butterfly, Metamorph can momentarily shift the properties of nearby allies, granting them temporary resistances or enhanced offensive capabilities. She embodies the essence of change and adaptability on the battlefield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Symbiont", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Epic, 140, 65, 80, 2,
            "A symbiotic pairing of a rare beetle and a luminescent fungus, Symbiont can establish a powerful link with an ally, sharing health, amplifying their stats, and even absorbing detrimental effects. They are the ultimate embodiment of cooperative power."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nexus", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Epic, 135, 80, 60, 3,
            "An enigmatic orb weaver spider, Nexus weaves intricate, nearly invisible astral threads across the battlefield. These threads can channel energy to allies, siphon it from enemies, or create psychic barriers that disrupt foes and safeguard allies. Her web connects all."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ætherwing", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Legendary, 150, 85, 90, 0,
            "An ethereal dragonfly of immense power, Ætherwing can temporarily phase allies out of reality, rendering them immune to damage, or weave shimmering veils of pure energy that redirect incoming attacks. Its ancient wisdom allows it to manipulate the very fabric of existence."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cadence", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Legendary, 145, 90, 80, 1,
            "The mythical Grand Weaver, Cadence is an impossibly ancient orb weaver spider whose web is said to connect all destinies. She can subtly alter the probabilities of events, causing enemy attacks to miss or allied abilities to critically succeed. Her foresight is unparalleled."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Solstice", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Legendary, 160, 80, 95, 2,
            "A celestial scarab beetle whose carapace reflects the sun and moon, Solstice channels primal cosmic energies. It can unleash bursts of revitalizing starlight to empower allies or summon localized eclipses that suppress enemy powers and drain their resolve."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Veridian", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Legendary, 155, 95, 85, 3,
            "The progenitor of all leaf insects, Veridian is a living embodiment of the forest's life force. It can instantly grow vibrant, defensive flora to shield allies, or emit spores that accelerate healing and remove all negative effects from its team. Its roots run deep into the world's essence."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronosynapse", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Mythic, 180, 100, 110, 0,
            "A legendary mayfly born from a cosmic anomaly, Chronosynapse can bend and twist the timeline itself. It can rewind moments to prevent damage, fast-forward allies to instantly refresh their abilities, or briefly trap enemies in temporal stasis, rendering them utterly helpless. Its command over time is absolute."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gaia's Whisper", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Mythic, 190, 95, 120, 1,
            "The manifestation of the world's natural harmony within an ancient mantis, Gaia's Whisper can commune with the very essence of life. It can summon protective barriers of pure nature, instantly cleanse all ailments from allies, or imbue them with overwhelming life force, making them briefly unstoppable."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lumina Lux", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Mythic, 175, 110, 105, 2,
            "A celestial firefly, Lumina Lux radiates pure, divine light that banishes all darkness and despair. It can project a protective aura that makes allies invulnerable, unleash blinding flashes that disorient and cripple all foes, or create zones of regeneration that instantly heal and revive fallen comrades."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Quintessence", CharacterGender.Insects, CharacterRole.Support,
            Rarity.Mythic, 185, 105, 115, 3,
            "An enigmatic, multi-faceted beetle believed to be woven from the fabric of reality itself, Quintessence embodies the ultimate support. It can mimic any support ability seen on the battlefield, reflecting it with amplified power, or create a temporary pocket dimension where allies are completely safe and their abilities recharge at an incredible rate."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Armored Beetle", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Common, 150, 20, 80, 0,
            "A sturdy beetle known for its impenetrable carapace, able to withstand immense damage. Its slow but powerful attacks make it a formidable frontline defender."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Rhino Scarab", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Common, 160, 25, 75, 1,
            "Possessing a massive horn, this scarab can charge into battle, disrupting enemy lines and shrugging off hits with its thick exoskeleton."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Iron Ant", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Common, 140, 18, 85, 2,
            "A diligent and resilient ant, often found leading the charge. Its small stature belies incredible toughness, able to endure barrages and protect allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Dung Defender", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Common, 155, 22, 78, 3,
            "Despite its humble origins, this beetle is a master of defense, rolling into a near-invulnerable ball. It prefers to draw enemy aggression, allowing its allies to strike."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Goliath Guardian", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Uncommon, 180, 30, 90, 0,
            "A colossal beetle whose size alone intimidates foes. Its chitinous armor is exceptionally tough, making it a living shield on the battlefield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Obsidian Orb Weaver", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Uncommon, 170, 28, 95, 1,
            "This spider doesn't just spin webs; it weaves an almost unbreakable silk armor around itself, capable of absorbing massive blows."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Shield Wasp", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Uncommon, 165, 25, 100, 2,
            "Unlike its aggressive kin, the Shield Wasp is purely defensive. It generates a powerful bio-electric field that deflects projectiles and protects nearby allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Terra Termite", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Uncommon, 175, 27, 92, 3,
            "A master of subterranean defense, this termite fortifies its own body with compressed earth and rock, becoming an immovable bastion against any assault."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ironclad Monarch", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Rare, 200, 35, 110, 0,
            "Once a delicate butterfly, this monarch has undergone a miraculous metamorphosis, encasing itself in metallic, iridescent scales that deflect all but the strongest attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Crystal Locust", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Rare, 190, 38, 115, 1,
            "This rare locust's exoskeleton is infused with crystalline structures, making it incredibly durable. It can absorb kinetic energy from attacks and release it as a defensive shockwave."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Grand Mantis Lord", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Rare, 195, 32, 120, 2,
            "A venerated leader among mantis kind, this formidable warrior uses its bladed forelegs not for offense, but for parrying and redirecting incoming attacks with uncanny precision."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Volcanic Bombardier", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Rare, 210, 40, 105, 3,
            "Dwelling in extreme heat, this beetle's carapace is formed from hardened magma. It can release controlled bursts of superheated gas to repel enemies, making it incredibly hard to approach."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chrono-Scarab", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Epic, 250, 45, 140, 0,
            "A mystical beetle said to have mastered localized time manipulation. Its hardened shell can briefly exist outside the normal flow of time, making it virtually invulnerable to incoming damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aetherwing Emperor", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Rare, 240, 48, 150, 1,
            "This magnificent moth's wings are woven from pure arcane energy. It generates an ethereal barrier that absorbs all forms of damage, making it a transcendent bulwark."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gaia Golem", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Rare, 260, 50, 135, 2,
            "Not merely an insect, but a living fusion of ancient insectoid essence and primordial earth. It moves with the weight of mountains and its carapace is as unyielding as the planet's core."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Abyssal Devourer", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Rare, 230, 42, 145, 3,
            "Hailing from the deepest, darkest chasms, this monstrous creature's armor is formed from solidified shadow and unknown resilient materials. It thrives on absorbing punishment, growing stronger with each blow."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Primordial Colossus", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Legendary, 300, 60, 200, 0,
            "A relic from an age long past, this titanic insect is said to be one of the original guardians of the insect world. Its multi-layered, ancient chitin is impervious to all but the most cataclysmic forces."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Soulweaver Sphinx", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Legendary, 280, 55, 210, 1,
            "This enigmatic sphinx does not merely defend its body, but its very essence. It projects a psychic shield that makes it untouchable, capable of redirecting even spiritual attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("World Carapace", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Legendary, 320, 65, 190, 2,
            "Not truly a single insect, but a living ecosystem of symbiotic organisms that collectively form an unparalleled defensive structure. It can repair itself instantly and adapt to any incoming threat."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Infinite Chrysalis", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Legendary, 290, 58, 205, 3,
            "A being in a perpetual state of metamorphic defense. It can shift between various forms, each presenting a new, impenetrable layer of protection. It is believed to be truly immortal, regenerating from any assault."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Cosmic Chitin", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Mythic, 350, 70, 250, 0,
            "Forged in the heart of a dying star, this being's shell is composed of exotic matter, absorbing and nullifying all forms of energy and physical attacks. It is a true black hole of defense."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Reality Anchor", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Mythic, 330, 68, 260, 1,
            "This legendary creature's presence alone warps the fabric of reality around it, causing enemy attacks to dissipate into nothingness before they even reach its form. It is the ultimate defender."));
        dataToLoad.Add(new CharacterDataLoaderFormat("The Unbroken One", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Mythic, 360, 72, 245, 2,
            "An entity so ancient and powerful that it predates the concept of damage. Its very existence defies harm, making it an absolute, immovable object in the face of any force."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aeon Sentinel", CharacterGender.Insects, CharacterRole.Tank,
            Rarity.Mythic, 340, 65, 255, 3,
            "A guardian from beyond time and space, this colossal insectoid stands eternal. Its defenses are woven from temporal paradoxes and spatial distortions, rendering it immune to all but the most fundamental cosmic shifts."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kaelen", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Common, 80, 110, 60, 0,
            "A swift and agile warrior, Kaelen specializes in rapid strikes and precise movements, often darting in and out of combat to deliver devastating blows. His light armor allows for incredible speed, but sacrifices some defense."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Thane", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Common, 95, 120, 55, 1,
            "A seasoned brawler with a gruff demeanor, Thane wields a massive two-handed axe, relying on brute strength and powerful swings to overwhelm his enemies. He's slow but hits incredibly hard."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Finn", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Common, 75, 115, 65, 2,
            "An opportunistic rogue, Finn prefers to fight from the shadows, utilizing daggers and cunning tactics to exploit enemy weaknesses. He excels at burst damage against isolated targets."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Roric", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Common, 85, 105, 70, 3,
            "A disciplined mercenary, Roric is a master of the spear, keeping foes at a distance with sweeping attacks and precise thrusts. He balances offense and a measured defense, never overextending."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Joric", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Uncommon, 90, 125, 70, 0,
            "A former gladiator, Joric fights with twin short swords, a whirlwind of steel and fury. His attacks are relentless, and he gains momentum the longer he stays in combat, making him dangerous in extended engagements."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Zephyr", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Uncommon, 85, 130, 65, 1,
            "An arcane marksman, Zephyr weaves elemental magic into his arrows, imbuing them with frost or fire. He excels at targeting distant enemies and applying debuffs, controlling the battlefield from afar."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gorok", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Uncommon, 105, 135, 60, 2,
            "A half-orc berserker, Gorok charges into battle with a massive maul, driven by a primal rage. He sacrifices some personal defense for overwhelming power, often ignoring pain to land critical blows."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Silas", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Uncommon, 80, 120, 75, 3,
            "A shadow dancer, Silas moves with supernatural grace, striking from unexpected angles with enchanted daggers. He can momentarily vanish, repositioning to exploit enemy flanks and dealing high burst damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lyraeus", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Rare, 100, 145, 80, 0,
            "An ancient elven spellblade, Lyraeus channels raw arcane energy through his enchanted greatsword. He commands both devastating magical attacks and potent melee strikes, often leaving trails of elemental power in his wake."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Volkov", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Rare, 95, 150, 75, 1,
            "A legendary bounty hunter, Volkov is a master of all ranged weaponry, but prefers his custom-built heavy crossbow. Each shot is delivered with pinpoint accuracy and immense force, capable of piercing the toughest armor."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Drakon", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Rare, 110, 140, 85, 2,
            "A draconic bloodline warrior, Drakon possesses scales of hardened hide and wields a flaming two-handed sword. He can unleash short bursts of fiery breath and shrug off lesser attacks, making him a fearsome frontline damage dealer."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kael", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Rare, 90, 155, 70, 3,
            "A spectral assassin, Kael drifts through combat, phasing in and out of existence to deliver deadly strikes with ethereal blades. His attacks bypass conventional defenses, and he is notoriously difficult to pin down."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Sol Invictus", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Epic, 115, 160, 90, 0,
            "Clad in radiant armor, Sol Invictus is a warrior blessed by the sun itself. His attacks burn with divine fire, and he can call down searing rays of light, incinerating foes and temporarily empowering allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Umbraeus", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Epic, 105, 165, 85, 1,
            "The embodiment of shadow, Umbraeus is a master of void manipulation. He can teleport across the battlefield, summon shadowy tendrils to bind enemies, and unleash blasts of pure darkness that unravel matter itself."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Epic, 100, 170, 95, 2,
            "A temporal anomaly, Chronos manipulates the flow of time around him. He can accelerate his own actions to perform multiple attacks in quick succession, or briefly freeze enemies in place, leaving them vulnerable to his devastating strikes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Atlas", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Epic, 130, 155, 100, 3,
            "A colossus of living stone and iron, Atlas is a juggernaut whose every blow shakes the earth. While slow, his raw power is unmatched, capable of shattering defenses and creating shockwaves that damage all nearby foes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ragnarok", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Legendary, 120, 180, 100, 0,
            "The prophesied end-bringer, Ragnarok wields a colossal, smoldering sword that hums with destructive energy. His attacks unleash cataclysmic force, scarring the very landscape and leaving foes in ruin. He can temporarily become invulnerable, channeling pure destruction."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Void Weaver", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Legendary, 110, 190, 95, 1,
            "A being from beyond the known cosmos, the Void Weaver commands energies that twist reality. He conjures singularities that pull enemies into oblivion and unleashes cosmic rays that ignore all conventional defenses, capable of erasing targets from existence."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aetherion", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Legendary, 115, 185, 105, 2,
            "A celestial champion, Aetherion descends from the heavens, wreathed in starlight. He summons constellations to empower his attacks, fires meteors from above, and can briefly transform into a being of pure light, overwhelming all in his path."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kage-no-Kami", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Legendary, 105, 195, 90, 3,
            "The very spirit of shadows and cunning, Kage-no-Kami is a phantom blade master. He moves faster than the eye can follow, creating after-images and striking from impossible angles. His techniques are legendary, allowing him to sever life force directly and become completely untargetable for short durations."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Primus", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Mythic, 130, 210, 110, 0,
            "The First Flame, Primus is a primordial entity born from the genesis of existence. He manifests as a being of pure, incandescent energy, wielding a colossal sword forged from a dying star. His every attack unleashes cosmic novas, scorching foes with absolute destructive power that ignores all forms of resistance. He can briefly become a super-nova, consuming everything around him."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nexus", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Mythic, 120, 215, 105, 1,
            "The fabric of reality made sentient, Nexus can manipulate causality and existence itself. He fights by ripping holes in space-time, pulling enemies into alternate dimensions, or calling forth impossible paradoxes to eradicate them. He can foresee and negate any incoming attack, striking at the very concept of his opponents."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Abaddon", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Mythic, 125, 220, 100, 2,
            "The Destroyer of Worlds, Abaddon is an entity of pure annihilation. Wielding a black blade that drinks light and life, he consumes all in his path, leaving only void. His presence corrupts the environment, weakening all foes, and his ultimate power allows him to manifest a fragment of true oblivion, wiping out entire armies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Pantheon", CharacterGender.Male, CharacterRole.DamageDealer,
            Rarity.Mythic, 135, 205, 115, 3,
            "The collective will of forgotten gods, Pantheon is a manifestation of divine wrath and power. He embodies the strengths of countless deities, able to shift between divine aspects of thunder, valor, and war. Each strike is backed by epochal power, and he can call upon the full might of the ancient pantheon to unleash a world-shattering judgment."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Elara", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Common, 120, 30, 60, 0,
            "A gentle yet resolute wanderer, Elara's healing touch is sought after in the harshest of lands. He wields ancient herbal knowledge and quiet determination."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kael", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Common, 110, 40, 50, 1,
            "Once a battlefield medic, Kael now dedicates his life to patching up heroes. His practical approach to healing often comes with a dose of gruff encouragement."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Finnian", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Common, 100, 35, 55, 2,
            "A young, earnest acolyte of the Sunstone Order, Finnian's prayers manifest as soothing light. He is eager to prove his worth and protect his allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Rhys", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Common, 130, 25, 65, 3,
            "A seasoned mentor with a calm demeanor, Rhys has seen countless battles. His wisdom guides both his healing spells and his companions."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lyraeus", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Uncommon, 135, 45, 70, 0,
            "A solitary druid whose connection to nature grants him potent regenerative powers. His quiet presence brings solace and strength to those around him."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Seraphon", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Uncommon, 125, 50, 60, 1,
            "A former paladin who, after losing his fighting arm, discovered a deeper calling in sacred magic. He channels divine energy to mend wounds and inspire courage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Zephyr", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Uncommon, 115, 55, 65, 2,
            "A nimble wind whisperer whose restorative breezes can mend flesh and invigorate spirits. He moves with grace, always positioning himself to provide critical support."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Obsidian", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Uncommon, 140, 40, 75, 3,
            "A stoic earth shaman whose touch can solidify resolve and mend even grievous injuries with geomantic energy. He is a rock of stability on the battlefield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Solon", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Rare, 150, 60, 80, 0,
            "An ancient sage whose wisdom is as profound as his restorative magic. He can unravel curses and mend the deepest spiritual wounds with celestial light."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aethel", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Rare, 140, 65, 75, 1,
            "A venerated prophet whose visions guide his healing hands. He can glimpse future ailments and prevent them, bolstering allies with divine foresight."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Corvus", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Rare, 130, 70, 85, 2,
            "A mysterious blood mage who draws upon life force (his own or others) to perform powerful, rapid healing. His methods are unconventional but undeniably effective."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aurelian", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Rare, 160, 55, 90, 3,
            "A redeemed spectral knight who now protects the living. His ethereal touch can phase through defenses to heal directly, and he can briefly manifest as a shield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Archon Lyra", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Epic, 180, 80, 100, 0,
            "A celestial being whose presence itself is a fount of regeneration. He can channel pure cosmic energy to resurrect fallen allies and cleanse entire areas of affliction."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos Weaver", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Epic, 170, 85, 95, 1,
            "A master of temporal magic, capable of rewinding minor injuries and accelerating natural healing. He can even reverse the effects of poisons and debilitating spells."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Luminaeus", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Epic, 190, 75, 105, 2,
            "The living embodiment of the Sun's benevolent rays, Luminaeus bathes the battlefield in restorative light. He can supercharge allies' abilities while simultaneously mending their wounds."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nexus Shaman", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Epic, 200, 70, 110, 3,
            "A conduit to the primal life essence of the world, capable of drawing energy directly from the Nexus to perform miracles of healing and fortification. His connection to all living things is profound."));
        dataToLoad.Add(new CharacterDataLoaderFormat("The Ascendant", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Legendary, 250, 100, 150, 0,
            "A divine being said to be formed from pure compassion. His touch can grant immortality for brief periods, and his aura ensures no ally falls while he stands."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aeon Weaver", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Legendary, 220, 120, 130, 1,
            "The master of existence and non-existence. He can pluck allies from the brink of oblivion, reknitting their very essence, and can prevent fatal blows from ever landing."));
        dataToLoad.Add(new CharacterDataLoaderFormat("World-Heart Shaman", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Legendary, 280, 90, 160, 2,
            "The living pulse of the planet, he channels the unfathomable life force of Aegis itself. His connection can restore entire armies and invigorate them with boundless stamina."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Solara, The Radiant Zenith", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Legendary, 260, 110, 140, 3,
            "A celestial entity whose light is the ultimate balm. He can instantly purge all ailments, resurrect all fallen allies to full strength, and imbue them with divine protection."));
        dataToLoad.Add(new CharacterDataLoaderFormat("The Nexus Prime", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Mythic, 350, 150, 200, 0,
            "The primordial source of all healing energy, a consciousness that embodies the very essence of life and restoration. His existence ensures reality itself seeks equilibrium, mending all that is broken."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Architect of Life", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Mythic, 320, 180, 190, 1,
            "A cosmic entity capable of rewriting the fundamental code of existence to reverse decay, perfectly mend any injury, and imbue allies with temporary invulnerability and boundless vitality."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos Sovereign", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Mythic, 380, 140, 220, 2,
            "The undisputed master of time and causality. He can rewind any damage, negate any harmful event, and even foresee and prevent all future harm to his allies. His presence bends fate itself."));
        dataToLoad.Add(new CharacterDataLoaderFormat("The Grand Harmonizer", CharacterGender.Male, CharacterRole.Healer,
            Rarity.Mythic, 360, 160, 210, 3,
            "A being of pure, resonant energy that brings absolute balance and perfection to all. He eradicates all discord, illness, and injury, elevating allies to their peak potential while making them impervious to harm."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Elara", CharacterGender.Male, CharacterRole.Support,
            Rarity.Common, 120, 30, 70, 0,
            "A compassionate healer who provides protective barriers and minor restorative magic to allies, always standing ready to bolster defenses."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Finn", CharacterGender.Male, CharacterRole.Support,
            Rarity.Common, 110, 40, 60, 1,
            "A seasoned tactician whose presence on the battlefield inspires courage and subtly enhances the combat prowess of his companions."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gareth", CharacterGender.Male, CharacterRole.Support,
            Rarity.Common, 130, 25, 80, 2,
            "A stoic standard-bearer, he dedicates himself to defending his comrades, absorbing blows and drawing enemy attention with unwavering resolve."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Rhys", CharacterGender.Male, CharacterRole.Support,
            Rarity.Common, 100, 35, 65, 3,
            "Agile and perceptive, Rhys is an invaluable scout who uses his knowledge of enemy movements to create openings and protect his team from unexpected assaults."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kaelen", CharacterGender.Male, CharacterRole.Support,
            Rarity.Uncommon, 135, 45, 75, 0,
            "A mystical scholar who channels ancient energies to fortify allies and disrupt enemy formations, making him a cornerstone of any defense."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Orion", CharacterGender.Male, CharacterRole.Support,
            Rarity.Uncommon, 125, 50, 70, 1,
            "A charismatic leader who inspires incredible resolve in his team, granting them temporary boosts to overcome daunting challenges."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Silas", CharacterGender.Male, CharacterRole.Support,
            Rarity.Uncommon, 140, 40, 85, 2,
            "A master of protective wards and arcane barriers, Silas can shield multiple allies simultaneously, turning the tide of battle with his defensive prowess."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Torvin", CharacterGender.Male, CharacterRole.Support,
            Rarity.Uncommon, 130, 48, 80, 3,
            "A gruff but loyal veteran, Torvin specializes in battlefield control, using his experience to slow foes and safeguard vulnerable allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lysander", CharacterGender.Male, CharacterRole.Support,
            Rarity.Rare, 150, 60, 95, 0,
            "A visionary strategist whose foresight allows him to preemptively counter enemy tactics, providing unparalleled defensive and tactical support."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Seraphon", CharacterGender.Male, CharacterRole.Support,
            Rarity.Rare, 160, 55, 100, 1,
            "Clad in ancient ceremonial armor, Seraphon radiates an aura of divine protection, healing the gravest wounds and deflecting powerful attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Alaric", CharacterGender.Male, CharacterRole.Support,
            Rarity.Rare, 145, 65, 90, 2,
            "A enigmatic temporal manipulator, Alaric can briefly rewind moments for allies, undoing damage or repositioning them out of harm's way."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Thorne", CharacterGender.Male, CharacterRole.Support,
            Rarity.Rare, 155, 58, 98, 3,
            "A master of runic magic, Thorne inscribes powerful glyphs on the battlefield, creating zones of invulnerability for allies and crippling debuffs for foes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Zephyr", CharacterGender.Male, CharacterRole.Support,
            Rarity.Epic, 170, 70, 110, 0,
            "An ethereal guardian who can manifest fleeting shields of pure energy, absorbing cataclysmic damage and empowering allies with renewed vigor."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Atlas", CharacterGender.Male, CharacterRole.Support,
            Rarity.Epic, 180, 65, 120, 1,
            "A titan amongst men, Atlas carries the weight of his allies' defense, capable of shrugging off assaults that would fell lesser heroes and redirecting harm."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos", CharacterGender.Male, CharacterRole.Support,
            Rarity.Epic, 165, 75, 105, 2,
            "A master of temporal flow, Chronos can manipulate time around his allies, granting them fleeting invincibility or accelerating their actions beyond mortal limits."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Eldrin", CharacterGender.Male, CharacterRole.Support,
            Rarity.Epic, 175, 68, 115, 3,
            "A venerable sage whose ancient wisdom translates into powerful protective incantations, Eldrin can conjure barriers that nullify even the strongest magical attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Solara", CharacterGender.Male, CharacterRole.Support,
            Rarity.Legendary, 200, 80, 140, 0,
            "The radiant embodiment of protective light, Solara can invoke a field that renders allies impervious to all forms of harm for a critical duration, while also mending grievous wounds instantly."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aethelred", CharacterGender.Male, CharacterRole.Support,
            Rarity.Legendary, 220, 75, 150, 1,
            "The legendary Shieldbearer, Aethelred is a living bastion who can anchor the very fabric of reality to his position, drawing all enemy aggression and reflecting a portion of the damage back."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Veridian", CharacterGender.Male, CharacterRole.Support,
            Rarity.Legendary, 190, 85, 130, 2,
            "A mystical conduit to the primordial life force, Veridian can rejuvenate an entire squad, bringing fallen comrades back to their feet and granting temporary invulnerability."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nyxus", CharacterGender.Male, CharacterRole.Support,
            Rarity.Legendary, 210, 82, 135, 3,
            "The enigmatic Weaver of Fates, Nyxus can subtly alter destiny, causing enemy attacks to miss harmlessly or ensuring critical hits for allies, turning the tide of battle with supreme precision."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Primus", CharacterGender.Male, CharacterRole.Support,
            Rarity.Mythic, 250, 90, 180, 0,
            "The primordial architect of defense, Primus can manifest absolute barriers that negate all incoming damage, briefly making allies untouchable, and can even rewind time for a single ally, restoring them to full power."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Zenith", CharacterGender.Male, CharacterRole.Support,
            Rarity.Mythic, 260, 85, 190, 1,
            "A celestial guardian whose presence alone bends reality, Zenith can create a sanctuary where allies are invulnerable and continuously healed, while enemies within its radius are completely nullified."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Oblivion", CharacterGender.Male, CharacterRole.Support,
            Rarity.Mythic, 240, 95, 170, 2,
            "An ancient entity that exists beyond time, Oblivion can sever connections to reality for enemies, causing their attacks to cease, and can momentarily grant allies an existence outside of conventional damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lumina", CharacterGender.Male, CharacterRole.Support,
            Rarity.Mythic, 255, 92, 185, 3,
            "The living embodiment of pure creation, Lumina can instantly reconstruct damaged allies, summon temporary shields of cosmic energy, and imbue them with an essence that ensures their survival against any threat."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Grak Stonehide", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Common, 250, 70, 120, 0,
            "A hulking goliath known for his impenetrable defenses and unwavering resolve. Grak stands as a living bulwark, protecting his allies with his massive shield and unyielding spirit."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Borin Ironclad", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Common, 230, 80, 110, 1,
            "A veteran dwarven warrior, Borin's armor is as legendary as his resilience. He charges into battle, shrugging off blows that would fell lesser heroes, all while delivering powerful counter-attacks."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Thane Shieldwall", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Common, 240, 75, 115, 2,
            "A noble human knight, Thane has dedicated his life to protecting the innocent. His polished shield and unwavering stance inspire confidence in his allies and fear in his enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ragnok Earthshake", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Common, 260, 65, 125, 3,
            "An orcish chieftain who commands the very ground beneath his feet. Ragnok's powerful physique and primal ferocity make him a formidable frontline presence, capable of absorbing immense damage."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kaelen Stoneheart", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Uncommon, 280, 85, 135, 0,
            "A grizzled veteran of countless skirmishes, Kaelen's resolve is as tough as the mountain rock. He wields a massive tower shield, capable of deflecting siege weapon fire, and inspires allies with his battle-hardened presence."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Bjorn Thunderfist", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Uncommon, 270, 95, 125, 1,
            "A massive barbarian from the frozen north, Bjorn is a whirlwind of muscle and steel. He charges into the thickest of fights, his dual-wielded axes a blur, drawing enemy attention with his sheer ferocity."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Commander Thorne", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Uncommon, 290, 80, 140, 2,
            "A decorated officer of the royal guard, Commander Thorne is a master tactician and an immovable object on the battlefield. He leads by example, his ornate shield and heavy armor providing an unbreachable frontline."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Grommash Bloodfang", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Uncommon, 300, 75, 150, 3,
            "A fearsome orc Warlord, Grommash earned his name through countless victories and a legendary ability to withstand punishment. He channels primal rage into his defenses, becoming an unstoppable force of nature."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lord Valerius, The Lionheart", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Rare, 350, 100, 180, 0,
            "A legendary paladin, Lord Valerius is a beacon of hope on the battlefield. Clad in enchanted gleaming plate armor, his massive shield pulses with divine energy, providing unparalleled protection and inspiring his allies to heroic feats."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Krag Stonehide, The Mountain King", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Rare, 380, 90, 190, 1,
            "A colossal goliath chieftain, Krag is a force of nature personified. His skin is like ancient stone, impervious to all but the most powerful blows. He commands the earth itself, creating barriers and quaking the ground to defend his kin."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Joric Ironbeard, Runelord of the Depths", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Rare, 360, 105, 175, 2,
            "A master dwarven runecaster and warrior, Joric's ancestral armor is etched with ancient runes of protection and resilience. He stands as an unmoving bastion, his magical defenses shrugging off arcane and physical attacks with equal ease."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Overlord Zarthus, The Tyrant's Bulwark", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Rare, 370, 95, 185, 3,
            "A terrifying orc warlord, Zarthus is a living siege engine. His heavily armored frame is augmented with dark rituals, making him incredibly resistant to pain and damage. He wades through enemy lines, drawing all aggression with his intimidating presence."));
        dataToLoad.Add(new CharacterDataLoaderFormat("King Aerion, The Unbroken", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Epic, 450, 120, 250, 0,
            "The legendary monarch and founder of the Aegis Vanguard, King Aerion stands as an indomitable fortress. Wielding the ancient shield 'Aegis' and clad in armor forged from starlight, he can withstand attacks that would shatter mountains, inspiring unyielding courage in all who fight beside him."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gorok, Earth-Heart Guardian", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Epic, 480, 110, 270, 1,
            "A primeval goliath, Gorok is rumored to be a living fragment of the world's core. His body is literally composed of living rock and molten earth, making him immune to most forms of damage. He can absorb and redirect colossal impacts, protecting vast areas with his raw elemental power."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Thrain Stonefist, Ancestral Shield-Bearer", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Epic, 460, 125, 245, 2,
            "The oldest and wisest of dwarven guardians, Thrain carries the ancestral shield 'Durin's Ward,' a relic imbued with the spirits of a thousand dwarven kings. His defenses are not merely physical; they are spiritual, capable of shrugging off even curses and banishments."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Draxus, The Doomforged Colossus", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Epic, 470, 115, 260, 3,
            "A terrifying orcish general, Draxus is a monstrous amalgamation of flesh and dark magic, encased in armor forged in the heart of a volcano. He thrives on pain, converting incoming damage into raw power and unleashing devastating counter-attacks that shake the very foundations of the battlefield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Primus, The First Sentinel", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Legendary, 600, 150, 350, 0,
            "A being of pure divine will, Primus was the first guardian forged at the dawn of creation. His armor is crafted from cosmic adamant, and his shield is a shard of a collapsed star, making him utterly invincible to all but existential threats. He commands celestial energies to defend all life."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos, The Temporal Bulwark", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Legendary, 580, 160, 340, 1,
            "A mysterious figure unbound by time, Chronos exists simultaneously in past, present, and future. Attacks ripple harmlessly through him as he subtly shifts his temporal presence. His shield is a swirling vortex of chronological energy, capable of rewinding damage and nullifying threats."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Atlas, The World-Bearer", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Legendary, 620, 140, 360, 2,
            "A titan of legend, Atlas literally carries the weight of a fragmented world upon his shoulders. His immense strength is matched only by his fortitude. He can project an aura of crushing gravity, diverting and absorbing blows that would otherwise shatter reality."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Oblivion, The Void-Shield", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Legendary, 590, 155, 355, 3,
            "An ancient entity from beyond the veil, Oblivion is a walking paradox—a void that defends. His very presence distorts reality, drawing all attacks into a pocket dimension of nothingness. He doesn't block damage; he makes it cease to exist."));
        dataToLoad.Add(new CharacterDataLoaderFormat("The Cosmic Aegis", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Mythic, 800, 200, 500, 0,
            "Not a single being, but the collective consciousness of the universe's most ancient and powerful guardians, manifested as a singular, impenetrable entity. The Cosmic Aegis is a living barrier made of pure starlight and primordial energy, capable of absorbing and redirecting cataclysmic forces."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Archon, The Immutable Core", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Mythic, 780, 210, 490, 1,
            "Archon is the fundamental principle of stability given form. He stands at the nexus of all realities, his very existence anchoring the fabric of existence. No force, physical or magical, can perturb his resolute stance, making him an unassailable bastion against any threat."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Echo of Creation", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Mythic, 820, 190, 510, 2,
            "A lingering imprint of the universe's birth, the Echo of Creation embodies the unyielding strength that brought all things into being. It manipulates the fundamental forces of physics to generate impenetrable fields and temporal distortions, rendering all attacks futile."));
        dataToLoad.Add(new CharacterDataLoaderFormat("The Sentinel Prime", CharacterGender.Male, CharacterRole.Tank,
            Rarity.Mythic, 790, 205, 520, 3,
            "The ultimate defensive mechanism of an elder civilization, the Sentinel Prime is a colossal automaton of impossible alloys and pure energy. Its programming dictates absolute defense, allowing it to adapt to and negate any offensive strategy, making it the perfect, eternal protector."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lyra Swiftstrike", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Common, 80, 120, 60, 0,
            "A nimble rogue with daggers as swift as her shadow, Lyra moves unseen, striking vital points with deadly precision. Her past is a blur of silent missions and whispered legends, making her a formidable but enigmatic ally."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Blaze Pyreheart", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Common, 75, 130, 55, 1,
            "A fiery mage whose spells incinerate enemies with intense heat. Blaze channels raw elemental power, leaving trails of ash and embers in her wake. Her temper is as volatile as her magic."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kaelen Bowhand", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Common, 85, 115, 65, 2,
            "An expert archer with an eagle eye and a steady hand. Kaelen's arrows fly true, piercing through armor and finding their mark from impressive distances. She is a hunter born of the wild, relying on instinct and precision."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Riven Blade fury", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Common, 90, 110, 70, 3,
            "A fierce warrior who wields a two-handed sword with brutal efficiency. Riven charges into battle, a whirlwind of steel and fury, her battle cries echoing across the battlefield as she carves through foes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Seraphina - Shadowbane", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Uncommon, 90, 135, 70, 0,
            "A former assassin with a conscience, Seraphina now uses her stealth and poisoned blades to protect the innocent. Her movements are fluid, and her strikes are infused with a subtle, debilitating magic."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Astraea - Starcaller", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Uncommon, 85, 140, 65, 1,
            "A celestial sorceress who draws power from distant stars. Astraea conjures cosmic energies, unleashing meteors and guiding starlight to smite her enemies. Her presence illuminates the darkest battlefields."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Valerius - Runesmith", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Uncommon, 95, 130, 75, 2,
            "A master artificer and marksman, Valerius imbues her custom-crafted crossbow bolts with explosive runes. Each shot is a masterpiece of destructive engineering, leaving no enemy unscathed."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Xylos - Whisperwind", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Uncommon, 100, 125, 80, 3,
            "A spectral warrior who can phase through solid objects and manipulate gusts of wind to enhance her strikes. Xylos is an elusive combatant, striking from unexpected angles with ghost-like speed."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ignis - Phoenix Flame", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Rare, 100, 150, 80, 0,
            "A legendary pyrokinetic whose flames burn with an otherworldly intensity. Ignis can summon torrents of fire, capable of melting steel and turning legions of foes into ash. She is a force of nature, reborn from the ashes of her past."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Umbra - Void Weaver'", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Rare, 95, 155, 75, 1,
            "A mysterious sorceress who harnesses the power of the void. Umbra can rip tears in reality, summoning shadowy tendrils and dark energies to consume her enemies. Her presence saps the will of those who oppose her."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Zephyr - Tempest Dancer", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Rare, 105, 145, 85, 2,
            "An agile warrior who moves with the speed of a gale, wielding dual enchanted blades. Zephyr can conjure miniature cyclones and use the very air to amplify her strikes, making her an unstoppable whirlwind of destruction."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Terra - Earthshaker", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Rare, 110, 140, 90, 3,
            "A formidable guardian who channels the raw power of the earth. Terra can cause localized tremors, summon stone spikes from the ground, and imbue her massive hammer with seismic force, shattering defenses and foes alike."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Solara - Dawnbreaker", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Epic, 115, 170, 90, 0,
            "A divine warrior chosen by ancient light spirits, Solara wields a blade imbued with pure solar energy. Her attacks unleash blinding flashes and searing rays, purifying evil and igniting hope in her allies. She is a beacon against the deepest shadows."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Nyx - Abyssal Siren", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Epic, 110, 175, 85, 1,
            "A enigmatic sorceress whose voice alone can shatter wills and whose shadows consume all light. Nyx commands primordial darkness, capable of opening portals to forgotten dimensions and binding foes in an eternal slumber. She is both terrifying and alluring."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chrona 'Time Weaver'", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Epic, 120, 165, 95, 2,
            "A mistress of temporal magic, Chrona can accelerate or rewind moments, allowing her to strike multiple times in an instant or dodge any attack before it lands. She sees all possible futures, always one step ahead of her enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Draconia 'Wyrmheart'", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Epic, 125, 160, 100, 3,
            "A legendary dragon-blooded warrior, Draconia possesses the raw strength and elemental breath of a dragon. She can unleash devastating gouts of fire or frost and her scales are as tough as ancient rock. Her roar alone can send lesser foes fleeing."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aethelred 'World's Edge'", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Legendary, 130, 190, 100, 0,
            "The prophesied warrior said to hold the very fate of existence in her hands. Aethelred wields a blade capable of severing the fabric of reality, dealing damage that bypasses all defenses. Her attacks unleash cosmic energy, devastating everything in their path."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Elysia 'Soulflame'", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Legendary, 125, 195, 95, 1,
            "A phoenix goddess incarnate, Elysia burns with the essence of creation and destruction. She can summon primordial flames that reduce even gods to ash, and her spirit is eternally reborn, making her virtually invincible."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Seraph 'Nexus Breaker'", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Legendary, 135, 185, 105, 2,
            "An angelic entity from beyond the known universe, Seraph manipulates fundamental forces of reality. She can tear apart physical and magical barriers with a thought, and her attacks ripple through dimensions, hitting targets no matter where they hide."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Morwen 'Shadow Empress'", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Legendary, 140, 180, 110, 3,
            "The ancient ruler of a forgotten empire of shadow, Morwen commands legions of darkness and wields powers stolen from primordial voids. She can plunge entire battlefields into absolute darkness, empowering her strikes to unimaginable levels and cursing foes with eternal despair."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Omnia 'Cosmic Singularity'", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Mythic, 140, 220, 110, 0,
            "The living embodiment of the universe's destructive potential. Omnia can create miniature black holes, unleash supernovas, and bend spacetime to her will, erasing enemies from existence with a mere gesture. She is the end of all things, and the beginning of none."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Genesis 'Primal Weaver'", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Mythic, 135, 225, 105, 1,
            "The architect of reality, Genesis can unravel and reconstruct the very fabric of existence. Her attacks are pure conceptual energy, capable of nullifying all defenses and rewriting the fundamental laws governing her opponents. She is a force beyond comprehension."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Elysium 'Ascendant Soul'", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Mythic, 145, 215, 115, 2,
            "A perfected being of pure spiritual energy, Elysium has transcended mortal form and wields the combined power of countless ascended souls. Her presence inspires unwavering devotion in allies and utter despair in enemies, her attacks striking directly at the essence of life itself."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Oblivion 'Void Manifest'", CharacterGender.Female, CharacterRole.DamageDealer,
            Rarity.Mythic, 150, 210, 120, 3,
            "The physical manifestation of absolute nothingness and entropy. Oblivion's touch corrodes reality, and her mere presence drains the energy from all around her. Her attacks are anti-matter, erasing targets from all planes of existence, leaving no trace behind."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Elara Meadowlight", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Common, 120, 30, 60, 0,
            "A gentle yet resilient healer, Elara wields natural light to mend wounds and bolster allies. Her connection to the living world allows her to draw strength from the earth itself."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Seraphina Bloom", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Common, 110, 35, 55, 1,
            "With a serene demeanor and a radiant aura, Seraphina is a beacon of hope on the battlefield. She specializes in area-of-effect healing, restoring vitality to multiple allies at once."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lyra Hearthsong", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Common, 130, 25, 65, 2,
            "Lyra's melodies are as potent as any spell, weaving protective harmonies and soothing injuries. Her voice can turn the tide of battle, inspiring courage and healing the weary."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kaelen Swiftpaws", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Common, 100, 40, 50, 3,
            "A nimble and quick-witted field medic, Kaelen moves with precision to reach fallen comrades. She uses herbal remedies and quick bandages to keep her team in the fight."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Astrid Lightweaver", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Uncommon, 150, 40, 80, 0,
            "A seasoned battlefield medic, Astrid can manipulate pure light energy to create potent healing barriers and mend grievous wounds. Her presence alone can uplift the spirits of her allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Willow Evergreen", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Uncommon, 140, 45, 75, 1,
            "Deeply connected to ancient forest magic, Willow channels the restorative power of nature. She can summon protective flora and mend allies with revitalizing plant energies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Iris Lumina", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Uncommon, 160, 35, 85, 2,
            "Iris wields enchanted glyphs that glow with mending light. She can place these glyphs strategically to heal multiple allies over time and cleanse negative effects."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Anya Swiftbrook", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Uncommon, 135, 50, 70, 3,
            "Known for her rapid healing techniques and insightful tactical support, Anya can swiftly stabilize critical allies. Her focus on efficiency makes her an invaluable asset in tight situations."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lyra Starwhisper", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Rare, 180, 55, 100, 0,
            "Drawing power from celestial energies, Lyra can invoke cosmic blessings to perform miracles. She can mend the gravest injuries and bestow powerful protective boons upon her allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Solara Verdantheart", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Rare, 170, 60, 95, 1,
            "A high priestess of the living world, Solara commands ancient nature spirits to aid her. She can cause entire groves of healing flora to erupt, revitalizing all who stand within them."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aurora Frostbloom", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Rare, 190, 50, 105, 2,
            "Wielding the rare magic of cryogenic healing, Aurora can slow the spread of damage and even reverse deterioration. Her touch can seal wounds with ice-cold precision, rendering allies almost impervious."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kaelen Riftmend", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Rare, 165, 65, 90, 3,
            "Kaelen has a unique ability to manipulate temporal energies, allowing her to rewind minor wounds or accelerate natural recovery. Her healing transcends conventional methods, offering unparalleled restoration."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Elysia Lumina", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Epic, 220, 70, 130, 0,
            "A divine conduit of pure, radiant light, Elysia can call upon celestial powers to perform awe-inspiring feats of healing. Her presence can cleanse battlefields and resurrect fallen allies, making her a true savior."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gaia Verdantheart", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Epic, 210, 75, 125, 1,
            "The primordial spirit of life itself, Gaia embodies the ultimate restorative force. She can terraform battle zones into lush, healing sanctuaries, granting immortality-like regeneration to her entire vanguard."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Astraeus Chronos", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Epic, 230, 65, 135, 2,
            "Master of temporal manipulation, Astraeus can completely reverse grievous damage, turning back the clock on injuries or even summoning past, uninjured versions of allies. Her power over time makes her an unparalleled support."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Morwenna Soulfire", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Epic, 200, 80, 120, 3,
            "Morwenna wields the forbidden arts of soul-binding, drawing forth life energy from the ether to restore even the most fractured spirits. She can sacrifice a portion of her own immense vitality to bring allies back from the brink of death, empowered by her sacrifice."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Archangel Seraphiel", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Legendary, 280, 90, 180, 0,
            "A true celestial being, Seraphiel descends from the highest heavens, imbued with pure divine grace. Her mere presence radiates an aura of absolute restoration, capable of mending any wound, dispelling all afflictions, and even shielding allies from death itself."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lyra Veritas", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Legendary, 270, 95, 175, 1,
            "The living embodiment of the universal truth of life, Lyra can channel the very essence of creation to perform miracles. She can manifest perfect cellular regeneration, nullify all negative energies, and bestow temporary invulnerability upon her chosen champions."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos Weaver", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Legendary, 290, 85, 190, 2,
            "The enigmatic master of the timeline itself, Chronos Weaver can meticulously unravel and re-weave the fabric of existence around allies, erasing all damage and preventing future harm. Her control over causality allows for unprecedented protective and restorative abilities."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Elara Phoenixheart", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Legendary, 260, 100, 170, 3,
            "Born from the ashes of forgotten stars, Elara possesses the undying flame of rejuvenation. She can resurrect fallen allies with a burst of cosmic fire, granting them enhanced strength, and her healing touch burns away all impurities and weaknesses."));
        dataToLoad.Add(new CharacterDataLoaderFormat("The Life-Giver", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Mythic, 350, 120, 250, 0,
            "An entity of pure creation, whispered to be the source of all vitality. The Life-Giver doesn't just heal; she imbues allies with an unshakeable connection to the universal life force, rendering them almost impervious to harm and granting them constant, accelerated regeneration. Her touch can birth new life where none existed."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Anima Mundi", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Mythic, 330, 130, 240, 1,
            "The Soul of the World, Anima Mundi is a cosmic consciousness that flows through all living things. She can mend not just bodies, but spirits, restoring allies to their peak physical and mental states instantly, dispelling all curses, and reinforcing their very existence with global, protective harmony."));
        dataToLoad.Add(new CharacterDataLoaderFormat("The Chronosoph", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Mythic, 360, 110, 260, 2,
            "Beyond even the Chronos Weaver, the Chronosoph is the architect of time itself. She can perfectly reconstruct any ally, returning them to their optimal state at any point in their existence, or even projecting them briefly into an uninjured future to avoid damage. Her understanding of causality makes her an absolute safeguard."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lumina Lux", CharacterGender.Female, CharacterRole.Healer,
            Rarity.Mythic, 320, 140, 230, 3,
            "The embodiment of the primal light that initiated all existence. Lumina Lux radiates absolute purity and healing. Her presence dissolves all decay, disease, and injury, leaving only perfection. She can call upon cosmic rays to bathe allies in rejuvenating energy, offering limitless restoration and protection from any darkness."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Elara Meadowlight", CharacterGender.Female, CharacterRole.Support,
            Rarity.Common, 120, 30, 70, 0,
            "A gentle healer who mends allies with radiant blessings, Elara's presence brings comfort and resilience to the battlefield. Her touch can soothe wounds and fortify spirits, making her an indispensable part of any vanguard."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lyra Swiftbow", CharacterGender.Female, CharacterRole.Support,
            Rarity.Common, 110, 45, 60, 1,
            "A nimble scout and protector, Lyra uses her precise aim and quick thinking to provide cover and distraction for her teammates. Her arrows may not fell giants, but they can incapacitate foes and clear paths for her allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Seraphina Stoneheart", CharacterGender.Female, CharacterRole.Support,
            Rarity.Common, 130, 25, 80, 2,
            "Though not a frontline brawler, Seraphina is a stalwart guardian, capable of absorbing blows and redirecting threats away from weaker allies. Her unwavering resolve makes her a living shield for the vanguard."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Willow Whisperwind", CharacterGender.Female, CharacterRole.Support,
            Rarity.Common, 100, 35, 65, 3,
            "A serene mystic whose subtle enchantments can turn the tide of battle. Willow specializes in debuffing enemies and subtly empowering her allies, ensuring their success through careful manipulation of arcane energies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Astrid Rune Weave", CharacterGender.Female, CharacterRole.Support,
            Rarity.Uncommon, 135, 40, 85, 0,
            "An apprentice runecaster who weaves protective sigils and minor healing spells. Her growing understanding of ancient runes allows her to empower allies and disrupt enemy formations with surprising effectiveness."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Faelan Glowbrook", CharacterGender.Female, CharacterRole.Support,
            Rarity.Uncommon, 125, 50, 75, 1,
            "A forest spirit guide who inspires courage and vitality in her companions. Faelan's connection to nature allows her to mend wounds and bolster defenses with ancient, earthy magic."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kaelen Shadowstep", CharacterGender.Female, CharacterRole.Support,
            Rarity.Uncommon, 115, 60, 70, 2,
            "A former rogue who now dedicates her skills to protecting her allies from harm. Kaelen uses distractions, swift movements, and well-placed debuffs to control the battlefield and ensure her team's survival."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Raina Frostgale", CharacterGender.Female, CharacterRole.Support,
            Rarity.Uncommon, 140, 35, 90, 3,
            "A stoic warrior priestess who channels the biting winds and protective ice of her mountain home. Raina can slow enemies and shield her allies, her chilling presence a formidable barrier against encroaching threats."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Seraphina Lumina", CharacterGender.Female, CharacterRole.Support,
            Rarity.Rare, 150, 50, 100, 0,
            "A celestial emissary whose divine radiance bathes allies in protective light and purges darkness from the battlefield. Her presence is a beacon of hope, capable of turning the tide against even the most formidable foes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lyra Soulweave", CharacterGender.Female, CharacterRole.Support,
            Rarity.Rare, 140, 65, 95, 1,
            "A master of arcane redirection, Lyra can weave complex energy patterns to absorb damage from allies and distribute it harmlessly, or even reflect it back at her enemies. Her control over magical currents is unparalleled."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Eira Frostbloom", CharacterGender.Female, CharacterRole.Support,
            Rarity.Rare, 160, 45, 110, 2,
            "A revered priestess of the ancient Winterbloom order, Eira can conjure powerful ice constructs to shield her team and unleash devastating blizzards that incapacitate entire enemy ranks. Her magic is both beautiful and terrifying."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Zara Viperscale", CharacterGender.Female, CharacterRole.Support,
            Rarity.Rare, 130, 70, 90, 3,
            "A cunning alchemist and strategist from the elusive Serpent Isles. Zara utilizes potent elixirs and venomous concoctions to cripple enemies and imbue her allies with temporary, but powerful, enhancements."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Anya Starcaller", CharacterGender.Female, CharacterRole.Support,
            Rarity.Epic, 170, 70, 120, 0,
            "A legendary oracle who draws power directly from the cosmos, Anya can foresee threats and manipulate fate to protect her allies. She conjures constellations to empower her team and unleash cosmic events upon her enemies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Isolde Echoheart", CharacterGender.Female, CharacterRole.Support,
            Rarity.Epic, 160, 85, 115, 1,
            "The last known wielder of the ancient Song of Ages, Isolde's melodic enchantments can mend the most grievous wounds and inspire unparalleled courage. Her voice resonates with forgotten magic, turning despair into triumph."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Valeriana Verdant", CharacterGender.Female, CharacterRole.Support,
            Rarity.Epic, 180, 60, 130, 2,
            "A mythical dryad queen who commands the very essence of life. Valeriana can instantly revitalize fallen allies, grow impenetrable thorny barriers, and channel the raw power of the forest to overwhelm her foes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Xylia Void Weaver", CharacterGender.Female, CharacterRole.Support,
            Rarity.Epic, 150, 90, 110, 3,
            "A mysterious sorceress who has mastered the manipulation of spatial rifts and temporal anomalies. Xylia can teleport allies out of danger, trap enemies in localized time distortions, and bend reality to protect her vanguard."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aerion, The Celestial Aegis", CharacterGender.Female, CharacterRole.Support,
            Rarity.Legendary, 200, 100, 150, 0,
            "A divine being of pure starlight and compassion, Aerion descends from the highest heavens to personally safeguard the innocent. Her touch can cleanse all ailments, resurrect the fallen, and her very presence inspires an unbreakable will in her allies."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lyra, Echo of Creation", CharacterGender.Female, CharacterRole.Support,
            Rarity.Legendary, 190, 110, 140, 1,
            "The prime conduit of primordial life energy, Lyra wields the power that birthed worlds. She can reshape the battlefield with ancient flora, conjure elemental guardians, and imbue her allies with temporary invincibility, drawing upon the very essence of creation."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Seraphina, Heart of the Nexus", CharacterGender.Female, CharacterRole.Support,
            Rarity.Legendary, 210, 95, 160, 2,
            "The sentient core of an ancient magical network, Seraphina possesses complete mastery over all arcane energies. She can shunt allies through dimensions, unravel enemy spells instantly, and unleash focused magical storms that obliterate threats while fortifying her team's defenses to an absolute maximum."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Xylos, The Weaver of Fates", CharacterGender.Female, CharacterRole.Support,
            Rarity.Legendary, 180, 120, 130, 3,
            "A mysterious entity that exists outside conventional time, Xylos sees all possible futures and subtly manipulates threads of destiny. She can rewind moments to prevent damage, fast-forward time to hasten ally actions, and even momentarily sever enemies from the flow of existence, making them vulnerable."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Astraea, Apex of the Empyrean", CharacterGender.Female, CharacterRole.Support,
            Rarity.Mythic, 250, 130, 200, 0,
            "The living embodiment of cosmic balance and restorative light, Astraea can unravel reality's decay and usher in epochs of profound healing. She can completely reset battle conditions, nullify all damage taken by allies for a duration, and her presence alone brings absolute harmony to chaos."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gaia, Heart of the World-Root", CharacterGender.Female, CharacterRole.Support,
            Rarity.Mythic, 260, 120, 210, 1,
            "The primordial spirit of life itself, Gaia is connected to every living thing. She can awaken the planet's core, causing colossal ancient trees to shield her allies, terraform the battlefield to her advantage, and grant eternal regeneration that makes her vanguard virtually unstoppable."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos, Weave of Unending Time", CharacterGender.Female, CharacterRole.Support,
            Rarity.Mythic, 240, 140, 190, 2,
            "Existing beyond the fabric of the universe, Chronos is the ultimate master of temporal manipulation. She can compress eons into a moment for her allies, trap foes in infinite loops, and even split her consciousness across timelines to support her team from multiple points simultaneously, ensuring no defeat is final."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lumen, Echo of the Infinite", CharacterGender.Female, CharacterRole.Support,
            Rarity.Mythic, 230, 150, 180, 3,
            "The sentient resonance of pure potential, Lumen can manifest any protective or restorative energy from across the multiverse. She can instantly adapt to any threat, replicate the strongest defensive capabilities of any ally, and her light can banish even existential threats, creating absolute sanctuary."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Borghild", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Common, 120, 25, 40, 0,
            "A stoic shieldmaiden known for her unbreakable resolve and unwavering commitment to protecting her allies. Her heavy armor and towering presence on the battlefield inspire courage in her comrades. She carries a massive, ornate shield passed down through generations of guardians."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Groka", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Common, 115, 30, 38, 1,
            "A seasoned warrior with a no-nonsense attitude and a formidable spiked gauntlet. She’s not afraid to charge into the thick of battle, drawing enemy fire and shrugging off blows that would fell lesser heroes. Her scarred armor tells tales of countless skirmishes."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Thordis", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Common, 125, 28, 42, 2,
            "Though seemingly quiet, Thordis possesses an inner strength as immovable as a mountain. Wielding a two-handed hammer, she delivers powerful counter-attacks while maintaining an impenetrable defensive stance, often creating openings for her teammates. She wears practical, reinforced plate."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Runa", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Common, 110, 27, 35, 3,
            "Agile for a tank, Runa uses a combination of swift movements and a durable buckler to deflect attacks, often positioning herself to absorb damage intended for more fragile heroes. Her quick reflexes make her a surprisingly difficult target to pin down. Her gear is lighter, allowing for greater mobility."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Lyra", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Uncommon, 130, 30, 45, 0,
            "A former royal guard, Lyra commands the battlefield with a shimmering tower shield and tactical precision. Her uncommon rarity comes from her ability to boost the defense of nearby allies, making her a crucial linchpin in any formation. Her armor is polished and bears a faded crest."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Dagny", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Uncommon, 135, 33, 48, 1,
            "Hailing from a remote, iron-clad tribe, Dagny's resilience is legendary. She wields a massive, blunt maul that, despite its defensive nature, can deliver stunning blows. Her unique tribal markings glow faintly when she absorbs heavy damage, signifying her uncommon durability."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Serafina", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Uncommon, 125, 32, 43, 2,
            "A temple guardian who channels divine energy, Serafina protects her comrades with sacred barriers and a consecrated greatshield. Her uncommon status is reflected in her ability to briefly heal herself while drawing enemy aggression, ensuring her presence on the front lines. She wears ornate, ceremonial plate armor."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Kaelen", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Uncommon, 128, 31, 46, 3,
            "A battle-hardened mercenary who has seen countless conflicts, Kaelen's pragmatic approach to tanking involves drawing fire with taunts and using a reinforced, spiked buckler to deflect attacks while counter-attacking. Her uncommon skill lies in her ability to reduce incoming damage from specific enemy types. Her armor is functional and heavily scarred."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Valeriana", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Rare, 150, 35, 55, 0,
            "Known as the 'Iron Empress,' Valeriana is a veteran commander whose presence alone shifts the tide of battle. Wielding an enchanted runic shield, she can project a powerful aura that fortifies her entire team's defenses while drawing all enemy aggression to herself. Her rare ability allows her to temporarily become invulnerable, making her a true endgame tank. Her armor is regal and exceptionally crafted."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Aethel", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Rare, 155, 32, 60, 1,
            "The 'Stone Heart,' Aethel is bound to ancient earth magic, allowing her to manifest earthen golems as temporary allies or turn her skin to unbreakable stone. Her rarity stems from her unique ability to convert incoming damage into a defensive boon for herself or a nearby ally, making her nearly impossible to dislodge. She wears armor made from magically reinforced rock and metal."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Ignis", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Rare, 145, 38, 52, 2,
            "A guardian forged in volcanic fires, Ignis embraces the heat of battle. Her rare power allows her to immolate enemies that dare strike her, dealing passive fire damage while simultaneously reducing their attack power. She wields a massive, heated mace that scorches the ground with every swing and is clad in obsidian-like armor that shimmers with internal heat."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Seraphina", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Rare, 140, 37, 50, 3,
            "A celestial protector touched by divine light, Seraphina floats gracefully across the battlefield, redirecting harm with angelic precision. Her unique, rare ability allows her to absorb a fatal blow for an ally once per combat, completely nullifying it, before re-engaging with renewed divine vigor. She wears ethereal, winged armor that glows faintly."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Astraea", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Epic, 170, 40, 70, 0,
            "The 'Cosmic Bulwark,' Astraea is a celestial guardian whose very presence warps reality, making her nearly invulnerable. Her epic power allows her to create a miniature black hole that pulls all enemy attacks towards her, rendering her allies completely safe for a short duration, while also empowering her with cosmic energy for a devastating counter. Her armor is made of solidified starlight and constantly shifts with nebulae patterns."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Valkyrie , Brunhilde", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Epic, 165, 42, 68, 1,
            "A true 'Shield-Maiden of the Gods,' Brunhilde descends from Valhalla, bringing divine might to the mortal realm. Her epic ability grants her temporary divine invulnerability, during which she reflects all damage taken back to her attackers with amplified force, while also inspiring her allies to fight with renewed ferocity. She wields a legendary shield and spear, clad in ornate, feathered plate armor."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Chronos , Tempestia", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Epic, 160, 38, 65, 2,
            "The 'Mistress of Time,' Tempestia is a temporal anchor, capable of manipulating the flow of battle. Her epic power allows her to rewind the last few seconds of combat, negating all damage taken by herself and her allies, and resetting crucial cooldowns. This makes her incredibly difficult to defeat and invaluable in challenging encounters. She wears ancient, clockwork-infused armor that hums with temporal energy."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Leviathan , Krakon", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Epic, 175, 35, 75, 3,
            "Hailing from the deepest abysses, Krakon is a monstrous tank whose body is fused with primordial oceanic power. Her epic ability transforms her into a colossal sea beast, granting immense health regeneration and a crushing area-of-effect attack that pulls all enemies to her, allowing her to absorb damage and disrupt entire enemy formations. Her natural armor is like hardened coral and chitin."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Gaia, Terra Prime", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Legendary, 200, 45, 80, 0,
            "The 'Heart of the World,' Terra Prime is the living embodiment of the earth's resilience. Her legendary power allows her to reshape the battlefield itself, creating impassable terrain to funnel enemies, summoning ancient treants to fight by her side, and passively regenerating the health of all allies on ground she controls. Her presence makes an entire team unyielding. Her armor is an extension of the earth, adorned with living flora and ancient stones."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Athena, Pallas", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Legendary, 190, 50, 78, 1,
            "The 'Goddess of War and Wisdom,' Pallas is the ultimate strategic and defensive force. Her legendary ability grants her total command over enemy targeting, forcing all attacks and abilities onto her for an extended duration while simultaneously boosting her team's damage significantly. She can also deploy an impenetrable Aegis shield that deflects all projectiles and magical attacks for a short period. She wears gleaming, divine armor, wielding a spear and the iconic Gorgon-emblazoned shield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Phoenix, Ignacia", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Legendary, 185, 55, 75, 2,
            "The 'Flame of Rebirth,' Ignacia is an elemental force that defies death itself. Her legendary power allows her to self-immolate, dealing immense fire damage to all surrounding enemies while becoming temporarily invulnerable. Should she fall, she rises from her own ashes with full health and a massive defensive buff, capable of repeating this cycle once per battle. Her armor is forged from living flame and volcanic rock, constantly radiating intense heat."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Void Weaver, Nyx", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Legendary, 195, 48, 82, 3,
            "The 'Shadow of the Cosmos,' Nyx is a mysterious entity from beyond mortal understanding. Her legendary ability allows her to tear fissures in reality, pulling all enemies into a void dimension where they take continuous damage and are completely unable to attack or use abilities, while her allies are buffed. She is a master of spatial manipulation and can instantly teleport across the battlefield to absorb threats. Her form is constantly shifting, shrouded in cosmic shadow and starlight, wearing armor that seems to absorb light."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Primordial Anima, Genesis", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Mythic, 250, 50, 90, 0,
            "The 'Architect of Existence,' Genesis is a fragment of the universal life force itself, manifesting as a protector. Her mythic power allows her to literally recreate portions of the timeline, preventing all fatal damage to herself and her entire team for a sustained period, effectively resetting crucial battle moments. She can also siphon the life force from enemies to heal allies, making her an unmovable and unkillable anchor. Her form is a majestic, crystalline being, wreathed in nebula and primordial light, wielding a staff that pulses with creation energy."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Absolute Null, Oblivion", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Mythic, 240, 58, 88, 1,
            "The 'End of All Things,' Oblivion is an entity born from the entropy of the cosmos. Her mythic ability enables her to create an 'Event Horizon' that completely erases all incoming damage for her and her allies within its radius, while simultaneously dissolving enemy armor and defenses to zero. She can also briefly exist outside of time and space, becoming untargetable and untouchable, only to reappear to devastating effect. Her armor is an abyss-like void, absorbing all light, with a gauntlet that flickers with non-existence."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Fate Weaver, Moirai", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Mythic, 230, 60, 85, 2,
            "The 'Puppeteer of Destiny,' Moirai sees and manipulates the threads of fate. Her mythic power allows her to alter the outcome of critical attacks, causing enemy abilities to fail or even backfire, dealing massive damage to their own ranks. She can also link the life forces of her allies, distributing incoming damage evenly to prevent any single hero from falling, or temporarily making an ally completely immune to all harm. She is an ethereal being, adorned with ancient, glowing runes, her movements precise and otherworldly, carrying a loom-like shield."));
        dataToLoad.Add(new CharacterDataLoaderFormat("Divine Sovereign, Olympia", CharacterGender.Female, CharacterRole.Tank,
            Rarity.Mythic, 245, 52, 92, 3,
            "The 'Apex of Divinity,' Olympia embodies supreme cosmic authority. Her mythic ability is a singular, overwhelming command that forces all enemies to kneel and cease all actions for a prolonged period, leaving them utterly vulnerable. During this time, her team gains immense buffs to all stats, and Olympia herself becomes a conduit for raw divine energy, capable of unleashing a single, devastating 'Judgment' attack that can wipe out entire enemy forces. She is clad in pure golden, radiating light, wearing a crown of stars, and wields a scepter of ultimate power."));

        #endregion

        
        /* foreach (var dataBlock in allCharacters)
        {
            // Find the record in your list:
            var found = dataToLoad.Find(
                x => x.gender == dataBlock.gender && x.role == dataBlock.role &&
                     x.rarity == dataBlock.rarity && x.tier == dataBlock.tier
            ); 
            
            // Now you can access properties if found is not null:
            if (found != null)
            {
                string assetPath = AssetDatabase.GetAssetPath(dataBlock);
                AssetDatabase.RenameAsset(assetPath, dataBlock.characterNom);
                
                dataBlock.name = found.characterName;
                dataBlock.baseHealth = found.baseHealth;
                dataBlock.baseAttack = found.baseHealth;
                dataBlock.baseDefense = found.baseDefense;
                dataBlock.characterDescription = found.characterDescription;
            }
            else
            {
                Debug.Log("No record was found. "+ dataBlock.gender + ", "+ dataBlock.role + ", "+ dataBlock.rarity + ", "+ dataBlock.tier );
            } 

        }
        AssetDatabase.SaveAssets(); */
    } 
}

[System.Serializable]
public class CharacterDataLoaderFormat
{
    public string characterName;
    public CharacterGender gender;
    public CharacterRole role;
    public Rarity rarity;
    public int baseHealth;
    public int baseAttack;
    public int baseDefense;
    public int tier;
    public string characterDescription;

    // Custom Constructor
    public CharacterDataLoaderFormat(
        string characterName,
        CharacterGender gender,
        CharacterRole role,
        Rarity rarity,
        int baseHealth,
        int baseAttack,
        int baseDefense,
        int tier,
        string characterDescription)
    {
        this.characterName = characterName;
        this.gender = gender;
        this.role = role;
        this.rarity = rarity;
        this.baseHealth = baseHealth;
        this.baseAttack = baseAttack;
        this.baseDefense = baseDefense;
        this.tier = tier;
        this.characterDescription = characterDescription;
    }
}
