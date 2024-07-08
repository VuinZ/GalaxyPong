using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public GameObject mainMenuCanvas;
    public GameObject GameCanvas;
    //fungsi mengganti scene melalui suatu dengan memakai parameter suatu nama scene
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    //fungsi untuk keluar dari aplikasi
    public void QuitApp()
    {
        Application.Quit();
    }
    public void ShowMain()
    {
        GameCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
        
    }

    public void ShowGame()
    {
        mainMenuCanvas.SetActive(false);
        GameCanvas.SetActive(true);
        
    }

    public void MainLagi()
    {
        mainMenuCanvas.SetActive(false);
        GameCanvas.SetActive(true);
    } 

    public void OnePlayer()
    {
        SceneManager.LoadScene("SoloGameEasy");
    }

    public void OnePlayerhard()
    {
        SceneManager.LoadScene("SoloGameHard");
    }

    public void TwoPlayer()
    {
        SceneManager.LoadScene("Game");
    }

    public void TMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}