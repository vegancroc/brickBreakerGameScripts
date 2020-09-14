using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Image hurtEffectImage;
    public Button button;
    public Button button2;
    Text txt;
    [SerializeField]
    private int healthNumber;

    public Text gameOver;

    void Start()
    {
        txt = GetComponent<Text>();
    }

    #region Functions

    public void DecreaseHealth() //Canı 1 azalt..
    {
        healthNumber--;
        ShowHurtEffect();
    }

    void Update()
    {
        CheckHealth();
        WriteText();
    }

    void WriteText()
    {
        string text = "Health: " + healthNumber; //Canı ekrana yazdır..
        txt.text = text;
    }
    void CheckHealth() //Can 0'a indiğinde oyunu bitir..
    {
        if (healthNumber == 0)
        {
            hurtEffectImage.gameObject.SetActive(false);
            gameOver.gameObject.SetActive(true);
            button.gameObject.SetActive(true);
            button2.gameObject.SetActive(true);
            FindObjectOfType<soundManager>().volumeDown();
            Time.timeScale = 0f;
        }
    }

    void CloseHurtEffect()
    {
        hurtEffectImage.gameObject.SetActive(false);
    }

    void ShowHurtEffect()
    {
        hurtEffectImage.gameObject.SetActive(true);
        Invoke("CloseHurtEffect", 0.1f);
    }

    #endregion
}
