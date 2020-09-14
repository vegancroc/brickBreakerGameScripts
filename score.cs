using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Button button;
    public Button button2;
    public Button button3;
    Text txt;
    private int scoreNumber;
    public Text gameOver;
    [SerializeField]
    private int maxNumber;

    void Start()
    {
        txt = GetComponent<Text>();
    }

    #region Functions
    public void AddScore() //Skoru 1 arttır..
    {
        scoreNumber++;
    }

    void Update()
    {
        ScoreCheck();
        WriteText(); 
    }

    void WriteText()
    {
        string text = "Score: " + scoreNumber; //Skoru ekrana yazdır..
        txt.text = text;
    }

    void ScoreCheck()
    {
        
        if (scoreNumber ==  maxNumber)
        {
            if (button3 != null)
            {
                button3.gameObject.SetActive(true);
            }
            button.gameObject.SetActive(true);
            button2.gameObject.SetActive(true);
            gameOver.gameObject.SetActive(true); //Bütün kutular kırıldığında oyunu bitir..
            FindObjectOfType<soundManager>().volumeDown();
            Time.timeScale = 0f;
        }
    }
    #endregion

}
