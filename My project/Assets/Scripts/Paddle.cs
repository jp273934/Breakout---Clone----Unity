using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour
{
    public int moveSpeed;
    private Rigidbody2D rb;

    public Paddle()
    {
        moveSpeed = 500;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Keyboard.current.leftArrowKey.isPressed && transform.position.x > -6)
        {
            transform.position -= transform.right * moveSpeed * Time.deltaTime;
        }

        if(Keyboard.current.rightArrowKey.isPressed && transform.position.x < 6)
        {
           transform.position += transform.right * moveSpeed * Time.deltaTime;
        }  
    }
}
