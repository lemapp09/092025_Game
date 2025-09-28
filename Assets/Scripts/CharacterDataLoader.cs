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
        #endregion

        
        foreach (var dataBlock in allCharacters)
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
        AssetDatabase.SaveAssets();
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
