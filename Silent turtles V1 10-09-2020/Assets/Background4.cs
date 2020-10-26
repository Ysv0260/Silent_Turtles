using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background4 : MonoBehaviour
{

    public float ScrollSpeed;
    Vector2 startPos;
    public float speed;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * ScrollSpeed, speed);
        transform.position = startPos + Vector2.right * newPos;
    }
}