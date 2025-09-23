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
}