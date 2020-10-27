using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{
    //InfiniteScrolling effect
    private float length, startPos;
    public GameObject cam;
    public float InfiniteEffect;

    //Background Moving effect
    private BoxCollider2D box;
    private Rigidbody2D ridge;
    private float width;
    private float speed = -150f;


    void Start()
    {
        //Infinite Effect
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;

        //Scroll Effect
        box = GetComponent<BoxCollider2D>();
        ridge = GetComponent<Rigidbody2D>();
        width = box.size.x;
        ridge.velocity = new Vector2(speed, 0);

    }

    void Update()
    {
        //Scrolling Effect
        if (transform.position.x < -width)
        {
            Repo();
        }
        
        //Infinite Effect
        float tempCam = (ridge.transform.position.x * (1 - InfiniteEffect));
        float distance = (ridge.transform.position.x * InfiniteEffect);

        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        if (tempCam > startPos + length)
        {
            startPos += length;
        }
        else if (tempCam < startPos - length)
        {
            startPos -= length;
        }
    }

    private void Repo()
    {
        //Scrolling Effect
        Vector2 vector = new Vector2(width * 200f, 0);
        transform.position = (Vector2)transform.position + vector;
    }
}
