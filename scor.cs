using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scor : MonoBehaviour
{
    public float zaman;
    public Text zaman_text;
    public Text hiscoretext;

    public float hiscore;

    public void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            hiscore = PlayerPrefs.GetFloat("HighScore");
        }

        zaman = 0; //ıstedıgınzaman
        zaman_text.text=""+(int)zaman;
    }
    public void Update()
    {
        zaman += Time.deltaTime;
        zaman_text.text=""+(int)zaman;

        if (zaman > hiscore)
        {
            hiscore = zaman;
            PlayerPrefs.SetFloat("HighScore", hiscore);
        }
        zaman_text.text = " " + Mathf.Round(zaman);
        hiscoretext.text = " " + Mathf.Round(hiscore);
    }
}
