
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerButtonsMenu : MonoBehaviour
{
    [SerializeField] private GameObject panelSettings;
    [SerializeField] private GameObject panelStats;
    [SerializeField] private GameObject panelMenu;
    [SerializeField] private GameObject panelNormDaiWeek;
    [SerializeField] private List<Image> listButtons;
    [SerializeField] private GameObject returnPlayMenu;
    public void Play()
    {
        panelNormDaiWeek.SetActive(true);
        panelMenu.SetActive(false);
        returnPlayMenu.SetActive(true);
        ClearButtonsSprites();
    }
    public void COOP()
    {
        ClearButtonsSprites();
    }
    public void Settings()
    {
        panelSettings.SetActive(true);
        panelMenu.SetActive(false);
        ClearButtonsSprites();
    }
    public void Stats()
    {
        panelStats.SetActive(true);
        panelMenu.SetActive(false);
        ClearButtonsSprites();
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void ReturnPlayMenu()
    {
        panelMenu.SetActive(true);
        panelNormDaiWeek.SetActive(false);
        returnPlayMenu.SetActive(false);
        ClearButtonsSprites();
    }

    public void ChangeSceneNormal()
    {
        SceneManager.LoadScene("SelectCharacter");
    }
    private void ClearButtonsSprites()
    {
        foreach (Image button in listButtons)
        {
            button.enabled = false;
        }
    }
}
