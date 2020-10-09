using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGrepeat : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb;
    private float width;

    //these two need to be the same 
    private float speed = -20f;         
    private float repo = 20f;
    private int speed_2 = 0;
    private int repo_2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = boxCollider.size.x - 50;
        rb.velocity = new Vector2(speed, speed_2);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-width){
            Reposition();
        }
        
    }

    private void Reposition(){
        Vector2 vector = new Vector2(width * repo, repo_2);
        transform.position = (Vector2)transform.position + vector;
    }
}
