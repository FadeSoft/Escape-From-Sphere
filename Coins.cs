using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class Coins : MonoBehaviour
{

    public int Value;
    public Text CoinAmount;
 

    public int My_Money;
    public GameObject MoneyEnoughTxt;
   

    private void Start()
    {
        Value = PlayerPrefs.GetInt("mypara");
        CoinAmount.text = "" + CoinAmount;
        

    }
   

    void Update()
    {
        CoinAmount.text = "" + Value;
        

    }

    public void fade()
    {
        PlayerPrefs.GetInt("mypara", Value);
        CoinAmount.text = "" + Value;

    }

    public void Add50Altin()
    {
        Value += 50;
        PlayerPrefs.SetInt("mypara", Value);
        
    }
    public void Add100Altin()
    {
        Value += 100;
        PlayerPrefs.SetInt("mypara", Value);
    }
    

    public void GiveCoin()
    {


        if (Value >= 10)
        {
            Value -= 10;
           
            PlayerPrefs.SetInt("mypara", Value);


        }
        else if (Value < 10)
        {
            MoneyEnoughTxt.SetActive(true);

        }


    }
    public void DontGiveCoin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Time.timeScale = 1;
    }
}
