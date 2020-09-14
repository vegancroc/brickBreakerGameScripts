using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    Rigidbody2D rb;
    
    [SerializeField]
    private float radius;
    [SerializeField]
    private float radius2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    { 
        Movement();
    }

    void Movement()
    {
        /*
         * cursorPosition = İmleç pozisyonunu bul..
         * constanxvalue = Belirlenen değer aralıklarının dışına çıkmadan bir x değeri gönder(radius,radius2)..
         */
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float constantxValue = Mathf.Clamp(cursorPosition.x, radius, radius2); 
        transform.position = new Vector3(constantxValue, transform.position.y);
    }
    
}
