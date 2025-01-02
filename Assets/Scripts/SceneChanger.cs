using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public static void QuitGame()
    {
        Application.Quit();
    }
    public static void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public static void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

}
