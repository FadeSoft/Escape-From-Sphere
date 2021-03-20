using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctıons : MonoBehaviour
{
    public GameObject gameoveralpnl;
    public GameObject stnalpnl;
   
    
    
    /// //////////////////////////////////////////////////////////////////////
    
    public GameObject Panel1;
    public void ShowHidePanel(bool status)
    {
        Panel1.gameObject.SetActive(status);
    }
    
    public void PauseResumeGame()
    {
        
        Time.timeScale = 0;
        Panel1.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Time.timeScale = 1;
    }
    public void Resume()
    {
        Panel1.SetActive(false);
        Time.timeScale = 1;
    }
    public void sil()
    {
        Panel1.SetActive(true);
        Time.timeScale = 0;
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void easyhardmedium()
    {
        SceneManager.LoadScene(2);
    }

    ///////////////////////////////////////////////////////////////////////

    public void satınalpnlac()
    {
        stnalpnl.SetActive(true);
    }
    public void geridön()
    {
        stnalpnl.SetActive(false);
        gameoveralpnl.SetActive(true);
    }
}


