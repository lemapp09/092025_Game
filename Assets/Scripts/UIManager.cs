using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public UIDocument uiDocument; // Assign your UI Document in the Inspector
    private Button _playerButton;
    private Button _heroesButton;
    private Button _summonButton;
    private Button _shopButton;

    private void OnEnable()
    {
        if (uiDocument == null)
        {
            Debug.LogError("UI Document is not assigned to UIManager!");
            return;
        }

        VisualElement root = uiDocument.rootVisualElement;
        
        // Get buttons by name
        _summonButton = root.Q<Button>("SummonButton");
        _heroesButton = root.Q<Button>("RosterButton");
        _shopButton = root.Q<Button>("ShopButton");

        // Register click events
        _summonButton?.RegisterCallback<ClickEvent>(evt => LoadScene("Summoning"));
        _heroesButton?.RegisterCallback<ClickEvent>(evt => LoadScene("HeroCatalog"));
        _shopButton?.RegisterCallback<ClickEvent>(evt => LoadScene("ShopGallery"));
    }

    private void LoadScene(string sceneName)
    {
        Debug.Log("Loading scene " + sceneName);
        SceneManager.LoadScene(sceneName);
    }

    private void OnDisable()
    {
        // Unregister click events
        // Unregister click events
        _summonButton?.UnregisterCallback<ClickEvent>(evt => LoadScene("Summoning"));
        _heroesButton?.UnregisterCallback<ClickEvent>(evt => LoadScene("HeroCatalog"));
        _shopButton?.UnregisterCallback<ClickEvent>(evt => LoadScene("ShopGallery"));
    }
}