using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour
{
    public int moveSpeed;
    private Rigidbody2D rb;
    private GamaManager gamaManager;

    public Paddle()
    {
        moveSpeed = 500;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gamaManager = FindAnyObjectByType<GamaManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Keyboard.current.leftArrowKey.isPressed && transform.position.x > -6 && gamaManager.IsGameOver == false)
        {
            transform.position -= transform.right * moveSpeed * Time.deltaTime;
        }

        if(Keyboard.current.rightArrowKey.isPressed && transform.position.x < 6 && gamaManager.IsGameOver == false)
        {
           transform.position += transform.right * moveSpeed * Time.deltaTime;
        }  
    }
}
