using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ui : MonoBehaviour
{

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }

    
}
