using System;
using UnityEngine;
using System.Collections.Generic;

public class CharacterDatabase : MonoBehaviour
{
    // This list will be filled in the Unity Editor
    public List<CharacterData> allCharacters = new List<CharacterData>();

    // We can make this a Singleton for easy access
    public static CharacterDatabase Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // Don't destroy this object when a new scene loads
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int[,,] ClanCount()
    {
        // Assuming:
        // clan has 6 values 
        // role has 4 values → size 4
        // rarity has 6 values → size 6
        // Adjust numbers based on your enums!
        int[,,] clanCount = new int[6,4,6];

        // Loop through all characters and increment count
        foreach (CharacterData characterData in allCharacters)
        {
            clanCount[(int)characterData.gender,
                (int)characterData.role,
                (int)characterData.rarity]++;
        }

        return clanCount;
    }


}