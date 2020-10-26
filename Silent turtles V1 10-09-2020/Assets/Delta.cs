using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delta : MonoBehaviour
{

    /*private Transform camTransform;
    private Vector3 lastCamPos;

    // Start is called before the first frame update
    private void Start()
    {
        camTransform = Camera.main.transform;
        lastCamPos = camTransform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 deltaMove = camTransform.position - lastCamPos;
        float parallaxEffect = .5f;
        transform.position += deltaMove * parallaxEffect;
        lastCamPos = camTransform.position;
    }*/
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
