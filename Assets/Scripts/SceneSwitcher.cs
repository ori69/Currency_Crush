using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitcher : MonoBehaviour
{
    public void ExitGame() // not used in web bild
    {
        Debug.Log("Player has quit the game");
        Application.Quit();
    }

    public void SaveAndExit()
    {
        SaveGame.Save();
        SceneManager.LoadScene("PlayLoadMenu");
        Debug.Log("Player used Save & Exit ");
    }

    public void NewGame()
    {
        GameBoard.LOADEDGAME = false;
        Debug.Log("Player started new game ");
        SceneManager.LoadScene("Game");
    }

    public void ContinueGame()
    {
        GameBoard.LOADEDGAME = true;
        Debug.Log("Player continued game");
        SceneManager.LoadScene("Game");
    }
 }
