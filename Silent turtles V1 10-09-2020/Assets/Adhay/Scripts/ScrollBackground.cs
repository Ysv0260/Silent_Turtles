using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBackground : MonoBehaviour
{
   

    private BoxCollider2D box;
    private Rigidbody2D ridge;
    private float width;
    private float speed = -150f;

    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        ridge = GetComponent<Rigidbody2D>();
        width = box.size.x;
        ridge.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -width)
        {
            Repo();
        }

    }


    private void Repo()
    {
        Vector2 vector = new Vector2(width * 200f, 0);
        transform.position = (Vector2)transform.position + vector;
    }

}