using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class CountDownMeteor : MonoBehaviour
{
    public PlayerMovementMeteor movement;

    public GameObject gameOverPnl;
    public GameObject gameOverPnl2;


    public Text TimeText;


    public void zamanarttı()
    {
        gameOverPnl.SetActive(false);

        Time.timeScale = 1;

        movement.enabled = true;
        
    }
  
}
 