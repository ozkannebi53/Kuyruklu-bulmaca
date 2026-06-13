using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject gamePanel;
    public GameObject storePanel;
    public GameObject settingsPanel;

    void Start()
    {
        Debug.Log("UIManager started.");
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        gamePanel.SetActive(false);
        storePanel.SetActive(false);
        settingsPanel.SetActive(false);
        Debug.Log("Showing Main Menu.");
    }

    public void ShowGamePanel()
    {
        mainMenuPanel.SetActive(false);
        gamePanel.SetActive(true);
        storePanel.SetActive(false);
        settingsPanel.SetActive(false);
        Debug.Log("Showing Game Panel.");
    }

    public void ShowStorePanel()
    {
        mainMenuPanel.SetActive(false);
        gamePanel.SetActive(false);
        storePanel.SetActive(true);
        settingsPanel.SetActive(false);
        Debug.Log("Showing Store Panel.");
    }

    public void ShowSettingsPanel()
    {
        mainMenuPanel.SetActive(false);
        gamePanel.SetActive(false);
        storePanel.SetActive(false);
        settingsPanel.SetActive(true);
        Debug.Log("Showing Settings Panel.");
    }

    // Placeholder for general UI interactions
    public void OnButtonClick(string buttonName)
    {
        Debug.Log($"{buttonName} button clicked.");
        // Implement specific button actions here
    }
}
