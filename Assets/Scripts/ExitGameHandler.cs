using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExitGameHandler : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Player has quit the game");
        Application.Quit();
    }
}
