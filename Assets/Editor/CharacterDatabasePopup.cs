using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterDatabasePopup : EditorWindow
{
    [MenuItem("Tools/Show CharacterDatabase Count")]
    public static void ShowWindow()
    {
        var wnd = GetWindow<CharacterDatabasePopup>();
        wnd.titleContent = new GUIContent("Character Database Count");
    }

    // This method will now be called one frame after the window is created
    public void OnEnable()
    {
        // Use delayCall to schedule the UI creation for the next editor update
        EditorApplication.delayCall += BuildUI;
    }

    // Moved all your UI logic into this new method
    private void BuildUI()
    {
        // To prevent adding UI multiple times if OnEnable is called again
        rootVisualElement.Clear();

        var db = FindFirstObjectByType<CharacterDatabase>();
        int count = db ? db.allCharacters.Count : 0;

        var popup = new VisualElement();
        popup.style.backgroundColor = new Color(0.2f, 0.2f, 0.2f, 0.98f);
        popup.style.paddingLeft = 8;
        popup.style.paddingRight = 8;
        popup.style.paddingTop = 8;
        popup.style.paddingBottom = 8;

        var label = new Label($"Character ScriptableObjects: {count}");
        popup.Add(label);

        label = new Label("--------------");
        popup.Add(label);

        string[] clanNames = { "PaladinMale", "PaladinFemale", "Plants", "Monster", "Robots", "Insects" };
        string[] roleNames = { "Tank", "Healer", "Damage Dealer", "Support" };
        string[] rarityNames = { "Common", "Uncommon", "Rare", "Epic", "Legendary", "Mythic" };
        var clanCount = db.ClanCount();

        // Top foldout for "All Characters"
        var allClansFoldout = new Foldout() { text = "Character Summary", value = true };
        popup.Add(allClansFoldout);

        for (int i = 0; i < clanNames.Length; i++)
        {
            // Clan foldout
            var clanFoldout = new Foldout() { text = clanNames[i], value = false };
            allClansFoldout.Add(clanFoldout);

            for (int j = 0; j < roleNames.Length; j++)
            {
                // Role foldout
                var roleFoldout = new Foldout() { text = roleNames[j], value = false };
                clanFoldout.Add(roleFoldout);

                for (int k = 0; k < rarityNames.Length; k++)
                {
                    // Rarity label
                    label = new Label($"{rarityNames[k]}: {clanCount[i, j, k]}");
                    roleFoldout.Add(label);
                }
            }
        }
        rootVisualElement.Add(popup);
    }
}