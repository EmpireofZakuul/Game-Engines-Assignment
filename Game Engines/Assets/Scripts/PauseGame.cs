using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    //InputManager inputManager;

    
   // public GameObject Keys;
   // public GameObject SettingsGame;
    public bool Paused = false;
    public GameObject PauseMenuUI;
   // public GameObject health;
   // public GameObject keymenu;
   // public GameObject menu;
    //public GameObject settings;

    public void Awake()
    {
        Pause();
    }
    public void Start()
    {
        //inputManager = GameObject.FindObjectOfType<InputManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        AudioListener.pause = false;
        //  health.SetActive(true);
        // keymenu.SetActive(false);
        // menu.SetActive(false);
        // settings.SetActive(false);

    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
        //health.SetActive(false);
        AudioListener.pause = true;
    }

    public void QuitGameMenu()
    {

#if UNITY_STANDALONE
        Application.Quit();
#endif

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

}
