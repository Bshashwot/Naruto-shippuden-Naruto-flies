using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int score = 0;

    void Start()
    {
        scoreText.text = "Score: 0";
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}