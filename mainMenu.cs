using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    public Text myText;

    void Awake()
    {
        Time.timeScale = 1f;
        InvokeRepeating("ChangeColors", 0, 2f);
    }
    void ChangeColorBlue()
    {
        myText.color = Color.blue;
    }

    void ChangeColorRed()
    {
        myText.color = Color.red;
    }

    void ChangeColorYellow()
    {
        myText.color = Color.yellow;
    }

    void ChangeColorGreen()
    {
        myText.color = Color.green;
    }

    void ChangeColors()
    {
        Invoke("ChangeColorBlue", 1f);
        Invoke("ChangeColorRed", 1.5f);
        Invoke("ChangeColorYellow", 2f);
        Invoke("ChangeColorGreen", 2.5f);
    }
}
