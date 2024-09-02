using UnityEngine;

public class UIPauseManager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject settingsMenuPanel;
    [SerializeField] private GameObject creditsMenuPanel;
    
    private void Awake()
    {
        CloseAll();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsActive())
            {
                CloseAll();
            }
            else
            {
                OpenMainMenu();
                Time.timeScale = 0.0f;
            }
        }
    }
    
    public void OpenMainMenu()
    {
        mainMenuPanel.SetActive(true);
    }
    
    public void OpenSettingsMenu()
    {
        settingsMenuPanel.SetActive(true);
    }

    public void OpenCreditsMenu()
    {
        creditsMenuPanel.SetActive(true);
    }
    
    public void CloseMainMenu()
    {   
        mainMenuPanel.SetActive(false);
    }

    public void CloseSettingsMenu()
    {
        settingsMenuPanel.SetActive(false);
    }

    public void CloseCreditsMenu()
    {
        creditsMenuPanel.SetActive(false);
    }

    public void CloseAll()
    {
        CloseMainMenu();
        CloseSettingsMenu();
        CloseCreditsMenu();
        Time.timeScale = 1.0f;
    }

    public bool IsActive()
    {
        return mainMenuPanel.activeSelf ||
               settingsMenuPanel.activeSelf ||
               creditsMenuPanel.activeSelf;
    }
}
