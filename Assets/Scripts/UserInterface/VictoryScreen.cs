using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class VictoryScreen : MonoBehaviour
{
    public void restartGame() //When restart is predd
    {
        SceneManager.LoadScene("MainScene");
    }

    public void quitGame() //When quit button is pressed
    {
        Application.Quit();
    }
}
