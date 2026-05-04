using TMPro;
using UnityEngine;

public class GamaManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform spawnPoint;
    public Ball ball;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI totalBallText;
    public bool IsGameOver { get; set; }

    private int score;
    private int totalBalls;
    private bool isBallLaunched;

    void Start()
    {
        isBallLaunched = false;
        score = 0;
        scoreText.text = "Score : " + score;
        totalBalls = 3;
        totalBallText.text = "Balls : " + totalBalls;
        IsGameOver = false;
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
        if(totalBalls > 0)
        {
            Instantiate(ball);
            ball.transform.position = spawnPoint.position;
            totalBalls -= 1;
            totalBallText.text = "Balls : " + totalBalls;
        }
        else
        {
            IsGameOver = true;
        }
       

        
    }

    public void UpdateScore()
    {
        score += 100;
        scoreText.text = "Score : " + score;
    }
}
