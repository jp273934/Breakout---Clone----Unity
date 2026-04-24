using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int moveSpeed;

    private Rigidbody2D rb;

    private void Awake()
    {
        moveSpeed = 200;
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = Vector2.up * moveSpeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(Vector2.up * moveSpeed * Time.deltaTime); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.name == "Paddle")
        {
            Debug.Log("Paddle was hit");
            rb.linearVelocity = new Vector2(1, 1) * moveSpeed * Time.deltaTime;
        }

       if(collision.gameObject.tag == "Brick")
        {
            Debug.Log("brick was hit");
            var brick = collision.gameObject;

            Destroy(brick);
        }
    }
}
