using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public GameObject Pause;
    void Update()
    {
        if(Input .GetKeyDown (KeyCode.Escape))
        {
            AudioListener.volume = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Pause.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Resume()
    {
        AudioListener.volume = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Pause.SetActive(false);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
