using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainbowColor : MonoBehaviour
{

    public float Speed = 1;
    private CanvasRenderer rend;

    void Start()
    {
        rend = GetComponent<CanvasRenderer>();
    }

    void Update()
    {
        rend.SetColor(Color.HSVToRGB(Mathf.PingPong(Time.time * Speed, 1), 5, 5));
    }
}
