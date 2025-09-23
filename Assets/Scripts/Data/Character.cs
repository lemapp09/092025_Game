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
    public Character(string name, Sprite image, CharacterGender characterGender, CharacterRole characterRole, Rarity characterRarity)
    {
        characterName = name;
        characterImage = image;
        gender = characterGender;
        role = characterRole;
        rarity = characterRarity;
        level = 1;
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
    Male,
    Female,
    Androgynous, // For characters without a clearly defined gender
    Creature,    // For monsters, beasts, or non-humanoids
    Machine,     // For robots or constructs
    None         // For entities that have no gender
}

// Existing Enums for Roles and Rarity
public enum CharacterRole
{
    Tank,
    Healer,
    DamageDealer,
    Support
}

public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary,
    Mythic
}