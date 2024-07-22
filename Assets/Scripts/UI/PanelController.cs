using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    [SerializeField] private CanvasGroup cGroup;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;

    public GameObject settingsPanel;
    public GameObject exitPanel;
    void Start()
    {
        
        EndGameManager.endManager.RegisterPanelController(this);
    }

    // Update is called once per frame
    public void ActivateWin(){
        cGroup.alpha = 1;
        winScreen.SetActive(true);
    }

    public void ActivateLose(){
        cGroup.alpha = 1;
        loseScreen.SetActive(true);
    }

    public void ShowSettingsPanel()
    {
        settingsPanel.SetActive(true);
    }

    public void HideSettingsPanel()
    {
        settingsPanel.SetActive(false);
    }

    public void ShowExitPanel()
    {
        exitPanel.SetActive(true);
    }

    public void HideExitPanel()
    {
        exitPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
