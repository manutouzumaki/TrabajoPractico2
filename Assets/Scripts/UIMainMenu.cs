using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIMainMenu : UIMenu
{
    [Header("Main menu buttons")]
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button exitButton;
    
    private new void Awake()
    {
        base.Awake();
        playButton.onClick.AddListener(OnPlayButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
    }
    
    private void OnDestroy()
    {
        playButton.onClick.RemoveAllListeners();
        settingsButton.onClick.RemoveAllListeners();
        creditsButton.onClick.RemoveAllListeners();
        exitButton.onClick.RemoveAllListeners();
    }
    
    private void OnPlayButtonClicked()
    {
        Time.timeScale = 1.0f;
        Pause.CloseMainMenu();
    }

    private void OnSettingsButtonClicked()
    {
        Pause.CloseMainMenu();
        Pause.OpenSettingsMenu();
    }
    
    private void OnCreditsButtonClicked()
    {
        Pause.CloseMainMenu();
        Pause.OpenCreditsMenu();
    }
    
    private void OnExitButtonClicked()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
    
}
