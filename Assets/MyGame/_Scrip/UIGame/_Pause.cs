using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void Pause()
    {

        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Home()
    {
        SceneManager.LoadScene("_Home");
        Time.timeScale = 1;
    }
    public void Restart()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene("_Main");
        Time.timeScale = 1;
    }
    public void Continue()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    
}
