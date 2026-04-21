using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour
{
    public int moveSpeed;

    public Paddle()
    {
        moveSpeed = 10;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.leftArrowKey.isPressed)
        {
            Debug.Log("left key was pressed");

            transform.position -= transform.right * moveSpeed * Time.deltaTime;
        }

        if(Keyboard.current.rightArrowKey.isPressed)
        {
            Debug.Log("right key was pressed");

            transform.position += transform.right * moveSpeed * Time.deltaTime;
        }
    }
}
