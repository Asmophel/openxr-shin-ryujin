using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject HowtoPlayPanel;
    [SerializeField] private GameObject MainMenuPanel;
    private bool isOpened = false;


    public void PlayGame()
    {
        SceneManager.LoadScene("VhunterGameplay");
    }

    public void HowtoPlayMenu()
    {
        isOpened = !isOpened;
        MainMenuPanel.SetActive(!isOpened);
        HowtoPlayPanel.SetActive(isOpened);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
