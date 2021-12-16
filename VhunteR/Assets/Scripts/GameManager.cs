using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject HowToPlayPanel;
    private bool isPaused = false;
    private bool isOpened = false;

    #region Singleton
    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseOrResumeGame();
        }
    }

    public void PauseOrResumeGame()
    {
        isPaused = !isPaused;
        pausePanel.SetActive(isPaused);

    }

    public void HowtoPlayMenu()
    {
        isOpened = !isOpened;
        HowToPlayPanel.SetActive(isOpened);
        pausePanel.SetActive(!isOpened);
    }
}