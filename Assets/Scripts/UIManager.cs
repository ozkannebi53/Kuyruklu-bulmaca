using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject gamePanel;
    public GameObject settingsPanel;
    // Store paneli gerçek ödemeler kaldırıldığı için şimdilik devre dışı veya oyun içi jeton odaklı olacak.
    public GameObject inGameStorePanel; 

    void Start()
    {
        Debug.Log("UIManager started.");
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        gamePanel.SetActive(false);
        settingsPanel.SetActive(false);
        if(inGameStorePanel != null) inGameStorePanel.SetActive(false);
        Debug.Log("Showing Main Menu.");
    }

    public void ShowGamePanel()
    {
        mainMenuPanel.SetActive(false);
        gamePanel.SetActive(true);
        settingsPanel.SetActive(false);
        if(inGameStorePanel != null) inGameStorePanel.SetActive(false);
        Debug.Log("Showing Game Panel.");
    }

    public void ShowInGameStore()
    {
        mainMenuPanel.SetActive(false);
        gamePanel.SetActive(false);
        settingsPanel.SetActive(false);
        if(inGameStorePanel != null) inGameStorePanel.SetActive(true);
        Debug.Log("Showing In-Game Store (Coins only).");
    }

    public void OnButtonClick(string buttonName)
    {
        Debug.Log($"{buttonName} button clicked.");
    }
}
