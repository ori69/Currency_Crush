using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayLoadMenu : MonoBehaviour
{
    public Button Continue;
    public Text ContinueText;
    void Update()
    {
        if (PlayerPrefs.GetInt("Exists") == 1)
        {
            Continue.enabled = true;
            Continue.image.color = new Color(1, 1, 1, 1);
            ContinueText.text = "Continue";
        }
        else 
        {
            Continue.enabled = false;
            Continue.image.color = new Color(0, 0, 0, 0);
            ContinueText.text = "";
        }

    }
}
