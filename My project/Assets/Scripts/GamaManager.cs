using UnityEngine;

public class GamaManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform spawnPoint;
    public Ball ball;

    private bool isBallLaunched;
    void Start()
    {
        isBallLaunched = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.isBallLaunched == false)
        {
            Instantiate(ball);
            ball.transform.position = spawnPoint.position;  
            isBallLaunched = true;
        }
    }

    public void RespawnBall()
    {
        Instantiate(ball);
        ball.transform.position = spawnPoint.position;
        Debug.Log("ball was respawned");
    }
}
