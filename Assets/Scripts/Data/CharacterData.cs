using UnityEngine;

// This attribute allows you to create instances of this Scriptable Object
// directly from the Unity Editor's Assets > Create menu.
[CreateAssetMenu(fileName = "NewCharacter", menuName = "Game/Character Data")]
public class CharacterData : ScriptableObject
{
    // Basic character identity
    public string characterNom;
    public Sprite characterImage;

    // Gender
    public CharacterGender gender;

    // Game-specific roles and rarity
    public CharacterRole role;
    public Rarity rarity;

    // Stats and progression
    public int baseHealth;
    public int baseAttack;
    public int baseDefense;
    public int tier;
    
    // Description for flavor text
    [TextArea(3, 10)]
    public string characterDescription;

    // A method to calculate a character's total health
    // You can add this logic here or in a separate combat system script.
    public int GetTotalHealth(int level)
    {
        return baseHealth + (level * 10);
    }
}