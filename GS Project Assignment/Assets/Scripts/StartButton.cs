using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartScene()
    {
        SceneManager.LoadScene("Level1");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("howto");
    }

    public void MainMenuScreen()
    {
        SceneManager.LoadScene("menu");
    }
}
