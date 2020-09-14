using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    private float startingSpeed;
    [SerializeField]
    private float constantSpeed;
    
    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * startingSpeed);
    }

    void Update()
    {
        rb.velocity = constantSpeed * (rb.velocity.normalized);
        CheckSpeed();
    }

    #region Functions
    void OnCollisionEnter2D(Collision2D collision) //Tag'i obstacle olan objeye temas halinde sesi oynat..
    {
        if (collision.gameObject.tag == "obstacle")
        {
            FindObjectOfType<soundManager>().PlayBallHittingSound(1);
        }

        if (collision.gameObject.name == "red_obstacle") //"red_obstacle" isimli objeye değince canı azalt, sesi oynat..
        {
            FindObjectOfType<health>().DecreaseHealth();
            FindObjectOfType<soundManager>().PlayHurtSound(0.07f);
        }

        if (collision.gameObject.tag == "metal") //Tag'i metal olan objeye temas halinde sesi oynat..
        {
            FindObjectOfType<soundManager>().PlayMetalHitSound(0.5f);
        }
    }
    void CheckSpeed() //Topun aynı doğrultuda takılmasını engelle..
    {
        if (Mathf.Abs(rb.velocity.x) <=0.9 )
        {
            rb.velocity = new Vector2((Random.Range(1, 3)), rb.velocity.y);
        }
        else if (Mathf.Abs(rb.velocity.y) <= 0.9)
        {
            rb.velocity = new Vector2(rb.velocity.x, Random.Range(1, 3));
        }
    }

    #endregion
}
