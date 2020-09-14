using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingObject : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        RotateObject();
    }

    void RotateObject()
    {
        rb.transform.Rotate(new Vector3(0,0,90), rotateSpeed);
        
    }
}
