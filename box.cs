using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void OnCollisionEnter2D(Collision2D hit) //"ball" isimli objeye temas halinde skoru arttır, kendini devre dışı bırak.. 
    {
        if (hit.gameObject.name == "ball")
        { 
            FindObjectOfType<score>().AddScore();
            gameObject.SetActive(false);
        }

    }
}
