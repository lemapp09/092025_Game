using UnityEngine;

[System.Serializable]
public class Character
{
    // Basic character identity
    public string characterName;
    public Sprite characterImage;

    // A more comprehensive gender field
    public CharacterGender gender;

    // Game-specific roles and rarity
    public CharacterRole role;
    public Rarity rarity;

    // Stats and progression
    public int level;
    public int baseHealth;
    public int baseAttack;
    public int baseDefense;
    
    // Calculated stats
    public int currentHealth;

    // Constructor to initialize a new character
    public Character(string name, Sprite image, CharacterGender characterGender, CharacterRole characterRole, Rarity characterRarity, int tier)
    {
        characterName = name;
        characterImage = image;
        gender = characterGender;
        role = characterRole;
        rarity = characterRarity;
        level = 1;
        tier = 1;
    }

    // A method to calculate a character's total health, including level progression
    public int GetMaxHealth()
    {
        // Example: Base health plus a bonus for each level
        return baseHealth + (level * 10);
    }
}

// New Enum for Gender
public enum CharacterGender
{
    Male = 0,
    Female = 1,
    Plants = 2, // For characters without a clearly defined gender
    Monsters = 3,    // For monsters, beasts, or non-humanoids
    Robots = 4,     // For robots or constructs
    Insects = 5         // For entities that have no gender
}

// Existing Enums for Roles and Rarity
public enum CharacterRole
{
    Tank = 0,
    Healer = 1,
    DamageDealer = 2,
    Support = 3
}

public enum Rarity
{
    Common = 0,
    Uncommon = 1,
    Rare = 2,
    Epic = 3,
    Legendary = 4,
    Mythic = 5
}